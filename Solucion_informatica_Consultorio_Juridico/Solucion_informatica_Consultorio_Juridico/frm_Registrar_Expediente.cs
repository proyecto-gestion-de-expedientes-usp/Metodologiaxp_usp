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
    public partial class frm_Registrar_Expediente : Form
    {
        Clases.Validacioes validadcion = new Clases.Validacioes();
        Capas.conexion cone = new Capas.conexion();
        Clases.Datos sad = new Clases.Datos();
        public frm_Registrar_Expediente()
        {
            InitializeComponent();
        }

        private void frm_Registrar_Expediente_Load(object sender, EventArgs e)
        {
            generarid();
            mostrar();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("insertar_exp", cone.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@exp_id", SqlDbType.Int);
                cmd.Parameters.Add("@movexp", SqlDbType.Int);
                cmd.Parameters.Add("@juzg_id", SqlDbType.Int);
                cmd.Parameters.Add("@doc", SqlDbType.Int);
                cmd.Parameters.Add("@exp_nrosentencia", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@exp_expediente", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@exp_secrejuzg", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@exp_fechainicio", SqlDbType.Date);
                cmd.Parameters.Add("@exp_materia", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@exp_resolucionnro", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@exp_ciudad", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@exp_fecha", SqlDbType.Date);
                cmd.Parameters.Add("@exp_vistos", SqlDbType.VarChar, 30);


                cmd.Parameters["@exp_id"].Value = txt_id_exp.Text;
                cmd.Parameters["@movexp"].Value = txt_id_mov_exp.Text;
                cmd.Parameters["@juzg_id"].Value = txt_id_juzgados.Text;
                cmd.Parameters["@doc"].Value = txt_id_doc.Text;
                cmd.Parameters["@exp_nrosentencia"].Value = txt_sentencia.Text;
                cmd.Parameters["@exp_expediente"].Value = txt_expediente.Text;
                cmd.Parameters["@exp_secrejuzg"].Value = txt_secretaria_juzgado.Text;
                cmd.Parameters["@exp_fechainicio"].Value = dp_ini.Text;
                cmd.Parameters["@exp_materia"].Value = txt_materia.Text;
                cmd.Parameters["@exp_resolucionnro"].Value = txt_resolucion.Text;
                cmd.Parameters["@exp_ciudad"].Value = txt_ciudad.Text;
                cmd.Parameters["@exp_fecha"].Value = dp_fin.Text;
                cmd.Parameters["@exp_vistos"].Value = txt_vistos.Text;



                cone.con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Los datos fueron insertados correctamente");
                generarid();
                //mostrar();
                cone.con.Close();
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

                SqlCommand cmd = new SqlCommand("actualizar_exp", cone.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@exp_id", SqlDbType.Int);
                cmd.Parameters.Add("@movexp", SqlDbType.Int);
                cmd.Parameters.Add("@juzg_id", SqlDbType.Int);
                cmd.Parameters.Add("@doc", SqlDbType.Int);
                cmd.Parameters.Add("@exp_nrosentencia", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@exp_expediente", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@exp_secrejuzg", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@exp_fechainicio", SqlDbType.Date);
                cmd.Parameters.Add("@exp_materia", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@exp_resolucionnro", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@exp_ciudad", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@exp_fecha", SqlDbType.Date);
                cmd.Parameters.Add("@exp_vistos", SqlDbType.VarChar, 30);


                cmd.Parameters["@exp_id"].Value = txt_id_exp.Text;
                cmd.Parameters["@movexp"].Value = txt_id_mov_exp.Text;
                cmd.Parameters["@juzg_id"].Value = txt_id_juzgados.Text;
                cmd.Parameters["@doc"].Value = txt_id_doc.Text;
                cmd.Parameters["@exp_nrosentencia"].Value = txt_sentencia.Text;
                cmd.Parameters["@exp_expediente"].Value = txt_expediente.Text;
                cmd.Parameters["@exp_secrejuzg"].Value = txt_secretaria_juzgado.Text;
                cmd.Parameters["@exp_fechainicio"].Value = dp_ini.Text;
                cmd.Parameters["@exp_materia"].Value = txt_materia.Text;
                cmd.Parameters["@exp_resolucionnro"].Value = txt_resolucion.Text;
                cmd.Parameters["@exp_ciudad"].Value = txt_ciudad.Text;
                cmd.Parameters["@exp_fecha"].Value = dp_fin.Text;
                cmd.Parameters["@exp_vistos"].Value = txt_vistos.Text;



                cone.con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Los datos fueron insertados correctamente");
                generarid();
                //mostrar();
                cone.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void generarid()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select isnull(Max(cast(exp_id as int)),0)+1 from Expediente", cone.con);
            DataTable sqlex = new DataTable();
            sda.Fill(sqlex);
            txt_id_exp.Text = sqlex.Rows[0][0].ToString();
            cone.con.Close();
        }
        public void mostrar()
        {

            dgv_datos.DataSource = sad.mostrarexp();
        }

        private void txt_sentencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            validadcion.soloNumeros(e);
        }

        private void txt_ciudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            validadcion.soloLetras(e);
        }
    }
}