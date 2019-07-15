using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Data.SqlClient;


namespace Solucion_informatica_Consultorio_Juridico
{
    public partial class frm_documento : Form
    {
        string campo;

     
        Capas.conexion xd = new Capas.conexion();
        public frm_documento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Pdf Files|*.pdf";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Equals("") || txtFile.Text.Trim().Equals("") || txt_id.Text.Trim().Equals(""))
            {
                MessageBox.Show("El nombre es obligatorio");
                return;
            }
            byte[] file = null;

            Stream myStream = openFileDialog1.OpenFile();
            using (MemoryStream ms = new MemoryStream())
            {

                myStream.CopyTo(ms);
                file = ms.ToArray();
            }
            using (Model.consultoriojurEntities db = new Model.consultoriojurEntities())
            {

                Model.Documento doc = new Model.Documento();
                doc.doc_id =Convert.ToInt32(txt_id.Text.Trim());
                doc.doc_nombre = txtName.Text.Trim();
                doc.doc_documento = file;
                doc.doc_nombrereal = openFileDialog1.SafeFileName;
                doc.doc_fecha = dp_fecha.Value;

                db.Documento.Add(doc);
                db.SaveChanges();
            }
            Refresh();
            generarid();
        }
        public void Refresh()
        {
            using (Model.consultoriojurEntities db = new Model.consultoriojurEntities())
            {
                var lst = from d in db.Documento
                          select new { d.doc_id, d.doc_nombre, d.doc_fecha };
            
                dgvLista.DataSource = lst.ToList();
            }
        }

        private void frm_documento_Load(object sender, EventArgs e)
        {
            Refresh();
            generarid();
        }
        public DataTable buscar(string campo, string valor)
        {

           xd.con.Open();
            string sql = "select * from Documento where " + campo + " like '" + valor + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, xd.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            xd.con.Close();
            return dt;
        }
        public DataTable mostrar()
        {
            xd.con.Open();
            string sql = "select * from Documento";
            SqlDataAdapter da = new SqlDataAdapter(sql, xd.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            xd.con.Close();
            return dt;
        }
        public void generarid()
        {

            SqlDataAdapter sda = new SqlDataAdapter("select isnull(Max(cast(doc_id as int)),0)+1 from Documento", xd.con);
            DataTable sqlex = new DataTable();
            sda.Fill(sqlex);
            txt_id.Text = sqlex.Rows[0][0].ToString();


        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string valor = txt_buscar.Text;
            dgvLista.DataSource = buscar(campo, valor);

            txt_buscar.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dgvLista.DataSource = mostrar();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            campo = "doc_nombre";
            txt_buscar.Focus();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            campo = "doc_nombrereal";
            txt_buscar.Focus();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
