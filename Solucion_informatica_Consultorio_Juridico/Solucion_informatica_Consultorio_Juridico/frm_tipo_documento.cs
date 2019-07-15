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
    public partial class frm_tipo_documento : Form
    {
        string campo;
        Capas.conexion cone = new Capas.conexion();
        Capas.validaciones val = new Capas.validaciones();
        public frm_tipo_documento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtnombdocum.Enabled = false;
            button1.Enabled = false;
            button3.Enabled = true;

            if (Capas.validaciones.ValidarFormulario(this, errorProvider1) == false)
            {
                try
                {

                    SqlCommand cmd = new SqlCommand("sp_insertar_tipodoc", cone.con);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@tipdoc_nom", SqlDbType.VarChar, 35);
                    cmd.Parameters["@tipdoc_nom"].Value = txtnombdocum.Text;
                    cone.con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Los datos fueron insertados correctamente");
                    cone.con.Close();
                    dgdatos.DataSource = mostrar();
                    txtnombdocum.Text = "";
                }
                catch (Exception ex)
                {
                    cone.con.Close();
                    MessageBox.Show(ex.Message, "Error al Grabar");
                }
            }
            else { }
        }
        public void col()
        {
            dgdatos.Columns[0].HeaderText = "ID";
            dgdatos.Columns[1].HeaderText = "NOMBRE";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = true;
            txtnombdocum.Enabled = false;
            int seleccionar;
            seleccionar = this.dgdatos.SelectedRows.Count;

            if (seleccionar == 0)

            {
                MessageBox.Show("Para modificar debe seleccionar una Fila en la tabla");

                if (txt_id.Text.Trim() == "")
                {
                    MessageBox.Show("Falta seleccionar ID");
                }
            }
            else
            {
                try
                {

                    SqlCommand cmd = new SqlCommand("sp_actualizar_tipodoc", cone.con);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id_tipdoc", SqlDbType.Int);
                    cmd.Parameters.Add("@tipdoc_nom", SqlDbType.VarChar, 35);



                    cmd.Parameters["@id_tipdoc"].Value = txt_id.Text;
                    cmd.Parameters["@tipdoc_nom"].Value = txtnombdocum.Text;


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
            button1.Enabled = true;
            txtnombdocum.Enabled = true;
            button3.Enabled = false;
            limpiar();
        }

        private void frm_tipo_documento_Load(object sender, EventArgs e)
        {
            dgdatos.DataSource = mostrar();
            col();
        }
        public void limpiar()
        {
            txt_id.Text = "";
            txt_buscar.Text = "";
            txt_buscar.Focus();
        }
        public DataTable mostrar()
        {
            cone.con.Open();
            string sql = "select * from Tip_documento";
            SqlDataAdapter da = new SqlDataAdapter(sql, cone.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cone.con.Close();
            return dt;
        }
        public DataTable buscar(string campo, string valor)
        {
            cone.con.Open();
            string sql = "select * from Tip_documento where " + campo + " like '" + valor + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, cone.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cone.con.Close();
            return dt;
        }

        private void dgdatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button2.Enabled = true;
            button1.Enabled = false;
            button3.Enabled = false;
            txtnombdocum.Enabled = true;

            int pos = dgdatos.CurrentRow.Index;
            txt_id.Text = dgdatos.CurrentRow.Cells[0].Value.ToString();
            txtnombdocum.Text = dgdatos.CurrentRow.Cells[1].Value.ToString();
        }

        private void frm_tipo_documento_Activated(object sender, EventArgs e)
        {
            //cmb_condi.DropDownStyle = ComboBoxStyle.DropDownList;
            //radioButton1.Checked = true;
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            campo = "id_tipdoc";
            txt_buscar.Focus();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            campo = "tipdoc_nom";
            txt_buscar.Focus();
        }

        private void cmb_condi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtnombdocum_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoloLetras(e);
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

        private void txtnombdocum_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }
}
