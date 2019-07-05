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
    public partial class frm_buscar_estadoabog : Form
    {
        Capas.conexion cone = new Capas.conexion();

        string campo;
        public frm_buscar_estadoabog()
        {
            InitializeComponent();
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
            string sql = "select * from Estado_Abogado where " + campo + " like '" + valor + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, cone.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cone.con.Close();
            return dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dgdatos.DataSource = mostrar();
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

        private void frm_buscar_estadoabog_Load(object sender, EventArgs e)
        {
            dgdatos.DataSource = mostrar();
            col();
        }
        public void col()
        {
            dgdatos.Columns[0].HeaderText = "ID";
            dgdatos.Columns[1].HeaderText = "ESTADO";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frm_buscar_estadoabog_Activated(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }
    }
}
