using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryAriasExequielControlesBasicos
{
    public partial class frmSecundario : Form
    {
        public frmSecundario()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lblEscribir.Text = txtEscribir.Text; 
        }

        private void cmdAsignar_Click(object sender, EventArgs e)
        {
            if (optAzul.Checked == true)
            {
                lblEscribir.ForeColor = Color.Blue;
                txtEscribir.ForeColor = Color.Blue; 
            }
            if (optRojo.Checked == true)
            {
                lblEscribir.ForeColor = Color.Red;
                txtEscribir.ForeColor = Color.Red; 
               
            }
        }

        private void frmSecundario_Load(object sender, EventArgs e)
        {

        }

        private void cmdMostrar_Click(object sender, EventArgs e)
        {
            string textoConcatenar = "";
            if (chkLeche.Checked==true) 
            {
                lblEscriba.Text = "Heladera";
                textoConcatenar = textoConcatenar + "Heladera";
            }
            if (chkArroz.Checked==true)
            {
                lblEscriba.Text = "Freezer";
                textoConcatenar = textoConcatenar + "Freezer";
            }
            if (chkAceite.Checked == true)
            {
                lblEscriba.Text = "Alacena";
                textoConcatenar = textoConcatenar + "Alacena"; 
            }
            lblEscriba.Text = textoConcatenar; 

            cboMostrar.Items.Add(textoConcatenar);
        }
    }
}
