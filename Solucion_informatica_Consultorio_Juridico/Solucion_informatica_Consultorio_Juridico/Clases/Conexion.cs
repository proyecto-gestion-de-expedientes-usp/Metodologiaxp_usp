using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Solucion_informatica_Consultorio_Juridico.Clases
{
    class Conexion
    {
        private SqlConnection Con = new SqlConnection("database = consultoriojur; data source =.; integrated security = true");

        public SqlConnection AbrirConexion()
        {
            if (Con.State == ConnectionState.Closed)
                Con.Open();
            return Con;
        }

        public SqlConnection CerrarConexion()
        {
            if (Con.State == ConnectionState.Open)
                Con.Close();
            return Con;
        }
    }
}
