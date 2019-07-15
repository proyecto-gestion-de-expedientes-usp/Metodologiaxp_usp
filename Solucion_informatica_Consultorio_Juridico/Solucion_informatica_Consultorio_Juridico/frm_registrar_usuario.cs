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
using System.Text.RegularExpressions;

namespace Solucion_informatica_Consultorio_Juridico
{

    

    public partial class frm_registrar_usuario : Form
    {
        Clases.Validacioes validadcion = new Clases.Validacioes();
        Clases.Conexion cnn = new Clases.Conexion();
        SqlConnection gh;
        string campo;
        string valor;
        DataTable dts = new DataTable();
        DataTable ds = new DataTable();
        
        Clases.Datos sad = new Clases.Datos();

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
            llenar_dpto();
            mostrarestadousuario();
            btn_modificar.Enabled = false;

            SqlDataAdapter sda = new SqlDataAdapter("select isnull(Max(cast(usu_id as int)),0)+1 from Usuario", cnn.AbrirConexion());
            DataTable sqlex = new DataTable();
            sda.Fill(sqlex);
            txt_id_usu.Text = sqlex.Rows[0][0].ToString();
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
            txt_dni.Enabled = false;
            txt_nombres.Enabled = false;
            txt_apepat.Enabled = false;
            txt_apemat.Enabled = false;
            txt_cel.Enabled = false;
            txt_domici.Enabled = false;
            cb_Sexo.Enabled = false;
            cb_estadoci.Enabled = false;
            dp_fenaci.Enabled = false;
            cb_dpto.Enabled = false;
            cb_provin.Enabled = false;
            cb_distritos.Enabled = false;
            cb_esta_usua.Enabled = false;
            cb_tip_usu.Enabled = false;
            txt_correo.Enabled = false;
            txt_contra.Enabled = false;
            btn_guardar.Enabled = false;
            btnnuevo.Enabled = true;
            btn_limpiar.Enabled = true;
            try
            {
                
                SqlCommand cmd = new SqlCommand("insertar_Usu", cnn.AbrirConexion());
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
                cmd.Parameters["@usu_ciudad"].Value = cb_distritos.Text;
                cmd.Parameters["@usu_provincia"].Value = cb_provin.Text;
                cmd.Parameters["@id_estusu"].Value = txt_cod_estausua.Text;
                cmd.Parameters["@usu_departamento"].Value = cb_dpto.Text;
                cmd.Parameters["@usu_contraseña"].Value = txt_contra.Text;


                cnn.AbrirConexion();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Los datos fueron insertados correctamente");
                cnn.CerrarConexion();
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
                //string ConnectionString = "database=consultoriojur;data source=.;integrated security=sspi";
                //SqlConnection cnn = new SqlConnection(ConnectionString);
                SqlCommand cmd = new SqlCommand("actualizar_Usu", cnn.AbrirConexion());
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
                cmd.Parameters["@usu_ciudad"].Value = cb_distritos.Text;
                cmd.Parameters["@usu_provincia"].Value = cb_provin.Text;
                cmd.Parameters["@id_estusu"].Value = txt_cod_estausua.Text;
                cmd.Parameters["@usu_departamento"].Value = cb_dpto.Text;
                cmd.Parameters["@usu_contraseña"].Value = txt_contra.Text;


                cnn.AbrirConexion();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Los datos fueron modificados correctamente");
                cnn.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txt_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            validadcion.soloNumeros(e);
        }

        private void txt_cel_KeyPress(object sender, KeyPressEventArgs e)
        {
            validadcion.soloNumeros(e);
        }

        private void txt_nombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            validadcion.soloLetras(e);
        }

        private void txt_apepat_KeyPress(object sender, KeyPressEventArgs e)
        {
            validadcion.soloLetras(e);
        }

        private void txt_apemat_KeyPress(object sender, KeyPressEventArgs e)
        {
            validadcion.soloLetras(e);
        }

        private void txt_dpto_KeyPress(object sender, KeyPressEventArgs e)
        {
            validadcion.soloLetras(e);
        }

        private void txt_provincia_KeyPress(object sender, KeyPressEventArgs e)
        {
            validadcion.soloLetras(e);
        }

