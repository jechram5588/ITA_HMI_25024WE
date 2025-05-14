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
    public partial class Form_Dialog : Form
    {
        public bool CloseForm = false;
        public string fMessage = "";
        int time = 0;
        public Form_Dialog(string msj)
        {
            InitializeComponent();
            lbMessage.Text = msj;
            fMessage = msj;
            lbMensajeTitulo.Text = Lang.lbMensajeTitulo;
        }

        private void Form_Dialog_Load(object sender, EventArgs e)
        {
            timerClose.Start();
        }

        private void timerClose_Tick(object sender, EventArgs e)
        {
            time += 250;
            lbMessage.Text = fMessage;
            if (CloseForm)
                this.Close();
            if (time > 10000)
                btnClose.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
