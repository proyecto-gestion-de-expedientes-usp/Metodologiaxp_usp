﻿using System;
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
        public void generarid()
        {

            SqlDataAdapter sda = new SqlDataAdapter("select isnull(Max(cast(doc_id as int)),0)+1 from Documento", xd.con);
            DataTable sqlex = new DataTable();
            sda.Fill(sqlex);
            txt_id.Text = sqlex.Rows[0][0].ToString();

        }
    }
}