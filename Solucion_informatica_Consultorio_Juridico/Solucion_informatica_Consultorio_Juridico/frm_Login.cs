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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Clases.Acceso ace = new Clases.Acceso();

            ace.Usuario = txtusu.Text;
            ace.Clave = txtpas.Text;
            ace.Tipo = comboBox1.Text;
            if (this.comboBox1.Text == "Seleccionar")
            {
                MessageBox.Show("Seleccione Tipo de Usuario", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            




            if (txtusu.Text == "")
            {
                MessageBox.Show("Digite Usuario para Continuar", "Consultorio USP", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtusu.Focus();
            }
            else if (txtpas.Text == "")
            {
                MessageBox.Show("Digite Clave para Continuar", "Consultorio USP", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtpas.Focus();
            }
            else if (ace.Verificar() == true)
            {
                if (comboBox1.Text == "Alumno")
                {
                    //frm_Administracion_Alumno inicia = new frm_Administracion_Alumno();
                    //inicia.Show();
                    //this.Hide();

                    //inicia.toolStripStatusLabel2.Text = "Usuario: " + txtusu.Text + "  *** " + " Cargo: " + comboBox1.Text.ToString();

                }
                if (comboBox1.Text == "Asesor")
                {
                    //frm_Administracion_Asesor inicia = new frm_Administracion_Asesor();
                    //inicia.Show();
                    //this.Hide();

                    //inicia.toolStripStatusLabel2.Text = "Usuario: " + txtusu.Text + "  *** " + " Cargo: " + comboBox1.Text.ToString();

                }
                if (comboBox1.Text == "Admin")
                {
                    
                    frm_Menu_Admin ma = new frm_Menu_Admin();
                    ma.Show();
                    this.Hide();

                    //ma.toolStripStatusLabel2.Text = "Usuario: " + txtusu.Text + "  *** " + " Cargo: " + comboBox1.Text.ToString();

                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_recuperar_contra_por_email rec = new frm_recuperar_contra_por_email();
            rec.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_registrar_usuario fr = new frm_registrar_usuario();
            fr.ShowDialog();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {

        }
    } }

