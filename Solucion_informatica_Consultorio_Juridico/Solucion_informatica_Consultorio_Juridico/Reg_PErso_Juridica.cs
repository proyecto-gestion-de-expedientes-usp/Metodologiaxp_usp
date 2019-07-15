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
    }
}
