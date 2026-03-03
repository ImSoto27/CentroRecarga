using NEGOCIO;
using PRESENTACION;
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
    public partial class AgregarRecarga : Form
    {
        Principal principal;

        CN_Recarga recarga = new CN_Recarga();
        CN_Operadora operadora = new CN_Operadora();
        CN_Vendedor vendedor = new CN_Vendedor();
        public AgregarRecarga(Principal frmPrincipal)
        {
            InitializeComponent();
            principal = frmPrincipal;
        }

        private void AgregarRecarga_FormClosed(object sender, FormClosedEventArgs e)
        {
            principal.Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int vendedorID = Convert.ToInt32(comboBox1.SelectedValue);
                int operadoraID = Convert.ToInt32(comboBox2.SelectedValue);
                int monto = (int)Convert.ToDecimal(textBox1.Text);

                ;
                recarga.AgregarRecarga(vendedorID, operadoraID, monto);

                MessageBox.Show("Recarga guardada correctamente");

                principal.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AgregarRecarga_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = vendedor.MostrarVendedores();
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "VendedorID";

            comboBox2.DataSource = operadora.MostrarOperadoras();
            comboBox2.DisplayMember = "NombreOperadora";
            comboBox2.ValueMember = "OperadoraID";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            principal.Show();
            this.Close();
        }
    }
}
