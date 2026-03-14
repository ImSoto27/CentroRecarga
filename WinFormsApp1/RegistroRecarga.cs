using NEGOCIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRESENTACION
{
    public partial class RegistroRecarga : Form
    {
        Principal principal;

        public CN_Recarga recarga = new CN_Recarga();
        public RegistroRecarga(Principal frmPrincipal)
        {
            InitializeComponent();
            principal = frmPrincipal;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarRecarga();
        }

        private void MostrarRecarga()
        {
            dataGridView1.DataSource = recarga.MostrarRecargas();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            principal.Show();
            this.Close();
        }

        private void AgregarRecarga_FormClosed(object sender, FormClosedEventArgs e)
        {
            principal.Show();
        }

        private void RegistroRecarga_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
