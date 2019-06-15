using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Solucion_informatica_Consultorio_Juridico.Clases
{
   
    class Datos
    {
        public SqlConnection con = new SqlConnection("database=consultoriojur;data source=.;integrated security=sspi");

        public DataTable mostrar()
        {

            con.Open();
            string sql = "select * from Persona";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
