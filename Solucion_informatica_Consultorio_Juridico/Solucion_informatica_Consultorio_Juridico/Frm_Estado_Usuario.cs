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
    public partial class Frm_Estado_Usuario : Form
    {
        Capas.conexion cone =new Capas.conexion();
        Capas.validaciones val = new Capas.validaciones();
        string campo;

        public Frm_Estado_Usuario()
        {
            InitializeComponent();
        }

        private void Frm_Estado_Usuario_Activated(object sender, EventArgs e)
        {
            //cmb_condi.DropDownStyle = ComboBoxStyle.DropDownList;
            radioButton1.Checked = true;
        }

        private void Frm_Estado_Usuario_Load(object sender, EventArgs e)
        {
            dgdatos.DataSource = mostrar();
            col();
        }
        public void col()
        {
            dgdatos.Columns[0].HeaderText = "ID";
            dgdatos.Columns[1].HeaderText = "CONDICION"; 
        }
        public DataTable mostrar()
        {
            cone.con.Open();
            string sql = "select * from Estado_Usu";
            SqlDataAdapter da = new SqlDataAdapter(sql, cone.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cone.con.Close();
            return dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {     
                try
                {

                    SqlCommand cmd = new SqlCommand("sp_insertar_estadousu", cone.con);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@est_condi", SqlDbType.VarChar, 20);
                    cmd.Parameters["@est_condi"].Value = cmb_condi.Text;
                    cone.con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Los datos fueron insertados correctamente");
                    cone.con.Close();
                    dgdatos.DataSource = mostrar();
                }
                catch (Exception ex)
                {
                    cone.con.Close();
                    MessageBox.Show(ex.Message, "Error al Grabar");
                }           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int seleccionar;
            seleccionar = this.dgdatos.SelectedRows.Count;

            if (seleccionar == 0)

            {
                MessageBox.Show("Para modificar debe seleccionar una Fila en la tabla");

                if (txt_id.Text.Trim() == "" )
                {
                    MessageBox.Show("Falta seleccionar ID");
                }
            }
            else
            {
                try
            {

                SqlCommand cmd = new SqlCommand("sp_actualizar_estadousu", cone.con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id_estusu", SqlDbType.Int);
                cmd.Parameters.Add("@est_condi", SqlDbType.VarChar,20);
               


                cmd.Parameters["@id_estusu"].Value = txt_id.Text;
                cmd.Parameters["@est_condi"].Value = cmb_condi.Text;
            

                cone.con.Open();

                cmd.ExecuteNonQuery();

                MessageBox.Show("Los datos fueron actualizados correctamente");

                cone.con.Close();
                    limpiar();
                    dgdatos.DataSource = mostrar();
             
            }


            catch (Exception ex)
            {
                cone.con.Close();
                MessageBox.Show(ex.Message, "Error al Actualizar");
            }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            limpiar();
          
        }

        public void limpiar()
        {
            txt_id.Text = "";
            txt_buscar.Text = "";
            txt_buscar.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string valor = txt_buscar.Text;
            dgdatos.DataSource = buscar(campo, valor);

            txt_buscar.Focus();
        }
        public DataTable buscar(string campo, string valor)
        {
            cone.con.Open();
            string sql = "select * from Estado_Usu where " + campo + " like '" + valor + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, cone.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cone.con.Close();
            return dt;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            campo = "id_estusu";
            txt_buscar.Focus();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {   
            campo = "est_condi";
            txt_buscar.Focus();
        }

        private void dgdatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int pos = dgdatos.CurrentRow.Index;
            txt_id.Text = dgdatos.CurrentRow.Cells[0].Value.ToString();
            cmb_condi.Text = dgdatos.CurrentRow.Cells[1].Value.ToString();
         
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dgdatos.DataSource = mostrar();
        }

        private void cmb_condi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            { e.Handled = false; }
            else if (Char.IsSeparator(e.KeyChar))
            { e.Handled = false; }
            else
            { e.Handled = true; }
        }

        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                val.SoloNumeros(e);
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                    txt_buscar.Clear();
                }
            }

            if (radioButton2.Checked == true)
            {
                val.SoloLetras(e);
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                    txt_buscar.Clear();
                }
            }
        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoloNumeros(e);
        }
    }
}
