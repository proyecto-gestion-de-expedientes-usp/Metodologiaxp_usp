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
    public partial class Reg_PErso_Juridica : Form
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
        public Reg_PErso_Juridica()
        {
            InitializeComponent();
        }

        private void Reg_PErso_Juridica_Load(object sender, EventArgs e)
        {
            llenar_dpto();
        }
        public void llenar_dpto()
        {
            cb_dpto_persoJ.Items.Add("Amazonas");
            cb_dpto_persoJ.Items.Add("Áncash");
            cb_dpto_persoJ.Items.Add("Apurímac");
            cb_dpto_persoJ.Items.Add("Arequipa");
            cb_dpto_persoJ.Items.Add("Ayacucho");
            cb_dpto_persoJ.Items.Add("Cajamarca");
            cb_dpto_persoJ.Items.Add("Callao");
            cb_dpto_persoJ.Items.Add("Cuzco");
            cb_dpto_persoJ.Items.Add("Huancavelica");
            cb_dpto_persoJ.Items.Add("Huánuco");
            cb_dpto_persoJ.Items.Add("Ica");
            cb_dpto_persoJ.Items.Add("Junín");
            cb_dpto_persoJ.Items.Add("La Libertad");
            cb_dpto_persoJ.Items.Add("Lambayeque");
            cb_dpto_persoJ.Items.Add("Lima");
            cb_dpto_persoJ.Items.Add("Loreto");
            cb_dpto_persoJ.Items.Add("Madre de Dios");
            cb_dpto_persoJ.Items.Add("Moquegua");
            cb_dpto_persoJ.Items.Add("Pasco");
            cb_dpto_persoJ.Items.Add("Piura");
            cb_dpto_persoJ.Items.Add("Puno");
            cb_dpto_persoJ.Items.Add("San Martín");
            cb_dpto_persoJ.Items.Add("Tacna");
            cb_dpto_persoJ.Items.Add("Tumbes");
            cb_dpto_persoJ.Items.Add("Ucayali");
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btn_guar_perj_Click(object sender, EventArgs e)
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

            //cmd.Parameters["@pers_id"].Value = txt_id_persoJ.Text;
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
            cmd.Parameters.Add("@pers_numdoc", SqlDbType.Char, 12);
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
        public void generar_id()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select isnull(Max(cast(pers_id as int)),0)+1 from Persona", cnn.AbrirConexion());
            DataTable sqlex = new DataTable();
            sda.Fill(sqlex);
           
            txt_id_persoJ.Text = sqlex.Rows[0][0].ToString();
        }

        private void cb_dpto_persoJ_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_dpto_persoJ.SelectedItem.Equals("Amazonas"))
            {
                cb_provin_persoJ.Items.Clear();
                cb_provin_persoJ.Items.Add("Chachapoyas");
                cb_provin_persoJ.Items.Add("Bagua");
                cb_provin_persoJ.Items.Add("Bongara");
                cb_provin_persoJ.Items.Add("Condorcanqui");
                cb_provin_persoJ.Items.Add("Luya");
                cb_provin_persoJ.Items.Add("Rodríguez de Mendoza");
                cb_provin_persoJ.Items.Add("Utcubamba");

            }
            if (cb_dpto_persoJ.SelectedItem.Equals("Áncash"))
            {
                cb_provin_persoJ.Items.Clear();
                cb_provin_persoJ.Items.Add("Huaraz");
                cb_provin_persoJ.Items.Add("Aija");
                cb_provin_persoJ.Items.Add("Antonio raymondi");
                cb_provin_persoJ.Items.Add("Asunción");
                cb_provin_persoJ.Items.Add("Bolognesi");
                cb_provin_persoJ.Items.Add("Carhuaz");
                cb_provin_persoJ.Items.Add("Carlos Fermín Fitzcarrald");
                cb_provin_persoJ.Items.Add("Casma");
                cb_provin_persoJ.Items.Add("Corongo");
                cb_provin_persoJ.Items.Add("Huari");
                cb_provin_persoJ.Items.Add("Huarmey");
                cb_provin_persoJ.Items.Add("Huaylas");
                cb_provin_persoJ.Items.Add("Mariscal Luzuriaga");
                cb_provin_persoJ.Items.Add("Ocros");
                cb_provin_persoJ.Items.Add("Pallasca");
                cb_provin_persoJ.Items.Add("Pomabamba");
                cb_provin_persoJ.Items.Add("Recuay");
                cb_provin_persoJ.Items.Add("Santa");
                cb_provin_persoJ.Items.Add("Sihuas");
                cb_provin_persoJ.Items.Add("Yungay");




            }
            if (cb_dpto_persoJ.SelectedItem.Equals("Apurímac"))
            {
                cb_provin_persoJ.Items.Clear();

                cb_provin_persoJ.Items.Add("Abancay");
                cb_provin_persoJ.Items.Add("Andahuaylas");
                cb_provin_persoJ.Items.Add("Antabamba");
                cb_provin_persoJ.Items.Add("Aymaraes");
                cb_provin_persoJ.Items.Add("Cotabambas");
                cb_provin_persoJ.Items.Add("Chincheros");
                cb_provin_persoJ.Items.Add("Grau");
            }
            if (cb_dpto_persoJ.SelectedItem.Equals("Arequipa"))
            {

                cb_provin_persoJ.Items.Clear();
                cb_provin_persoJ.Items.Add("Arequipa");
                cb_provin_persoJ.Items.Add("Camana");
                cb_provin_persoJ.Items.Add("Caraveli");
                cb_provin_persoJ.Items.Add("Caylloma");
                cb_provin_persoJ.Items.Add("Condesuyos");
                cb_provin_persoJ.Items.Add("Islay");
                cb_provin_persoJ.Items.Add("La unión");

            }
            if (cb_dpto_persoJ.SelectedItem.Equals("Ayacucho"))
            {

                cb_provin_persoJ.Items.Clear();
                cb_provin_persoJ.Items.Add("Huamanga");
                cb_provin_persoJ.Items.Add("Cangallo");
                cb_provin_persoJ.Items.Add("Huanca sancos");
                cb_provin_persoJ.Items.Add("Huanta");
                cb_provin_persoJ.Items.Add("La Mar");
                cb_provin_persoJ.Items.Add("Lucanas");
                cb_provin_persoJ.Items.Add("Parinacochas");
                cb_provin_persoJ.Items.Add("Páucar del Sara Sara");
                cb_provin_persoJ.Items.Add("Víctor Fajardo");
                cb_provin_persoJ.Items.Add("Vilcas Huaman");
                cb_provin_persoJ.Items.Add("Parinacochas");

            }
        }

        private void cb_distritos_persoJ_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cb_provin_persoJ_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_provin_persoJ.SelectedItem.Equals("Santa"))
            {
                cb_distritos_persoJ.Items.Clear();
                cb_distritos_persoJ.Items.Add("Cáceres Del Perú");
                cb_distritos_persoJ.Items.Add("Chimbote");
                cb_distritos_persoJ.Items.Add("Coishco");
                cb_distritos_persoJ.Items.Add("Macate");
                cb_distritos_persoJ.Items.Add("Moro");
                cb_distritos_persoJ.Items.Add("Nepeña");
                cb_distritos_persoJ.Items.Add("Nuevo Chimbote");
                cb_distritos_persoJ.Items.Add("Samanco");
                cb_distritos_persoJ.Items.Add("Santa");

            }
        }
    }
}
