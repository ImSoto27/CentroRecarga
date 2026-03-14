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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PRESENTACION
{

    public partial class VerCierres : Form
    {
        CN_Vendedor vendedor = new CN_Vendedor();
        CN_Operadora operadora = new CN_Operadora();
        CN_Cierre cierres = new CN_Cierre();
        Cierres principal;

        public VerCierres(Cierres frmPrincipal)
        {
            InitializeComponent();
            principal = frmPrincipal;
        }

        public int cierreID { get; set; }

        private void VerCierres_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MostrarCierre(int cierreID)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.DataSource = cierres.MostrarCierre2(cierreID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            principal.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int cierreID = Convert.ToInt32(textBox1.Text);
                MostrarCierre(cierreID);
            }
            catch (Exception ex)
            { 
            MessageBox.Show("Ingrese un ID de cierre válido.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
