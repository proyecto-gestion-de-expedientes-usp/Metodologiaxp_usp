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
    public partial class Frm_reporte : Form
    {
        public Frm_reporte()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void Frm_reporte_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reportes.RPT_Casos_x_Ciclo xd = new Reportes.RPT_Casos_x_Ciclo();
            xd.SetParameterValue("@fechaDesde", dtp_ini.Text);
            xd.SetParameterValue("@fechaHasta", dtp_fini.Text);
            crystalReportViewer1.ReportSource = xd;
        }
    }
}
