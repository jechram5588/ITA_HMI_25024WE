using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMI_25024WE
{
    public partial class Form_Parameters : Form
    {
        private bool IsLamined;

        public Form_Parameters()
        {
            InitializeComponent();
            IsLamined = Properties.Settings.Default.IsLamined;
        }

        private void Form_Parameters_Load(object sender, EventArgs e)
        {
            lbParameterstitle.Text = Lang.lbParameterstitle;
            lbParameterPaintedPlate.Text = Lang.lbParameterPaintedPlate;
            lbParameterLaminedPlate.Text = Lang.lbParameterLaminedPlate;
            lbParametersLaserPower.Text = Lang.lbParametersLaserPower;
            lbParametersScanSpeed.Text = Lang.lbParametersScanSpeed;
            lbParametersPulseFrequency.Text = Lang.lbParametersPulseFrequency;
            lbParametersSpotVarieable.Text = Lang.lbParametersSpotVarieable;
            lbParametersRepetition.Text = Lang.lbParametersRepetition;
            lbParametersFillLineInterval.Text = Lang.lbParametersFillLineInterval;
            btnParametersSave.Text = Lang.msj_Save;
            btnParametersCancel.Text = Lang.msj_Cancel;

            setColored();
        }

        private void setColored()
        {
            if (IsLamined)
            {
                lbParameterLaminedPlate.BackColor = Color.GreenYellow;
                lbParameterPaintedPlate.BackColor = Color.White;
            }
            else
            {
                lbParameterLaminedPlate.BackColor = Color.White;
                lbParameterPaintedPlate.BackColor = Color.GreenYellow;
            }
        }

        private void btnParametersCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnParametersSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsLamined)
                {
                    Properties.Settings.Default.LaminatedPlate_LaserPower = Convert.ToDouble(nudParametersLaserPower.Value);
                    Properties.Settings.Default.LaminatedPlate_ScanSpeed = Convert.ToInt32(nudParametersScanSpeed.Value);
                    Properties.Settings.Default.LaminatedPlate_Frequency = Convert.ToInt32(nudParametersFrecuency.Value);
                    Properties.Settings.Default.LaminatedPlate_SpotVariable = Convert.ToInt32(nudParametersSpotVariable.Value);
                    Properties.Settings.Default.LaminatedPlate_Repetition = Convert.ToInt32(nudParametersRepetition.Value);
                    Properties.Settings.Default.LaminatedPlate_FillLineInterval = Convert.ToDouble((nudParametersFillLineInterval.Value * 1000).ToString());
                }
                else
                {
                    Properties.Settings.Default.PaintedPlate_LaserPower = Convert.ToDouble(nudParametersLaserPower.Value);
                    Properties.Settings.Default.PaintedPlate_ScanSpeed = Convert.ToInt32(nudParametersScanSpeed.Value);
                    Properties.Settings.Default.PaintedPlate_Frequency = Convert.ToInt32(nudParametersFrecuency.Value);
                    Properties.Settings.Default.PaintedPlate_SpotVariable = Convert.ToInt32(nudParametersSpotVariable.Value);
                    Properties.Settings.Default.PaintedPlate_Repetition = Convert.ToInt32(nudParametersRepetition.Value);
                    Properties.Settings.Default.PaintedPlate_FillLineInterval = Convert.ToDouble((nudParametersFillLineInterval.Value * 1000).ToString());
                }
                Properties.Settings.Default.IsLamined = IsLamined;
                Properties.Settings.Default.Save();
            }
            catch
            {
                MessageBox.Show(Lang.msj_ErrorSaving, Lang.msj_Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(Lang.msj_SavedSuccessfully, Lang.msj_Message, MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void lbParameterPaintedPlate_Click(object sender, EventArgs e)
        {
            IsLamined = false;
            nudParametersLaserPower.Value = Convert.ToDecimal(Properties.Settings.Default.PaintedPlate_LaserPower);
            nudParametersScanSpeed.Value = Convert.ToDecimal(Properties.Settings.Default.PaintedPlate_ScanSpeed);
            nudParametersFrecuency.Value = Convert.ToDecimal(Properties.Settings.Default.PaintedPlate_Frequency);
            nudParametersSpotVariable.Value = Convert.ToDecimal(Properties.Settings.Default.PaintedPlate_SpotVariable);
            nudParametersRepetition.Value = Convert.ToDecimal(Properties.Settings.Default.PaintedPlate_Repetition);
            nudParametersFillLineInterval.Value = Convert.ToDecimal(Properties.Settings.Default.PaintedPlate_FillLineInterval / 1000.0);
            setColored();
        }

        private void lbParameterLaminedPlate_Click(object sender, EventArgs e)
        {
            IsLamined = true;
            nudParametersLaserPower.Value = Convert.ToDecimal(Properties.Settings.Default.LaminatedPlate_LaserPower);
            nudParametersScanSpeed.Value = Convert.ToDecimal(Properties.Settings.Default.LaminatedPlate_ScanSpeed);
            nudParametersFrecuency.Value = Convert.ToDecimal(Properties.Settings.Default.LaminatedPlate_Frequency);
            nudParametersSpotVariable.Value = Convert.ToDecimal(Properties.Settings.Default.LaminatedPlate_SpotVariable);
            nudParametersRepetition.Value = Convert.ToDecimal(Properties.Settings.Default.LaminatedPlate_Repetition);
            nudParametersFillLineInterval.Value = Convert.ToDecimal(Properties.Settings.Default.LaminatedPlate_FillLineInterval / 1000.0);
            setColored();
        }
    }
}
