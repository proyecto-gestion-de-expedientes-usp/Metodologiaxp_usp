using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;


namespace Solucion_informatica_Consultorio_Juridico
{
    public partial class frm_Menu_Admin : Form
    {
        public frm_Menu_Admin()
        { 
            InitializeComponent();
        }

        private void registrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_registrar_usuario u = new frm_registrar_usuario();
            u.ShowDialog();
        }

        private void abogadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_registrar_abogado ab = new frm_registrar_abogado();
            ab.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void personaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_registrar_persona sqlex = new frm_registrar_persona();
            sqlex.ShowDialog();
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

        private void buscarAbogadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_buscar_abogado u = new Frm_buscar_abogado();
            u.ShowDialog();
        }

        private void buscarDemandadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Frm_buscar_demandado u = new Frm_buscar_demandado();
            u.ShowDialog();
        }

        private void buscarDemandanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Frm_buscar_demandante u = new Frm_buscar_demandante();
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

        private void registrarDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
          frm_documento u = new frm_documento();
            u.ShowDialog();
        }

        private void registrarAnexosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Anexos u = new frm_Anexos();
            u.ShowDialog();
        }

        private void registrarTipoAbogadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_tipo_abogadocs u = new Frm_tipo_abogadocs();
            u.ShowDialog();
        }

        private void registrarTipoDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frm_tipo_documento u = new frm_tipo_documento();
            u.ShowDialog();
        }

        private void registrarEstadoAbogadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Estadoabog u = new Frm_Estadoabog();
            u.ShowDialog();
        }

        private void registrarDocumentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Estado_Usuario u = new Frm_Estado_Usuario();
            u.ShowDialog();
        }

        private void registrarTipoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_tipo_usuario u = new frm_tipo_usuario();
            u.ShowDialog();
        }

        private void buscarEstadoAbogadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_buscar_estadoabog u = new frm_buscar_estadoabog();
            u.ShowDialog();
        }

        private void buscarEstadoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_buscar_estadousu u = new frm_buscar_estadousu();
            u.ShowDialog();
        }

        private void buscarTipoDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_buscar_tipo_documento u = new frm_buscar_tipo_documento();
            u.ShowDialog();
        }

        private void buscarTipoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frm_buscar_tipo_usuario u = new frm_buscar_tipo_usuario();
            u.ShowDialog();
        }

        private void buscarTipoAbogadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_buscar_tipoabog u = new frm_buscar_tipoabog();
            u.ShowDialog();
        }

        private void personasDemandadasToolStripMenuItem_Click(object sender, EventArgs e)
        {


            frm_RPT_PERSXDDO form = new frm_RPT_PERSXDDO();
            form.ShowDialog();
            ReportDocument oRep = new ReportDocument();           
            oRep.Load(@"C:\Users\Usuario\Source\Repos\proyecto-gestion-de-expedientes-usp\Metodologiaxp_usp\Solucion_informatica_Consultorio_Juridico\Solucion_informatica_Consultorio_Juridico\Reportes\RPT_PERSXDDO.rpt");
            form.crystalReportViewer1.ReportSource = oRep;      
            oRep.ExportToDisk(ExportFormatType.PortableDocFormat, @"C:\Users\Usuario\Desktop\reporte_demandado.pdf");

       

        }

        private void personasDemandanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frm_RPT_PERSXDTE form = new frm_RPT_PERSXDTE();
            form.ShowDialog();
            ReportDocument oRep = new ReportDocument();
            oRep.Load(@"C:\Users\Usuario\Source\Repos\proyecto-gestion-de-expedientes-usp\Metodologiaxp_usp\Solucion_informatica_Consultorio_Juridico\Solucion_informatica_Consultorio_Juridico\Reportes\RPT_PERSXDDO.rpt");
            form.crystalReportViewer1.ReportSource = oRep;
            oRep.ExportToDisk(ExportFormatType.PortableDocFormat, @"C:\Users\Usuario\Desktop\reporte_demandante.pdf");
        }

        private void casosPorCicloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_reporte gg = new Frm_reporte();
            gg.ShowDialog();
        }

        private void bùsquedasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void documentosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frm_Menu_Admin_Load(object sender, EventArgs e)
        {

        }

        private void maestroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void accionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
