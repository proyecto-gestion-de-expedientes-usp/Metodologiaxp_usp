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
 

    public partial class Frm_tipo_abogadocs : Form
    {
        string campo;
        Capas.conexion cone = new Capas.conexion();
        Capas.validaciones val = new Capas.validaciones();
        public Frm_tipo_abogadocs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Capas.validaciones.ValidarFormulario(this, errorProvider1) == false)
            {
                try
                {

                    SqlCommand cmd = new SqlCommand("sp_insertar_tipo_abogado", cone.con);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@tipb_id", SqlDbType.Int);
                    cmd.Parameters.Add("@tipb_def_inc", SqlDbType.VarChar, 20);
                    cmd.Parameters.Add("@tipb_estado", SqlDbType.VarChar, 20);
                    cmd.Parameters.Add("@tipb_descripcion", SqlDbType.VarChar, 50);

                    cmd.Parameters["@tipb_id"].Value = txt_id.Text;
                    cmd.Parameters["@tipb_def_inc"].Value = cmb_condi.Text;
                    cmd.Parameters["@tipb_estado"].Value = txt_estado.Text;
                    cmd.Parameters["@tipb_descripcion"].Value = txt_descripcion.Text;
                    cone.con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Los datos fueron insertados correctamente");
                    cone.con.Close();
                    dgdatos.DataSource = mostrar();
                    generar_id();
                    txt_descripcion.Text = "";
                }
                catch (Exception ex)
                {
                    cone.con.Close();
                    MessageBox.Show(ex.Message, "Error al Grabar");
                }
            }

            else { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int seleccionar;
            seleccionar = this.dgdatos.SelectedRows.Count;

            if (seleccionar == 0)

            {
                MessageBox.Show("Para modificar debe seleccionar una Fila en la tabla");

                if (txt_estado.Text.Trim() == "" || txt_descripcion.Text.Trim() == "")
                {
                    MessageBox.Show("Debe llenar los campos vacios");
                }
            }
            else
            {
                try
                {

                    SqlCommand cmd = new SqlCommand("sp_actualizar_tipo_abogado", cone.con);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@tipb_id", SqlDbType.Int);
                    cmd.Parameters.Add("@tipb_def_inc", SqlDbType.VarChar, 20);
                    cmd.Parameters.Add("@tipb_estado", SqlDbType.VarChar, 20);
                    cmd.Parameters.Add("@tipb_descripcion", SqlDbType.VarChar, 50);

                    cmd.Parameters["@tipb_id"].Value = txt_id.Text;
                    cmd.Parameters["@tipb_def_inc"].Value = cmb_condi.Text;
                    cmd.Parameters["@tipb_estado"].Value = txt_estado.Text;
                    cmd.Parameters["@tipb_descripcion"].Value = txt_descripcion.Text;

                    cone.con.Open();

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Los datos fueron actualizados correctamente");

                    cone.con.Close();
                    dgdatos.DataSource = mostrar();
                    generar_id();
                    txt_descripcion.Text = "";
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
            txt_id.Text = "";
            txt_estado.Text = "";
            txt_descripcion.Text = "";

            txt_buscar.Text = "";
            txt_buscar.Focus();
            generar_id();
            //txt_id.Text = Convert.ToString(dgdatos.RowCount - 1);   
        }
        public void generar_id()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select isnull(Max(cast(tipb_id as int)),0)+1 from Tipo_Abogado", cone.con);
            DataTable sqlex = new DataTable();
            sda.Fill(sqlex);

            txt_id.Text = sqlex.Rows[0][0].ToString();
        }
        private void Frm_tipo_abogadocs_Load(object sender, EventArgs e)
        {
            dgdatos.DataSource = mostrar();
            generar_id();
            col();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            campo = "tipb_def_inc";
            txt_buscar.Focus();
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
        public DataTable buscar(string campo, string valor)
        {

            cone.con.Open();
            string sql = "select * from Tipo_Abogado where " + campo + " like '" + valor + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, cone.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cone.con.Close();
            return dt;
        }
        public DataTable mostrar()
        {
            cone.con.Open();
            string sql = "select * from Tipo_Abogado";
            SqlDataAdapter da = new SqlDataAdapter(sql, cone.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cone.con.Close();
            return dt;
        }
        public void col()
        {
            dgdatos.Columns[0].HeaderText = "ID";
            dgdatos.Columns[1].HeaderText = "PAPEL";
            dgdatos.Columns[2].HeaderText = "ESTADO";
            dgdatos.Columns[3].HeaderText = "DESCRIPCION";
            
        }

        private void dgdatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int pos = dgdatos.CurrentRow.Index;
            txt_id.Text = dgdatos.CurrentRow.Cells[0].Value.ToString();
            cmb_condi.Text = dgdatos.CurrentRow.Cells[1].Value.ToString();
            txt_estado.Text = dgdatos.CurrentRow.Cells[2].Value.ToString();
            txt_descripcion.Text = dgdatos.CurrentRow.Cells[3].Value.ToString();
        }

        private void Frm_tipo_abogadocs_Activated(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
            //txt_idper.Text = Program.idper;
            //txt_nomper.Text = Program.nomper;
            generar_id();
            cmb_condi.DropDownStyle = ComboBoxStyle.DropDownList;      
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            campo = "tipb_id";
            txt_buscar.Focus();
        }

        private void txt_estado_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoloLetras(e);
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

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoloNumeros(e);
        }

        private void txt_descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                val.SoloNumeros(e);
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                    txt_buscar.Clear();
                }
            }

            if (radioButton1.Checked == true)
            {
                val.SoloLetras(e);
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                    txt_buscar.Clear();
                }
            }
        }

        private void txt_descripcion_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txt_estado_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }
}
