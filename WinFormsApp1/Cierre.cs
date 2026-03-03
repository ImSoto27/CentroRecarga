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
    public partial class Cierre : Form
    {
        CN_Vendedor vendedor = new CN_Vendedor();
        CN_Operadora operadora = new CN_Operadora();
        public Cierre()
        {
            InitializeComponent();
        }

        private void Cierre_Load(object sender, EventArgs e)
        {

        }
    }
}