        private void txt_distrito_KeyPress(object sender, KeyPressEventArgs e)
        {
            validadcion.soloLetras(e);
        }
        public static bool Valorreo(string email)
        {
            string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                { return true; }
                else
                { return false; }
            }
            else
            { return false; }
        }
        private void txt_correo_Leave(object sender, EventArgs e)
        {
            if (Valorreo(txt_correo.Text))
            {

            }
            else
            {
                MessageBox.Show("Dirección de correo electrónico no valido, el correo debe tener el formato: nombre@dominio.com, " +
                    " por favor ingrese un correo válido", "Alerta", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                txt_correo.SelectAll();
                txt_correo.Focus();
            }

        }

        private void txt_nombres_Validated(object sender, EventArgs e)
        {
            if (txt_nombres.Text.Trim() == "")
            {
                errorNombre.SetError(txt_nombres, "Ingrese Nombres...");
            }
        }

        private void txt_apepat_Validated(object sender, EventArgs e)
        {
            if (txt_apepat.Text.Trim() == "")
            {
                errorNombre.SetError(txt_apepat, "Ingrese Apellido Paterno...");
            }
        }

        private void txt_apemat_Validated(object sender, EventArgs e)
        {
            if (txt_apemat.Text.Trim() == "")
            {
                errorNombre.SetError(txt_apemat, "Ingrese Apellido Materno...");
            }
        }

        private void txt_dpto_Validated(object sender, EventArgs e)
        {
            if (cb_dpto.Text.Trim() == "")
            {
                errorNombre.SetError(cb_dpto, "Ingrese Departamento...");
            }
        }

        private void txt_provincia_Validated(object sender, EventArgs e)
        {
            if (cb_provin.Text.Trim() == "")
            {
                errorNombre.SetError(cb_provin, "Ingrese Provincia...");
            }
        }

        private void txt_distrito_Validated(object sender, EventArgs e)
        {
            if (cb_distritos.Text.Trim() == "")
            {
                errorNombre.SetError(cb_distritos, "Ingrese Distrito...");
            }
        }

        private void txt_domici_Validated(object sender, EventArgs e)
        {
            if (txt_domici.Text.Trim() == "")
            {
                errorNombre.SetError(txt_domici, "Ingrese Domicilio...");
            }
        }

        private void txt_dni_Validated(object sender, EventArgs e)
        {

        }

        private void txt_dni_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_dni_Validating(object sender, CancelEventArgs e)
        {
            var cadena = txt_dni.Text;
            if (cadena.Length > 8)
            {
                txt_dni.Focus();
                MessageBox.Show("El dni solo tiene 8 digitos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                if (cadena.Length < 8)
                {
                    MessageBox.Show("Ingrese los 8 digitos del DNI 😎", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        public void llenar_dpto()
        {
            cb_dpto.Items.Add("Amazonas");
            cb_dpto.Items.Add("Áncash");
            cb_dpto.Items.Add("Apurímac");
            cb_dpto.Items.Add("Arequipa");
            cb_dpto.Items.Add("Ayacucho");
            cb_dpto.Items.Add("Cajamarca");
            cb_dpto.Items.Add("Callao");
            cb_dpto.Items.Add("Cuzco");
            cb_dpto.Items.Add("Huancavelica");
            cb_dpto.Items.Add("Huánuco");
            cb_dpto.Items.Add("Ica");
            cb_dpto.Items.Add("Junín");
            cb_dpto.Items.Add("La Libertad");
            cb_dpto.Items.Add("Lambayeque");
            cb_dpto.Items.Add("Lima");
            cb_dpto.Items.Add("Loreto");
            cb_dpto.Items.Add("Madre de Dios");
            cb_dpto.Items.Add("Moquegua");
            cb_dpto.Items.Add("Pasco");
            cb_dpto.Items.Add("Piura");
            cb_dpto.Items.Add("Puno");
            cb_dpto.Items.Add("San Martín");
            cb_dpto.Items.Add("Tacna");
            cb_dpto.Items.Add("Tumbes");
            cb_dpto.Items.Add("Ucayali");
        }

        private void cb_dpto_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenar_dpto();
            if (cb_dpto.SelectedItem.Equals("Amazonas"))
            {
                cb_provin.Items.Clear();
                cb_provin.Items.Add("Chachapoyas");
                cb_provin.Items.Add("Bagua");
                cb_provin.Items.Add("Bongara");
                cb_provin.Items.Add("Condorcanqui");
                cb_provin.Items.Add("Luya");
                cb_provin.Items.Add("Rodríguez de Mendoza");
                cb_provin.Items.Add("Utcubamba");

            }
            if (cb_dpto.SelectedItem.Equals("Áncash"))
            {
                cb_provin.Items.Clear();
                cb_provin.Items.Add("Huaraz");
                cb_provin.Items.Add("Aija");
                cb_provin.Items.Add("Antonio raymondi");
                cb_provin.Items.Add("Asunción");
                cb_provin.Items.Add("Bolognesi");
                cb_provin.Items.Add("Carhuaz");
                cb_provin.Items.Add("Carlos Fermín Fitzcarrald");
                cb_provin.Items.Add("Casma");
                cb_provin.Items.Add("Corongo");
                cb_provin.Items.Add("Huari");
                cb_provin.Items.Add("Huarmey");
                cb_provin.Items.Add("Huaylas");
                cb_provin.Items.Add("Mariscal Luzuriaga");
                cb_provin.Items.Add("Ocros");
                cb_provin.Items.Add("Pallasca");
                cb_provin.Items.Add("Pomabamba");
                cb_provin.Items.Add("Recuay");
                cb_provin.Items.Add("Santa");
                cb_provin.Items.Add("Sihuas");
                cb_provin.Items.Add("Yungay");




            }
            if (cb_dpto.SelectedItem.Equals("Apurímac"))
            {
                cb_provin.Items.Clear();

                cb_provin.Items.Add("Abancay");
                cb_provin.Items.Add("Andahuaylas");
                cb_provin.Items.Add("Antabamba");
                cb_provin.Items.Add("Aymaraes");
                cb_provin.Items.Add("Cotabambas");
                cb_provin.Items.Add("Chincheros");
                cb_provin.Items.Add("Grau");
            }
            if (cb_dpto.SelectedItem.Equals("Arequipa"))
            {

                cb_provin.Items.Clear();
                cb_provin.Items.Add("Arequipa");
                cb_provin.Items.Add("Camana");
                cb_provin.Items.Add("Caraveli");
                cb_provin.Items.Add("Caylloma");
                cb_provin.Items.Add("Condesuyos");
                cb_provin.Items.Add("Islay");
                cb_provin.Items.Add("La unión");

            }
            if (cb_dpto.SelectedItem.Equals("Ayacucho"))
            {

                cb_provin.Items.Clear();
                cb_provin.Items.Add("Huamanga");
                cb_provin.Items.Add("Cangallo");
                cb_provin.Items.Add("Huanca sancos");
                cb_provin.Items.Add("Huanta");
                cb_provin.Items.Add("La Mar");
                cb_provin.Items.Add("Lucanas");
                cb_provin.Items.Add("Parinacochas");
                cb_provin.Items.Add("Páucar del Sara Sara");
                cb_provin.Items.Add("Víctor Fajardo");
                cb_provin.Items.Add("Vilcas Huaman");
                cb_provin.Items.Add("Parinacochas");

            }
        }

        private void cb_distritos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cb_provin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_provin.SelectedItem.Equals("Santa"))
            {
                cb_distritos.Items.Clear();
                cb_distritos.Items.Add("Cáceres Del Perú");
                cb_distritos.Items.Add("Chimbote");
                cb_distritos.Items.Add("Coishco");
                cb_distritos.Items.Add("Macate");
                cb_distritos.Items.Add("Moro");
                cb_distritos.Items.Add("Nepeña");
                cb_distritos.Items.Add("Nuevo Chimbote");
                cb_distritos.Items.Add("Samanco");
                cb_distritos.Items.Add("Santa");

            }

        }

        private void rbt_dni_CheckedChanged(object sender, EventArgs e)
        {
            campo = "usu_dni";
        }

        private void rbt_nom_apepatymat_CheckedChanged(object sender, EventArgs e)
        {
            campo ="usu_apellidopat";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string valor = textBox1.Text;

            dgv_usuarios.DataSource = sad.mostrarusu(campo,valor);

            textBox1.Focus();
        }

        private void dgv_usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int pos = dgv_usuarios.CurrentRow.Index;
            txt_id_usu.Text = dgv_usuarios.CurrentRow.Cells[0].Value.ToString();
            txt_cod_tipusua.Text = dgv_usuarios.CurrentRow.Cells[1].Value.ToString();
            txt_dni.Text = dgv_usuarios.CurrentRow.Cells[2].Value.ToString();
            txt_nombres.Text = dgv_usuarios.CurrentRow.Cells[3].Value.ToString();
            txt_apepat.Text = dgv_usuarios.CurrentRow.Cells[4].Value.ToString();
            txt_apemat.Text = dgv_usuarios.CurrentRow.Cells[5].Value.ToString();
            txt_cel.Text = dgv_usuarios.CurrentRow.Cells[6].Value.ToString();
            txt_domici.Text = dgv_usuarios.CurrentRow.Cells[7].Value.ToString();
            cb_Sexo.Text = dgv_usuarios.CurrentRow.Cells[8].Value.ToString();
            txt_correo.Text = dgv_usuarios.CurrentRow.Cells[9].Value.ToString();
            cb_estadoci.Text = dgv_usuarios.CurrentRow.Cells[10].Value.ToString();
            dp_fenaci.Text = dgv_usuarios.CurrentRow.Cells[11].Value.ToString();
            cb_distritos.Text = dgv_usuarios.CurrentRow.Cells[12].Value.ToString();
            cb_provin.Text = dgv_usuarios.CurrentRow.Cells[13].Value.ToString();
            txt_cod_estausua.Text = dgv_usuarios.CurrentRow.Cells[14].Value.ToString();
            cb_dpto .Text= dgv_usuarios.CurrentRow.Cells[15].Value.ToString();
            txt_contra.Text = dgv_usuarios.CurrentRow.Cells[16].Value.ToString();

            btn_modificar.Enabled =true;
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txt_dni.Enabled = true;
            txt_nombres.Enabled = true;
            txt_apepat.Enabled = true;
            txt_apemat.Enabled = true;
            txt_cel.Enabled = true;
            txt_domici.Enabled = true;
            cb_Sexo.Enabled = true;
            cb_estadoci.Enabled = true;
            dp_fenaci.Enabled = true;
            cb_dpto.Enabled = true;
            cb_provin.Enabled = true;
            cb_distritos.Enabled = true;
            cb_esta_usua.Enabled = true;
            cb_tip_usu.Enabled = true;
            txt_correo.Enabled = true;
            txt_contra.Enabled = true;
            btnnuevo.Enabled = false;
            btn_guardar.Enabled = true;
            btn_limpiar.Enabled = true;
        }
    }
    }

