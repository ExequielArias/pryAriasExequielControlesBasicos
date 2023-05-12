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
    public partial class frmPrincipal : Form
    {
        Random rnd = new Random();  
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_MouseMove(object sender, MouseEventArgs e)
        {
            lblEjeX.Text = e.X.ToString();  
            lblEjeY.Text = e.Y.ToString();  
        }

        private void frmPrincipal_Click(object sender, EventArgs e)
        {
            lblBienvenido.Visible = true; 
        }

        private void lblBienvenido_MouseEnter(object sender, EventArgs e)
        {
            lblBienvenido.Location = new Point(rnd.Next(10, 599), rnd.Next(10, 599));
        }

        private void cmdSecundario_Click(object sender, EventArgs e)
        {
            frmSecundario frmSecundario = new frmSecundario();
            frmSecundario.ShowDialog(); 
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
