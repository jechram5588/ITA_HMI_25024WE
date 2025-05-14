using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMI_25024WE
{
    public partial class Form_Settings : Form
    {
        public bool idUpdated = false;

        public Form_Settings()
        {
            InitializeComponent();
        }

        private void btnPathFiles_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);
                    Properties.Settings.Default.PathFiles = fbd.SelectedPath.ToString();
                }
                txtPathFiles.Text = Properties.Settings.Default.PathFiles;
            }
        }

        private void btnSettingsSave_Click(object sender, EventArgs e)
        {
            if (ValidateIPv4(txtIP.Text))
            {
                Properties.Settings.Default.IP_Marker = txtIP.Text;
                Properties.Settings.Default.Save();                
            
                Properties.Settings.Default.ControllerSerialNo = Convert.ToInt32(txtSerial.Value);
                Properties.Settings.Default.UseIPConnection = rbIP.Checked;
            
                Properties.Settings.Default.Save();

                this.idUpdated = true;
                this.Close();
            }
            else
                MessageBox.Show(Lang.msj_InvalidIP, Lang.msj_Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnAuxFolder_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);
                    Properties.Settings.Default.AuxFolder = fbd.SelectedPath.ToString();
                }
                txtAuxFolder.Text = Properties.Settings.Default.AuxFolder;
            }
        }

        private void btnSettingsCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Settings_Load(object sender, EventArgs e)
        {
            txtPathFiles.Text = Properties.Settings.Default.PathFiles;
            txtAuxFolder.Text = Properties.Settings.Default.AuxFolder;
            txtIP.Text = Properties.Settings.Default.IP_Marker;
            txtSerial.Value = Properties.Settings.Default.ControllerSerialNo;
            rbIP.Checked = Properties.Settings.Default.UseIPConnection;
            rbUsb.Checked = !rbIP.Checked;

            lbSettingTitle.Text = Lang.lbSettingTitle;
            lbPathFiles.Text = Lang.lbPathFiles;
            lbAuxFolder.Text = Lang.lbAuxFolder;
            btnSettingsSave.Text = Lang.msj_Save;
            btnSettingsCancel.Text = Lang.msj_Cancel;
            lbSerialMarker.Text = Lang.lbSerialMarker;
        }

        public bool ValidateIPv4(string ipString)
        {
            if (String.IsNullOrWhiteSpace(ipString))
            {
                return false;
            }

            string[] splitValues = ipString.Split('.');
            if (splitValues.Length != 4)
            {
                return false;
            }

            byte tempForParsing;

            return splitValues.All(r => byte.TryParse(r, out tempForParsing));
        }
    }
}
