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
    public partial class frm_buscar_tipoabog : Form
    {
        String campo;
        Capas.conexion cone = new Capas.conexion();
        public frm_buscar_tipoabog()
        {
            InitializeComponent();
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

        public void col()
        {
            dgdatos.Columns[0].HeaderText = "ID";
            dgdatos.Columns[1].HeaderText = "NOMBRE";
            dgdatos.Columns[2].HeaderText = "DESCRIPCION";

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

        private void frm_buscar_tipoabog_Load(object sender, EventArgs e)
        {
            dgdatos.DataSource = mostrar();
            col();
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
    }
}
