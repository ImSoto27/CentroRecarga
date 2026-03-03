using System;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using System.Data;

namespace DATOS
{
    public class ConexionSql
    {
        private SqlConnection conexion = new SqlConnection("Server=.;Database=CENTRORECARGA;TrustServerCertificate=True;Integrated Security=True");


        public SqlConnection AbrirConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Closed)
                conexion.Open();
            return conexion;

        }

        public SqlConnection CerrarConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
                conexion.Close();
            return conexion;
        }
    }
}
