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
    public partial class frm_demandante : Form
    {
        string campo;

        Capas.conexion cone = new Capas.conexion();
        Capas.validaciones val = new Capas.validaciones();
     
        public frm_demandante()
        {
            InitializeComponent();
        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            txt_reg.Enabled = false;
            btn_reg.Enabled = false;
            button2.Enabled = true;

            if (Capas.validaciones.ValidarFormulario(this, errorProvider1) == false)
            {
          
                try
                {

                    SqlCommand cmd = new SqlCommand("sp_insertar_demandante", cone.con);

                    cmd.CommandType = CommandType.StoredProcedure;

                    //cmd.Parameters.Add("@demte_id", SqlDbType.Int);
                    cmd.Parameters.Add("@pers_id", SqlDbType.Int);
                    cmd.Parameters.Add("@demte_registro", SqlDbType.VarChar, 20);


                    //cmd.Parameters["@demte_id"].Value = txt_iddo.Text;
                    cmd.Parameters["@pers_id"].Value = txt_idper.Text;
                    cmd.Parameters["@demte_registro"].Value = txt_reg.Text;


                    cone.con.Open();

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Los datos fueron insertados correctamente");

                    cone.con.Close();
                    dgdatos.DataSource = mostrar();
                    generar_id();
                }


                catch (Exception ex)
                {
                    cone.con.Close();
                    MessageBox.Show(ex.Message, "Error al Grabar");
                }
            }

            else
            {

            }
        }

        public DataTable mostrar()
        {

            cone.con.Open();
            string sql = "select * from View_Demandante";
            SqlDataAdapter da = new SqlDataAdapter(sql, cone.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cone.con.Close();
            return dt;

        }

        public void col()
        {
            dgdatos.Columns[0].HeaderText = "ID";
            dgdatos.Columns[1].HeaderText = "ID_PERSONA";
            dgdatos.Columns[2].HeaderText = "PERSONA";
            dgdatos.Columns[3].HeaderText = "NUM_DOC";
            dgdatos.Columns[4].HeaderText = "REGISTRO";
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            campo = "demte_id";
            txt_buscar.Focus();
        }

        private void frm_demandante_Load(object sender, EventArgs e)
        {
            dgdatos.DataSource = mostrar();
            generar_id();
            col();
        }
        public void generar_id()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select isnull(Max(cast(demte_id as int)),0)+1 from Demandante", cone.con);
            DataTable sqlex = new DataTable();
            sda.Fill(sqlex);

            txt_iddo.Text = sqlex.Rows[0][0].ToString();
        }

        private void btn_buscar1_Click(object sender, EventArgs e)
        {
            string valor = txt_buscar.Text;
            dgdatos.DataSource = buscar(campo, valor);

            txt_buscar.Focus();
        }

        public DataTable buscar(string campo, string valor)
        {

            cone.con.Open();
            string sql = "select * from View_Demandante where " + campo + " like '" + valor + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, cone.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cone.con.Close();
            return dt;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            campo = "pers_numdoc";
            txt_buscar.Focus();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            campo = "demte_registro";
            txt_buscar.Focus();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            int seleccionar;
            seleccionar = this.dgdatos.SelectedRows.Count;

            if (seleccionar == 0)

            {
                MessageBox.Show("Para modificar debe seleccionar una Fila en la tabla");

                if (txt_idper.Text.Trim() == "" || txt_nomper.Text.Trim() == "")
                {
                    MessageBox.Show("Debe seleccionar a la Persona demandante");
                }
            }
            else
            {
                try
                {

                    SqlCommand cmd = new SqlCommand("sp_actualizar_demandante", cone.con);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@demte_id", SqlDbType.Int);
                    cmd.Parameters.Add("@pers_id", SqlDbType.Int);
                    cmd.Parameters.Add("@demte_registro", SqlDbType.VarChar, 20);


                    cmd.Parameters["@demte_id"].Value = txt_iddo.Text;
                    cmd.Parameters["@pers_id"].Value = txt_idper.Text;
                    cmd.Parameters["@demte_registro"].Value = txt_reg.Text;

                    cone.con.Open();

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Los datos fueron actualizados correctamente");

                    cone.con.Close();
                    dgdatos.DataSource = mostrar();
                    generar_id();
                }


                catch (Exception ex)
                {
                    cone.con.Close();
                    MessageBox.Show(ex.Message, "Error al Actualizar");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            txt_reg.Enabled = true;
            btn_reg.Enabled = true;
            button2.Enabled = false;
            txt_idper.Text = "";
            txt_iddo.Text = "";
            txt_nomper.Text = "";

            txt_buscar.Text = "";
            txt_buscar.Focus();
            txt_iddo.Text = Convert.ToString(dgdatos.RowCount - 1);
        }

        private void dgdatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int pos = dgdatos.CurrentRow.Index;

            txt_iddo.Text = dgdatos.CurrentRow.Cells[0].Value.ToString();
            txt_idper.Text = dgdatos.CurrentRow.Cells[1].Value.ToString();
            txt_nomper.Text = dgdatos.CurrentRow.Cells[2].Value.ToString();
            txt_reg.Text = dgdatos.CurrentRow.Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_buscar_persona frm = new Frm_buscar_persona();

            frm.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dgdatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_demandante_Activated(object sender, EventArgs e)
        {
            txt_idper.Text = Program.idpers;
            txt_nomper.Text = Program.nompers;
            generar_id();
            txt_reg.DropDownStyle = ComboBoxStyle.DropDownList;
            radioButton2.Checked = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgdatos.DataSource = mostrar();
        }

        private void txt_reg_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_iddo_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoloNumeros(e);
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
            if (radioButton3.Checked == true)
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

        private void txt_idper_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txt_nomper_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txt_iddo_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txt_reg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
