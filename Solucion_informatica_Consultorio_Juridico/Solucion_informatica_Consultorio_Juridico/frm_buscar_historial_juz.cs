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
    public partial class frm_buscar_historial_juz : Form
    {
        Capas.conexion cone = new Capas.conexion();
        public frm_buscar_historial_juz()
        {
            InitializeComponent();
        }

        private void frm_buscar_historial_juz_Load(object sender, EventArgs e)
        {
            dgdatos.DataSource = mostrar();
        }
        public DataTable mostrar()
        {
            cone.con.Open();
            string sql = "select * from View_Historial_Juzgado";
            SqlDataAdapter da = new SqlDataAdapter(sql, cone.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cone.con.Close();
            return dt;
        }
        public DataTable buscar(string valor)
        {

            cone.con.Open();
            string sql = "select * from View_Historial_Juzgado where juzg_id like '" + valor + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, cone.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cone.con.Close();
            return dt;
        }

        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            string valor = txt_buscar.Text;
            dgdatos.DataSource = buscar(valor);

            txt_buscar.Focus();
        }

        private void dgdatos_DoubleClick(object sender, EventArgs e)
        {
            Program.idjuzgado=Convert.ToString(dgdatos.CurrentRow.Cells[0].Value);
            Program.juzgadonom = Convert.ToString(dgdatos.CurrentRow.Cells[1].Value);
            this.Hide();
        }
    }
}
