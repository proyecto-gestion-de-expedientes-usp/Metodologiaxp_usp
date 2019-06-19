using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Solucion_informatica_Consultorio_Juridico.Clases
{
    public class Acceso
    {

        private string mensaje;
        private string usuario;
        private string clave;
        private string tipo;
        Conexion con = new Conexion();

        public string Mensaje
        {
            get
            {
                return mensaje;
            }

            set
            {
                mensaje = value;
            }
        }

        public string Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }

        public string Clave
        {
            get
            {
                return clave;
            }

            set
            {
                clave = value;
            }
        }

        public string Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }

        public bool Verificar()
        {
     
                bool resultado = false;
                SqlCommand comando = new SqlCommand("select * from Usuario ,  Tipo_Usuario where usu_dni='" + usuario + "'and usu_contraseña='" + clave + "'and tipusu_tipousuario='" + tipo + "'", Capas.Acceso.ObtenerAcceso());
                SqlDataReader ejecuta = comando.ExecuteReader();
                if (ejecuta.Read())
                {
                    resultado = true;
                    mensaje = "Su Logueo Fue Ingresado Correctamente \n \n               Bienvenido al Sistema \n \n del Consultorio Juridico de la USP";
                }
                else
                {
                    mensaje = "         Excedio el Limite de Intentos al Sistema \n \nEspere unos Minutos y Ingrese Su Logueo Otra Vez";
                }

                return resultado;

           

           
        }


        public DataTable buscarpersona(string valor)
        {

            con.AbrirConexion();
            string sql = "SELECT        dbo.Persona.*, dbo.Tip_documento.tipdoc_nom FROM dbo.Persona INNER JOIN dbo.Tip_documento ON dbo.Persona.id_tipdoc = dbo.Tip_documento.id_tipdoc where pers_numdoc like'" + valor + "%'";

            SqlDataAdapter da = new SqlDataAdapter(sql, con.AbrirConexion());
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.CerrarConexion();
            return dt;
        }
    }
    
}


