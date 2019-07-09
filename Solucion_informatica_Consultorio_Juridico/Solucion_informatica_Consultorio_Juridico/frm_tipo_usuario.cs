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
   
    public partial class frm_tipo_usuario : Form
    {
        string campo;
        Capas.conexion cone = new Capas.conexion();
        public frm_tipo_usuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_insertar_tipo_usuario", cone.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@tipusu_id", SqlDbType.Int);
                cmd.Parameters.Add("@tipusu_tipousuario", SqlDbType.VarChar,20);
                cmd.Parameters.Add("@tipusu_descripcion", SqlDbType.VarChar, 30);

                cmd.Parameters["@tipusu_id"].Value = txt_id.Text;
                cmd.Parameters["@tipusu_tipousuario"].Value = txttipousu.Text;
                cmd.Parameters["@tipusu_descripcion"].Value = txtdescripcion.Text;

                cone.con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Los datos fueron insertados correctamente");
                cone.con.Close();
                dgdatos.DataSource = mostrar();
         
                txt_id.Text = Convert.ToString(dgdatos.RowCount - 1);
           
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

                if (txt_id.Text.Trim() == "" || txtdescripcion.Text.Trim() == "")
                {
                    MessageBox.Show("Se Prohiben Campos Vacios");
                }
            }
            else
            {
                try
                {

                    SqlCommand cmd = new SqlCommand("sp_actualizar_tipo_usuario", cone.con);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@tipusu_id", SqlDbType.Int);
                    cmd.Parameters.Add("@tipusu_tipousuario", SqlDbType.VarChar, 20);
                    cmd.Parameters.Add("@tipusu_descripcion", SqlDbType.VarChar, 30);

                    cmd.Parameters["@tipusu_id"].Value = txt_id.Text;
                    cmd.Parameters["@tipusu_tipousuario"].Value = txttipousu.Text;
                    cmd.Parameters["@tipusu_descripcion"].Value = txtdescripcion.Text;


                    cone.con.Open();

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Los datos fueron actualizados correctamente");

                    cone.con.Close();
                    limpiar();
                    dgdatos.DataSource = mostrar();
                    txt_id.Text = Convert.ToString(dgdatos.RowCount - 1);
                    limpiar();
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
            txtdescripcion.Text = "";
            txttipousu.Text = "";
            txt_buscar.Focus();
            txt_id.Text = Convert.ToString(dgdatos.RowCount - 1);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {         
            campo = "tipusu_id";
            txt_buscar.Focus();
        }

   

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            campo = "tipusu_tipousuario";
            txt_buscar.Focus();
            
        }

        class Validar
      {
          public static void SoloLetras(KeyPressEventArgs V)
            {
                if (Char.IsLetter(V.KeyChar))
                {
                    V.Handled = false;
                }
                else if (Char.IsControl(V.KeyChar))
                { V.Handled = false;
                }
                else if (Char.IsSeparator(V.KeyChar))
                { V.Handled = false;
                }
                else
                { V.Handled = true;       
                }
            }
            public static void SoloNumeros(KeyPressEventArgs V)
            {
                if (Char.IsDigit(V.KeyChar))
                {
                    V.Handled = false;
                }
                else if (Char.IsSeparator(V.KeyChar))
                {
                    V.Handled = false;
                }
                else if (Char.IsControl(V.KeyChar))
                {
                    V.Handled = false;
                }
                else
                {
                    V.Handled = true;             
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

          
            string valor = txt_buscar.Text;
            dgdatos.DataSource = buscar(campo, valor);

            txt_buscar.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dgdatos.DataSource = mostrar();
        }

        private void frm_tipo_usuario_Activated(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            //txt_idper.Text = Program.idper;
            //txt_nomper.Text = Program.nomper;
            txt_id.Text = Convert.ToString(dgdatos.RowCount - 1);
            //cmb_condi.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void frm_tipo_usuario_Load(object sender, EventArgs e)
        {
            dgdatos.DataSource = mostrar();
            col();
        }
        public DataTable mostrar()
        {
            cone.con.Open();
            string sql = "select * from Tipo_Usuario";
            SqlDataAdapter da = new SqlDataAdapter(sql, cone.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cone.con.Close();
            return dt;
        }
        public DataTable buscar(string campo, string valor)
        {
            cone.con.Open();
            string sql = "select * from Tipo_Usuario where " + campo + " like '" + valor + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, cone.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cone.con.Close();
            return dt;
        }
        public void col()
        {
            dgdatos.Columns[0].HeaderText = "ID";
            dgdatos.Columns[1].HeaderText = "TIPO";
            dgdatos.Columns[2].HeaderText = "DESCRIPCION";
        }

        private void txttipousu_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void radioButton1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validar.SoloNumeros(e);
        }

        private void radioButton2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validar.SoloLetras(e);
        }

        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {              
            if (radioButton1.Checked == true)
            {
                Validar.SoloNumeros(e);  
            }

            if (radioButton2.Checked == true)
            {
                Validar.SoloLetras(e);
            }
        }

        private void dgdatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int pos = dgdatos.CurrentRow.Index;
            txt_id.Text = dgdatos.CurrentRow.Cells[0].Value.ToString();
          txttipousu.Text = dgdatos.CurrentRow.Cells[1].Value.ToString();
            txtdescripcion.Text = dgdatos.CurrentRow.Cells[2].Value.ToString();
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
