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

namespace Solucion_informatica_Consultorio_Juridico
{
    public partial class frm_Registrar_MovimientoExp : Form
    {
        Clases.Conexion con = new Clases.Conexion();
        Clases.Datos sad = new Clases.Datos();
        public frm_Registrar_MovimientoExp()
        {
            InitializeComponent();
        }

        private void frm_Registrar_MovimientoExp_Load(object sender, EventArgs e)
        {
            //generarid();
            mostrar();

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("insertar_MovExp", con.AbrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@movexp_id", SqlDbType.Int);
                cmd.Parameters.Add("@ab_id", SqlDbType.Int);
                cmd.Parameters.Add("@usu_id", SqlDbType.Int );
                cmd.Parameters.Add("@demte_id", SqlDbType.Int);
                cmd.Parameters.Add("@demdo_id", SqlDbType.Int);
                cmd.Parameters.Add("@anexo_id", SqlDbType.Int);
                cmd.Parameters.Add("@movexp_asunto", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@movexp_fechaing", SqlDbType.Date);
                cmd.Parameters.Add("@movexp_estado", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@movexp_progreso", SqlDbType.VarChar, 250);
                cmd.Parameters.Add("@movexp_cantfolios", SqlDbType.VarChar, 10);
                cmd.Parameters.Add("@movexp_descripcion", SqlDbType.VarChar,250);
                cmd.Parameters.Add("@movexp_nro", SqlDbType.VarChar, 10);


                cmd.Parameters["@movexp_id"].Value = txt_id_movexp.Text;
                cmd.Parameters["@ab_id"].Value = txt_id_abo.Text;
                cmd.Parameters["@usu_id"].Value = txt_id_usu.Text;
                cmd.Parameters["@demte_id"].Value = txt_id_demandt.Text;
                cmd.Parameters["@demdo_id"].Value = txt_id_demandd.Text;
                cmd.Parameters["@anexo_id"].Value = txt_id_anex.Text;
                cmd.Parameters["@movexp_asunto"].Value = txt_asunto.Text;
                cmd.Parameters["@movexp_fechaing"].Value = dp_fecha.Text;
                cmd.Parameters["@movexp_estado"].Value = cb_estado.Text;
                cmd.Parameters["@movexp_progreso"].Value = txt_progre.Text;
                cmd.Parameters["@movexp_cantfolios"].Value = txt_cantfol.Text;
                cmd.Parameters["@movexp_descripcion"].Value = txt_descrip.Text;
                cmd.Parameters["@movexp_nro"].Value = txt_nroexp.Text;



                con.AbrirConexion();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Los datos fueron insertados correctamente");
                generarid();
                mostrar();
                con.CerrarConexion();
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("insertar_MovExp", con.AbrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@movexp_id", SqlDbType.Int);
                cmd.Parameters.Add("@ab_id", SqlDbType.Int);
                cmd.Parameters.Add("@usu_id", SqlDbType.Int);
                cmd.Parameters.Add("@demte_id", SqlDbType.Int);
                cmd.Parameters.Add("@demdo_id", SqlDbType.Int);
                cmd.Parameters.Add("@anexo_id", SqlDbType.Int);
                cmd.Parameters.Add("@movexp_asunto", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@movexp_fechaing", SqlDbType.Date);
                cmd.Parameters.Add("@movexp_estado", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@movexp_progreso", SqlDbType.VarChar, 250);
                cmd.Parameters.Add("@movexp_cantfolios", SqlDbType.VarChar, 10);
                cmd.Parameters.Add("@movexp_descripcion", SqlDbType.VarChar, 250);
                cmd.Parameters.Add("@movexp_nro", SqlDbType.VarChar, 10);


                cmd.Parameters["@movexp_id"].Value = txt_id_movexp.Text;
                cmd.Parameters["@ab_id"].Value = txt_id_abo.Text;
                cmd.Parameters["@usu_id"].Value = txt_id_usu.Text;
                cmd.Parameters["@demte_id"].Value = txt_id_demandt.Text;
                cmd.Parameters["@demdo_id"].Value = txt_id_demandd.Text;
                cmd.Parameters["@anexo_id"].Value = txt_id_anex.Text;
                cmd.Parameters["@movexp_asunto"].Value = txt_asunto.Text;
                cmd.Parameters["@movexp_fechaing"].Value = dp_fecha.Text;
                cmd.Parameters["@movexp_estado"].Value = cb_estado.Text;
                cmd.Parameters["@movexp_progreso"].Value = txt_progre.Text;
                cmd.Parameters["@movexp_cantfolios"].Value = txt_cantfol.Text;
                cmd.Parameters["@movexp_descripcion"].Value = txt_descrip.Text;
                cmd.Parameters["@movexp_nro"].Value = txt_nroexp.Text;



                con.AbrirConexion();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Los datos fueron modificados correctamente");
                //generarid();
                //mostrar();
                con.CerrarConexion();
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void mostrar() {

            dgv_datos.DataSource = sad.mostrarmovexp();
        }
        public void generarid()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select isnull(Max(cast(movexp_id as int)),0)+1 from Movimiento_Expediente", con.AbrirConexion());
            DataTable sqlex = new DataTable();
            sda.Fill(sqlex);
            txt_id_movexp.Text = sqlex.Rows[0][0].ToString();
        }
    }
}
