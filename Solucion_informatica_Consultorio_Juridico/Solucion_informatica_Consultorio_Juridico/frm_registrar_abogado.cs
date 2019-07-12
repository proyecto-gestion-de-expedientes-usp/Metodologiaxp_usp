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
using System.Data;
namespace Solucion_informatica_Consultorio_Juridico
{
    public partial class frm_registrar_abogado : Form
    {
        Clases.Validacioes validacion = new Clases.Validacioes();

        SqlConnection cnn = new SqlConnection("database=consultoriojur;data source=.;integrated security=sspi");
        public frm_registrar_abogado()
        {
            InitializeComponent();
        }

        private void frm_registrar_abogado_Load(object sender, EventArgs e)
        {
            generar_cod();
            dgv_datos_abo.DataSource = mostrar();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                string ConnectionString = "database=consultoriojur;data source=.;integrated security=sspi";
                SqlConnection cnn = new SqlConnection(ConnectionString);
                SqlCommand cmd = new SqlCommand("insertar_Abogado", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ab_id", SqlDbType.Int);
                cmd.Parameters.Add("@tipb_id", SqlDbType.Int);
                cmd.Parameters.Add("@ab_estado", SqlDbType.Int);
                cmd.Parameters.Add("@ab_nombres", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@ab_apellidopat", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@ab_apellidomat", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@ab_dni", SqlDbType.Char, 8);
           

                cmd.Parameters["@ab_id"].Value = txt_idAbogado.Text;
                cmd.Parameters["@tipb_id"].Value = txt_idtipabogado.Text;
                cmd.Parameters["@ab_estado"].Value = TXT_IDESTADO.Text;
                cmd.Parameters["@ab_nombres"].Value = txt_nomb.Text;
                cmd.Parameters["@ab_apellidopat"].Value = txt_apepat.Text;
                cmd.Parameters["@ab_apellidomat"].Value = txt_apemat.Text;
                cmd.Parameters["@ab_dni"].Value = txt_dni.Text;
                
             


                cnn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Los datos fueron insertados correctamente");
                
                cnn.Close();

                generar_cod();  
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
                string ConnectionString = "database=consultoriojur;data source=.;integrated security=sspi";
                SqlConnection cnn = new SqlConnection(ConnectionString);
                SqlCommand cmd = new SqlCommand("actualizar_abogado", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ab_id", SqlDbType.Int);
                cmd.Parameters.Add("@tipb_id", SqlDbType.Int);
                cmd.Parameters.Add("@id_estabo", SqlDbType.Int);
                cmd.Parameters.Add("@ab_nombres", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@ab_apellidopat", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@ab_apellidomat", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@ab_dni", SqlDbType.Char, 8);




                cmd.Parameters["@ab_id"].Value = txt_idAbogado.Text;
                cmd.Parameters["@tipb_id"].Value = txt_idtipabogado.Text;
                cmd.Parameters["@id_estabo"].Value = TXT_IDESTADO.Text;
                cmd.Parameters["@ab_nombres"].Value = txt_nomb.Text;
                cmd.Parameters["@ab_apellidopat"].Value = txt_apepat.Text;
                cmd.Parameters["@ab_apellidomat"].Value = txt_apemat.Text;
                cmd.Parameters["@ab_dni"].Value = txt_dni.Text;




                cnn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Los datos fueron modificados correctamente");
                cnn.Close();
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void generar_cod() {
            SqlDataAdapter sda = new SqlDataAdapter("select isnull(Max(cast(ab_id as int)),0)+1 from Abogado", cnn);
            DataTable sqlex = new DataTable();
            sda.Fill(sqlex);
            txt_idAbogado.Text = sqlex.Rows[0][0].ToString();
        }
        public DataTable mostrar()
        {
            cnn.Open();
            string sql = "select * from View_Abogado";
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        public DataTable buscar(string valor)
        {

            cnn.Open();
            string sql = "select * from View_Abogado where DNI like '" + valor + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        private void txt_nomb_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloLetras(e);
        }

        private void txt_apepat_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloLetras(e);
        }

        private void txt_apemat_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloLetras(e);
        }

        private void txt_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloNumeros(e);
        }

        private void txt_nomb_Validated(object sender, EventArgs e)
        {
            if (txt_nomb.Text.Trim() == "")
            {
                errornombreabog.SetError(txt_nomb, "Ingrese Nombre");
            }
        }

        private void txt_apepat_Validated(object sender, EventArgs e)
        {
            if (txt_apepat.Text.Trim() == "")
            {
                errorApePat.SetError(txt_apepat, "Ingrese Apellido Paterno");
            }
        }

        private void txt_apemat_Validated(object sender, EventArgs e)
        {
            if (txt_apemat.Text.Trim() == "")
            {
                errorApeMat.SetError(txt_apemat, "Ingrese Apellido Materno");
            }
        }

        private void txt_dni_Validated(object sender, EventArgs e)
        {
            if (txt_dni.Text.Trim() == "")
            {
                errorDNI.SetError(txt_dni, "Ingrese DNI");
            }
        }

        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            string valor = txt_buscar.Text;
            dgv_datos_abo.DataSource = buscar(valor);

            txt_buscar.Focus();
        }

        private void dgv_datos_abo_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
