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
    public partial class RegistroVendedores : Form
    {
        public CN_Vendedor vendedor = new CN_Vendedor();

        Principal principal;
        public RegistroVendedores(Principal frmPrincipal)
        {
            InitializeComponent();
            principal = frmPrincipal;
        }

        private void RegistroVendedores_Load(object sender, EventArgs e)
        {
            MostrarVendedores();
        }

        private void MostrarVendedores()
        {
            dataGridView1.DataSource = vendedor.MostrarVendedores();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            principal.Show();
            this.Close();
        }

        private void RegistroVendedores_FormClosed(object sender, FormClosedEventArgs e)
        {
            principal.Show();
        }

    }
}
