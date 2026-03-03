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

        public void AgregarRecarga(int vendedorID, int operadoraID, decimal monto)
        {
            consulta.InsertarRecarga(vendedorID, operadoraID, Convert.ToDecimal(monto));
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
        public CD_ConsultaCierre consulta = new CD_ConsultaCierre();
        public DataTable MostrarCierre
            ()
        {
            DataTable tabla = new DataTable();
            tabla = consulta.Mostrar();
            return tabla;
        }
    }
}
