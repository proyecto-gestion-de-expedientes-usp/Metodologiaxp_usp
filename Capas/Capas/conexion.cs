using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Capas
{
    public class conexion
    {
        public SqlConnection con = new SqlConnection("database=consultoriojur;data source=.;integrated security=sspi");
   }
}
