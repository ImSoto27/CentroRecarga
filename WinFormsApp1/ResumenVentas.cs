using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NEGOCIO;

namespace PRESENTACION
{
    public partial class ResumenVentas : Form
    {
        CN_Vendedor vendedor = new CN_Vendedor();
        CN_Operadora operadora = new CN_Operadora();
        CN_Cierre cierres = new CN_Cierre();
        Cierres principal;
        public ResumenVentas(Cierres frmPrincipal)
        {
            InitializeComponent();
            principal = frmPrincipal;
        }
        public int vendedorID { get; set; }
        public int operadoraID { get; set; }
        
        public string fechacierre { get; set; }


        private void Cierre_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = vendedor.MostrarVendedores();
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "VendedorID";

            comboBox2.DataSource = operadora.MostrarOperadoras();
            comboBox2.DisplayMember = "NombreOperadora";
            comboBox2.ValueMember = "OperadoraID";

            MostrarCierre();




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int vendedorID = Convert.ToInt32(comboBox1.SelectedValue);
                int operadoraID = Convert.ToInt32(comboBox2.SelectedValue);
                string fechacierre = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                Agregar(vendedorID, operadoraID, fechacierre);
                MostrarCierre();


            }

            catch(Exception ex) 
            {
                MessageBox.Show("Error: No puede haber dos cierres iguales un mismo dia");
            }
        }

        private void MostrarCierre()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = cierres.MostrarCierre();
            

        }
        private void Agregar(int vendedorID, int operadoraID, string fechacierre)
        {
            cierres.AgregarCierres(vendedorID, operadoraID, fechacierre);
        }

        private void ResumenVentas_FormClosed(object sender, FormClosedEventArgs e)
        {
            principal.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            principal.Show();
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
