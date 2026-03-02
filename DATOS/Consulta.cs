using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using System.Data;

namespace DATOS
{
    public class CD_ConsultaRecarga
    {
        private ConexionSql conexion = new ConexionSql();

        SqlDataReader leer;
        DataTable Tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SLECT*FROM Recarga";
            leer = comando.ExecuteReader();
            Tabla.Load(leer);
            conexion.CerrarConexion();
            return Tabla;
        }
    }
}
