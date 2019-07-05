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
    public partial class Menu_Trabajador : Form
    {
        public Menu_Trabajador()
        {
            InitializeComponent();
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
            frm_Registrar_Expediente u = new frm_Registrar_Expediente();
            u.ShowDialog();
        }

        private void registrarMovimientoExpedienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frm_Registrar_MovimientoExp u = new frm_Registrar_MovimientoExp();
            u.ShowDialog();
        }

        private void registrarHistorialJuzgadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Frm_reg_historialjuzg u = new Frm_reg_historialjuzg();
            u.ShowDialog();
        }

        private void registrarPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frm_registrar_persona u = new frm_registrar_persona();
            u.ShowDialog();
        }

        private void buscarAbogadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Frm_buscar_abogado u = new Frm_buscar_abogado();
            u.ShowDialog();
        }

        private void buscarDemandanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Frm_buscar_demandante u = new Frm_buscar_demandante();
            u.ShowDialog();
        }

        private void buscarDemandadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_buscar_demandado u = new Frm_buscar_demandado();
            u.ShowDialog();
        }

        private void buscarPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Frm_buscar_persona u = new Frm_buscar_persona();
            u.ShowDialog();
        }

        private void buscarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_buscar_Usuario u = new Frm_buscar_Usuario();
            u.ShowDialog();
        }

        private void buscarDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void registrarDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_documento u = new frm_documento();
            u.ShowDialog();
        }

        private void registrarAnexoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Anexos u = new frm_Anexos();
            u.ShowDialog();
        }
    }
}
