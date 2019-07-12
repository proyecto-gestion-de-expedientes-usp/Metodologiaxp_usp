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
    public partial class frm_buscar_anexo : Form
    {
        Capas.conexion cone = new Capas.conexion();
        public frm_buscar_anexo()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frm_buscar_anexo_Load(object sender, EventArgs e)
        {
            dgdatos.DataSource = mostrar();
        }
        public DataTable mostrar()
        {
            cone.con.Open();
            string sql = "select * from View_Anexos";
            SqlDataAdapter da = new SqlDataAdapter(sql, cone.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cone.con.Close();
            return dt;
        }
        public DataTable buscar(string valor)
        {

            cone.con.Open();
            string sql = "select * from View_Anexos where anexo_nombre like '" + valor + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, cone.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cone.con.Close();
            return dt;
        }

        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            string valor = txt_buscar.Text;
            dgdatos.DataSource = buscar( valor);

            txt_buscar.Focus();
        }

        private void dgdatos_DoubleClick(object sender, EventArgs e)
        {
            Program.idanexo = Convert.ToString(dgdatos.CurrentRow.Cells[0].Value);
            Program.nomanexo = Convert.ToString(dgdatos.CurrentRow.Cells[1].Value);
            this.Hide();
        }
    }
}
