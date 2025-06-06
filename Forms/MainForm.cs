using MBPLib2;
using Microsoft.Win32;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace HMI_25024WE
{
    public partial class MainForm : Form
    {
        //Variables de applicacion
        private const string TemplateFile = "Template.MA2", AppName = "pdf2dxf";
        private string Assets, AuxFolder, PathFiles, WorkingFolder, SearchFolder, IP_Marker, Destino = "", XML_FileSendIt = "";
        private bool isManualMode = false, IsCamaraON = false, IsConnected = false, isTempleteOK = false, IsJobSenditOK = false, WasAborted = false, IsFormClosing = false;
        private int ControllerSerialNo = 0;
        private Int64 LabelsSendit = 0;


        private Models.TemplateCoordenates Template = null;
        public Models.MarkingParameters MarkingParameters = new Models.MarkingParameters();
        private CultureInfo Idioma;
        private MarkerTCPClient MarkerTCPClient;

        List<Models.Plates> Plates = new List<Models.Plates>();
        List<Models.XMLFiles> XMLFiles = new List<Models.XMLFiles>();

        //Ventanas de ayuda
        Form_Dialog fDialog;

        //cross threads calls
        delegate void SetControlTemplate(string text);
        delegate void SetControlTreeView();
        delegate void SetControlButton(string text);


        #region [Methods]
        public void LoadTreeViewParameters()
        {
            AuxFolder = Properties.Settings.Default.AuxFolder;
            PathFiles = Properties.Settings.Default.PathFiles;
            IP_Marker = Properties.Settings.Default.IP_Marker;
            ControllerSerialNo = Properties.Settings.Default.ControllerSerialNo;
            Assets = AppDomain.CurrentDomain.BaseDirectory + "Assets\\";

            if (Properties.Settings.Default.UseIPConnection)
            {
                axMBActX1.Comm.ConnectionType = ConnectionTypes.CONNECTION_ETHERNET;
                axMBActX1.Comm.IpAddress = IP_Marker;
                MarkerTCPClient = new MarkerTCPClient(IP_Marker, 50002);
            }
            else
            {
                axMBActX1.Comm.ConnectionType = ConnectionTypes.CONNECTION_USB;
                axMBActX1.Comm.UsbControllerSerialNo = ControllerSerialNo;
            }

            string[] fol = PathFiles.Split('\\');
            WorkingFolder = fol[fol.Length - 1];

            AppendText(Lang.msj_ParameterLoadingCompleted);
        }
        public void LoadTemplatesNames()
        {
            if (Directory.Exists(Assets))
            {
                Plates.Clear();
                string[] files = Directory.GetFiles(Assets, "*.json");
                for (int i = 0; i < files.Length; i++)
                {
                    Plates.Add(new Models.Plates { Id = i, Name = Path.GetFileNameWithoutExtension(files[i]) });
                }
                if (Plates.Count < 1)
                {
                    MessageBox.Show(Lang.msj_ThereNoTemplate, Lang.msj_Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
                else
                {
                    cbModAutTemplate.DataSource = null;
                    cbModAutTemplate.DataSource = Plates;
                    cbModAutTemplate.ValueMember = "Id";
                    cbModAutTemplate.DisplayMember = "Name";
                }
            }
            else
            {
                MessageBox.Show(Lang.msj_PathNotFind, Lang.msj_Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ConvertPDF2DXF(string Origen, string PDFFileName, string LastFolder)
        {
            //Cerramos program si esta abierto
            foreach (var process in Process.GetProcessesByName(AppName))
                process.Kill();

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;

            startInfo.FileName = Assets + "PDF2DXF4\\" + AppName + ".exe";
            startInfo.WindowStyle = ProcessWindowStyle.Normal;

            string folder = Path.Combine(AuxFolder, LastFolder);
            Destino = Path.Combine(folder, PDFFileName + ".dxf");

            if (!System.IO.Directory.Exists(folder))
                System.IO.Directory.CreateDirectory(folder);

            startInfo.Arguments = "\"" + Origen + "\" \"" + Destino + "\"";
            try
            {
                using (Process exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit();
                }
                ConvertDXF2MHL(PDFFileName, LastFolder);
            }
            catch (Exception error)
            {
                AppendText("Convert PDF to DXF " + error.Message);
                fDialog.CloseForm = true;
            }
        }
        public void ConvertDXF2MHL(string FileName, string lastFolder)
        {
            bool ShowProgress = true;
            string dxFile = Path.Combine(AuxFolder, lastFolder, FileName + ".dxf");
            string mhlFile = Path.Combine(AuxFolder, lastFolder, FileName + ".MHL");
            this.Invoke((Action)delegate ()
            {
                try
                {
                    axMBActX1.Dxf.Convert(dxFile, mhlFile, ShowProgress);
                    AppendText(Lang.msj_ConvertDXFtoMHL);
                    LoadTemplate(mhlFile);
                }
                catch (System.Runtime.InteropServices.COMException error)
                {
                    AppendText("Convert DXF to MHL " + error.Message);
                    fDialog.CloseForm = true;
                }
            });
        }
        public string ConvertToDateEng2Other(string fecha, string Lang)
        {
            string ret = "";

            DateTime d = new DateTime(
                        Convert.ToInt32(fecha.Substring(4, 4)),
                        Convert.ToInt32(fecha.Substring(2, 2)),
                        Convert.ToInt32(fecha.Substring(0, 2))
                        );
            string us = d.ToString(new CultureInfo("en-US"));
            ret = d.ToString("ddMMMyyyy").ToUpper();

            if (Lang != "EN")
                switch (Lang)
                {
                    default:
                        ret = ret.Replace("JAN", "ENE");
                        ret = ret.Replace("APR", "ABR");
                        ret = ret.Replace("AUG", "AGO");
                        ret = ret.Replace("DEC", "DIC");
                        break;
                    case "PT":
                        ret = ret.Replace("FEB", "FEV");
                        ret = ret.Replace("APR", "ABR");
                        ret = ret.Replace("MAY", "MAI");
                        ret = ret.Replace("SEP", "SET");
                        ret = ret.Replace("OCT", "OUT");
                        ret = ret.Replace("DIC", "DEZ");
                        break;
                }
            if (ret.Contains("."))
                ret = ret.Replace(".", "");
            return ret;
        }
        public DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            return dataTable;
        }
        public void AppendText(string msj)
        {
            this.Invoke((Action)delegate ()
            {
                rtbLogger.AppendText(DateTime.Now.ToString("HH:mm:ss") + " " + msj + "\r\n");
                rtbLogger.ScrollToCaret();
            });
        }
        private void LoadTemplate(string mhlPath)
        {
            AppendText(Lang.msj_LoadingTemplate);
            isTempleteOK = false;

            fDialog.fMessage = Lang.msj_LoadingTemplate;

            string tempFile = Path.Combine(AuxFolder, TemplateFile);
            try
            {
                while (File.Exists(tempFile))
                {
                    AppendText(Lang.msj_DeletingTemplate);
                    File.Delete(tempFile);
                    Thread.Sleep(1000);
                }
                File.Copy(Path.Combine(Assets, TemplateFile), tempFile);
                while (!File.Exists(tempFile))
                {
                    Thread.Sleep(2000);
                }
                Load2Ctrol(mhlPath);
            }
            catch (Exception error)
            {
                AppendText("Load Template " + error.Message);
                fDialog.CloseForm = true;
                return;
            }
        }
        private void Load2Ctrol(string mhlPath)
        {
            string progress = "";
            try
            {
                progress = "Coordenates";
                if (LoadTemplateCoordenates())
                {
                    progress = "set edit";
                    axMBActX1.Context = ContextTypes.CONTEXT_EDITING;
                    if (axMBActX1.OpenJob(Path.Combine(AuxFolder, TemplateFile)))
                    {
                        Thread.Sleep(500);
                        progress = "parameters";

                        //parametros de marcado
                        axMBActX1.CommonBlock.LaserPower = MarkingParameters.LaserPower;
                        axMBActX1.CommonBlock.ScanSpeed = MarkingParameters.ScanSpeed;
                        axMBActX1.CommonBlock.Frequency = MarkingParameters.Frequency;
                        axMBActX1.CommonBlock.SpotVariable = MarkingParameters.SpotVariable;
                        axMBActX1.CommonBlock.Repetition = MarkingParameters.Repetition;
                        axMBActX1.CommonBlock.FillLineInterval = Convert.ToInt32(MarkingParameters.FillLineInterval);

                        progress = "delete block";
                        axMBActX1.DeleteBlock(0);

                        progress = "serialising";

                        Int64 completed = 0;
                        Int64 serial = 0;
                        Int64 required = 0;
                        Int64 labels2Make = 0;

                        this.Invoke((MethodInvoker)delegate () { completed = Convert.ToInt32(txtModAutQuantityCompleted.Text); });
                        this.Invoke((MethodInvoker)delegate () { serial = Convert.ToInt32(txtModeAutStartSerial.Text); });
                        this.Invoke((MethodInvoker)delegate () { required = Convert.ToInt32(nudModAutQuantityRequired.Value); });
                        serial += completed;
                        progress = "quantities";

                        if (isManualMode)
                            labels2Make = required;
                        else
                            if (required >= completed)
                            labels2Make = required - completed;
                        else
                        {
                            fDialog.CloseForm = true;
                            AppendText(Lang.msj_QuantityCompleted);
                            return;
                        }
                        progress = "nodes";
                        if (Template.Coordinates.Count > 0)
                        {
                            int cont = 0;

                            Int64 labelAdded = 0;

                            foreach (Models.Coordenate item in Template.Coordinates.OrderBy(a => a.Node))
                            {
                                if (labelAdded < labels2Make)
                                {
                                    progress = "node label";

                                    AppendText($"{Lang.msj_LoadingLabel}:{item.Node}");


                                    axMBActX1.CreateBlock(DataTypes.DATA_HATCHLOGO, cont, mhlPath);

                                    axMBActX1.Block(cont).LogoWidth = Template.Width;
                                    axMBActX1.Block(cont).LogoHeight = Template.Height;


                                    axMBActX1.Block(cont).ReferencePosition = ReferencePositionTypes.REFERENCEPOSITION_BOTTOMLEFT;
                                    axMBActX1.Block(cont).X = item.MHL_X;
                                    axMBActX1.Block(cont).Y = item.MHL_Y;
                                    axMBActX1.Block(cont).Z = item.MHL_Z;

                                    if (Template.LabelAngle > 0)
                                        axMBActX1.Block(cont).Angle = Template.LabelAngle;

                                    cont++;
                                    Thread.Sleep(150);

                                    progress = "node text";

                                    axMBActX1.CreateBlock(DataTypes.DATA_CHARHORIZONTAL, cont, string.Format("{0} {1}", txtModeAutDate.Text, serial + labelAdded));

                                    axMBActX1.Block(cont).ReferencePosition = ReferencePositionTypes.REFERENCEPOSITION_BOTTOMLEFT;
                                    axMBActX1.Block(cont).X = item.TXT_X;
                                    axMBActX1.Block(cont).Y = item.TXT_Y;
                                    axMBActX1.Block(cont).Z = item.TXT_Z;

                                    axMBActX1.Block(cont).CharWidth = Template.CharWidth;
                                    axMBActX1.Block(cont).CharHeight = Template.CharHeight;

                                    progress = "node font";
                                    axMBActX1.Block(cont).FontType = FontTypes.FONT_TRUETYPE;
                                    axMBActX1.Block(cont).TrueTypeFontName = "RomanS";


                                    progress = "node angle";
                                    if (Template.TextAngle > 0)
                                    {
                                        axMBActX1.Block(cont).Angle = Template.TextAngle;
                                        axMBActX1.Block(cont).CharAlignType = CharAlignTypes.CHARALIGN_EQUALLAYOUT;
                                        axMBActX1.Block(cont).CharFullWidth = Template.CharFullWidth;
                                    }

                                    cont++;
                                    labelAdded++;
                                    Thread.Sleep(150);
                                }
                                else
                                    break;
                            }

                            LabelsSendit = labelAdded;
                            progress = "saving file";

                            if (axMBActX1.SaveJob(AuxFolder + "\\" + TemplateFile))
                            {
                                isTempleteOK = true;
                            }
                        }
                        else
                            MessageBox.Show(Lang.msj_TemplateWithoutCoordinates, Lang.msj_Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                isTempleteOK = false;
                fDialog.CloseForm = true;
                AppendText($"Load to control: {progress}\t{Lang.msj_ErrorOccurred} ");
                AppendText(ex.Message);
                MessageBox.Show(Lang.msj_ErrorOccurred, Lang.msj_Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AppendText(Lang.msj_Done);
            fDialog.CloseForm = true;
        }
        private bool LoadTemplateCoordenates()
        {
            string Text = "";
            this.Invoke((MethodInvoker)delegate () { Text = cbModAutTemplate.Text; });

            string file = Path.Combine(Assets, Text + ".json");
            if (File.Exists(file))
            {
                JObject JsonData = JObject.Parse(File.ReadAllText(file));
                Template = JsonConvert.DeserializeObject<Models.TemplateCoordenates>(JsonData.ToString());
                AppendText($"{Lang.msj_TemplateLoaded} " + Text);
                return true;
            }
            else
            {
                fDialog.CloseForm = true;
                AppendText($"{Lang.msj_ThereNoTemplate} " + Text);
                return false;
            }
        }
        private void CleanCtrls()
        {
            txtModeAutMaterial.Text =
            txtModeAutStartSerial.Text =
            txtModAutEndingSerial.Text =
            txtModeAutDate.Text =
            txtModAutQuantityCompleted.Text =
            txtFilter.Text =
            txtAuxPath.Text = "";
            nudModAutQuantityRequired.Value = 1;
        }
        private void EnableCtrls()
        {
            txtModeAutStartSerial.Enabled =
            txtModeAutDate.Enabled =
            nudModAutQuantityRequired.Enabled = isManualMode;
        }
        public void EnableGbCtrls(bool enable)
        {
            gbSearch.Invoke(new Action(() =>
            {
                gbSearch.Enabled = enable;
            }));

            gbData.Invoke(new Action(() =>
            {
                gbData.Enabled = enable;
            }));

            gbMode.Invoke(new Action(() =>
            {
                gbMode.Enabled = enable;
            }));

            gbXMLFiles.Invoke(new Action(() =>
            {
                gbXMLFiles.Enabled = enable;
            }));

            btnSendtoMarker.Invoke(new Action(() =>
            {
                btnSendtoMarker.Enabled = enable;
            }));

            btnClearError.Invoke(new Action(() =>
            {
                btnClearError.Enabled = enable;
            }));

            btnZoomAll.Invoke(new Action(() =>
            {
                btnZoomAll.Enabled = enable;
            }));

            btnSendtoMarker.Invoke(new Action(() =>
            {
                btnZoomAll.Enabled = enable;
            }));

            menu.Invoke(new Action(() =>
            {
                menu.Enabled = enable;
            }));


        }
        private bool LoadDGVData2Txts()
        {
            try
            {
                if (dgvJobs.SelectedRows.Count > 0)
                {
                    txtModeAutMaterial.Text = dgvJobs.SelectedRows[0].Cells["Name"].Value.ToString();
                    txtModeAutStartSerial.Text = dgvJobs.SelectedRows[0].Cells["Serial_Number"].Value.ToString();
                    txtModAutEndingSerial.Text = (Convert.ToInt32(dgvJobs.SelectedRows[0].Cells["Serial_Number"].Value.ToString()) + Convert.ToInt32(dgvJobs.SelectedRows[0].Cells["Quantity"].Value.ToString()) - 1).ToString();
                    txtModeAutDate.Text = ConvertToDateEng2Other(dgvJobs.SelectedRows[0].Cells["Date"].Value.ToString(), dgvJobs.SelectedRows[0].Cells["Languaje"].Value.ToString());
                    if (!isManualMode)
                        nudModAutQuantityRequired.Value = Convert.ToInt32(dgvJobs.SelectedRows[0].Cells["Quantity"].Value.ToString());

                    txtModAutQuantityCompleted.Text = dgvJobs.SelectedRows[0].Cells["Quantity_Marked"].Value.ToString();
                    txtAuxPath.Text = dgvJobs.SelectedRows[0].Cells["Path"].Value.ToString();
                    txtModeAutPDF.Text = dgvJobs.SelectedRows[0].Cells["Graphics_PDF_File"].Value.ToString();

                    XML_FileSendIt = Path.Combine(txtAuxPath.Text, txtModeAutMaterial.Text).ToString();
                    return true;
                }
                else
                {
                    XML_FileSendIt = "";
                    MessageBox.Show(Lang.msj_YouHaveNotSelectedaPDF, Lang.msj_Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{Lang.msj_InvalidXMLFile}", Lang.msj_Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                CleanCtrls();
                return false;
            }
        }
        private void LoadWorkMode()
        {
            if (!isManualMode)
            {
                btnMode.Image = Properties.Resources.manual;
                btnMode.Text = Lang.msj_ManualMode;
                lbDisplayMode.Text = Lang.msj_AutomaticMode.ToUpper();
                lbDisplayMode.BackColor = Color.GreenYellow;
                EnableCtrls();
            }
            else
            {
                btnMode.Image = Properties.Resources.automatic;
                btnMode.Text = Lang.msj_AutomaticMode;
                lbDisplayMode.Text = Lang.msj_ManualMode.ToUpper();
                lbDisplayMode.BackColor = Color.Red;
                EnableCtrls();
            }
        }
        private void LoadMarkingParameters()
        {
            if (Properties.Settings.Default.IsLamined)
            {
                MarkingParameters.LaserPower = Properties.Settings.Default.LaminatedPlate_LaserPower;
                MarkingParameters.ScanSpeed = Properties.Settings.Default.LaminatedPlate_ScanSpeed;
                MarkingParameters.Frequency = Properties.Settings.Default.LaminatedPlate_Frequency;
                MarkingParameters.SpotVariable = Properties.Settings.Default.LaminatedPlate_SpotVariable;
                MarkingParameters.Repetition = Properties.Settings.Default.LaminatedPlate_Repetition;
                MarkingParameters.FillLineInterval = Properties.Settings.Default.LaminatedPlate_FillLineInterval;
            }
            else
            {
                MarkingParameters.LaserPower = Properties.Settings.Default.PaintedPlate_LaserPower;
                MarkingParameters.ScanSpeed = Properties.Settings.Default.PaintedPlate_ScanSpeed;
                MarkingParameters.Frequency = Properties.Settings.Default.PaintedPlate_Frequency;
                MarkingParameters.SpotVariable = Properties.Settings.Default.PaintedPlate_SpotVariable;
                MarkingParameters.Repetition = Properties.Settings.Default.PaintedPlate_Repetition;
                MarkingParameters.FillLineInterval = Properties.Settings.Default.PaintedPlate_FillLineInterval;
            }
        }
        private void LoadFileData()
        {
            if (LoadDGVData2Txts())
            {
                if (dgvJobs.SelectedRows.Count > 0)
                {
                    string PdfFileName = Path.GetFileNameWithoutExtension(dgvJobs.SelectedRows[0].Cells["Graphics_PDF_File"].Value.ToString());
                    string Ruta = dgvJobs.SelectedRows[0].Cells["Path"].Value.ToString();

                    string[] folders = Ruta.Split('\\');
                    string lastfolder = folders[folders.Length - 1];

                    if (!File.Exists(Path.Combine(AuxFolder, lastfolder, PdfFileName + ".MHL")))
                    {
                        if (File.Exists(Path.Combine(AuxFolder, lastfolder, PdfFileName + ".dxf")))
                            File.Delete(Path.Combine(AuxFolder, lastfolder, PdfFileName + ".dxf"));

                        fDialog = new Form_Dialog(Lang.msj_ConvertingFilesPleaseWait);
                        AppendText(Lang.msj_ConvertPDFtoDXF);
                        string Origen = Path.Combine(Ruta, PdfFileName + ".pdf");
                        var t = new Thread(() => ConvertPDF2DXF(Origen, PdfFileName, lastfolder));
                        t.CurrentUICulture = Idioma;
                        t.Start();
                        fDialog.ShowDialog();
                    }
                    else
                    {
                        fDialog = new Form_Dialog(Lang.msj_LoadingTemplate);
                        var t = new Thread(() => LoadTemplate(Path.Combine(AuxFolder, lastfolder, PdfFileName + ".MHL")));
                        t.CurrentUICulture = Idioma;
                        t.Start();
                        fDialog.ShowDialog();
                    }
                }
            }

        }
        private bool Connect(bool toConnect)
        {
            bool is_success = false;
            try
            {
                if (!IsConnected && toConnect)
                {
                    fDialog.fMessage = Lang.msj_Connecting;
                    AppendText(Lang.msj_Connecting);

                    is_success = axMBActX1.Comm.Online();
                    if (!is_success)
                    {
                        IsConnected = false;
                        if (Properties.Settings.Default.UseIPConnection)
                            AppendText($"{Lang.msj_ConnectError} {IP_Marker}");
                        else
                            AppendText($"{Lang.msj_ConnectError} {ControllerSerialNo}");

                        fDialog.CloseForm = true;
                    }
                    else
                        IsConnected = true;
                }
                else
                {
                    if (axMBActX1.Comm.IsOnline)
                        is_success = axMBActX1.Comm.Offline();
                    IsConnected = false;
                }
            }
            catch (Exception ex)
            {
                IsConnected = false;
                fDialog.CloseForm = true;
                AppendText($"Connect {Lang.msj_ErrorOccurred}  {ex.Message}");
                EnableGbCtrls(true);
            }

            return is_success;
        }
        private void Camera()
        {
            try
            {
                if (!IsCamaraON)
                {
                    axMBActX1.Operation.IsCameraFinderView = true;
                    axMBActX1.Operation.SetLighting(true);
                    IsCamaraON = true;
                }
                else
                {
                    axMBActX1.Operation.IsCameraFinderView = false;
                    axMBActX1.Operation.SetLighting(false);
                    IsCamaraON = false;
                }
            }
            catch (System.Runtime.InteropServices.COMException error)
            {
                AppendText("Camera " + error.Message);
            }
        }
        private void SendJobToCotroller()
        {
            try
            {
                if (Connect(true))
                {
                    axMBActX1.Context = ContextTypes.CONTEXT_CONTROLLER;
                    fDialog.fMessage = Lang.msj_Sending;
                    AppendText(Lang.msj_Sending);
                    Thread.Sleep(500);
                    if (axMBActX1.SendControllerJob(0, Path.Combine(AuxFolder, TemplateFile)))
                    {
                        fDialog.fMessage = Lang.btnSendtoMarker;
                        AppendText(Lang.msj_SavedSuccessfully);
                        IsJobSenditOK = true;
                        StartMarking();
                    }
                    else
                    {
                        fDialog.CloseForm = true;
                        AppendText(Lang.msj_ErrorSaving);
                        IsJobSenditOK = false;
                        EnableGbCtrls(true);
                    }
                }
            }
            catch (Exception ex)
            {
                EnableGbCtrls(true);
                fDialog.CloseForm = true;
                AppendText("Send Job To Cotroller " + Lang.msj_ErrorOccurred + " " + ex.Message);
            }
        }
        public void StartMarking()
        {
            IsCamaraON = false;
            Camera();
            try
            {
                fDialog.CloseForm = true;
                AppendText(Lang.msj_StartMarking);
                //axMBActX1.Operation.StartMarking();
            }
            catch (System.Runtime.InteropServices.COMException error)
            {
                EnableGbCtrls(true);
                fDialog.CloseForm = true;
                AppendText("Start Marking " + error.Message);
            }
        }
        private void CleanError()
        {
            try
            {
                if (axMBActX1.Comm.IsOnline)
                {
                    axMBActX1.Comm.Offline();
                    IsConnected = false;
                }
                if (Connect(true))
                    axMBActX1.Operation.ClearError();
                Connect(false);
            }
            catch (System.Runtime.InteropServices.COMException error)
            {
                AppendText("CleanError " + Lang.msj_ErrorOccurred + " " + error.Message);
            }
            fDialog.CloseForm = true;
        }
        private void UpdateQuantityMarkedXML()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(XML_FileSendIt);

            XmlNode root = doc.DocumentElement;
            XmlNode node = doc.DocumentElement.SelectSingleNode("/placajob/quantitymarked");
            if (node == null)
            {
                XmlElement marked = doc.CreateElement("quantitymarked");
                marked.InnerText = "0";
                root.AppendChild(marked);
                node = doc.DocumentElement.SelectSingleNode("/placajob/quantitymarked");
            }
            node.InnerText = (Convert.ToInt32(node.InnerText) + LabelsSendit).ToString();
            doc.Save(XML_FileSendIt);
            DeleteXMLCompleted();
        }
        public void DeleteXMLCompleted()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(XML_FileSendIt);
            XmlNode quantity = doc.DocumentElement.SelectSingleNode("/placajob/quantity");
            XmlNode quantitymarked = doc.DocumentElement.SelectSingleNode("/placajob/quantitymarked");

            int iquantity = 0, iquantitymarked = 0;

            if (quantity != null)
                iquantity = Convert.ToInt32(quantity.InnerText);

            if (quantitymarked != null)
                iquantitymarked = Convert.ToInt32(quantitymarked.InnerText);


            string pdfFile = Path.GetDirectoryName(XML_FileSendIt);
            pdfFile = Path.Combine(pdfFile, Path.GetFileNameWithoutExtension(XML_FileSendIt) + ".PDF");
            if (iquantitymarked >= iquantity)
            {
                if (File.Exists(XML_FileSendIt))
                    File.Delete(XML_FileSendIt);
                if (File.Exists(pdfFile))
                    File.Delete(pdfFile);
                CleanCtrls();
                XML_FileSendIt = "";
            }
        }
        public void SetRegeditValues()
        {
            try
            {
                RegistryKey SoftwareKey = Registry.CurrentUser.OpenSubKey("Software", true);
                RegistryKey AppNameKey = SoftwareKey.OpenSubKey(AppName, true);
                RegistryKey tMainForm = AppNameKey.OpenSubKey("TMainForm", true);

                tMainForm.SetValue("TextasVectorCheck_Checked", "True");
                tMainForm.SetValue("UsemmCheck_Checked", "True");
                tMainForm.SetValue("ConvertTextCheck_Checked", "True");
            }
            catch (Exception ex)
            {
                AppendText($"Regix {Lang.msj_ErrorOccurred} {ex.Message}");
            }
        }
        #endregion

        #region [Methods_treeView]
        private void InitializeTreeView()
        {
            fDialog = new Form_Dialog(Lang.msj_LoadingParameters);
            Thread ini = new Thread(() => BuildTreeView());
            ini.CurrentUICulture = Idioma;
            ini.Start();
            fDialog.BringToFront();
            fDialog.ShowDialog();
        }
        private void BuildTreeView()
        {
            if (this.trvPathFiles.InvokeRequired)
            {
                SetControlTreeView d = new SetControlTreeView(BuildTreeView);
                this.Invoke(d);
            }
            else
            {
                LoadTreeViewParameters();
                if (trvPathFiles.Nodes.Count > 0)
                    trvPathFiles.Nodes.Clear();
                if (Directory.Exists(PathFiles))
                {
                    DirectoryInfo directoryInfo = new DirectoryInfo(PathFiles);
                    if (directoryInfo.Exists)
                    {
                        BuildTree(directoryInfo, trvPathFiles.Nodes);
                    }
                }
                fDialog.CloseForm = true;
            }
        }
        private void BuildTree(DirectoryInfo directoryInfo, TreeNodeCollection addInMe)
        {

            TreeNode curNode = addInMe.Add(directoryInfo.Name);
            foreach (DirectoryInfo subdir in directoryInfo.GetDirectories())
            {
                BuildTree(subdir, curNode.Nodes);
            }
        }
        private void LoadXMLFilesToDGV()
        {
            if (!Directory.Exists(SearchFolder))
                return;

            string[] files;
            if (rbSearchByFolder.Checked)
                files = Directory.GetFiles(SearchFolder, "*.xml");
            else
            {
                var extensions = new List<string> { };
                files = Directory.GetFiles(SearchFolder, "*" + txtSearch.Text + "*.xml", SearchOption.AllDirectories);
            }

            try
            {
                XMLFiles = new List<Models.XMLFiles>();

                foreach (string item in files)
                {
                    FileInfo file = new FileInfo(item);

                    Models.XMLFiles fileData = new Models.XMLFiles();
                    XmlDocument doc = new XmlDocument();
                    doc.Load(file.FullName);

                    fileData.Name = file.Name;
                    fileData.Path = System.IO.Path.GetDirectoryName(file.FullName);

                    XmlNode node = doc.DocumentElement.SelectSingleNode("/placajob/quantity");
                    fileData.Quantity = node != null ? node.InnerText : "0";

                    node = doc.DocumentElement.SelectSingleNode("/placajob/graphicsPDFfile");
                    fileData.Graphics_PDF_File = node != null ? node.InnerText : "0";

                    node = doc.DocumentElement.SelectSingleNode("/placajob/variable/serialnumber");
                    fileData.Serial_Number = node != null ? node.InnerText : "0";

                    node = doc.DocumentElement.SelectSingleNode("/placajob/variable/date");
                    fileData.Date = node != null ? node.InnerText : "0";

                    node = doc.DocumentElement.SelectSingleNode("/placajob/quantitymarked");
                    fileData.Quantity_Marked = node != null ? node.InnerText : "0";

                    node = doc.DocumentElement.SelectSingleNode("/placajob/language");
                    fileData.Languaje = node != null ? node.InnerText : "0";

                    if (Convert.ToInt32(fileData.Quantity_Marked) < Convert.ToInt32(fileData.Quantity))
                        XMLFiles.Add(fileData);
                    else
                    {
                        XML_FileSendIt = file.FullName;
                        DeleteXMLCompleted();
                    }
                }

                if (XMLFiles.Count > 0)
                {
                    DataTable dt = ToDataTable(XMLFiles);
                    dgvJobs.DataSource = dt;
                    dgvJobs.Columns["Path"].Visible = false;
                    dgvJobs.Columns["Graphics_PDF_File"].Visible = true;
                }
                else
                    dgvJobs.DataSource = null;
            }
            catch (Exception ex)
            {
                AppendText($"Load XML Files To DGV {Lang.msj_ErrorOccurred} " + ex.Message);
                return;
            }
        }
        private void trvPathFiles_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == WorkingFolder)
                SearchFolder = PathFiles;
            else
                SearchFolder = Path.Combine(PathFiles, e.Node.Text);

            CleanCtrls();
            LoadXMLFilesToDGV();
        }
        #endregion

        #region [Language_methods]
        private void Setlanguage()
        {
            Thread.CurrentThread.CurrentUICulture = Idioma;
            menuLanguage.Text = Lang.menuLanguage;
            menuLanguage_English.Text = Lang.menuLanguage_English;
            menuLanguage_Spanish.Text = Lang.menuLanguage_Spanish;
            menuLanguage_Portuguese.Text = Lang.menuLanguage_Portuguese;
            menuSetting_About.Text = Lang.menuSetting_About;
            menuSettings.Text = Lang.menuSettings;
            menuSettings_Parameters.Text = Lang.menuSettings_Parameters;
            menuSettings_AppSettings.Text = Lang.menuSettings_AppSettings;
            menuSettings_TemplateEditor.Text = Lang.menuSettings_TemplateEditor;
            menuSetting_About.Text = Lang.menuSetting_About;

            gbSearch.Text = Lang.gbSearch;
            rbSearchByFolder.Text = Lang.rbSearchByFolder;
            rbSearchByString.Text = Lang.rbSearchByString;
            btnOpenPDF.Text = Lang.btnOpenPDF;
            btnMode.Text = Lang.msj_AutomaticMode;
            lbModeAutMaterial.Text = Lang.lbModeAutMaterial;
            lbModeAutStarSerial.Text = Lang.lbModeAutStarSerial;
            lbModeAutEndSerial.Text = Lang.lbModeAutEndSerial;
            lbModeAutDate.Text = Lang.lbModeAutDate;
            lbModAutQuantityRequired.Text = Lang.lbModAutQuantityRequired;
            lbModAutQuantityCompleted.Text = Lang.lbModAutQuantityCompleted;
            lbModeAutPDF.Text = Lang.lbModeAutPDF;
            lbModAutTemplate.Text = Lang.lbModAutTemplate;
            lbFilterDgv.Text = Lang.lbFilterDgv;
            btnReload.Text = Lang.btnReload;
            btnZoomAll.Text = Lang.btnZoomAll;
            btnZoom1.Text = Lang.btnZoom1;
            btnLogClear.Text = Lang.btnLogClear;
            btnSendtoMarker.Text = Lang.btnSendtoMarker;
            btnStopMarking.Text = Lang.btnStopMarking;
            btnClearError.Text = Lang.btnLogClear;
            gbXMLFiles.Text = Lang.gbXMLFiles;
            menuExit.Text = Lang.menuExit;
            LoadWorkMode();
        }
        #endregion

        #region [Events_Menu]
        private void menuLanguage_English_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.CultureInfo = "";
            Properties.Settings.Default.Save();
            Idioma = new CultureInfo(Properties.Settings.Default.CultureInfo);
            Setlanguage();
        }
        private void menuLanguage_Spanish_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.CultureInfo = "es-MX";
            Properties.Settings.Default.Save();
            Idioma = new CultureInfo(Properties.Settings.Default.CultureInfo);
            Setlanguage();
        }
        private void menuLanguage_Portuguese_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.CultureInfo = "pt-BR";
            Properties.Settings.Default.Save();
            Idioma = new CultureInfo(Properties.Settings.Default.CultureInfo);
            Setlanguage();
        }
        private void menuParameters_Click(object sender, EventArgs e)
        {
            Form_Parameters p = new Form_Parameters();
            p.ShowDialog();
            LoadMarkingParameters();
        }
        private void menuSettings_AppSettings_Click(object sender, EventArgs e)
        {
            Form_Settings s = new Form_Settings();
            s.ShowDialog();
            if (s.idUpdated)
            {
                InitializeTreeView();
            }
        }
        private void menuExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Lang.msj_CloseTheApplication, Lang.msj_Message, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                IsFormClosing = true;
                this.Close();
            }
        }
        #endregion

        #region [Events_App]
        public MainForm()
        {
            InitializeComponent();
            Idioma = new CultureInfo(Properties.Settings.Default.CultureInfo);
            Setlanguage();
            axMBActX1.InitMBActX(MarkingUnitTypes.MARKINGUNIT_MDX2520);
            trvPathFiles.ImageList = imageList1;
            CheckForIllegalCrossThreadCalls = false;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeTreeView();
            LoadTemplatesNames();
            LoadMarkingParameters();
            LoadWorkMode();
            SetRegeditValues();
        }
        private void btnOpenPDF_Click(object sender, EventArgs e) => LoadFileData();
        private void btnStopMarking_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsConnected)
                {
                    WasAborted = true;
                    axMBActX1.Operation.StopMarking();
                    AppendText(Lang.msj_MarkingAbort);
                    EnableGbCtrls(true);
                }
                else
                    AppendText(Lang.msj_NotConnected);
            }
            catch (System.Runtime.InteropServices.COMException error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void btnSendtoMarker_Click(object sender, EventArgs e)
        {
            if (XML_FileSendIt != "" && LabelsSendit > 0 && isTempleteOK)
            {
                if (MessageBox.Show(Lang.msj_SendToMarking, Lang.msj_Message, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    IsJobSenditOK = false;
                    WasAborted = false;
                    EnableGbCtrls(false);
                    fDialog = new Form_Dialog(Lang.msj_Connecting);
                    var t = new Thread(() => SendJobToCotroller());
                    t.CurrentUICulture = Idioma;
                    t.Start();
                    fDialog.ShowDialog();
                }
            }
            else
                MessageBox.Show(Lang.mjs_ReloadTemplateFirst, Lang.msj_Message, MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void btnZoomAll_Click(object sender, EventArgs e) => axMBActX1.ZoomAll();
        private void btnZoom1_Click(object sender, EventArgs e) => axMBActX1.Zoom(-90.00, 120.000, 120);

        private void button1_Click(object sender, EventArgs e)
        {
            //DriveInfo[] drives = DriveInfo.GetDrives();
            //foreach (DriveInfo drive in drives)
            //{
            //    string label = drive.IsReady ?
            //    String.Format(" - {0}", drive.VolumeLabel) : null;
            //    AppendText(string.Format("{0} - {1}{2}", drive.Name, drive.DriveType, label));
            //}

            //using (var fbd = new FolderBrowserDialog())
            //{
            //    DialogResult result = fbd.ShowDialog();

            //    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            //    {
            //        string[] files = Directory.GetFiles(fbd.SelectedPath);
            //        Properties.Settings.Default.PathFiles = fbd.SelectedPath.ToString();
            //    }
            //}
            DeleteXMLCompleted();
        }

        private void txtModeAutStartSerial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!IsFormClosing && MessageBox.Show(Lang.msj_CloseTheApplication, Lang.msj_Message, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.No)
                e.Cancel = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                    axMBActX1.Context = ContextTypes.CONTEXT_CONTROLLER;
                    fDialog.fMessage = Lang.msj_Sending;
                    AppendText(Lang.msj_Sending);
                    Thread.Sleep(500);
                    if (axMBActX1.SendControllerJob(0, Path.Combine(AuxFolder, TemplateFile)))
                    {
                        fDialog.fMessage = Lang.btnSendtoMarker;
                        AppendText(Lang.msj_SavedSuccessfully);
                        IsJobSenditOK = true;
                    }
                    else
                    {
                        fDialog.CloseForm = true;
                        AppendText(Lang.msj_ErrorSaving);
                        IsJobSenditOK = false;
                        EnableGbCtrls(true);
                    }
            }
            catch (Exception ex)
            {
                EnableGbCtrls(true);
                fDialog.CloseForm = true;
                AppendText("Send Job To Cotroller " + Lang.msj_ErrorOccurred + " " + ex.Message);
            }
            finally
            {
                fDialog.CloseForm = true;
                AppendText("job enviado");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (axMBActX1.ReceiveControllerJob(Path.Combine(AuxFolder, TemplateFile), 0))
                {
                    rtbLogger.AppendText("jobLeido");
                    try
                    {
                        if (axMBActX1.OpenJob(Path.Combine(AuxFolder, TemplateFile)))
                        {
                            rtbLogger.AppendText("job Abierto");
                        }
                    }
                    catch (System.Runtime.InteropServices.COMException error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
            }
            catch (System.Runtime.InteropServices.COMException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rtbLogger.AppendText(MarkerTCPClient.Ready());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (!IsConnected)
                Connect(true);
            else
                Connect(false);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            rtbLogger.AppendText(MarkerTCPClient.SendCommand(textBox1.Text));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Camera();
        }

        private void btnRefreshdgv_Click(object sender, EventArgs e) => LoadXMLFilesToDGV();
        private void menuSettings_TemplateEditor_Click(object sender, EventArgs e)
        {
            Form_TemplateEditor te = new Form_TemplateEditor();
            this.Hide();
            te.ShowDialog();
            LoadTemplatesNames();
            this.Show();
        }
        private void menuSetting_About_Click(object sender, EventArgs e)
        {
            Form_About a = new Form_About();
            a.ShowDialog();
        }
        private void button1_Click_2(object sender, EventArgs e) => Connect(true);
        private void axMBActX1_EvMarkingEnd(object sender, AxMBPLib2._DMBActXEvents_EvMarkingEndEvent e)
        {
            if (IsJobSenditOK && !isManualMode && !WasAborted)
            {
                IsJobSenditOK = false;
                UpdateQuantityMarkedXML();
                LabelsSendit = 0;
                LoadXMLFilesToDGV();
                foreach (DataGridViewRow row in dgvJobs.Rows)
                {
                    string ts = row.Cells["Name"].Value.ToString();
                    if (ts == Path.GetFileName(XML_FileSendIt))
                    {
                        row.Selected = true;
                        LoadDGVData2Txts();
                    }
                }
            }
            fDialog.CloseForm = true;
            IsCamaraON = true;
            Camera();
            AppendText(Lang.msj_MarkingDone);
            Connect(false);
            EnableGbCtrls(true);
        }
        private void button2_Click(object sender, EventArgs e) => Connect(!IsConnected);
        private void txtFilter_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (XMLFiles.Count > 0)
                {
                    DataTable dt = ToDataTable(XMLFiles.FindAll(w => w.Name.Contains(txtFilter.Text)));
                    dgvJobs.DataSource = dt;
                    dgvJobs.Columns["Path"].Visible = false;
                }
            }
        }
        private void btnReloadTemplate_Click(object sender, EventArgs e)
        {
            if (txtModeAutMaterial.Text.Length > 0)
            {
                string Ruta = txtAuxPath.Text;
                string[] folders = Ruta.Split('\\');
                string lastfolder = folders[folders.Length - 1];

                string Archivo = System.IO.Path.GetFileNameWithoutExtension(txtModeAutMaterial.Text);

                if (File.Exists(Path.Combine(AuxFolder, lastfolder, Archivo + ".MHL")))
                {
                    fDialog = new Form_Dialog(Lang.msj_LoadingTemplate);
                    var t = new Thread(() => LoadTemplate(Path.Combine(AuxFolder, lastfolder, Archivo + ".MHL")));
                    t.CurrentUICulture = Idioma;
                    t.Start();
                    fDialog.ShowDialog();
                }
                else
                    LoadFileData();
            }
            else
                MessageBox.Show(Lang.msj_YouHaveNotSelectedaPDF, Lang.msj_Message, MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                LoadXMLFilesToDGV();
        }
        private void btnClearError_Click(object sender, EventArgs e)
        {
            fDialog = new Form_Dialog(Lang.msj_Connecting);
            var t = new Thread(() => CleanError());
            t.CurrentUICulture = Idioma;
            t.Start();
            fDialog.ShowDialog();
        }
        private void rbSearchByFile_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSearchByFolder.Checked)
            {
                txtSearch.Text = "";
                txtSearch.Enabled = false;
            }
            else
            {
                trvPathFiles.Enabled = false;
                SearchFolder = PathFiles;
                txtSearch.Enabled = true;
            }
            trvPathFiles.Enabled = rbSearchByFolder.Checked;
        }
        private void btnMode_Click(object sender, EventArgs e)
        {
            isManualMode = !isManualMode;
            LoadWorkMode();
        }
        private void btnLogClear_Click(object sender, EventArgs e) => rtbLogger.Text = "";
        private void dgvJobs_Click(object sender, EventArgs e) => LoadDGVData2Txts();
        #endregion
    }
}
