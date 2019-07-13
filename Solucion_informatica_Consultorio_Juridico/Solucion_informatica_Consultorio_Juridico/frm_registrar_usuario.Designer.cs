namespace Solucion_informatica_Consultorio_Juridico
{
    partial class frm_registrar_usuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_registrar_usuario));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cb_Sexo = new System.Windows.Forms.ComboBox();
            this.cb_estadoci = new System.Windows.Forms.ComboBox();
            this.cb_esta_usua = new System.Windows.Forms.ComboBox();
            this.dp_fenaci = new System.Windows.Forms.DateTimePicker();
            this.txt_id_usu = new System.Windows.Forms.TextBox();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.txt_nombres = new System.Windows.Forms.TextBox();
            this.txt_apepat = new System.Windows.Forms.TextBox();
            this.txt_apemat = new System.Windows.Forms.TextBox();
            this.txt_cel = new System.Windows.Forms.TextBox();
            this.txt_domici = new System.Windows.Forms.TextBox();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.txt_contra = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_distritos = new System.Windows.Forms.ComboBox();
            this.cb_provin = new System.Windows.Forms.ComboBox();
            this.cb_dpto = new System.Windows.Forms.ComboBox();
            this.txt_cod_tipusua = new System.Windows.Forms.TextBox();
            this.txt_cod_estausua = new System.Windows.Forms.TextBox();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_tip_usu = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbt_dni = new System.Windows.Forms.RadioButton();
            this.rbt_nom_apepatymat = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgv_usuarios = new System.Windows.Forms.DataGridView();
            this.errorNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorApePaterno = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorApeMaterno = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDomicilio = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDepar = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDistri = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorApePaterno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorApeMaterno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDomicilio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDepar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDistri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tipo de usuario:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Dni:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nombres:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Apellido Paterno:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Apellido Materno:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Teléfono/Celular:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Domicilio:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Sexo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Correo:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 263);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Estado civil:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 290);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Fecha de Nacimiento :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 316);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Departamento:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(34, 339);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Provincia:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(39, 363);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Distrito:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(58, 75);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Contraseña:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1, 395);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(97, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Estado de Usuario:";
            // 
            // cb_Sexo
            // 
            this.cb_Sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Sexo.FormattingEnabled = true;
            this.cb_Sexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cb_Sexo.Location = new System.Drawing.Point(101, 235);
            this.cb_Sexo.Name = "cb_Sexo";
            this.cb_Sexo.Size = new System.Drawing.Size(121, 21);
            this.cb_Sexo.TabIndex = 1;
            // 
            // cb_estadoci
            // 
            this.cb_estadoci.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_estadoci.FormattingEnabled = true;
            this.cb_estadoci.Items.AddRange(new object[] {
            "Soltero/a",
            "Casado/a",
            "Divorciado/a",
            "Viudo/a"});
            this.cb_estadoci.Location = new System.Drawing.Point(101, 260);
            this.cb_estadoci.Name = "cb_estadoci";
            this.cb_estadoci.Size = new System.Drawing.Size(121, 21);
            this.cb_estadoci.TabIndex = 1;
            // 
            // cb_esta_usua
            // 
            this.cb_esta_usua.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_esta_usua.FormattingEnabled = true;
            this.cb_esta_usua.Location = new System.Drawing.Point(153, 390);
            this.cb_esta_usua.Name = "cb_esta_usua";
            this.cb_esta_usua.Size = new System.Drawing.Size(121, 21);
            this.cb_esta_usua.TabIndex = 1;
            this.cb_esta_usua.SelectedIndexChanged += new System.EventHandler(this.cb_esta_usua_SelectedIndexChanged);
            // 
            // dp_fenaci
            // 
            this.dp_fenaci.Location = new System.Drawing.Point(138, 287);
            this.dp_fenaci.MaxDate = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            this.dp_fenaci.MinDate = new System.DateTime(1945, 1, 1, 0, 0, 0, 0);
            this.dp_fenaci.Name = "dp_fenaci";
            this.dp_fenaci.Size = new System.Drawing.Size(214, 20);
            this.dp_fenaci.TabIndex = 2;
            this.dp_fenaci.Value = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            this.dp_fenaci.ValueChanged += new System.EventHandler(this.dp_fenaci_ValueChanged);
            // 
            // txt_id_usu
            // 
            this.txt_id_usu.Enabled = false;
            this.txt_id_usu.Location = new System.Drawing.Point(101, 13);
            this.txt_id_usu.Name = "txt_id_usu";
            this.txt_id_usu.Size = new System.Drawing.Size(62, 20);
            this.txt_id_usu.TabIndex = 3;
            // 
            // txt_dni
            // 
            this.txt_dni.Location = new System.Drawing.Point(101, 39);
            this.txt_dni.MaxLength = 8;
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(130, 20);
            this.txt_dni.TabIndex = 3;
            this.txt_dni.TextChanged += new System.EventHandler(this.txt_dni_TextChanged);
            this.txt_dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dni_KeyPress);
            this.txt_dni.Validating += new System.ComponentModel.CancelEventHandler(this.txt_dni_Validating);
            this.txt_dni.Validated += new System.EventHandler(this.txt_dni_Validated);
            // 
            // txt_nombres
            // 
            this.txt_nombres.Location = new System.Drawing.Point(101, 65);
            this.txt_nombres.MaxLength = 20;
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.Size = new System.Drawing.Size(204, 20);
            this.txt_nombres.TabIndex = 3;
            this.txt_nombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombres_KeyPress);
            this.txt_nombres.Validated += new System.EventHandler(this.txt_nombres_Validated);
            // 
            // txt_apepat
            // 
            this.txt_apepat.Location = new System.Drawing.Point(101, 91);
            this.txt_apepat.MaxLength = 20;
            this.txt_apepat.Name = "txt_apepat";
            this.txt_apepat.Size = new System.Drawing.Size(179, 20);
            this.txt_apepat.TabIndex = 3;
            this.txt_apepat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_apepat_KeyPress);
            this.txt_apepat.Validated += new System.EventHandler(this.txt_apepat_Validated);
            // 
            // txt_apemat
            // 
            this.txt_apemat.Location = new System.Drawing.Point(101, 117);
            this.txt_apemat.MaxLength = 20;
            this.txt_apemat.Name = "txt_apemat";
            this.txt_apemat.Size = new System.Drawing.Size(179, 20);
            this.txt_apemat.TabIndex = 3;
            this.txt_apemat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_apemat_KeyPress);
            this.txt_apemat.Validated += new System.EventHandler(this.txt_apemat_Validated);
            // 
            // txt_cel
            // 
            this.txt_cel.Location = new System.Drawing.Point(101, 143);
            this.txt_cel.MaxLength = 10;
            this.txt_cel.Name = "txt_cel";
            this.txt_cel.Size = new System.Drawing.Size(121, 20);
            this.txt_cel.TabIndex = 3;
            this.txt_cel.TextChanged += new System.EventHandler(this.txt_cel_TextChanged);
            this.txt_cel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cel_KeyPress);
            // 
            // txt_domici
            // 
            this.txt_domici.Location = new System.Drawing.Point(101, 169);
            this.txt_domici.MaxLength = 40;
            this.txt_domici.Multiline = true;
            this.txt_domici.Name = "txt_domici";
            this.txt_domici.Size = new System.Drawing.Size(251, 60);
            this.txt_domici.TabIndex = 3;
            this.txt_domici.Validated += new System.EventHandler(this.txt_domici_Validated);
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(50, 27);
            this.txt_correo.MaxLength = 60;
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(207, 20);
            this.txt_correo.TabIndex = 3;
            this.txt_correo.Leave += new System.EventHandler(this.txt_correo_Leave);
            // 
            // txt_contra
            // 
            this.txt_contra.Location = new System.Drawing.Point(128, 72);
            this.txt_contra.MaxLength = 30;
            this.txt_contra.Name = "txt_contra";
            this.txt_contra.PasswordChar = '*';
            this.txt_contra.Size = new System.Drawing.Size(129, 20);
            this.txt_contra.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_distritos);
            this.groupBox1.Controls.Add(this.cb_provin);
            this.groupBox1.Controls.Add(this.cb_dpto);
            this.groupBox1.Controls.Add(this.txt_cod_tipusua);
            this.groupBox1.Controls.Add(this.txt_cod_estausua);
            this.groupBox1.Controls.Add(this.btn_salir);
            this.groupBox1.Controls.Add(this.btn_limpiar);
            this.groupBox1.Controls.Add(this.btn_modificar);
            this.groupBox1.Controls.Add(this.btn_guardar);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_domici);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_cel);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_apemat);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_apepat);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txt_nombres);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txt_dni);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txt_id_usu);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.dp_fenaci);
            this.groupBox1.Controls.Add(this.cb_tip_usu);
            this.groupBox1.Controls.Add(this.cb_Sexo);
            this.groupBox1.Controls.Add(this.cb_esta_usua);
            this.groupBox1.Controls.Add(this.cb_estadoci);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(712, 461);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cb_distritos
            // 
            this.cb_distritos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_distritos.FormattingEnabled = true;
            this.cb_distritos.Location = new System.Drawing.Point(94, 360);
            this.cb_distritos.Name = "cb_distritos";
            this.cb_distritos.Size = new System.Drawing.Size(121, 21);
            this.cb_distritos.TabIndex = 7;
            this.cb_distritos.SelectedIndexChanged += new System.EventHandler(this.cb_distritos_SelectedIndexChanged);
            // 
            // cb_provin
            // 
            this.cb_provin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_provin.FormattingEnabled = true;
            this.cb_provin.Location = new System.Drawing.Point(94, 336);
            this.cb_provin.Name = "cb_provin";
            this.cb_provin.Size = new System.Drawing.Size(121, 21);
            this.cb_provin.TabIndex = 8;
            this.cb_provin.SelectedIndexChanged += new System.EventHandler(this.cb_provin_SelectedIndexChanged);
            // 
            // cb_dpto
            // 
            this.cb_dpto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_dpto.FormattingEnabled = true;
            this.cb_dpto.Location = new System.Drawing.Point(94, 313);
            this.cb_dpto.Name = "cb_dpto";
            this.cb_dpto.Size = new System.Drawing.Size(121, 21);
            this.cb_dpto.TabIndex = 9;
            this.cb_dpto.SelectedIndexChanged += new System.EventHandler(this.cb_dpto_SelectedIndexChanged);
            // 
            // txt_cod_tipusua
            // 
            this.txt_cod_tipusua.Location = new System.Drawing.Point(101, 417);
            this.txt_cod_tipusua.Name = "txt_cod_tipusua";
            this.txt_cod_tipusua.Size = new System.Drawing.Size(46, 20);
            this.txt_cod_tipusua.TabIndex = 6;
            // 
            // txt_cod_estausua
            // 
            this.txt_cod_estausua.Location = new System.Drawing.Point(101, 391);
            this.txt_cod_estausua.Name = "txt_cod_estausua";
            this.txt_cod_estausua.Size = new System.Drawing.Size(46, 20);
            this.txt_cod_estausua.TabIndex = 6;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(571, 379);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(119, 33);
            this.btn_salir.TabIndex = 5;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(571, 319);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(119, 33);
            this.btn_limpiar.TabIndex = 5;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(571, 260);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(119, 33);
            this.btn_modificar.TabIndex = 5;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(571, 198);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(119, 33);
            this.btn_guardar.TabIndex = 5;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txt_contra);
            this.groupBox2.Controls.Add(this.txt_correo);
            this.groupBox2.Location = new System.Drawing.Point(392, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 108);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Usuario de Sesion";
            // 
            // cb_tip_usu
            // 
            this.cb_tip_usu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tip_usu.FormattingEnabled = true;
            this.cb_tip_usu.Location = new System.Drawing.Point(153, 416);
            this.cb_tip_usu.Name = "cb_tip_usu";
            this.cb_tip_usu.Size = new System.Drawing.Size(121, 21);
            this.cb_tip_usu.TabIndex = 1;
            this.cb_tip_usu.SelectedIndexChanged += new System.EventHandler(this.cb_tip_usu_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbt_dni);
            this.groupBox3.Controls.Add(this.rbt_nom_apepatymat);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.dgv_usuarios);
            this.groupBox3.Location = new System.Drawing.Point(730, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(478, 460);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Busqueda por";
            // 
            // rbt_dni
            // 
            this.rbt_dni.AutoSize = true;
            this.rbt_dni.Location = new System.Drawing.Point(97, 21);
            this.rbt_dni.Name = "rbt_dni";
            this.rbt_dni.Size = new System.Drawing.Size(41, 17);
            this.rbt_dni.TabIndex = 10;
            this.rbt_dni.TabStop = true;
            this.rbt_dni.Text = "Dni";
            this.rbt_dni.UseVisualStyleBackColor = true;
            this.rbt_dni.CheckedChanged += new System.EventHandler(this.rbt_dni_CheckedChanged);
            // 
            // rbt_nom_apepatymat
            // 
            this.rbt_nom_apepatymat.AutoSize = true;
            this.rbt_nom_apepatymat.Location = new System.Drawing.Point(295, 21);
            this.rbt_nom_apepatymat.Name = "rbt_nom_apepatymat";
            this.rbt_nom_apepatymat.Size = new System.Drawing.Size(67, 17);
            this.rbt_nom_apepatymat.TabIndex = 11;
            this.rbt_nom_apepatymat.TabStop = true;
            this.rbt_nom_apepatymat.Text = "Apellidos";
            this.rbt_nom_apepatymat.UseVisualStyleBackColor = true;
            this.rbt_nom_apepatymat.CheckedChanged += new System.EventHandler(this.rbt_nom_apepatymat_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 46);
            this.textBox1.MaxLength = 30;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(466, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // dgv_usuarios
            // 
            this.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuarios.Location = new System.Drawing.Point(6, 72);
            this.dgv_usuarios.Name = "dgv_usuarios";
            this.dgv_usuarios.Size = new System.Drawing.Size(466, 367);
            this.dgv_usuarios.TabIndex = 8;
            this.dgv_usuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_usuarios_CellClick);
            // 
            // errorNombre
            // 
            this.errorNombre.ContainerControl = this;
            // 
            // errorApePaterno
            // 
            this.errorApePaterno.ContainerControl = this;
            // 
            // errorApeMaterno
            // 
            this.errorApeMaterno.ContainerControl = this;
            // 
            // errorDomicilio
            // 
            this.errorDomicilio.ContainerControl = this;
            // 
            // errorDepar
            // 
            this.errorDepar.ContainerControl = this;
            // 
            // errorProv
            // 
            this.errorProv.ContainerControl = this;
            // 
            // errorDistri
            // 
            this.errorDistri.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_registrar_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1220, 484);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_registrar_usuario";
            this.Opacity = 0.9D;
            this.Text = "Registrar Usuarios";
            this.Load += new System.EventHandler(this.frm_registrar_usuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorApePaterno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorApeMaterno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDomicilio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDepar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDistri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cb_Sexo;
        private System.Windows.Forms.ComboBox cb_estadoci;
        private System.Windows.Forms.ComboBox cb_esta_usua;
        private System.Windows.Forms.DateTimePicker dp_fenaci;
        private System.Windows.Forms.TextBox txt_id_usu;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.TextBox txt_nombres;
        private System.Windows.Forms.TextBox txt_apepat;
        private System.Windows.Forms.TextBox txt_apemat;
        private System.Windows.Forms.TextBox txt_cel;
        private System.Windows.Forms.TextBox txt_domici;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.TextBox txt_contra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_cod_tipusua;
        private System.Windows.Forms.TextBox txt_cod_estausua;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb_tip_usu;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbt_dni;
        private System.Windows.Forms.RadioButton rbt_nom_apepatymat;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgv_usuarios;
        private System.Windows.Forms.ErrorProvider errorNombre;
        private System.Windows.Forms.ErrorProvider errorApePaterno;
        private System.Windows.Forms.ErrorProvider errorApeMaterno;
        private System.Windows.Forms.ErrorProvider errorDomicilio;
        private System.Windows.Forms.ErrorProvider errorDepar;
        private System.Windows.Forms.ErrorProvider errorProv;
        private System.Windows.Forms.ErrorProvider errorDistri;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cb_distritos;
        private System.Windows.Forms.ComboBox cb_provin;
        private System.Windows.Forms.ComboBox cb_dpto;
    }
}