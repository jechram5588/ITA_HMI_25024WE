using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using MBPLib2;

namespace HMI_25024WE
{
    public partial class Form1 : Form
    {

        private string Assets, Archivo,TempC;

        // Dll Set Focus
        [DllImport("user32.dll")]
        public static extern bool ShowWindowAsync(HandleRef hWnd, int nCmdShow);
        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr WindowHandle);
        public const int SW_RESTORE = 9;
        // Dll mouse Click
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;

        public Form1()
        {
            InitializeComponent();
            Assets = AppDomain.CurrentDomain.BaseDirectory + "Assets\\";
            TempC = @"c:\keyence\";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (btnOnline.Text == "OFF")
                {
                    axMBActX1.Comm.Offline();
                    btnOnline.Text = "ON";
                }
                else
                {
                    if (axMBActX1.Comm.IsOnline)
                        axMBActX1.Comm.Offline();

                    axMBActX1.Comm.ConnectionType = ConnectionTypes.CONNECTION_ETHERNET;
                    axMBActX1.Comm.IpAddress = "192.168.1.10";
                    bool is_success = axMBActX1.Comm.Online();
                    if (is_success)
                    {
                        axMBActX1.Context = ContextTypes.CONTEXT_CONTROLLER;
                        btnOnline.Text = "OFF";
                    }
                    else
                        btnOnline.Text = "ON";
                }
            }
            catch (System.Runtime.InteropServices.COMException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int JobNo = int.Parse(this.numericUpDown1.Value.ToString());
            richTextBox1.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " Cambio de programa a " + numericUpDown1.Value + "\r\n");
            try
            {
                axMBActX1.Operation.SetCurrentJobNo(JobNo);
                richTextBox1.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " Cambiado OK\r\n");
            }
            catch (System.Runtime.InteropServices.COMException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            axMBActX1.InitMBActX(MarkingUnitTypes.MARKINGUNIT_MDX2520);
            //axMBActX1.IsAutoRedraw = true;
            //axMBActX1.IsBlockingCommunication = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " Inicio\r\n");
            int JobNo;
            string JobTitle;
            try
            {
                JobNo = axMBActX1.Operation.GetCurrentJobNo();
                richTextBox1.AppendText(JobNo.ToString() + " ");
                JobTitle = axMBActX1.Operation.GetJobTitle(JobNo);
                richTextBox1.AppendText(JobTitle.ToString() + "\r\n");
            }
            catch (System.Runtime.InteropServices.COMException error)
            {
                MessageBox.Show(error.Message);
            }
            richTextBox1.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " Correcto\r\n");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                axMBActX1.Operation.ClearError();
            }
            catch (System.Runtime.InteropServices.COMException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int Count;
            try
            {
                Count = axMBActX1.UpdateControllerFileCount(ControllerFileTypes.CONTROLLERFILE_JOB);
                for (int index = 0; index < Count; index++)
                {
                    richTextBox1.AppendText(axMBActX1.ControllerFile(index).JobNo + ":" + axMBActX1.ControllerFile(index).FileName + "\n");
                }
            }
            catch (System.Runtime.InteropServices.COMException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " Inicio\r\n");

            try
            {
                axMBActX1.Context = ContextTypes.CONTEXT_EDITING;
                axMBActX1.OpenControllerJob(Convert.ToInt32(numericUpDown1.Value));
                axMBActX1.Block(0).LaserPower = Convert.ToInt32(numericUpDown2.Value);
                axMBActX1.Block(1).Text = textBox1.Text;
                //axMBActX1.CommonBlock.LaserPower = Convert.ToInt32(numericUpDown2.Value);
                axMBActX1.SaveControllerJob(Convert.ToInt32(numericUpDown1.Value));
                axMBActX1.Context = ContextTypes.CONTEXT_CONTROLLER;
                richTextBox1.AppendText("Terminado\r\n");
            }
            catch (System.Runtime.InteropServices.COMException error)
            {
                MessageBox.Show(error.Message);
                return;
            }
            richTextBox1.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " Termino\r\n");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string path = "";
            using (var fbd = new OpenFileDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK)
                {
                    path = fbd.FileName;
                }
            }
            //try
            //{
                axMBActX1.Context = ContextTypes.CONTEXT_EDITING;
                axMBActX1.OpenJob(path);
            //}
            //catch (Exception error)
            //{
            //    Console.WriteLine(error.Message);
            //    return;
            //}
        }

        public void ConvertPDF2DXF(string origen, string FileName)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            
            startInfo.FileName = Assets + "PDF2DXF4\\pdf2dxf.exe";
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            startInfo.Arguments = "\""+origen+"\" \""+ TempC + FileName + ".dxf\"";

            try
            {
                using (Process exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit();
                }
                richTextBox1.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "Convert terminado\r\n");
                this.ConvertDXF2MHL(FileName);
            }
            catch
            {
                richTextBox1.AppendText("Error al convertir\r\n");
                // Log error.
            }
        }
        public void ConvertDXF2MHL(string FileName)
        {
            bool ShowProgress = true;
            string dxFile = TempC + FileName + ".dxf";
            string mhlFile = TempC + FileName + ".MHL";
            try
            {
                axMBActX1.Dxf.Convert(dxFile, mhlFile, ShowProgress);
                richTextBox1.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") +" DXF to MHL Terminado\r\n");
            }
            catch (System.Runtime.InteropServices.COMException error)
            {
                MessageBox.Show(error.Message);
            }
        }
        CultureInfo Idioma = new CultureInfo("");

        private void pbFlagMex_Click(object sender, EventArgs e)
        {
            Idioma = new CultureInfo("");
            Setlanguage();
        }
        private void Setlanguage()
        {
            Thread.CurrentThread.CurrentUICulture = Idioma;
            label1.Text = Lang.menuLanguage_English;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            List<Models.Coordenate> Coordinates = new List<Models.Coordenate>();
            try
            {
                Models.Coordenate coor= new Models.Coordenate(); ;
                for (int i = 0; i < 42; i++)
                {
                    if (i % 2 == 0)
                    {
                        coor = new Models.Coordenate();
                        coor.Node = i;
                        coor.MHL_X = axMBActX1.Block(i).X;
                        coor.MHL_Y = axMBActX1.Block(i).Y;
                    }
                    else{
                        coor.TXT_X = axMBActX1.Block(i).X;
                        coor.TXT_Y = axMBActX1.Block(i).Y;
                        Coordinates.Add(coor);
                    }
                }
            }
            catch { }
            finally
            {
                Console.WriteLine("Termine");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string pdfFilePath = @"C:\Jech_Data\0. Desktop\WEG Files\182-4TC1.pdf";

            string impresora = "KEYENCE Laser Marker";
            string sumatraPath = @"C:\Jech_Data\0. Desktop\WEG Files\SumatraPDF\SumatraPDF-3.5.2-64.exe";

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = sumatraPath,
                Arguments = $"-print-to \"{impresora}\" \"{pdfFilePath}\"",
                UseShellExecute = false,
                CreateNoWindow = true
            };

            Process.Start(psi);

            bool app = true;
            string proceso = "MarkingBuilderPlus";

            while (app)
            {
                Console.WriteLine("Close marking");
                Process[] pname = Process.GetProcessesByName(proceso);
                if (pname.Length > 0)
                {
                    Thread.Sleep(10000);
                    FocusProcess(pname[0].ProcessName);
                    Console.WriteLine("Focus");
                    break;
                }
                Thread.Sleep(1000);
            }
            DoMouseClick(800, 600);
            Thread.Sleep(1000);
            DoMouseClick(800, 600);
            //FocusProcess(proceso);

            SendKeys.SendWait("{ENTER}");
            Thread.Sleep(2000);

            DoMouseClick(800, 500);
            Thread.Sleep(1000);
            DoMouseClick(800, 500);
            SendKeys.SendWait("y");

            SendKeys.SendWait("(%{F4})");
            Thread.Sleep(1000);
            
            SendKeys.SendWait("{N}");
        }


        public static void DoMouseClick(int x, int y)
        {
            // Mueve el cursor
            Cursor.Position = new System.Drawing.Point(x, y);
            // Clic izquierdo
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (uint)x, (uint)y, 0, 0);
        }

        private void FocusProcess(string procName)
        {
            Process[] objProcesses = System.Diagnostics.Process.GetProcessesByName(procName);
            if (objProcesses.Length > 0)
            {
                IntPtr hWnd = IntPtr.Zero;
                hWnd = objProcesses[0].MainWindowHandle;
                ShowWindowAsync(new HandleRef(null, hWnd), SW_RESTORE);
                SetForegroundWindow(objProcesses[0].MainWindowHandle);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DoMouseClick(Convert.ToInt32(nudX.Value),Convert.ToInt32(nudY.Value));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " envio de job\r\n");

            try
            {
                if (axMBActX1.SendControllerJob(0, @"D:\Desktop\PruebasMarcadora\Mediana1.MA2"))
                {
                    richTextBox1.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") +" Enviado Correctamente\r\n");
                }
            }
            catch (System.Runtime.InteropServices.COMException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "pdf",
                Filter = "pdf files (*.pdf)|*.pdf",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Archivo = System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
                if (!File.Exists(TempC + Archivo + ".MHL"))
                {
                    richTextBox1.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " El archivo No existe");
                    this.ConvertPDF2DXF(openFileDialog1.FileName, Archivo);
                }
                else
                    richTextBox1.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " El archivo existe");
            }

            //try
            //{
            //    axMBActX1.ConvertToPhotoFile(
            //    folder+"logo.png",
            //    folder + "logo.MZU",
            //    SubtractiveColorTypes.HIGH_RESOLUTION,
            //    true, 0, false, 0.7, 0, 0, false);
            //}
            //catch (System.Runtime.InteropServices.COMException error)
            //{
            //    MessageBox.Show(error.Message);
            //}
        }
    }
}
