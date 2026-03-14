using DATOS;
using Microsoft.Data;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEGOCIO
{
    public class CN_Recarga
    {
        public CD_Recarga consulta = new CD_Recarga();

        public DataTable MostrarRecargas()
        {
            DataTable tabla = new DataTable();
            tabla = consulta.Mostrar();
            return tabla;
        }

        public void AgregarRecarga(int vendedorID, int operadoraID, string Numero, decimal monto)
        {
            consulta.InsertarRecarga(vendedorID, operadoraID, Numero, Convert.ToDecimal(monto));
        }
    }

    public class CN_Operadora
    {
        public CD_ConsultaOperadora consulta = new CD_ConsultaOperadora();
        public DataTable MostrarOperadoras()
        {
            DataTable tabla = new DataTable();
            tabla = consulta.Mostrar();
            return tabla;
        }
    }

    public class CN_Vendedor
    {
        public CD_ConsultaVendedor consulta = new CD_ConsultaVendedor();
        public DataTable MostrarVendedores()
        {
            DataTable tabla = new DataTable();
            tabla = consulta.Mostrar();
            return tabla;
        }
    }

    public class CN_Cierre
    {
        public int vendedorID1 { get; set; }
        public int operadoraID1 { get; set; }
        public string fechacierre1 { get; set; }
        public int cierreID1 { get; set; }


        public CD_ConsultaCierre consulta = new CD_ConsultaCierre();
        public Cierres2 consulta2 = new Cierres2();

        public DataTable MostrarCierre()
        {
            DataTable tabla = new DataTable();
            tabla = consulta.Mostrar();
            return tabla;
        }

        public DataTable MostrarCierre2(int cierreID)
        {
            consulta2.cierreID = cierreID1;
            DataTable tabla = new DataTable();
            tabla = consulta2.DetallarCierre(cierreID);
            return tabla;
        }

        public void AgregarCierres(int vendedorID, int operadoraID, string fechacierre)
        {
            consulta.vendedorID = vendedorID1;
            consulta.operadoraID = operadoraID1;
            consulta.fechacierre = fechacierre1;
            consulta.AgregarCierre(vendedorID, operadoraID, fechacierre);
        }

    }
}
