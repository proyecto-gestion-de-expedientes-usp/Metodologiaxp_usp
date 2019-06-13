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
namespace Solucion_informatica_Consultorio_Juridico
{
    public partial class frm_Anexos : Form
    {
        public frm_Anexos()
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
            if (txtName.Text.Trim().Equals("") || txtFile.Text.Trim().Equals(""))
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

                Model.Anexos anexo = new Model.Anexos();
                anexo.anexo_nombre = txtName.Text.Trim();
                anexo.anexo_documento = file;
                anexo.anexo_nombrereal = openFileDialog1.SafeFileName;
                anexo.anexo_fecha = dp_fecha.Value;

                db.Anexos.Add(anexo);
                db.SaveChanges();
            }
            Refresh();
        }
        public void Refresh()
        {
            using (Model.consultoriojurEntities db = new Model.consultoriojurEntities())
            {
                var lst = from d in db.Anexos
                          select new { d.anexo_id, d.anexo_nombre,d.anexo_fecha};

                dgvLista.DataSource = lst.ToList();
            }
        }

        private void frm_Anexos_Load(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
