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
    public partial class frm_buscar_tipo_usuario : Form
    {
        string campo;
        Capas.conexion cone = new Capas.conexion();
        Capas.validaciones val = new Capas.validaciones();
        public frm_buscar_tipo_usuario()
        {
            InitializeComponent();
        }

        private void frm_buscar_tipo_usuario_Load(object sender, EventArgs e)
        {
            dgdatos.DataSource = mostrar();
            col();
        }
        public void col()
        {
            dgdatos.Columns[0].HeaderText = "ID";
            dgdatos.Columns[1].HeaderText = "NOMBRE";
            dgdatos.Columns[2].HeaderText = "DESCRIPCION";
     
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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

        private void dgdatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void frm_buscar_tipo_usuario_Activated(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
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

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
