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

    public partial class frm_registrar_usuario : Form
    {
        SqlConnection gh;
        string campo;
        DataTable dts = new DataTable();
        DataTable ds = new DataTable();

        public frm_registrar_usuario()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frm_registrar_usuario_Load(object sender, EventArgs e)
        {
              

            gh = new SqlConnection("database=consultoriojur;data source=.;integrated security=true");

            mostrartipousuario();

            mostrarestadousuario();
            //btn_modificar.Enabled = false;
        }
        public void mostrarestadousuario()
        {

            gh.Open();
            string sql = "select * from Estado_Usu";
            SqlDataAdapter da = new SqlDataAdapter(sql, gh);

            da.Fill(dts);
            cb_esta_usua.DataSource = dts;
            cb_esta_usua.DisplayMember = "est_condi";

            gh.Close();

        }
        public void mostrartipousuario()
        {

            gh.Open();
            string sql = "select * from Tipo_Usuario";
            SqlDataAdapter da = new SqlDataAdapter(sql, gh);

            da.Fill(ds);
            cb_tip_usu.DataSource = ds;
            cb_tip_usu.DisplayMember = "tipusu_tipousuario";

            gh.Close();

        }

        private void cb_esta_usua_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = cb_esta_usua.SelectedIndex;
            txt_cod_estausua.Text = dts.Rows[a]["id_estusu"].ToString();
        }

        private void cb_tip_usu_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = cb_tip_usu.SelectedIndex;
            txt_cod_tipusua.Text = ds.Rows[a]["tipusu_id"].ToString();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                string ConnectionString = "database=consultoriojur;data source=.;integrated security=sspi";
                SqlConnection cnn = new SqlConnection(ConnectionString);
                SqlCommand cmd = new SqlCommand("insertar_Usu", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@usu_id", SqlDbType.Int);
                cmd.Parameters.Add("@tipusu_id", SqlDbType.Int);
                cmd.Parameters.Add("@usu_dni", SqlDbType.Char, 8);
                cmd.Parameters.Add("@usu_nombres", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@usu_apellidopat", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@usu_apellidomat", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@usu_telefono", SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@usu_direccion", SqlDbType.VarChar, 40);
                cmd.Parameters.Add("@usu_sexo", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@usu_correo", SqlDbType.VarChar, 60);
                cmd.Parameters.Add("@usu_estadocivil", SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@usu_fechanac", SqlDbType.Date);
                cmd.Parameters.Add("@usu_ciudad", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@usu_provincia", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@id_estusu", SqlDbType.Int);
                cmd.Parameters.Add("@usu_departamento", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@usu_contraseña", SqlDbType.VarChar, 30);

                cmd.Parameters["@usu_id"].Value = txt_id_usu.Text;
                cmd.Parameters["@tipusu_id"].Value = txt_cod_tipusua.Text;
                cmd.Parameters["@usu_dni"].Value = txt_dni.Text;
                cmd.Parameters["@usu_nombres"].Value = txt_nombres.Text;
                cmd.Parameters["@usu_apellidopat"].Value = txt_apepat.Text;
                cmd.Parameters["@usu_apellidomat"].Value = txt_apemat.Text;
                cmd.Parameters["@usu_telefono"].Value = txt_cel.Text;
                cmd.Parameters["@usu_direccion"].Value = txt_domici.Text;
                cmd.Parameters["@usu_sexo"].Value = cb_Sexo.Text;
                cmd.Parameters["@usu_correo"].Value = txt_correo.Text;
                cmd.Parameters["@usu_estadocivil"].Value = cb_estadoci.Text;
                cmd.Parameters["@usu_fechanac"].Value = dp_fenaci.Text;
                cmd.Parameters["@usu_ciudad"].Value = txt_distrito.Text;
                cmd.Parameters["@usu_provincia"].Value = txt_provincia.Text;
                cmd.Parameters["@id_estusu"].Value = txt_cod_estausua.Text;
                cmd.Parameters["@usu_departamento"].Value = txt_dpto.Text;
                cmd.Parameters["@usu_contraseña"].Value = txt_contra.Text;


                cnn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Los datos fueron insertados correctamente");
                cnn.Close();
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dp_fenaci_ValueChanged(object sender, EventArgs e)
        {
            campo = "@usu_fechanac";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                string ConnectionString = "database=consultoriojur;data source=.;integrated security=sspi";
                SqlConnection cnn = new SqlConnection(ConnectionString);
                SqlCommand cmd = new SqlCommand("actualizar_Usu", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@usu_id", SqlDbType.Int);
                cmd.Parameters.Add("@tipusu_id", SqlDbType.Int);
                cmd.Parameters.Add("@usu_dni", SqlDbType.Char, 8);
                cmd.Parameters.Add("@usu_nombres", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@usu_apellidopat", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@usu_apellidomat", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@usu_telefono", SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@usu_direccion", SqlDbType.VarChar, 40);
                cmd.Parameters.Add("@usu_sexo", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@usu_correo", SqlDbType.VarChar, 60);
                cmd.Parameters.Add("@usu_estadocivil", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@usu_fechanac", SqlDbType.Date);
                cmd.Parameters.Add("@usu_ciudad", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@usu_provincia", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@id_estusu", SqlDbType.Int);
                cmd.Parameters.Add("@usu_departamento", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@usu_contraseña", SqlDbType.VarChar, 30);

                cmd.Parameters["@usu_id"].Value = txt_id_usu.Text;
                cmd.Parameters["@tipusu_id"].Value = txt_cod_tipusua.Text;
                cmd.Parameters["@usu_dni"].Value = txt_dni.Text;
                cmd.Parameters["@usu_nombres"].Value = txt_nombres.Text;
                cmd.Parameters["@usu_apellidopat"].Value = txt_apepat.Text;
                cmd.Parameters["@usu_apellidomat"].Value = txt_apemat.Text;
                cmd.Parameters["@usu_telefono"].Value = txt_cel.Text;
                cmd.Parameters["@usu_direccion"].Value = txt_domici.Text;
                cmd.Parameters["@usu_sexo"].Value = cb_Sexo.Text;
                cmd.Parameters["@usu_correo"].Value = txt_correo.Text;
                cmd.Parameters["@usu_estadocivil"].Value = cb_estadoci.Text;
                cmd.Parameters["@usu_fechanac"].Value = dp_fenaci.Text;
                cmd.Parameters["@usu_ciudad"].Value = txt_distrito.Text;
                cmd.Parameters["@usu_provincia"].Value = txt_provincia.Text;
                cmd.Parameters["@id_estusu"].Value = txt_cod_estausua.Text;
                cmd.Parameters["@usu_departamento"].Value = txt_dpto.Text;
                cmd.Parameters["@usu_contraseña"].Value = txt_contra.Text;


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

    }
    }

