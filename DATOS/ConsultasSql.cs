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


    public class CD_Recarga
    {

        private ConexionSql conexion = new ConexionSql();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
                    

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT r.RecargaID, v.Nombre AS Vendedor, o.NombreOperadora AS Operadora, r.Monto, r.FechaRecarga AS Fecha FROM Recarga r INNER JOIN Vendedor v ON r.VendedorID = v.VendedorID INNER JOIN Operadora o ON r.OperadoraID = o.OperadoraID ORDER BY r.RecargaID";
            SqlDataReader leer = comando.ExecuteReader();
            tabla.Load(leer);

            conexion.CerrarConexion();

            return tabla;
        }

        public void InsertarRecarga(int vendedorID, int operadoraID, decimal monto)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO Recarga(VendedorID, OperadoraID, Monto) VALUES ('" + vendedorID+"', '"+operadoraID+"', '"+monto+"')";
            comando.ExecuteNonQuery();

        }
    }
    public class CD_ConsultaOperadora
    {
        private ConexionSql conexion = new ConexionSql();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT * FROM Operadora";
            SqlDataReader leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable MostrarOperadoras()
        {
            DataTable tabla = new DataTable();

            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "SELECT OperadoraID, NombreOperadora FROM Operadora WHERE Estado = 1";
                SqlDataReader leer = comando.ExecuteReader();
                tabla.Load(leer);
                conexion.CerrarConexion();
                return tabla;

            }
        }
    }

    public class CD_ConsultaVendedor
    {
        private ConexionSql conexion = new ConexionSql();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT * FROM Vendedor";
            SqlDataReader leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable MostrarOperadoras()
        {
            DataTable tabla = new DataTable();

            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "SELECT VendedorID, Nombre FROM Vendedor WHERE Activo = 1";
                SqlDataReader leer = comando.ExecuteReader();
                tabla.Load(leer);
                conexion.CerrarConexion();
                return tabla;

            }
        }
    }

    public class CD_ConsultaCierre
    {
        private ConexionSql conexion = new ConexionSql();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT r.RecargaID, v.Nombre AS Vendedor, o.NombreOperadora AS Operadora, r.Monto FROM CierreCaja r INNER JOIN Vendedor v ON r.VendedorID = v.VendedorID INNER JOIN Operadora o ON r.OperadoraID = o.OperadoraID ORDER BY v.VendedorID";
            SqlDataReader leer = comando.ExecuteReader();
            tabla.Load(leer);

            conexion.CerrarConexion();

            return tabla;
        }

        public void AgregarCierre(int vendedorID)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO CierreCaja(VendedorID, OperadoraID, RecargaID, Monto) SELECT VendedorID, OperaoraID, RecargaID, Monto FROM Recarga WHERE VendedorID = '" + vendedorID + "' ";
            comando.ExecuteNonQuery();

            conexion.CerrarConexion();
        }
    }
}
