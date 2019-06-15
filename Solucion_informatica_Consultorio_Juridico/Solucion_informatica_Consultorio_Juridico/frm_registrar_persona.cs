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
    public partial class frm_registrar_persona : Form
    {
        string campo;
        Clases.Datos sad = new Clases.Datos();
        SqlConnection cnn = new SqlConnection("database = consultoriojur; data source =.; integrated security = sspi");
        public frm_registrar_persona()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frm_registrar_persona_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select isnull(Max(cast(pers_id as int)),0)+1 from Persona", cnn);
            DataTable sqlex = new DataTable();
            sda.Fill(sqlex);
            txt_idper.Text = sqlex.Rows[0][0].ToString();
            mostrar();
            
           
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                string ConnectionString = "database=consultoriojur;data source=.;integrated security=sspi";
                SqlConnection cnn = new SqlConnection(ConnectionString);
                SqlCommand cmd = new SqlCommand("insertar_Persona", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@pers_id", SqlDbType.Int);
                cmd.Parameters.Add("@pers_nombres", SqlDbType.VarChar,20);
                cmd.Parameters.Add("@pers_apepat", SqlDbType.VarChar, 25);
                cmd.Parameters.Add("@pers_apemat", SqlDbType.VarChar, 25);
                cmd.Parameters.Add("@pers_ciudad", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@pers_provincia", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@pers_departamento", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@pers_ubigeo", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@pers_domlegal", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@pers_telefono", SqlDbType.VarChar, 13);
                cmd.Parameters.Add("@pers_email", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@id_tipdoc", SqlDbType.Int);
                cmd.Parameters.Add("@pers_numdoc", SqlDbType.Decimal);
                cmd.Parameters.Add("@pers_fenaci", SqlDbType.Date);
                
                cmd.Parameters["@pers_id"].Value = txt_idper.Text;
                cmd.Parameters["@pers_nombres"].Value = txt_nomb.Text;
                cmd.Parameters["@pers_apepat"].Value = txt_ape_pat.Text;
                cmd.Parameters["@pers_apemat"].Value = txt_ape_mat.Text;
                cmd.Parameters["@pers_ciudad"].Value = txt_ciud.Text;
                cmd.Parameters["@pers_provincia"].Value = txt_prov.Text;
                cmd.Parameters["@pers_departamento"].Value = txt_depart.Text;
                cmd.Parameters["@pers_ubigeo"].Value = txt_ubigeo.Text;
                cmd.Parameters["@pers_domlegal"].Value = txt_domilega.Text;
                cmd.Parameters["@pers_telefono"].Value = txt_telf.Text;
                cmd.Parameters["@pers_email"].Value = txt_email.Text;
                cmd.Parameters["@id_tipdoc"].Value = cb_tip_Doc.Text;
                cmd.Parameters["@pers_numdoc"].Value = txt_nro_documento.Text;
                cmd.Parameters["@pers_fenaci"].Value = dp_fenaci.Text;
           


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

        private void dp_fecha_ValueChanged(object sender, EventArgs e)
        {
            campo = "@pers_fenaci";
        }
        public void mostrar()
        {
           
            
                dgv_pers.DataSource = sad.mostrar();
            
        }

        private void dp_fenaci_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
