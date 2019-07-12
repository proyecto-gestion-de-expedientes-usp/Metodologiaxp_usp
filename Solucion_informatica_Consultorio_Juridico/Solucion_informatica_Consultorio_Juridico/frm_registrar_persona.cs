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
    public partial class frm_registrar_persona : Form

    {
        Clases.Validacioes validadcion = new Clases.Validacioes();
        SqlConnection gh;
        DataTable ds = new DataTable();
        DataTable dts = new DataTable();
        DataTable dx = new DataTable();
        Clases.Acceso xd = new Clases.Acceso();
        string campo;
        Clases.Datos sad = new Clases.Datos();
        Clases.Conexion cnn = new Clases.Conexion();
      
        public frm_registrar_persona()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frm_registrar_persona_Load(object sender, EventArgs e)
        {
            gh = new SqlConnection("database=consultoriojur;data source=.;integrated security=true");
            generar_id();
            mostrar();
            mostrar_tipDoc();
           


        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("insertar_Persona", cnn.AbrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@pers_id", SqlDbType.Int);
                cmd.Parameters.Add("@pers_nombres", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@pers_apepat", SqlDbType.VarChar, 25);
                cmd.Parameters.Add("@pers_apemat", SqlDbType.VarChar, 25);
                cmd.Parameters.Add("@pers_ciudad", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@pers_provincia", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@pers_departamento", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@pers_domlegal", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@pers_telefono", SqlDbType.VarChar, 13);
                cmd.Parameters.Add("@pers_email", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@id_tipdoc", SqlDbType.Int);
                cmd.Parameters.Add("@pers_numdoc", SqlDbType.VarChar, 11);
                cmd.Parameters.Add("@pers_fenaci", SqlDbType.Date);

                cmd.Parameters["@pers_id"].Value = txt_id_persoJ.Text;
                cmd.Parameters["@pers_nombres"].Value = txt_nom_persoJ.Text;
                cmd.Parameters["@pers_apepat"].Value = txt_ape_pat;
                cmd.Parameters["@pers_apemat"].Value = txt_ape_mat;
                cmd.Parameters["@pers_ciudad"].Value = cb_distritos_persoJ.Text;
                cmd.Parameters["@pers_provincia"].Value = cb_provin_persoJ.Text;
                cmd.Parameters["@pers_departamento"].Value = cb_dpto_persoJ.Text;
                cmd.Parameters["@pers_domlegal"].Value = txt_domic_persoJ.Text;
                cmd.Parameters["@pers_telefono"].Value = txt_tel_persoJ.Text;
                cmd.Parameters["@pers_email"].Value = txt_email_persoJ.Text;
                cmd.Parameters["@id_tipdoc"].Value = txt_id_Doc_persoJ.Text;
                cmd.Parameters["@pers_numdoc"].Value = txt_ruc_persoJ.Text;
                cmd.Parameters["@pers_fenaci"].Value = dp_cre_persoJ.Text;



                cnn.AbrirConexion();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Los datos fueron insertados correctamente");
                cnn.CerrarConexion();
                generar_id();
               
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


           


        }

        private void dp_fecha_ValueChanged(object sender, EventArgs e)
        {
            campo = "@pers_fenaci";
        }
        public void mostrar()
        {


            dgv_pers.DataSource = sad.mostrar();
            dgv_jurid.DataSource = sad.mostrar();

        }

        private void dp_fenaci_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("actualizar_pers", cnn.AbrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@pers_id", SqlDbType.Int);
                cmd.Parameters.Add("@pers_nombres", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@pers_apepat", SqlDbType.VarChar, 25);
                cmd.Parameters.Add("@pers_apemat", SqlDbType.VarChar, 25);
                cmd.Parameters.Add("@pers_ciudad", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@pers_provincia", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@pers_departamento", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@pers_domlegal", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@pers_telefono", SqlDbType.VarChar, 13);
                cmd.Parameters.Add("@pers_email", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@id_tipdoc", SqlDbType.Int);
                cmd.Parameters.Add("@pers_numdoc", SqlDbType.VarChar, 11);
                cmd.Parameters.Add("@pers_fenaci", SqlDbType.Date);

                cmd.Parameters["@pers_id"].Value = txt_idper.Text;
                cmd.Parameters["@pers_nombres"].Value = txt_nomb.Text;
                cmd.Parameters["@pers_apepat"].Value = txt_ape_pat.Text;
                cmd.Parameters["@pers_apemat"].Value = txt_ape_mat.Text;
                cmd.Parameters["@pers_ciudad"].Value = txt_ciud.Text;
                cmd.Parameters["@pers_provincia"].Value = txt_prov.Text;
                cmd.Parameters["@pers_departamento"].Value = txt_depart.Text;
                cmd.Parameters["@pers_domlegal"].Value = txt_domilega.Text;
                cmd.Parameters["@pers_telefono"].Value = txt_telf.Text;
                cmd.Parameters["@pers_email"].Value = txt_email.Text;
                cmd.Parameters["@id_tipdoc"].Value = txt_id_tip_doc.Text;
                cmd.Parameters["@pers_numdoc"].Value = txt_nro_documento.Text;
                cmd.Parameters["@pers_fenaci"].Value = dp_fenaci.Text;



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

        private void txt_buscar_doc_KeyPress(object sender, KeyPressEventArgs e)
        {
            string valor = txt_buscar_doc.Text;

            dgv_pers.DataSource = xd.buscarpersona(valor);

            txt_buscar_doc.Focus();
        }

        private void txt_nomb_KeyPress(object sender, KeyPressEventArgs e)
        {
            validadcion.soloLetras(e);
        }

        private void txt_ape_pat_KeyPress(object sender, KeyPressEventArgs e)
        {
            validadcion.soloLetras(e);
        }

        private void txt_ape_mat_KeyPress(object sender, KeyPressEventArgs e)
        {
            validadcion.soloLetras(e);
        }

        private void txt_ciud_KeyPress(object sender, KeyPressEventArgs e)
        {
            validadcion.soloLetras(e);
        }

        private void txt_prov_KeyPress(object sender, KeyPressEventArgs e)
        {
            validadcion.soloLetras(e);
        }

        private void txt_depart_KeyPress(object sender, KeyPressEventArgs e)
        {
            validadcion.soloLetras(e);
        }

        private void txt_telf_KeyPress(object sender, KeyPressEventArgs e)
        {
            validadcion.soloNumeros(e);
        }
        public void generar_id()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select isnull(Max(cast(pers_id as int)),0)+1 from Persona", cnn.AbrirConexion());
            DataTable sqlex = new DataTable();
            sda.Fill(sqlex);
            txt_idper.Text = sqlex.Rows[0][0].ToString();
            txt_id_persoJ.Text = sqlex.Rows[0][0].ToString();
        }
        public void mostrar_tipDoc()
        {

            gh.Open();
            string sql = "select * from Tip_documento";
            SqlDataAdapter da = new SqlDataAdapter(sql, gh);
            da.Fill(ds);
            cb_tip_Doc.DataSource = ds;

            cb_tip_Doc.DisplayMember = "tipdoc_nom";
            da.Fill(dx);
            comboBox1.DataSource = dx;

            comboBox1.DisplayMember = "tipdoc_nom";

            gh.Close();
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
        private void txt_email_Leave(object sender, EventArgs e)
        {
            if (Valorreo(txt_email.Text))
            {

            }
            else
            {
                MessageBox.Show("Dirección de correo electrónico no valido, el correo debe tener el formato: nombre@dominio.com, " +
                    " por favor ingrese un correo válido", "Alerta", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                txt_email.SelectAll();
                txt_email.Focus();
            }
        }

        private void txt_nro_documento_KeyPress(object sender, KeyPressEventArgs e)
        {
            validadcion.soloNumeros(e);
        }

        private void txt_nro_documento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nro_documento_Validated(object sender, EventArgs e)
        {
            var cadena = txt_nro_documento.Text;
            if (cadena.Length > 8)
            {
                txt_nro_documento.Focus();
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

        private void txt_buscar_doc_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_guar_perj_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insertar_Persona", cnn.AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@pers_id", SqlDbType.Int);
            cmd.Parameters.Add("@pers_nombres", SqlDbType.VarChar, 20);
            cmd.Parameters.Add("@pers_apepat", SqlDbType.VarChar, 25);
            cmd.Parameters.Add("@pers_apemat", SqlDbType.VarChar, 25);
            cmd.Parameters.Add("@pers_ciudad", SqlDbType.VarChar, 20);
            cmd.Parameters.Add("@pers_provincia", SqlDbType.VarChar, 20);
            cmd.Parameters.Add("@pers_departamento", SqlDbType.VarChar, 20);
            cmd.Parameters.Add("@pers_domlegal", SqlDbType.VarChar, 20);
            cmd.Parameters.Add("@pers_telefono", SqlDbType.VarChar, 13);
            cmd.Parameters.Add("@pers_email", SqlDbType.VarChar, 30);
            cmd.Parameters.Add("@id_tipdoc", SqlDbType.Int);
            cmd.Parameters.Add("@pers_numdoc", SqlDbType.VarChar, 11);
            cmd.Parameters.Add("@pers_fenaci", SqlDbType.Date);

            cmd.Parameters["@pers_id"].Value = txt_id_persoJ.Text;
            cmd.Parameters["@pers_nombres"].Value = txt_nom_persoJ.Text;
            cmd.Parameters["@pers_apepat"].Value = "NULL";
            cmd.Parameters["@pers_apemat"].Value = "NULL";
            cmd.Parameters["@pers_ciudad"].Value = cb_distritos_persoJ.Text;
            cmd.Parameters["@pers_provincia"].Value = cb_provin_persoJ.Text;
            cmd.Parameters["@pers_departamento"].Value = cb_dpto_persoJ.Text;
            cmd.Parameters["@pers_domlegal"].Value = txt_domic_persoJ.Text;
            cmd.Parameters["@pers_telefono"].Value = txt_tel_persoJ.Text;
            cmd.Parameters["@pers_email"].Value = txt_email_persoJ.Text;
            cmd.Parameters["@id_tipdoc"].Value = txt_id_Doc_persoJ.Text;
            cmd.Parameters["@pers_numdoc"].Value = txt_ruc_persoJ.Text;
            cmd.Parameters["@pers_fenaci"].Value = dp_cre_persoJ.Text;



            cnn.AbrirConexion();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Los datos fueron insertados correctamente");
            cnn.CerrarConexion();
            generar_id();
        }

        private void btn_mod_pj_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("actualizar_pers", cnn.AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@pers_id", SqlDbType.Int);
            cmd.Parameters.Add("@pers_nombres", SqlDbType.VarChar, 20);
            cmd.Parameters.Add("@pers_apepat", SqlDbType.VarChar, 25);
            cmd.Parameters.Add("@pers_apemat", SqlDbType.VarChar, 25);
            cmd.Parameters.Add("@pers_ciudad", SqlDbType.VarChar, 20);
            cmd.Parameters.Add("@pers_provincia", SqlDbType.VarChar, 20);
            cmd.Parameters.Add("@pers_departamento", SqlDbType.VarChar, 20);
            cmd.Parameters.Add("@pers_domlegal", SqlDbType.VarChar, 20);
            cmd.Parameters.Add("@pers_telefono", SqlDbType.VarChar, 13);
            cmd.Parameters.Add("@pers_email", SqlDbType.VarChar, 30);
            cmd.Parameters.Add("@id_tipdoc", SqlDbType.Int);
            cmd.Parameters.Add("@pers_numdoc", SqlDbType.VarChar, 11);
            cmd.Parameters.Add("@pers_fenaci", SqlDbType.Date);

            cmd.Parameters["@pers_id"].Value = txt_id_persoJ.Text;
            cmd.Parameters["@pers_nombres"].Value = txt_nom_persoJ.Text;
            cmd.Parameters["@pers_apepat"].Value = "NULL";
            cmd.Parameters["@pers_apemat"].Value = "NULL";
            cmd.Parameters["@pers_ciudad"].Value = cb_distritos_persoJ.Text;
            cmd.Parameters["@pers_provincia"].Value = cb_provin_persoJ.Text;
            cmd.Parameters["@pers_departamento"].Value = cb_dpto_persoJ.Text;
            cmd.Parameters["@pers_domlegal"].Value = txt_domic_persoJ.Text;
            cmd.Parameters["@pers_telefono"].Value = txt_tel_persoJ.Text;
            cmd.Parameters["@pers_email"].Value = txt_email_persoJ.Text;
            cmd.Parameters["@id_tipdoc"].Value = txt_id_Doc_persoJ.Text;
            cmd.Parameters["@pers_numdoc"].Value = txt_ruc_persoJ.Text;
            cmd.Parameters["@pers_fenaci"].Value = dp_cre_persoJ.Text;



            cnn.AbrirConexion();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Los datos fueron insertados correctamente");
            cnn.CerrarConexion();
            generar_id();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void txt_ruc_bus_KeyPress(object sender, KeyPressEventArgs e)
        {
            string valor = txt_ruc_bus.Text;
            dgv_jurid.DataSource = xd.buscarpersona(valor);
            txt_ruc_bus.Focus();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = comboBox1.SelectedIndex;
            txt_id_Doc_persoJ.Text = dx.Rows[a]["id_tipdoc"].ToString();
        }

        private void cb_tip_Doc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = cb_tip_Doc.SelectedIndex;
            txt_id_tip_doc.Text = ds.Rows[a]["id_tipdoc"].ToString();
        }
    }
}
