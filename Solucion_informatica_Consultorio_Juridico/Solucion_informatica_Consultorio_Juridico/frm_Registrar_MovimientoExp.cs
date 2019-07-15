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
    public partial class frm_Registrar_MovimientoExp : Form
    {
        Clases.Validacioes validadcion = new Clases.Validacioes();
        Clases.Conexion con = new Clases.Conexion();
        Clases.Datos sad = new Clases.Datos();
        public frm_Registrar_MovimientoExp()
        {
            InitializeComponent();
        }

        private void frm_Registrar_MovimientoExp_Load(object sender, EventArgs e)
        {
            generarid();
            mostrar();

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            btn_usu.Enabled = false;
            btn_demandd.Enabled = false;
            btn_demandt.Enabled = false;
            btn_anex.Enabled = false;
            btn_abog.Enabled = false;
            dp_fecha.Enabled = false;
            txt_asunto.Enabled = false;
            cb_estado.Enabled = false;
            txt_cantfol.Enabled = false;
            txt_progre.Enabled = false;
            txt_descrip.Enabled = false;
            btn_guardar.Enabled = false;
            btn_modificar.Enabled = false;
            button3.Enabled = true;

            
            try
            {

                SqlCommand cmd = new SqlCommand("insertar_MovExp", con.AbrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.Add("@movexp_id", SqlDbType.Int);
                cmd.Parameters.Add("@ab_id", SqlDbType.Int);
                cmd.Parameters.Add("@usu_id", SqlDbType.Int );
                cmd.Parameters.Add("@demte_id", SqlDbType.Int);
                cmd.Parameters.Add("@demdo_id", SqlDbType.Int);
                cmd.Parameters.Add("@anexo_id", SqlDbType.Int);
                cmd.Parameters.Add("@movexp_asunto", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@movexp_fechaing", SqlDbType.Date);
                cmd.Parameters.Add("@movexp_estado", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@movexp_progreso", SqlDbType.VarChar, 250);
                cmd.Parameters.Add("@movexp_cantfolios", SqlDbType.VarChar, 10);
                cmd.Parameters.Add("@movexp_descripcion", SqlDbType.VarChar,250);
                cmd.Parameters.Add("@movexp_nro", SqlDbType.VarChar, 10);


                //cmd.Parameters["@movexp_id"].Value = txt_id_movexp.Text;
                cmd.Parameters["@ab_id"].Value = txt_id_abo.Text;
                cmd.Parameters["@usu_id"].Value = txt_id_usu.Text;
                cmd.Parameters["@demte_id"].Value = txt_id_demandt.Text;
                cmd.Parameters["@demdo_id"].Value = txt_id_demandd.Text;
                cmd.Parameters["@anexo_id"].Value = txt_id_anex.Text;
                cmd.Parameters["@movexp_asunto"].Value = txt_asunto.Text;
                cmd.Parameters["@movexp_fechaing"].Value = dp_fecha.Text;
                cmd.Parameters["@movexp_estado"].Value = cb_estado.Text;
                cmd.Parameters["@movexp_progreso"].Value = txt_progre.Text;
                cmd.Parameters["@movexp_cantfolios"].Value = txt_cantfol.Text;
                cmd.Parameters["@movexp_descripcion"].Value = txt_descrip.Text;
                cmd.Parameters["@movexp_nro"].Value = txt_nroexp.Text;



                con.AbrirConexion();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Los datos fueron insertados correctamente");
                generarid();
                mostrar();
                con.CerrarConexion();
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            txt_asunto.Text = "";
            txt_cantfol.Text = "";
            txt_progre.Text = "";
            txt_descrip.Text = "";
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            btn_usu.Enabled = false;
            btn_demandd.Enabled = false;
            btn_demandt.Enabled = false;
            btn_anex.Enabled = false;
            btn_abog.Enabled = false;
            dp_fecha.Enabled = false;
            txt_asunto.Enabled = false;
            cb_estado.Enabled = false;
            txt_cantfol.Enabled = false;
            txt_progre.Enabled = false;
            txt_descrip.Enabled = false;
            btn_guardar.Enabled = false;
            btn_modificar.Enabled = false;
            button3.Enabled = true;
            try
            {

                SqlCommand cmd = new SqlCommand("insertar_MovExp", con.AbrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@movexp_id", SqlDbType.Int);
                cmd.Parameters.Add("@ab_id", SqlDbType.Int);
                cmd.Parameters.Add("@usu_id", SqlDbType.Int);
                cmd.Parameters.Add("@demte_id", SqlDbType.Int);
                cmd.Parameters.Add("@demdo_id", SqlDbType.Int);
                cmd.Parameters.Add("@anexo_id", SqlDbType.Int);
                cmd.Parameters.Add("@movexp_asunto", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@movexp_fechaing", SqlDbType.Date);
                cmd.Parameters.Add("@movexp_estado", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@movexp_progreso", SqlDbType.VarChar, 250);
                cmd.Parameters.Add("@movexp_cantfolios", SqlDbType.VarChar, 10);
                cmd.Parameters.Add("@movexp_descripcion", SqlDbType.VarChar, 250);
                cmd.Parameters.Add("@movexp_nro", SqlDbType.VarChar, 10);


                cmd.Parameters["@movexp_id"].Value = txt_id_movexp.Text;
                cmd.Parameters["@ab_id"].Value = txt_id_abo.Text;
                cmd.Parameters["@usu_id"].Value = txt_id_usu.Text;
                cmd.Parameters["@demte_id"].Value = txt_id_demandt.Text;
                cmd.Parameters["@demdo_id"].Value = txt_id_demandd.Text;
                cmd.Parameters["@anexo_id"].Value = txt_id_anex.Text;
                cmd.Parameters["@movexp_asunto"].Value = txt_asunto.Text;
                cmd.Parameters["@movexp_fechaing"].Value = dp_fecha.Text;
                cmd.Parameters["@movexp_estado"].Value = cb_estado.Text;
                cmd.Parameters["@movexp_progreso"].Value = txt_progre.Text;
                cmd.Parameters["@movexp_cantfolios"].Value = txt_cantfol.Text;
                cmd.Parameters["@movexp_descripcion"].Value = txt_descrip.Text;
                cmd.Parameters["@movexp_nro"].Value = txt_nroexp.Text;



                con.AbrirConexion();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Los datos fueron modificados correctamente");
                //generarid();
                //mostrar();
                con.CerrarConexion();
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            txt_asunto.Text = "";
            txt_cantfol.Text = "";
            txt_progre.Text = "";
            txt_descrip.Text = "";
        }
        public void mostrar() {

            dgv_datos.DataSource = sad.mostrarmovexp();
        }
        public void generarid()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select isnull(Max(cast(movexp_id as int)),0)+1 from Movimiento_Expediente", con.AbrirConexion());
            DataTable sqlex = new DataTable();
            sda.Fill(sqlex);
            txt_id_movexp.Text = sqlex.Rows[0][0].ToString();
        }

        private void txt_cantfol_KeyPress(object sender, KeyPressEventArgs e)
        {
            validadcion.soloNumeros(e);
        }

        private void txt_asunto_Validated(object sender, EventArgs e)
        {
            if (txt_asunto.Text.Trim() == "")
            {
                errorAsunto.SetError(txt_asunto, "Ingrese Asunto");
            }
        }

        private void txt_progre_Validated(object sender, EventArgs e)
        {
            if (txt_progre.Text.Trim() == "")
            {
                errorProgreso.SetError(txt_progre, "Ingrese Progreso");
            }
        }

        private void txt_descrip_Validated(object sender, EventArgs e)
        {
            if (txt_descrip.Text.Trim() == "")
            {
                errorDescrip.SetError(txt_descrip, "Ingrese Descripción");
            }
        }

        private void txt_cantfol_Validated(object sender, EventArgs e)
        {
            if (txt_cantfol.Text.Trim() == "")
            {
                errorFolios.SetError(txt_cantfol, "Ingrese Cantidad de Folios");
            }
        }

        private void frm_Registrar_MovimientoExp_Activated(object sender, EventArgs e)
        {
            txt_id_usu.Text = Program.idusu;
            txt_nom_usu.Text = Program.nomusu;

            txt_id_demandd.Text = Program.id_demandado;
            txt_nom_demandd.Text = Program.nom_demandado;

            txt_id_demandt.Text = Program.id_demandante;
            txt_nom_demandt.Text = Program.nom_demandante;

            txt_id_anex.Text = Program.idanexo;
            txt_nom_anex.Text = Program.nomanexo;

            txt_id_abo.Text = Program.anid;

           txt_nom_abo.Text = Program.anom;

            txt_id_abo.Text = Program.idabogado;
            txt_nom_abo.Text = Program.nomabogado;


        }

        private void btn_usu_Click(object sender, EventArgs e)
        {
            Frm_buscar_Usuario x = new Frm_buscar_Usuario();
            x.ShowDialog();
        }

        private void btn_demandd_Click(object sender, EventArgs e)
        {
            Frm_buscar_demandado sa = new Frm_buscar_demandado();
            sa.ShowDialog();
      
        }

        private void btn_demandt_Click(object sender, EventArgs e)
        {
            Frm_buscar_demandante z = new Frm_buscar_demandante();
            z.ShowDialog();
        }

        private void btn_anex_Click(object sender, EventArgs e)
        {
            frm_buscar_anexo q = new frm_buscar_anexo();
            q.ShowDialog();
        }

        private void btn_abog_Click(object sender, EventArgs e)
        {
            Frm_buscar_abogado d = new Frm_buscar_abogado();
            d.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_nroexp.Enabled = true;
            btn_usu.Enabled = true;
            btn_demandd.Enabled = true;
            btn_demandt.Enabled = true;
            btn_anex.Enabled = true;
            btn_abog.Enabled = true;
            dp_fecha.Enabled = true;
            txt_asunto.Enabled = true;
            cb_estado.Enabled = true;
            txt_cantfol.Enabled = true;
            txt_progre.Enabled = true;
            txt_descrip.Enabled = true;
            btn_guardar.Enabled = true;
            btn_modificar.Enabled = false;
            button3.Enabled = false;

            txt_asunto.Text = "";
            txt_cantfol.Text = "";
            txt_progre.Text = "";
            txt_descrip.Text = "";

        }
    }
}
