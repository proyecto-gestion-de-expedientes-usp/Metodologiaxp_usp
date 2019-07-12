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
    public partial class Frm_buscar_persona : Form
    {
        string campo;

        Capas.conexion cone = new Capas.conexion();
        Capas.validaciones val = new Capas.validaciones();
        public Frm_buscar_persona()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valor = txt_buscar.Text;
            dgdatos.DataSource = buscar(campo, valor);

            txt_buscar.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgdatos.DataSource = mostrar();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            campo = "NUMDOC";
            txt_buscar.Focus();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            campo = "EMAIL";
            txt_buscar.Focus();
        }
        public DataTable buscar(string campo, string valor)
        {

            cone.con.Open();
            string sql = "select * from View_Persona where " + campo + " like '" + valor + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, cone.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cone.con.Close();
            return dt;
        }
        //public void col()
        //{
        //    dgdatos.Columns[0].HeaderText = "ID";
        //    dgdatos.Columns[1].HeaderText = "PERSONA";
        //    dgdatos.Columns[2].HeaderText = "UBIGEO";
        //    dgdatos.Columns[3].HeaderText = "TIPO_DOC";
        //    dgdatos.Columns[4].HeaderText = "NUM_DOC";
        //    dgdatos.Columns[5].HeaderText = "EMAIL";


        //}
        public DataTable mostrar()
        {

            cone.con.Open();
            string sql = "select * from View_Persona";
            SqlDataAdapter da = new SqlDataAdapter(sql, cone.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cone.con.Close();
            return dt;

        }

        private void Frm_buscar_persona_Load(object sender, EventArgs e)
        {
            dgdatos.DataSource = mostrar();

            //col();
        }

        private void Frm_buscar_persona_Activated(object sender, EventArgs e)
        {
            radioButton4.Checked = true;
        }

        private void dgdatos_DoubleClick(object sender, EventArgs e)
        {
            Program.idper = Convert.ToString(dgdatos.CurrentRow.Cells[0].Value);
            Program.nomper = Convert.ToString(dgdatos.CurrentRow.Cells[1].Value);

            Program.idpers = Convert.ToString(dgdatos.CurrentRow.Cells[0].Value);
            Program.nompers = Convert.ToString(dgdatos.CurrentRow.Cells[1].Value);


            Hide();
        }

        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                val.SoloNumeros(e);
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                    txt_buscar.Clear();
                }
            }
        
        }
    }
}
