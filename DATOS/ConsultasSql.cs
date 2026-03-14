using Microsoft.Data;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public abstract class ConsultaBase
    {
        public ConexionSql conexion = new ConexionSql();
        public abstract DataTable Mostrar();
        
    }
    public class CD_Recarga : ConsultaBase
    {

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public override DataTable Mostrar()
        {
                    

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT r.RecargaID, v.Nombre AS Vendedor, o.NombreOperadora AS Operadora,r.Numero AS Numero, r.Monto, r.FechaRecarga AS Fecha FROM Recarga r INNER JOIN Vendedor v ON r.VendedorID = v.VendedorID INNER JOIN Operadora o ON r.OperadoraID = o.OperadoraID ORDER BY r.RecargaID";
            SqlDataReader leer = comando.ExecuteReader();
            tabla.Load(leer);

            conexion.CerrarConexion();

            return tabla;
        }

        public void InsertarRecarga(int vendedorID, int operadoraID, string Numero, decimal monto)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO Recarga(VendedorID, OperadoraID, Numero, Monto) VALUES ('" + vendedorID+"', '"+operadoraID+"','"+Numero+"', '"+monto+"')";
            comando.ExecuteNonQuery();

        }
    }
    public class CD_ConsultaOperadora : ConsultaBase
    {
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public override DataTable Mostrar()
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

    public class CD_ConsultaVendedor : ConsultaBase
    {
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public override DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT * FROM Vendedor";
            SqlDataReader leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
    }

    public class CD_ConsultaCierre : ConsultaBase
    {
 

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public int vendedorID { get; set; }
        public int operadoraID { get; set; }    
        public string fechacierre { get; set; }
        public override DataTable Mostrar()
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT c.CierreID, v.Nombre AS Vendedor, o.NombreOperadora AS Operadora, c.Total AS Total, FechaCierre AS Fecha FROM CierreCaja c INNER JOIN Vendedor v ON c.VendedorID = v.VendedorID INNER JOIN Operadora o ON c.OperadoraID = o.OperadoraID ORDER BY c.CierreID";
            SqlDataReader leer = comando.ExecuteReader();
            tabla.Load(leer);

            conexion.CerrarConexion();

            return tabla;
        }

        public void AgregarCierre(int vendedorID, int operadoraID, string fechacierre)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO CierreCaja (VendedorID, OperadoraID, FechaCierre, Total) SELECT VendedorID, OperadoraID, FechaRecarga, SUM(Monto) FROM Recarga  WHERE FechaRecarga = '"+fechacierre+"' AND VendedorID = '" + vendedorID+"' AND OperadoraID = '" + operadoraID+"' GROUP BY VendedorID, OperadoraID, FechaRecarga ORDER BY VendedorID, OperadoraID";
            comando.ExecuteNonQuery();

            conexion.CerrarConexion();
        }

    }

    public class Cierres2 : ConsultaBase
    {
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public int cierreID { get; set; }

        public DataTable DetallarCierre(int cierreID)
        {
            DataTable tabla = new DataTable();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "    SELECT * FROM DetalleCierre WHERE CierreID = '"+cierreID+"'";
            SqlDataReader leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public override DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT  c.CierreID, v.Nombre AS Vendedor, o.NombreOperadora AS Operadora, r.RecargaID, r.Numero, r.Monto, r.FechaRecarga FROM CierreCaja c INNER JOIN Vendedor v ON c.VendedorID = v.VendedorID INNER JOIN Operadora o ON c.OperadoraID = o.OperadoraID INNER JOIN Recarga r ON r.VendedorID = c.VendedorID AND r.OperadoraID = c.OperadoraID AND r.FechaRecarga = c.FechaCierre WHERE c.CierreID = '"+cierreID+"' ORDER BY r.RecargaID";
            SqlDataReader leer = comando.ExecuteReader();
            tabla.Load(leer);

            conexion.CerrarConexion();

            return tabla;
        }
    }
}
