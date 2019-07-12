﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Solucion_informatica_Consultorio_Juridico
{

    

    public partial class frm_registrar_usuario : Form
    {
        Clases.Validacioes validadcion = new Clases.Validacioes();
        SqlConnection gh;
        string campo;
        DataTable dts = new DataTable();
        DataTable ds = new DataTable();

        public frm_registrar_usuario()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frm_registrar_usuario_Load(object sender, EventArgs e)
        {
              

            gh = new SqlConnection("database=consultoriojur;data source=.;integrated security=true");

            mostrartipousuario();

            mostrarestadousuario();
            //btn_modificar.Enabled = false;
        }
        public void mostrarestadousuario()
        {

            gh.Open();
            string sql = "select * from Estado_Usu";
            SqlDataAdapter da = new SqlDataAdapter(sql, gh);

            da.Fill(dts);
            cb_esta_usua.DataSource = dts;
            cb_esta_usua.DisplayMember = "est_condi";

            gh.Close();

        }
        public void mostrartipousuario()
        {

            gh.Open();
            string sql = "select * from Tipo_Usuario";
            SqlDataAdapter da = new SqlDataAdapter(sql, gh);

            da.Fill(ds);
            cb_tip_usu.DataSource = ds;
            cb_tip_usu.DisplayMember = "tipusu_tipousuario";

            gh.Close();

        }

        private void cb_esta_usua_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = cb_esta_usua.SelectedIndex;
            txt_cod_estausua.Text = dts.Rows[a]["id_estusu"].ToString();
        }

        private void cb_tip_usu_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = cb_tip_usu.SelectedIndex;
            txt_cod_tipusua.Text = ds.Rows[a]["tipusu_id"].ToString();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                string ConnectionString = "database=consultoriojur;data source=.;integrated security=sspi";
                SqlConnection cnn = new SqlConnection(ConnectionString);
                SqlCommand cmd = new SqlCommand("insertar_Usu", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@usu_id", SqlDbType.Int);
                cmd.Parameters.Add("@tipusu_id", SqlDbType.Int);
                cmd.Parameters.Add("@usu_dni", SqlDbType.Char, 8);
                cmd.Parameters.Add("@usu_nombres", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@usu_apellidopat", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@usu_apellidomat", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@usu_telefono", SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@usu_direccion", SqlDbType.VarChar, 40);
                cmd.Parameters.Add("@usu_sexo", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@usu_correo", SqlDbType.VarChar, 60);
                cmd.Parameters.Add("@usu_estadocivil", SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@usu_fechanac", SqlDbType.Date);
                cmd.Parameters.Add("@usu_ciudad", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@usu_provincia", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@id_estusu", SqlDbType.Int);
                cmd.Parameters.Add("@usu_departamento", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@usu_contraseña", SqlDbType.VarChar, 30);

                cmd.Parameters["@usu_id"].Value = txt_id_usu.Text;
                cmd.Parameters["@tipusu_id"].Value = txt_cod_tipusua.Text;
                cmd.Parameters["@usu_dni"].Value = txt_dni.Text;
                cmd.Parameters["@usu_nombres"].Value = txt_nombres.Text;
                cmd.Parameters["@usu_apellidopat"].Value = txt_apepat.Text;
                cmd.Parameters["@usu_apellidomat"].Value = txt_apemat.Text;
                cmd.Parameters["@usu_telefono"].Value = txt_cel.Text;
                cmd.Parameters["@usu_direccion"].Value = txt_domici.Text;
                cmd.Parameters["@usu_sexo"].Value = cb_Sexo.Text;
                cmd.Parameters["@usu_correo"].Value = txt_correo.Text;
                cmd.Parameters["@usu_estadocivil"].Value = cb_estadoci.Text;
                cmd.Parameters["@usu_fechanac"].Value = dp_fenaci.Text;
                cmd.Parameters["@usu_ciudad"].Value = txt_distrito.Text;
                cmd.Parameters["@usu_provincia"].Value = txt_provincia.Text;
                cmd.Parameters["@id_estusu"].Value = txt_cod_estausua.Text;
                cmd.Parameters["@usu_departamento"].Value = txt_dpto.Text;
                cmd.Parameters["@usu_contraseña"].Value = txt_contra.Text;


                cnn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Los datos fueron insertados correctamente");
                cnn.Close();
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dp_fenaci_ValueChanged(object sender, EventArgs e)
        {
            campo = "@usu_fechanac";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                string ConnectionString = "database=consultoriojur;data source=.;integrated security=sspi";
                SqlConnection cnn = new SqlConnection(ConnectionString);
                SqlCommand cmd = new SqlCommand("actualizar_Usu", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@usu_id", SqlDbType.Int);
                cmd.Parameters.Add("@tipusu_id", SqlDbType.Int);
                cmd.Parameters.Add("@usu_dni", SqlDbType.Char, 8);
                cmd.Parameters.Add("@usu_nombres", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@usu_apellidopat", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@usu_apellidomat", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@usu_telefono", SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@usu_direccion", SqlDbType.VarChar, 40);
                cmd.Parameters.Add("@usu_sexo", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@usu_correo", SqlDbType.VarChar, 60);
                cmd.Parameters.Add("@usu_estadocivil", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@usu_fechanac", SqlDbType.Date);
                cmd.Parameters.Add("@usu_ciudad", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@usu_provincia", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@id_estusu", SqlDbType.Int);
                cmd.Parameters.Add("@usu_departamento", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@usu_contraseña", SqlDbType.VarChar, 30);

                cmd.Parameters["@usu_id"].Value = txt_id_usu.Text;
                cmd.Parameters["@tipusu_id"].Value = txt_cod_tipusua.Text;
                cmd.Parameters["@usu_dni"].Value = txt_dni.Text;
                cmd.Parameters["@usu_nombres"].Value = txt_nombres.Text;
                cmd.Parameters["@usu_apellidopat"].Value = txt_apepat.Text;
                cmd.Parameters["@usu_apellidomat"].Value = txt_apemat.Text;
                cmd.Parameters["@usu_telefono"].Value = txt_cel.Text;
                cmd.Parameters["@usu_direccion"].Value = txt_domici.Text;
                cmd.Parameters["@usu_sexo"].Value = cb_Sexo.Text;
                cmd.Parameters["@usu_correo"].Value = txt_correo.Text;
                cmd.Parameters["@usu_estadocivil"].Value = cb_estadoci.Text;
                cmd.Parameters["@usu_fechanac"].Value = dp_fenaci.Text;
                cmd.Parameters["@usu_ciudad"].Value = txt_distrito.Text;
                cmd.Parameters["@usu_provincia"].Value = txt_provincia.Text;
                cmd.Parameters["@id_estusu"].Value = txt_cod_estausua.Text;
                cmd.Parameters["@usu_departamento"].Value = txt_dpto.Text;
                cmd.Parameters["@usu_contraseña"].Value = txt_contra.Text;


                cnn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Los datos fueron modificados correctamente");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txt_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            validadcion.soloNumeros(e);
        }

        private void txt_cel_KeyPress(object sender, KeyPressEventArgs e)
        {
            validadcion.soloNumeros(e);
        }

        private void txt_nombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            validadcion.soloLetras(e);
        }

        private void txt_apepat_KeyPress(object sender, KeyPressEventArgs e)
        {
            validadcion.soloLetras(e);
        }

        private void txt_apemat_KeyPress(object sender, KeyPressEventArgs e)
        {
            validadcion.soloLetras(e);
        }

        private void txt_dpto_KeyPress(object sender, KeyPressEventArgs e)
        {
            validadcion.soloLetras(e);
        }

        private void txt_provincia_KeyPress(object sender, KeyPressEventArgs e)
        {
            validadcion.soloLetras(e);
        }

        private void txt_distrito_KeyPress(object sender, KeyPressEventArgs e)
        {
            validadcion.soloLetras(e);
        }
        public static bool Valorreo(string email)
        {
            string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                { return true; }
                else
                { return false; }
            }
            else
            { return false; }
        }
        private void txt_correo_Leave(object sender, EventArgs e)
        {
            if (Valorreo(txt_correo.Text))
            {

            }
            else
            {
                MessageBox.Show("Dirección de correo electrónico no valido, el correo debe tener el formato: nombre@dominio.com, " +
                    " por favor ingrese un correo válido", "Alerta", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                txt_correo.SelectAll();
                txt_correo.Focus();
            }

        }

        private void txt_nombres_Validated(object sender, EventArgs e)
        {
            if (txt_nombres.Text.Trim() == "")
            {
                errorNombre.SetError(txt_nombres, "Ingrese Nombres...");
            }
        }

        private void txt_apepat_Validated(object sender, EventArgs e)
        {
            if (txt_apepat.Text.Trim() == "")
            {
                errorNombre.SetError(txt_apepat, "Ingrese Apellido Paterno...");
            }
        }

        private void txt_apemat_Validated(object sender, EventArgs e)
        {
            if (txt_apemat.Text.Trim() == "")
            {
                errorNombre.SetError(txt_apemat, "Ingrese Apellido Materno...");
            }
        }

        private void txt_dpto_Validated(object sender, EventArgs e)
        {
            if (txt_dpto.Text.Trim() == "")
            {
                errorNombre.SetError(txt_dpto, "Ingrese Departamento...");
            }
        }

        private void txt_provincia_Validated(object sender, EventArgs e)
        {
            if (txt_provincia.Text.Trim() == "")
            {
                errorNombre.SetError(txt_provincia, "Ingrese Provincia...");
            }
        }

        private void txt_distrito_Validated(object sender, EventArgs e)
        {
            if (txt_distrito.Text.Trim() == "")
            {
                errorNombre.SetError(txt_distrito, "Ingrese Distrito...");
            }
        }

        private void txt_domici_Validated(object sender, EventArgs e)
        {
            if (txt_domici.Text.Trim() == "")
            {
                errorNombre.SetError(txt_domici, "Ingrese Domicilio...");
            }
        }

        private void txt_dni_Validated(object sender, EventArgs e)
        {

        }

        private void txt_dni_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_dni_Validating(object sender, CancelEventArgs e)
        {
            var cadena = txt_dni.Text;
            if (cadena.Length > 8)
            {
                txt_dni.Focus();
                MessageBox.Show("El dni solo tiene 8 digitos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                if (cadena.Length < 8)
                {
                    MessageBox.Show("Ingrese los 8 digitos del DNI 😎", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
    }

