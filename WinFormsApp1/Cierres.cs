using NEGOCIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRESENTACION
{
    public partial class Cierres : Form
    {

        Principal principal;

        public Cierres(Principal frmPrincipal)
        {
            InitializeComponent();
            principal = frmPrincipal;
        }
        public Cierres()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResumenVentas frm = new ResumenVentas(this);
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VerCierres frm = new VerCierres(this);
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            principal.Show();
            this.Close();
        }

        private void Cierres_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
