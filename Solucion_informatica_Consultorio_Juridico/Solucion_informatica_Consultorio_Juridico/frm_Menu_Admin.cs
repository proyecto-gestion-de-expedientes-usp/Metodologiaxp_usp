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
    }
}
