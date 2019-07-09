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
    public partial class Frm_Estadoabog : Form
    {
        Capas.conexion cone = new Capas.conexion();

        string campo;
        public Frm_Estadoabog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("sp_insertar_estadoabog", cone.con);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@estabog", SqlDbType.VarChar, 20);
                cmd.Parameters["@estabog"].Value = cmb_condi.Text;
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

                if (txt_id.Text.Trim() == "")
                {
                    MessageBox.Show("Falta seleccionar ID");
                }
            }
            else
            {
                try
                {

                    SqlCommand cmd = new SqlCommand("sp_actualizar_estadoabog", cone.con);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id_estabo", SqlDbType.Int);
                    cmd.Parameters.Add("@estabog", SqlDbType.VarChar, 20);



                    cmd.Parameters["@id_estabo"].Value = txt_id.Text;
                    cmd.Parameters["@estabog"].Value = cmb_condi.Text;


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

        private void Frm_Estadoabog_Load(object sender, EventArgs e)
        {
            dgdatos.DataSource = mostrar();
            col();
        }
        public void col()
        {
            dgdatos.Columns[0].HeaderText = "ID";
            dgdatos.Columns[1].HeaderText = "ESTADO";
        }
        public DataTable mostrar()
        {
            cone.con.Open();
            string sql = "select * from Estado_Abogado";
            SqlDataAdapter da = new SqlDataAdapter(sql, cone.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cone.con.Close();
            return dt;
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
        public DataTable buscar(string campo, string valor)
        {
            cone.con.Open();
            string sql = "select * from Estado_Abogado where " + campo + " like '" + valor + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, cone.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cone.con.Close();
            return dt;
        }

        private void dgdatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int pos = dgdatos.CurrentRow.Index;
            txt_id.Text = dgdatos.CurrentRow.Cells[0].Value.ToString();
            cmb_condi.Text = dgdatos.CurrentRow.Cells[1].Value.ToString();
        }

        private void Frm_Estadoabog_Activated(object sender, EventArgs e)
        {
            //cmb_condi.DropDownStyle = ComboBoxStyle.DropDownList;
            radioButton1.Checked = true;
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
            campo = "id_estabo";
            txt_buscar.Focus();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            campo = "estabog";
            txt_buscar.Focus();
        }
    }
}
