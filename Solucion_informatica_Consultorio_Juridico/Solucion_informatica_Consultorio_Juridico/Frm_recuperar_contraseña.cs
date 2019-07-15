using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Configuration;

namespace Solucion_informatica_Consultorio_Juridico
{
    public partial class Frm_recuperar_contraseña : Form
    {
        Clases.Conexion CNN = new Clases.Conexion();
        public Frm_recuperar_contraseña()
        {
            InitializeComponent();
        }

        private void Frm_recuperar_contraseña_Load(object sender, EventArgs e)
        {

        }
        public void GenerarNuevaContrasena(string email)
        {
            Random rd = new Random(DateTime.Now.Millisecond);
            int nuevaContrasena = rd.Next(100000, 999999);


            CNN.AbrirConexion();


            SqlCommand cmd = new SqlCommand("NuevaContrasena", CNN.AbrirConexion());

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@correo", email);
            cmd.Parameters.AddWithValue("@contrasena", nuevaContrasena);
            try
            {
                CNN.AbrirConexion();
                int filasAfectadas = cmd.ExecuteNonQuery();
                if (filasAfectadas != 0)
                {
                    EnviarCorreoContrasena(nuevaContrasena, email);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void EnviarCorreoContrasena(int contrasenaNueva, string correo)
        {
            string contraseña = "Usp2019-01";
            string mensaje = string.Empty;
          
            string destinatario = correo;
            string remitente = "consultorio.juridico.usp2019@gmail.com";
            string asunto = "Nueva contraseña del Sistema Juridico";
            string cuerpoDelMesaje = "Su nueva contraseña es" + " " + Convert.ToString(contrasenaNueva);
            MailMessage ms = new MailMessage(remitente, destinatario, asunto, cuerpoDelMesaje);


            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("consultorio.juridico.usp2019@gmail.com", contraseña);

            try
            {
                Task.Run(() =>
                {

                    smtp.Send(ms);
                    ms.Dispose();
                    MessageBox.Show("Correo enviado, sirvase revisar su bandeja de entrada");
                }
                );

                MessageBox.Show("Esta tarea puede tardar unos segundos, por favor espere.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar correo electronico: " + ex.Message);
            }
        }
        public string Contrasena
        {
            get
            { return "tu contraseña"; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CNN.AbrirConexion();
            {



                SqlCommand cmd = new SqlCommand("ValidarCorreo", CNN.AbrirConexion());


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@correo", txt_correo.Text);
                try
                {
                    CNN.AbrirConexion();
                    SqlDataReader lector = cmd.ExecuteReader();
                    if (lector.Read())
                    {

                        GenerarNuevaContrasena(txt_correo.Text);
                    }
                    else
                    {
                        MessageBox.Show("Correo no encontrado");

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }
    }
}
