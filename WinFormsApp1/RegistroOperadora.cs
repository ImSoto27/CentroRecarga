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
    public partial class RegistroOperadora : Form
    {
        public CN_Operadora operadora = new CN_Operadora();

        Principal principal;

        public RegistroOperadora(Principal frmPrincipal)
        {
            InitializeComponent();
            principal = frmPrincipal;
        }

        private void RegistroOperadora_Load(object sender, EventArgs e)
        {
            MostrarOperadora();
        }

        private void MostrarOperadora()
        {
            dataGridView1.DataSource = operadora.MostrarOperadoras();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            principal.Show();
            this.Close();

        }

        private void RegistroOperadora_FormClosed(object sender, FormClosedEventArgs e)
        {
            principal.Show();
        }

        private void RegistroOperadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
