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
    public partial class Frm_buscar_abogado : Form
    {
        string campo;

        Capas.conexion cone = new Capas.conexion();
        Capas.validaciones val = new Capas.validaciones();
        public Frm_buscar_abogado()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgdatos.DataSource = mostrar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valor = txt_buscar.Text;
            dgdatos.DataSource = buscar(campo, valor);

            txt_buscar.Focus();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            campo = "NOMBRES";
            txt_buscar.Focus();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            campo = "PARTE";
            txt_buscar.Focus();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            campo = "DNI";
            txt_buscar.Focus();
        }

        private void Frm_buscar_abogado_Load(object sender, EventArgs e)
        {
            dgdatos.DataSource = mostrar();
                        //col();
        }
        //public void col()
        //{
        //    dgdatos.Columns[0].HeaderText = "ID_ABOGADO";
        //    dgdatos.Columns[1].HeaderText = "ESTADO";
        //    dgdatos.Columns[2].HeaderText = "PARTE";
        //    dgdatos.Columns[3].HeaderText = "NOMBRES";
        //    dgdatos.Columns[4].HeaderText = "APELLIDO_P";
        //    dgdatos.Columns[5].HeaderText = "APELLIDO_M";
        //    dgdatos.Columns[6].HeaderText = "DNI";
        //}
        public DataTable mostrar()
        {
            cone.con.Open();
            string sql = "select * from View_Abogado";
            SqlDataAdapter da = new SqlDataAdapter(sql, cone.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cone.con.Close();
            return dt;
        }

        private void Frm_buscar_abogado_Activated(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
        }

        public DataTable buscar(string campo, string valor)
        {

            cone.con.Open();
            string sql = "select * from View_Abogado where " + campo + " like '" + valor + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, cone.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cone.con.Close();
            return dt;
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

            if (radioButton4.Checked == true)
            {
                val.SoloLetras(e);
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                    txt_buscar.Clear();
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgdatos_DoubleClick(object sender, EventArgs e)
        {
            Program.idabogado = Convert.ToString(dgdatos.CurrentRow.Cells[0].Value);
            Program.nomabogado = Convert.ToString(dgdatos.CurrentRow.Cells[3].Value);
            this.Hide();
        }
    }
}
