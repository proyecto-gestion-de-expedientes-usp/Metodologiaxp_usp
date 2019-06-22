using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Capas
{
    public class Acceso
    {
        public static SqlConnection ObtenerAcceso()
        {
            SqlConnection conectar = new SqlConnection("database=consultoriojur;data source=.;integrated security=sspi");
            conectar.Open();
            return conectar;


        }

        public SqlConnection con = new SqlConnection("database=alquiler;data source=.;integrated security=true");

    }
}
