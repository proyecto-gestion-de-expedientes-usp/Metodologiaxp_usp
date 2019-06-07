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
        public frm_registrar_abogado()
        {
            InitializeComponent();
        }

        private void frm_registrar_abogado_Load(object sender, EventArgs e)
        {

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
