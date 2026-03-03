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

        public CN_Cierre cierre = new CN_Cierre();
        public Cierres()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cierres_Load(object sender, EventArgs e)
        {
            MostrarCierres();
        }

        private void MostrarCierres()
        {
            dataGridView1.DataSource = cierre.MostrarCierre();
        }
    }
}
