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
           
            generar_id();
            mostrar();
            mostrar_tipDoc();
            llenar_dpto();
            //llenar_dptopj();


        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            cb_tip_Doc.Enabled = false;
            txt_nomb.Enabled = false;
            txt_ape_pat.Enabled = false;
            txt_ape_mat.Enabled = false;
            cb_dpto.Enabled = false;
            cb_pro.Enabled = false;
            cb_distr.Enabled = false;
            txt_domilega.Enabled = false;
            txt_telf.Enabled = false;
            txt_email.Enabled = false;
            txt_nro_documento.Enabled = false;
            btn_guardar.Enabled = false;
            btnnuevo.Enabled = true;
            try
            {

                SqlCommand cmd = new SqlCommand("insertar_Persona", cnn.AbrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.Add("@pers_id", SqlDbType.Int);
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
                cmd.Parameters.Add("@pers_numdoc", SqlDbType.Char, 12);
                cmd.Parameters.Add("@pers_fenaci", SqlDbType.Date);

                //cmd.Parameters["@pers_id"].Value = txt_idper.Text;
                cmd.Parameters["@pers_nombres"].Value = txt_nomb.Text;
                cmd.Parameters["@pers_apepat"].Value = txt_ape_pat.Text;
                cmd.Parameters["@pers_apemat"].Value = txt_ape_mat.Text;
                cmd.Parameters["@pers_ciudad"].Value = cb_distr.Text;
                cmd.Parameters["@pers_provincia"].Value = cb_pro.Text;
                cmd.Parameters["@pers_departamento"].Value = cb_dpto.Text;
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
            //dgv_jurid.DataSource = sad.mostrar();

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
                cmd.Parameters.Add("@pers_numdoc", SqlDbType.Char, 12);
                cmd.Parameters.Add("@pers_fenaci", SqlDbType.Date);

                cmd.Parameters["@pers_id"].Value = txt_idper.Text;
                cmd.Parameters["@pers_nombres"].Value = txt_nomb.Text;
                cmd.Parameters["@pers_apepat"].Value = txt_ape_pat.Text;
                cmd.Parameters["@pers_apemat"].Value = txt_ape_mat.Text;
                cmd.Parameters["@pers_ciudad"].Value = cb_distr.Text;
                cmd.Parameters["@pers_provincia"].Value = cb_pro.Text;
                cmd.Parameters["@pers_departamento"].Value = cb_dpto.Text;
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
            //txt_id_persoJ.Text = sqlex.Rows[0][0].ToString();
        }
        public void mostrar_tipDoc()
        {

            cnn.AbrirConexion();
            string sql = "select * from Tip_documento";
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn.AbrirConexion());
            da.Fill(ds);
            cb_tip_Doc.DataSource = ds;

            cb_tip_Doc.DisplayMember = "tipdoc_nom";
            da.Fill(dx);
            //comboBox1.DataSource = dx;

            //comboBox1.DisplayMember = "tipdoc_nom";

            cnn.CerrarConexion();
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
            //SqlCommand cmd = new SqlCommand("insertar_Persona", cnn.AbrirConexion());
            //cmd.CommandType = CommandType.StoredProcedure;
            ////cmd.Parameters.Add("@pers_id", SqlDbType.Int);
            //cmd.Parameters.Add("@pers_nombres", SqlDbType.VarChar, 20);
            //cmd.Parameters.Add("@pers_apepat", SqlDbType.VarChar, 25);
            //cmd.Parameters.Add("@pers_apemat", SqlDbType.VarChar, 25);
            //cmd.Parameters.Add("@pers_ciudad", SqlDbType.VarChar, 20);
            //cmd.Parameters.Add("@pers_provincia", SqlDbType.VarChar, 20);
            //cmd.Parameters.Add("@pers_departamento", SqlDbType.VarChar, 20); 
            //cmd.Parameters.Add("@pers_domlegal", SqlDbType.VarChar, 20);
            //cmd.Parameters.Add("@pers_telefono", SqlDbType.VarChar, 13);
            //cmd.Parameters.Add("@pers_email", SqlDbType.VarChar, 30);
            //cmd.Parameters.Add("@id_tipdoc", SqlDbType.Int);
            //cmd.Parameters.Add("@pers_numdoc", SqlDbType.Char, 12);
            //cmd.Parameters.Add("@pers_fenaci", SqlDbType.Date);

            ////cmd.Parameters["@pers_id"].Value = txt_id_persoJ.Text;
            //cmd.Parameters["@pers_nombres"].Value = txt_nom_persoJ.Text;
            //cmd.Parameters["@pers_apepat"].Value = "NULL";
            //cmd.Parameters["@pers_apemat"].Value = "NULL";
            //cmd.Parameters["@pers_ciudad"].Value = cb_distritos_persoJ.Text;
            //cmd.Parameters["@pers_provincia"].Value = cb_provin_persoJ.Text;
            //cmd.Parameters["@pers_departamento"].Value = cb_dpto_persoJ.Text;
            //cmd.Parameters["@pers_domlegal"].Value = txt_domic_persoJ.Text;
            //cmd.Parameters["@pers_telefono"].Value = txt_tel_persoJ.Text;
            //cmd.Parameters["@pers_email"].Value = txt_email_persoJ.Text;
            //cmd.Parameters["@id_tipdoc"].Value = txt_id_Doc_persoJ.Text;
            //cmd.Parameters["@pers_numdoc"].Value = txt_ruc_persoJ.Text;
            //cmd.Parameters["@pers_fenaci"].Value = dp_cre_persoJ.Text;



            //cnn.AbrirConexion();
            //cmd.ExecuteNonQuery();
            //MessageBox.Show("Los datos fueron insertados correctamente");
            //cnn.CerrarConexion();
            //generar_id();
        }

        private void btn_mod_pj_Click(object sender, EventArgs e)
        {
            //SqlCommand cmd = new SqlCommand("actualizar_pers", cnn.AbrirConexion());
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@pers_id", SqlDbType.Int);
            //cmd.Parameters.Add("@pers_nombres", SqlDbType.VarChar, 20);
            //cmd.Parameters.Add("@pers_apepat", SqlDbType.VarChar, 25);
            //cmd.Parameters.Add("@pers_apemat", SqlDbType.VarChar, 25);
            //cmd.Parameters.Add("@pers_ciudad", SqlDbType.VarChar, 20);
            //cmd.Parameters.Add("@pers_provincia", SqlDbType.VarChar, 20);
            //cmd.Parameters.Add("@pers_departamento", SqlDbType.VarChar, 20);
            //cmd.Parameters.Add("@pers_domlegal", SqlDbType.VarChar, 20);
            //cmd.Parameters.Add("@pers_telefono", SqlDbType.VarChar, 13);
            //cmd.Parameters.Add("@pers_email", SqlDbType.VarChar, 30);
            //cmd.Parameters.Add("@id_tipdoc", SqlDbType.Int);
            //cmd.Parameters.Add("@pers_numdoc", SqlDbType.Char, 12);
            //cmd.Parameters.Add("@pers_fenaci", SqlDbType.Date);

            //cmd.Parameters["@pers_id"].Value = txt_id_persoJ.Text;
            //cmd.Parameters["@pers_nombres"].Value = txt_nom_persoJ.Text;
            //cmd.Parameters["@pers_apepat"].Value = "NULL";
            //cmd.Parameters["@pers_apemat"].Value = "NULL";
            //cmd.Parameters["@pers_ciudad"].Value = cb_distritos_persoJ.Text;
            //cmd.Parameters["@pers_provincia"].Value = cb_provin_persoJ.Text;
            //cmd.Parameters["@pers_departamento"].Value = cb_dpto_persoJ.Text;
            //cmd.Parameters["@pers_domlegal"].Value = txt_domic_persoJ.Text;
            //cmd.Parameters["@pers_telefono"].Value = txt_tel_persoJ.Text;
            //cmd.Parameters["@pers_email"].Value = txt_email_persoJ.Text;
            //cmd.Parameters["@id_tipdoc"].Value = txt_id_Doc_persoJ.Text;
            //cmd.Parameters["@pers_numdoc"].Value = txt_ruc_persoJ.Text;
            //cmd.Parameters["@pers_fenaci"].Value = dp_cre_persoJ.Text;



            //cnn.AbrirConexion();
            //cmd.ExecuteNonQuery();
            //MessageBox.Show("Los datos fueron insertados correctamente");
            //cnn.CerrarConexion();
            //generar_id();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void txt_ruc_bus_KeyPress(object sender, KeyPressEventArgs e)
        {
            //string valor = txt_ruc_bus.Text;
            //dgv_jurid.DataSource = xd.buscarpersona(valor);
            //txt_ruc_bus.Focus();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int a = comboBox1.SelectedIndex;
            //txt_id_Doc_persoJ.Text = dx.Rows[a]["id_tipdoc"].ToString();
        }

        private void cb_tip_Doc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = cb_tip_Doc.SelectedIndex;
            txt_id_tip_doc.Text = ds.Rows[a]["id_tipdoc"].ToString();
        }

        //public void llenar_dptopj()
        //{
        //    cb_dpto_persoJ.Items.Add("Amazonas");
        //    cb_dpto_persoJ.Items.Add("Áncash");
        //    cb_dpto_persoJ.Items.Add("Apurímac");
        //    cb_dpto_persoJ.Items.Add("Arequipa");
        //    cb_dpto_persoJ.Items.Add("Ayacucho");
        //    cb_dpto_persoJ.Items.Add("Cajamarca");
        //    cb_dpto_persoJ.Items.Add("Callao");
        //    cb_dpto_persoJ.Items.Add("Cuzco");
        //    cb_dpto_persoJ.Items.Add("Huancavelica");
        //    cb_dpto_persoJ.Items.Add("Huánuco");
        //    cb_dpto_persoJ.Items.Add("Ica");
        //    cb_dpto_persoJ.Items.Add("Junín");
        //    cb_dpto_persoJ.Items.Add("La Libertad");
        //    cb_dpto_persoJ.Items.Add("Lambayeque");
        //    cb_dpto_persoJ.Items.Add("Lima");
        //    cb_dpto_persoJ.Items.Add("Loreto");
        //    cb_dpto_persoJ.Items.Add("Madre de Dios");
        //    cb_dpto_persoJ.Items.Add("Moquegua");
        //    cb_dpto_persoJ.Items.Add("Pasco");
        //    cb_dpto_persoJ.Items.Add("Piura");
        //    cb_dpto_persoJ.Items.Add("Puno");
        //    cb_dpto_persoJ.Items.Add("San Martín");
        //    cb_dpto_persoJ.Items.Add("Tacna");
        //    cb_dpto_persoJ.Items.Add("Tumbes");
        //    cb_dpto_persoJ.Items.Add("Ucayali");
        //}
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

        private void cb_pro_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cb_dpto_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cb_dpto.SelectedItem.Equals("Amazonas"))
            //{
            //    cb_pro.Items.Clear();
            //    cb_pro.Items.Add("Chachapoyas");
            //    cb_pro.Items.Add("Bagua");
            //    cb_pro.Items.Add("Bongara");
            //    cb_pro.Items.Add("Condorcanqui");
            //    cb_pro.Items.Add("Luya");
            //    cb_pro.Items.Add("Rodríguez de Mendoza");
            //    cb_pro.Items.Add("Utcubamba");

            //}
            //if (cb_dpto.SelectedItem.Equals("Áncash"))
            //{
            //    cb_pro.Items.Clear();
            //    cb_pro.Items.Add("Huaraz");
            //    cb_pro.Items.Add("Aija");
            //    cb_pro.Items.Add("Antonio raymondi");
            //    cb_pro.Items.Add("Asunción");
            //    cb_pro.Items.Add("Bolognesi");
            //    cb_pro.Items.Add("Carhuaz");
            //    cb_pro.Items.Add("Carlos Fermín Fitzcarrald");
            //    cb_pro.Items.Add("Casma");
            //    cb_pro.Items.Add("Corongo");
            //    cb_pro.Items.Add("Huari");
            //    cb_pro.Items.Add("Huarmey");
            //    cb_pro.Items.Add("Huaylas");
            //    cb_pro.Items.Add("Mariscal Luzuriaga");
            //    cb_pro.Items.Add("Ocros");
            //    cb_pro.Items.Add("Pallasca");
            //    cb_pro.Items.Add("Pomabamba");
            //    cb_pro.Items.Add("Recuay");
            //    cb_pro.Items.Add("Santa");
            //    cb_pro.Items.Add("Sihuas");
            //    cb_pro.Items.Add("Yungay");




            //}
            //if (cb_dpto.SelectedItem.Equals("Apurímac"))
            //{
            //    cb_pro.Items.Clear();

            //    cb_pro.Items.Add("Abancay");
            //    cb_pro.Items.Add("Andahuaylas");
            //    cb_pro.Items.Add("Antabamba");
            //    cb_pro.Items.Add("Aymaraes");
            //    cb_pro.Items.Add("Cotabambas");
            //    cb_pro.Items.Add("Chincheros");
            //    cb_pro.Items.Add("Grau");
            //}
            //if (cb_dpto.SelectedItem.Equals("Arequipa"))
            //{

            //    cb_pro.Items.Clear();
            //    cb_pro.Items.Add("Arequipa");
            //    cb_pro.Items.Add("Camana");
            //    cb_pro.Items.Add("Caraveli");
            //    cb_pro.Items.Add("Caylloma");
            //    cb_pro.Items.Add("Condesuyos");
            //    cb_pro.Items.Add("Islay");
            //    cb_pro.Items.Add("La unión");

            //}
            //if (cb_dpto.SelectedItem.Equals("Ayacucho"))
            //{

            //    cb_pro.Items.Clear();
            //    cb_pro.Items.Add("Huamanga");
            //    cb_pro.Items.Add("Cangallo");
            //    cb_pro.Items.Add("Huanca sancos");
            //    cb_pro.Items.Add("Huanta");
            //    cb_pro.Items.Add("La Mar");
            //    cb_pro.Items.Add("Lucanas");
            //    cb_pro.Items.Add("Parinacochas");
            //    cb_pro.Items.Add("Páucar del Sara Sara");
            //    cb_pro.Items.Add("Víctor Fajardo");
            //    cb_pro.Items.Add("Vilcas Huaman");
            //    cb_pro.Items.Add("Parinacochas");

            //}
        }

        private void cb_dpto_persoJ_SelectedIndexChanged(object sender, EventArgs e)
        {
            ////////if (cb_dpto_persoJ.SelectedItem.Equals("Amazonas"))
            ////////{
            ////////    cb_provin_persoJ.Items.Clear();
            ////////    cb_provin_persoJ.Items.Add("Chachapoyas");
            ////////    cb_provin_persoJ.Items.Add("Bagua");
            ////////    cb_provin_persoJ.Items.Add("Bongara");
            ////////    cb_provin_persoJ.Items.Add("Condorcanqui");
            ////////    cb_provin_persoJ.Items.Add("Luya");
            ////////    cb_provin_persoJ.Items.Add("Rodríguez de Mendoza");
            ////////    cb_provin_persoJ.Items.Add("Utcubamba");

            ////////}
            ////////if (cb_dpto_persoJ.SelectedItem.Equals("Áncash"))
            ////////{
            ////////    cb_provin_persoJ.Items.Clear();
            ////////    cb_provin_persoJ.Items.Add("Huaraz");
            ////////    cb_provin_persoJ.Items.Add("Aija");
            ////////    cb_provin_persoJ.Items.Add("Antonio raymondi");
            ////////    cb_provin_persoJ.Items.Add("Asunción");
            ////////    cb_provin_persoJ.Items.Add("Bolognesi");
            ////////    cb_provin_persoJ.Items.Add("Carhuaz");
            ////////    cb_provin_persoJ.Items.Add("Carlos Fermín Fitzcarrald");
            ////////    cb_provin_persoJ.Items.Add("Casma");
            ////////    cb_provin_persoJ.Items.Add("Corongo");
            ////////    cb_provin_persoJ.Items.Add("Huari");
            ////////    cb_provin_persoJ.Items.Add("Huarmey");
            ////////    cb_provin_persoJ.Items.Add("Huaylas");
            ////////    cb_provin_persoJ.Items.Add("Mariscal Luzuriaga");
            ////////    cb_provin_persoJ.Items.Add("Ocros");
            ////////    cb_provin_persoJ.Items.Add("Pallasca");
            ////////    cb_provin_persoJ.Items.Add("Pomabamba");
            ////////    cb_provin_persoJ.Items.Add("Recuay");
            ////////    cb_provin_persoJ.Items.Add("Santa");
            ////////    cb_provin_persoJ.Items.Add("Sihuas");
            ////////    cb_provin_persoJ.Items.Add("Yungay");




            ////////}
            ////////if (cb_dpto_persoJ.SelectedItem.Equals("Apurímac"))
            ////////{
            ////////    cb_provin_persoJ.Items.Clear();

            ////////    cb_provin_persoJ.Items.Add("Abancay");
            ////////    cb_provin_persoJ.Items.Add("Andahuaylas");
            ////////    cb_provin_persoJ.Items.Add("Antabamba");
            ////////    cb_provin_persoJ.Items.Add("Aymaraes");
            ////////    cb_provin_persoJ.Items.Add("Cotabambas");
            ////////    cb_provin_persoJ.Items.Add("Chincheros");
            ////////    cb_provin_persoJ.Items.Add("Grau");
            ////////}
            ////////if (cb_dpto_persoJ.SelectedItem.Equals("Arequipa"))
            ////////{

            ////////    cb_provin_persoJ.Items.Clear();
            ////////    cb_provin_persoJ.Items.Add("Arequipa");
            ////////    cb_provin_persoJ.Items.Add("Camana");
            ////////    cb_provin_persoJ.Items.Add("Caraveli");
            ////////    cb_provin_persoJ.Items.Add("Caylloma");
            ////////    cb_provin_persoJ.Items.Add("Condesuyos");
            ////////    cb_provin_persoJ.Items.Add("Islay");
            ////////    cb_provin_persoJ.Items.Add("La unión");

            ////////}
            ////////if (cb_dpto_persoJ.SelectedItem.Equals("Ayacucho"))
            ////////{

            ////////    cb_provin_persoJ.Items.Clear();
            ////////    cb_provin_persoJ.Items.Add("Huamanga");
            ////////    cb_provin_persoJ.Items.Add("Cangallo");
            ////////    cb_provin_persoJ.Items.Add("Huanca sancos");
            ////////    cb_provin_persoJ.Items.Add("Huanta");
            ////////    cb_provin_persoJ.Items.Add("La Mar");
            ////////    cb_provin_persoJ.Items.Add("Lucanas");
            ////////    cb_provin_persoJ.Items.Add("Parinacochas");
            ////////    cb_provin_persoJ.Items.Add("Páucar del Sara Sara");
            ////////    cb_provin_persoJ.Items.Add("Víctor Fajardo");
            ////////    cb_provin_persoJ.Items.Add("Vilcas Huaman");
            ////////    cb_provin_persoJ.Items.Add("Parinacochas");

            ////////}
        }

        private void cb_provin_persoJ_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cb_provin_persoJ.SelectedItem.Equals("Santa"))
            //{
            //    cb_distritos_persoJ.Items.Clear();
            //    cb_distritos_persoJ.Items.Add("Cáceres Del Perú");
            //    cb_distritos_persoJ.Items.Add("Chimbote");
            //    cb_distritos_persoJ.Items.Add("Coishco");
            //    cb_distritos_persoJ.Items.Add("Macate");
            //    cb_distritos_persoJ.Items.Add("Moro");
            //    cb_distritos_persoJ.Items.Add("Nepeña");
            //    cb_distritos_persoJ.Items.Add("Nuevo Chimbote");
            //    cb_distritos_persoJ.Items.Add("Samanco");
            //    cb_distritos_persoJ.Items.Add("Santa");

            //}
        }

        private void txt_email_persoJ_Leave(object sender, EventArgs e)
        {
            //if (Valorreo(txt_email_persoJ.Text))
            //{

            //}
            //else
            //{
            //    MessageBox.Show("Dirección de correo electrónico no valido, el correo debe tener el formato: nombre@dominio.com, " +
            //        " por favor ingrese un correo válido", "Alerta", MessageBoxButtons.OK,
            //        MessageBoxIcon.Exclamation);
            //    txt_email_persoJ.SelectAll();
            //    txt_email_persoJ.Focus();
            //}
        }

        private void txt_ruc_persoJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            validadcion.soloNumeros(e);
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_nomb.Text = "";
            txt_ape_pat.Text = "";
            txt_ape_mat.Text = "";
            txt_domilega.Text = "";
            txt_telf.Text = "";
            txt_email.Text = "";
           
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            
        }

        private void btnnuevo_Click_1(object sender, EventArgs e)
        {
            cb_tip_Doc.Enabled = true;
            txt_nomb.Enabled = true;
            txt_ape_pat.Enabled = true;
            txt_ape_mat.Enabled = true;
            cb_dpto.Enabled = true;
            cb_pro.Enabled = true;
            cb_distr.Enabled = true;
            txt_domilega.Enabled = true;
            txt_telf.Enabled = true;
            txt_email.Enabled = true;
            txt_nro_documento.Enabled = true;
            btn_guardar.Enabled = true;
            btnnuevo.Enabled = false;
        }

        private void cb_pro_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cb_pro.SelectedItem.Equals("Santa"))
            {
                cb_distr.Items.Clear();
                cb_distr.Items.Add("Cáceres Del Perú");
                cb_distr.Items.Add("Chimbote");
                cb_distr.Items.Add("Coishco");
                cb_distr.Items.Add("Macate");
                cb_distr.Items.Add("Moro");
                cb_distr.Items.Add("Nepeña");
                cb_distr.Items.Add("Nuevo Chimbote");
                cb_distr.Items.Add("Samanco");
                cb_distr.Items.Add("Santa");

            }
        }

        private void cb_dpto_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cb_dpto.SelectedItem.Equals("Amazonas"))
            {
                cb_pro.Items.Clear();
                cb_pro.Items.Add("Chachapoyas");
                cb_pro.Items.Add("Bagua");
                cb_pro.Items.Add("Bongara");
                cb_pro.Items.Add("Condorcanqui");
                cb_pro.Items.Add("Luya");
                cb_pro.Items.Add("Rodríguez de Mendoza");
                cb_pro.Items.Add("Utcubamba");

            }
            if (cb_dpto.SelectedItem.Equals("Áncash"))
            {
                cb_pro.Items.Clear();
                cb_pro.Items.Add("Huaraz");
                cb_pro.Items.Add("Aija");
                cb_pro.Items.Add("Antonio raymondi");
                cb_pro.Items.Add("Asunción");
                cb_pro.Items.Add("Bolognesi");
                cb_pro.Items.Add("Carhuaz");
                cb_pro.Items.Add("Carlos Fermín Fitzcarrald");
                cb_pro.Items.Add("Casma");
                cb_pro.Items.Add("Corongo");
                cb_pro.Items.Add("Huari");
                cb_pro.Items.Add("Huarmey");
                cb_pro.Items.Add("Huaylas");
                cb_pro.Items.Add("Mariscal Luzuriaga");
                cb_pro.Items.Add("Ocros");
                cb_pro.Items.Add("Pallasca");
                cb_pro.Items.Add("Pomabamba");
                cb_pro.Items.Add("Recuay");
                cb_pro.Items.Add("Santa");
                cb_pro.Items.Add("Sihuas");
                cb_pro.Items.Add("Yungay");




            }
            if (cb_dpto.SelectedItem.Equals("Apurímac"))
            {
                cb_pro.Items.Clear();

                cb_pro.Items.Add("Abancay");
                cb_pro.Items.Add("Andahuaylas");
                cb_pro.Items.Add("Antabamba");
                cb_pro.Items.Add("Aymaraes");
                cb_pro.Items.Add("Cotabambas");
                cb_pro.Items.Add("Chincheros");
                cb_pro.Items.Add("Grau");
            }
            if (cb_dpto.SelectedItem.Equals("Arequipa"))
            {

                cb_pro.Items.Clear();
                cb_pro.Items.Add("Arequipa");
                cb_pro.Items.Add("Camana");
                cb_pro.Items.Add("Caraveli");
                cb_pro.Items.Add("Caylloma");
                cb_pro.Items.Add("Condesuyos");
                cb_pro.Items.Add("Islay");
                cb_pro.Items.Add("La unión");

            }
            if (cb_dpto.SelectedItem.Equals("Ayacucho"))
            {

                cb_pro.Items.Clear();
                cb_pro.Items.Add("Huamanga");
                cb_pro.Items.Add("Cangallo");
                cb_pro.Items.Add("Huanca sancos");
                cb_pro.Items.Add("Huanta");
                cb_pro.Items.Add("La Mar");
                cb_pro.Items.Add("Lucanas");
                cb_pro.Items.Add("Parinacochas");
                cb_pro.Items.Add("Páucar del Sara Sara");
                cb_pro.Items.Add("Víctor Fajardo");
                cb_pro.Items.Add("Vilcas Huaman");
                cb_pro.Items.Add("Parinacochas");

            }
        }

        private void cb_distr_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_nomb_KeyPress_1(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_nomb_TextChanged(object sender, EventArgs e)
        {
            var cadena = txt_nro_documento.Text;
            if (cadena.Length == 3)
            {
                
                MessageBox.Show("ingrese nombre completo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_nro_documento.Focus();

               
            }
            else
            {
                if (cadena.Length < 21)
                {
                    MessageBox.Show("alacanzo el maximo de caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
