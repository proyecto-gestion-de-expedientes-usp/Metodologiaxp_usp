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
        Clases.Conexion con = new Clases.Conexion();

        public DataTable mostrar()
        {

            con.AbrirConexion();
            string sql = "select * from Persona";
            SqlDataAdapter da = new SqlDataAdapter(sql, con.AbrirConexion());
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.CerrarConexion();
            return dt;
        }


        public DataTable mostrarmovexp()
        {

            con.AbrirConexion();
            string sql = "select * from Movimiento_Expediente";
            SqlDataAdapter da = new SqlDataAdapter(sql, con.AbrirConexion());
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.CerrarConexion();
            return dt;
        }

        public DataTable mostrarexp()
        {

            con.AbrirConexion();
            string sql = "select * from Expediente";
            SqlDataAdapter da = new SqlDataAdapter(sql, con.AbrirConexion());
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.CerrarConexion();
            return dt;
        }
    }
}
