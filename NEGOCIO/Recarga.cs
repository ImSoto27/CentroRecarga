using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using System.Data;
using DATOS;

namespace NEGOCIO
{
    public class CN_Recarga
    {
        private CD_ConsultaRecarga consulta = new CD_ConsultaRecarga();

        public DataTable MostrarRecargas()
        {
            DataTable tabla = new DataTable();
            tabla = consulta.Mostrar();
            return tabla;
        }
    }
}
