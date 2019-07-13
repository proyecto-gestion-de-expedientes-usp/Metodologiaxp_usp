using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solucion_informatica_Consultorio_Juridico
{
    public partial class frm_menu_asesor : Form
    {
        public frm_menu_asesor()
        {
            InitializeComponent();
        }

        private void frm_menu_asesor_Load(object sender, EventArgs e)
        {

        }

        private void accionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void registrarDemandadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_demandado u = new frm_demandado();
            u.ShowDialog();
        }

        private void registrarDemandanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_demandante u = new frm_demandante();
            u.ShowDialog();
        }

        private void registrarExpedienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Registrar_Expediente sqlex = new frm_Registrar_Expediente();
            sqlex.ShowDialog();
        }

        private void registrarHistorialJuzgadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_reg_historialjuzg u = new Frm_reg_historialjuzg();
            u.ShowDialog();
        }

        private void buscarAbogadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_buscar_demandado u = new Frm_buscar_demandado();
            u.ShowDialog();
        }

        private void buscarDemandanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_buscar_demandante u = new Frm_buscar_demandante();
            u.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

            frm_Login a = new frm_Login();
            a.ShowDialog();
        }
    }
}
