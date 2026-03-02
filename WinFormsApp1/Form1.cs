using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using NEGOCIO;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public CN_Recarga VerRecarga = new CN_Recarga();
        public Form1()
        {
            InitializeComponent();
        }

        private void MostrarRecarga()
        {
            dataGridView1.DataSource = VerRecarga.MostrarRecargas();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            MostrarRecarga();
        }
    }
}
