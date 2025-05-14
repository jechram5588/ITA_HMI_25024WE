using MBPLib2;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMI_25024WE
{
    public partial class Form_TemplateEditor : Form
    {
        List<Models.Plates> Plates = new List<Models.Plates>();
        Models.TemplateCoordenates Template = null;
        private string Assets;

        decimal TempCoord = 0;
        int TempNode = 0;

        public Form_TemplateEditor()
        {
            InitializeComponent();
            Assets = AppDomain.CurrentDomain.BaseDirectory + "Assets\\";
            LoadTemplatesNames();
            EnableCtrls(false);

            lbTemplates_Title.Text = Lang.lbTemplates_Title;
            lbTemplateEditor_Templates.Text = Lang.lbTemplateEditor_Templates;
            btnTemplateEditor_Add.Text = Lang.btnTemplateEditor_Add;
            btnTemplateEditor_Delete.Text = Lang.btnTemplateEditor_Delete;
            lbTemplateEditor_TemplateName.Text = Lang.lbTemplateEditor_TemplateName;
            gbTemplateEditor_Labels.Text = Lang.gbTemplateEditor_Labels;
            lbTemplateEditorWidth.Text = Lang.lbTemplateEditorWidth;
            lbTemplateEditor_Height.Text = Lang.lbTemplateEditor_Height;
            lbTemplateEditor_LabelAngle.Text = Lang.lbTemplateEditor_LabelAngle;
            gbTemplateEditor_TextData.Text = Lang.gbTemplateEditor_TextData;
            lbTemplateEditor_CharWidth.Text = Lang.lbTemplateEditor_CharWidth;
            lbTemplateEditor_TextAngle.Text = Lang.lbTemplateEditor_TextAngle;
            lbTemplateEditor_CharFullWidth.Text = Lang.lbTemplateEditor_CharFullWidth;
            btnTemplateEditor_AddNode.Text = Lang.btnTemplateEditor_AddNode;
            btnTemplateEditor_DeleteNode.Text = Lang.btnTemplateEditor_DeleteNode;
            btnTemplateEditor_Edit.Text = Lang.btnTemplateEditor_Edit;
            lbTemplateEditor_CharHeight.Text = Lang.lbTemplateEditor_CharHeight;
            btnTemplateEditor_ImportNodes.Text = Lang.btnTemplateEditor_ImportNodes;
        }

        private void Form_TemplateEditor_Load(object sender, EventArgs e)
        {
            lbTemplateEditor_Templates.Text = Lang.lbTemplateEditor_Templates;
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
                    lbTemplates.Items.Clear();
                }
                else
                {
                    lbTemplates.Items.Clear();
                    foreach (Models.Plates item in Plates)
                    {
                        lbTemplates.Items.Add(item.Name);
                    }
                }
            }
            else
            {
                MessageBox.Show(Lang.msj_PathNotFind, Lang.msj_Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTemplateEditor_Edit_Click(object sender, EventArgs e)
        {
            string output = JsonConvert.SerializeObject(dgvCoords.DataSource);
            List<Models.Coordenate> Coordenate = JsonConvert.DeserializeObject<List<Models.Coordenate>>(output);
            Template.Coordinates = Coordenate;

            Template.Width = Convert.ToDouble(nudWidth.Value);
            Template.Height = Convert.ToDouble(nudHeight.Value);
            Template.CharWidth = Convert.ToDouble(nudCharWidth.Value);
            Template.CharHeight = Convert.ToDouble(nudCharHeight.Value);
            Template.TextAngle = Convert.ToDouble(nudCharAngle.Value);
            Template.CharFullWidth = Convert.ToDouble(nudCharFullWidth.Value);
            Template.LabelAngle = Convert.ToDouble(nudAngle.Value);

            string json = JsonConvert.SerializeObject(Template);
            string path = Path.Combine(Assets, lbTemplates.SelectedItem.ToString() + ".json");

            if (txtName.Text != lbTemplates.SelectedItem.ToString())
            {
                if (!File.Exists(txtName.Text))
                {
                    if (MessageBox.Show(Lang.msj_RenameTemplate, Lang.msj_Message, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        string newpath = Path.Combine(Assets, txtName.Text + ".json");
                        File.WriteAllText(newpath, json);
                        File.Delete(path);
                        MessageBox.Show(Lang.msj_Success, Lang.msj_Message, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadTemplatesNames();
                        EnableCtrls(false);
                    }
                    else
                    {
                        string newpath = Path.Combine(Assets, txtName.Text + ".json");
                        File.WriteAllText(newpath, json);
                        MessageBox.Show(Lang.msj_Success, Lang.msj_Message, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadTemplatesNames();
                        EnableCtrls(false);
                    }
                }
                else
                    MessageBox.Show(Lang.msj_FileAlreadyExists, Lang.msj_Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (File.Exists(path))
                {
                    if (MessageBox.Show(Lang.msj_FileAlreadyExistsReplaceIt, Lang.msj_Message, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        File.WriteAllText(path, json);
                        MessageBox.Show(Lang.msj_Success, Lang.msj_Message, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadTemplatesNames();
                        EnableCtrls(false);
                    }
                }
            }
        }

        private void lbTemplates_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lbTemplates.SelectedItem != null)
                {

                    string file = Path.Combine(Assets, lbTemplates.SelectedItem.ToString() + ".json");
                    if (File.Exists(file))
                    {
                        txtName.Text = lbTemplates.SelectedItem.ToString();
                        JObject JsonData = JObject.Parse(File.ReadAllText(file));
                        Template = JsonConvert.DeserializeObject<Models.TemplateCoordenates>(JsonData.ToString());

                        dgvCoords.DataSource = Template.Coordinates;

                        nudWidth.Value = Convert.ToDecimal(Template.Width);
                        nudHeight.Value = Convert.ToDecimal(Template.Height);
                        nudCharWidth.Value = Convert.ToDecimal(Template.CharWidth);
                        nudCharHeight.Value = Convert.ToDecimal(Template.CharHeight);
                        nudCharAngle.Value = Convert.ToDecimal(Template.TextAngle);
                        nudCharFullWidth.Value = Convert.ToDecimal(Template.CharFullWidth);
                        nudAngle.Value = Convert.ToDecimal(Template.LabelAngle);

                        EnableCtrls(true);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(Lang.msj_ErrorOccurred, Lang.msj_Message+" "+ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvCoords_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > 0)
            {
                decimal Valor;
                bool successfullyParsed = decimal.TryParse(dgvCoords.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out Valor);

                if (e.ColumnIndex != 3 && e.ColumnIndex != 6)
                {
                    if (!successfullyParsed || Valor > 165 || Valor < -165)
                        dgvCoords.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = TempCoord;
                }
                else {
                    if (!successfullyParsed || Valor > 21 || Valor < -21)
                        dgvCoords.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = TempCoord;
                }
            }
            else
            {
                List<string> nodes = new List<string>();
                for (int i = 0; i < dgvCoords.Rows.Count; i++)
                {
                    if (i != e.RowIndex)
                    {
                        nodes.Add(dgvCoords.Rows[i].Cells[0].Value.ToString());
                    }
                }

                var t = nodes.Where(n => n == dgvCoords.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                if (t != null)
                    dgvCoords.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = TempNode;
            }
        }

        private void dgvCoords_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex > 0)
                TempCoord = Convert.ToDecimal(dgvCoords.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            else
                TempNode = Convert.ToInt32(dgvCoords.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);

            Console.WriteLine($"{TempNode} {TempCoord}");
        }

        public void EnableCtrls(bool enable)
        {
            gbTemplateEditor_Labels.BeginInvoke(new Action(() =>
            {
                gbTemplateEditor_Labels.Enabled = enable;
            }));
            gbTemplateEditor_TextData.BeginInvoke(new Action(() =>
            {
                gbTemplateEditor_TextData.Enabled = enable;
            }));
            btnTemplateEditor_Edit.BeginInvoke(new Action(() =>
            {
                btnTemplateEditor_Edit.Enabled = enable;
            }));
            btnTemplateEditor_Delete.BeginInvoke(new Action(() =>
            {
                btnTemplateEditor_Delete.Enabled = enable;
            }));
            txtName.BeginInvoke(new Action(() =>
            {
                txtName.Enabled = enable;
            }));
            btnTemplateEditor_AddNode.BeginInvoke(new Action(() =>
            {
                btnTemplateEditor_AddNode.Enabled = enable;
            }));
            btnTemplateEditor_DeleteNode.BeginInvoke(new Action(() =>
            {
                btnTemplateEditor_DeleteNode.Enabled = enable;
            }));
            btnTemplateEditor_ImportNodes.BeginInvoke(new Action(() =>
            {
                btnTemplateEditor_ImportNodes.Enabled = enable;
            }));
            if (!enable)
            {
                dgvCoords.DataSource = null;
                txtName.Text = "";
            }
        }

        private void btnTemplateEditor_Add_Click(object sender, EventArgs e)
        {
            string json = JsonConvert.SerializeObject(new Models.TemplateCoordenates { Width = 1, Height = 1, CharWidth = .6, CharHeight = 1 });
            string path = Path.Combine(Assets, Guid.NewGuid().ToString() + ".json");
            File.WriteAllText(path, json);
            EnableCtrls(false);
            LoadTemplatesNames();
        }

        private void btnTemplateEditor_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Lang.msj_DeleteTemplate + lbTemplates.SelectedItem.ToString(), Lang.msj_Message, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                string path = Path.Combine(Assets, lbTemplates.SelectedItem.ToString() + ".json");
                if (File.Exists(path))
                {
                    File.Delete(path);
                    MessageBox.Show(Lang.msj_Success, Lang.msj_Message, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTemplatesNames();
                    EnableCtrls(false);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Template != null)
            {
                if (Template.Coordinates == null)
                    Template.Coordinates = new List<Models.Coordenate>();

                Template.Coordinates.Add(new Models.Coordenate { Node = dgvCoords.Rows.Count + 1, MHL_X = 0, MHL_Y = 0, TXT_X = 0, TXT_Y = 0 });
                dgvCoords.DataSource = null;
                dgvCoords.Refresh();
                dgvCoords.DataSource = Template.Coordinates;
            }
        }

        private void btnTemplateEditor_DeleteNode_Click(object sender, EventArgs e)
        {
            if (dgvCoords.SelectedRows.Count == 1)
            {
                Models.Coordenate toDelete = null;
                foreach (Models.Coordenate item in Template.Coordinates)
                {
                    if (item.Node.ToString() == dgvCoords.SelectedRows[0].Cells["Node"].Value.ToString())
                        toDelete = item;
                }
                Template.Coordinates.Remove(toDelete);
                dgvCoords.DataSource = null;
                dgvCoords.Refresh();
                dgvCoords.DataSource = Template.Coordinates;
            }
        }

        private void btnTemplateEditor_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == ' ' || e.KeyChar == '\b')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void nudCharAngle_ValueChanged(object sender, EventArgs e)
        {
            nudCharWidth.Enabled = !(nudCharAngle.Value > 0);
            nudCharHeight.Enabled = !(nudCharAngle.Value > 0);
            nudCharFullWidth.Enabled = nudCharAngle.Value > 0;
        }

        private void btnTemplateEditor_ImportNodes_Click(object sender, EventArgs e)
        {
            using (var fbd = new OpenFileDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK)
                {
                    try
                    {
                        axMBActX1.Context = ContextTypes.CONTEXT_EDITING;
                        axMBActX1.OpenJob(fbd.FileName);
                        ImportLabels();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message, Lang.msj_ErrorOccurred, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }

        public void ImportLabels()
        {
            List<Models.Coordenate> Coordinates = new List<Models.Coordenate>();
            try
            {
                Models.Coordenate coor = new Models.Coordenate();
                int contNodo = 1;
                for (int i = 0; i < 48; i++)
                {
                    if (i % 2 == 0)
                    {
                        if (i == 0) {
                            Template.Width = axMBActX1.Block(i).Width;
                            Template.Height = axMBActX1.Block(i).Height;
                            Template.LabelAngle = axMBActX1.Block(i).Angle;
                        }
                        coor = new Models.Coordenate();
                        coor.Node = contNodo++;
                        coor.MHL_X = axMBActX1.Block(i).X;
                        coor.MHL_Y = axMBActX1.Block(i).Y;
                        coor.MHL_Z = axMBActX1.Block(i).Z;
                    }
                    else
                    {
                        if (i == 1) {
                            Template.TextAngle = axMBActX1.Block(i).Angle;

                            //if (Template.TextAngle > 0) {

                            //    switch (axMBActX1.Block(i).CharAlignType)
                            //    {
                            //        case CharAlignTypes.CHARALIGN_SPACE:
                            //            Template.CharFullWidth = 0;
                            //            Template.CharWidth = axMBActX1.Block(i).CharWidth;
                            //            Template.CharHeight = axMBActX1.Block(i).CharHeight;
                            //            break;
                            //        case CharAlignTypes.CHARALIGN_ANGLESPACE:
                            //        case CharAlignTypes.CHARALIGN_EQUALLAYOUT:
                            //        case CharAlignTypes.CHARALIGN_PITCH:
                            //            Template.CharFullWidth = axMBActX1.Block(i).CharFullWidth;
                            //            Template.CharWidth = 0.6;
                            //            Template.CharHeight = 0.6;
                            //            break;
                            //        default:
                            //            break;
                            //    }
                            //}
                            //else {
                            //    Template.CharFullWidth = 0;
                            //    Template.CharWidth = axMBActX1.Block(i).CharWidth;
                            //    Template.CharHeight = axMBActX1.Block(i).CharHeight;
                            //}
                        }
                        coor.TXT_X = axMBActX1.Block(i).X;
                        coor.TXT_Y = axMBActX1.Block(i).Y;
                        coor.TXT_Z = axMBActX1.Block(i).Z;
                        Coordinates.Add(coor);
                    }
                }
            }
            catch { }
            finally
            {
                if (Coordinates.Count > 0)
                {
                    if (Template != null)
                    {
                        if (Template.Coordinates == null)
                            Template.Coordinates = new List<Models.Coordenate>();
                        int position = Template.Coordinates.Count();
                        foreach (Models.Coordenate item in Coordinates)
                        {
                            Template.Coordinates.Add(new Models.Coordenate { Node = position + item.Node, 
                                MHL_X = item.MHL_X,
                                MHL_Y = item.MHL_Y,
                                MHL_Z = item.MHL_Z,
                            
                                TXT_X = item.TXT_X,
                                TXT_Y = item.TXT_Y,
                                TXT_Z = item.TXT_Z
                            });
                        }
                        dgvCoords.DataSource = null;
                        dgvCoords.Refresh();
                        dgvCoords.DataSource = Template.Coordinates;

                        nudAngle.Value = Convert.ToDecimal(Template.LabelAngle);
                        nudWidth.Value = Convert.ToDecimal(Template.Width);
                        nudHeight.Value = Convert.ToDecimal(Template.Height);

                        //nudCharWidth.Value = Convert.ToDecimal(Template.CharWidth);
                        //nudCharHeight.Value = Convert.ToDecimal(Template.CharHeight);
                        nudCharAngle.Value = Convert.ToDecimal(Template.TextAngle);
                        //nudCharFullWidth.Value = Convert.ToDecimal(Template.CharFullWidth);
                    }
                }
            }
        }
    }
}
