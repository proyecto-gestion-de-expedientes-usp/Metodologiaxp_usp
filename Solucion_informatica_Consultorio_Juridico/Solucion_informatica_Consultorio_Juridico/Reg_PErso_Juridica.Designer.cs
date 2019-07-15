namespace Solucion_informatica_Consultorio_Juridico
{
    partial class Reg_PErso_Juridica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reg_PErso_Juridica));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_mod_pj = new System.Windows.Forms.Button();
            this.btn_guar_perj = new System.Windows.Forms.Button();
            this.cb_distritos_persoJ = new System.Windows.Forms.ComboBox();
            this.cb_provin_persoJ = new System.Windows.Forms.ComboBox();
            this.cb_dpto_persoJ = new System.Windows.Forms.ComboBox();
            this.dp_cre_persoJ = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_ruc_bus = new System.Windows.Forms.TextBox();
            this.dgv_jurid = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_email_persoJ = new System.Windows.Forms.TextBox();
            this.txt_tel_persoJ = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.txt_ruc_persoJ = new System.Windows.Forms.TextBox();
            this.txt_domic_persoJ = new System.Windows.Forms.TextBox();
            this.txt_nom_persoJ = new System.Windows.Forms.TextBox();
            this.txt_id_Doc_persoJ = new System.Windows.Forms.TextBox();
            this.txt_id_persoJ = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_jurid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_mod_pj);
            this.groupBox3.Controls.Add(this.btn_guar_perj);
            this.groupBox3.Controls.Add(this.cb_distritos_persoJ);
            this.groupBox3.Controls.Add(this.cb_provin_persoJ);
            this.groupBox3.Controls.Add(this.cb_dpto_persoJ);
            this.groupBox3.Controls.Add(this.dp_cre_persoJ);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.btnnuevo);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.txt_email_persoJ);
            this.groupBox3.Controls.Add(this.txt_tel_persoJ);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.txt_ruc_persoJ);
            this.groupBox3.Controls.Add(this.txt_domic_persoJ);
            this.groupBox3.Controls.Add(this.txt_nom_persoJ);
            this.groupBox3.Controls.Add(this.txt_id_Doc_persoJ);
            this.groupBox3.Controls.Add(this.txt_id_persoJ);
            this.groupBox3.Location = new System.Drawing.Point(12, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(816, 432);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos de la Persona";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btn_mod_pj
            // 
            this.btn_mod_pj.Image = ((System.Drawing.Image)(resources.GetObject("btn_mod_pj.Image")));
            this.btn_mod_pj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_mod_pj.Location = new System.Drawing.Point(146, 311);
            this.btn_mod_pj.Name = "btn_mod_pj";
            this.btn_mod_pj.Size = new System.Drawing.Size(114, 45);
            this.btn_mod_pj.TabIndex = 45;
            this.btn_mod_pj.Text = "Modificar";
            this.btn_mod_pj.UseVisualStyleBackColor = true;
            this.btn_mod_pj.Click += new System.EventHandler(this.btn_mod_pj_Click);
            // 
            // btn_guar_perj
            // 
            this.btn_guar_perj.Image = ((System.Drawing.Image)(resources.GetObject("btn_guar_perj.Image")));
            this.btn_guar_perj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guar_perj.Location = new System.Drawing.Point(6, 311);
            this.btn_guar_perj.Name = "btn_guar_perj";
            this.btn_guar_perj.Size = new System.Drawing.Size(117, 45);
            this.btn_guar_perj.TabIndex = 44;
            this.btn_guar_perj.Text = "Guardar";
            this.btn_guar_perj.UseVisualStyleBackColor = true;
            this.btn_guar_perj.Click += new System.EventHandler(this.btn_guar_perj_Click);
            // 
            // cb_distritos_persoJ
            // 
            this.cb_distritos_persoJ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_distritos_persoJ.FormattingEnabled = true;
            this.cb_distritos_persoJ.Location = new System.Drawing.Point(122, 144);
            this.cb_distritos_persoJ.Name = "cb_distritos_persoJ";
            this.cb_distritos_persoJ.Size = new System.Drawing.Size(121, 21);
            this.cb_distritos_persoJ.TabIndex = 41;
            // 
            // cb_provin_persoJ
            // 
            this.cb_provin_persoJ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_provin_persoJ.FormattingEnabled = true;
            this.cb_provin_persoJ.Location = new System.Drawing.Point(122, 120);
            this.cb_provin_persoJ.Name = "cb_provin_persoJ";
            this.cb_provin_persoJ.Size = new System.Drawing.Size(121, 21);
            this.cb_provin_persoJ.TabIndex = 42;
            // 
            // cb_dpto_persoJ
            // 
            this.cb_dpto_persoJ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_dpto_persoJ.FormattingEnabled = true;
            this.cb_dpto_persoJ.Location = new System.Drawing.Point(122, 97);
            this.cb_dpto_persoJ.Name = "cb_dpto_persoJ";
            this.cb_dpto_persoJ.Size = new System.Drawing.Size(121, 21);
            this.cb_dpto_persoJ.TabIndex = 43;
            // 
            // dp_cre_persoJ
            // 
            this.dp_cre_persoJ.CustomFormat = "yyyy-MM-dd";
            this.dp_cre_persoJ.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dp_cre_persoJ.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dp_cre_persoJ.Location = new System.Drawing.Point(642, 45);
            this.dp_cre_persoJ.MinDate = new System.DateTime(1945, 1, 1, 0, 0, 0, 0);
            this.dp_cre_persoJ.Name = "dp_cre_persoJ";
            this.dp_cre_persoJ.Size = new System.Drawing.Size(74, 20);
            this.dp_cre_persoJ.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(495, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Fecha de Creacion Empresa";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_ruc_bus);
            this.groupBox4.Controls.Add(this.dgv_jurid);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Location = new System.Drawing.Point(323, 97);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(447, 323);
            this.groupBox4.TabIndex = 38;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Buscar Persona Juridica";
            // 
            // txt_ruc_bus
            // 
            this.txt_ruc_bus.Location = new System.Drawing.Point(9, 52);
            this.txt_ruc_bus.MaxLength = 13;
            this.txt_ruc_bus.Name = "txt_ruc_bus";
            this.txt_ruc_bus.Size = new System.Drawing.Size(191, 20);
            this.txt_ruc_bus.TabIndex = 43;
            // 
            // dgv_jurid
            // 
            this.dgv_jurid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_jurid.Location = new System.Drawing.Point(9, 78);
            this.dgv_jurid.Name = "dgv_jurid";
            this.dgv_jurid.Size = new System.Drawing.Size(432, 239);
            this.dgv_jurid.TabIndex = 42;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 29);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(119, 13);
            this.label16.TabIndex = 41;
            this.label16.Text = "Busqueda por Nro RUC";
            // 
            // btnnuevo
            // 
            this.btnnuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnnuevo.Image")));
            this.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnuevo.Location = new System.Drawing.Point(70, 371);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(113, 49);
            this.btnnuevo.TabIndex = 35;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(59, 226);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "Email";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(59, 200);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 13);
            this.label18.TabIndex = 33;
            this.label18.Text = "Telefono";
            // 
            // txt_email_persoJ
            // 
            this.txt_email_persoJ.Location = new System.Drawing.Point(122, 223);
            this.txt_email_persoJ.MaxLength = 30;
            this.txt_email_persoJ.Name = "txt_email_persoJ";
            this.txt_email_persoJ.Size = new System.Drawing.Size(180, 20);
            this.txt_email_persoJ.TabIndex = 32;
            // 
            // txt_tel_persoJ
            // 
            this.txt_tel_persoJ.Location = new System.Drawing.Point(122, 197);
            this.txt_tel_persoJ.MaxLength = 15;
            this.txt_tel_persoJ.Name = "txt_tel_persoJ";
            this.txt_tel_persoJ.Size = new System.Drawing.Size(138, 20);
            this.txt_tel_persoJ.TabIndex = 31;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(356, 48);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(27, 13);
            this.label19.TabIndex = 30;
            this.label19.Text = "Ruc";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(181, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 29;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(38, 174);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(78, 13);
            this.label20.TabIndex = 27;
            this.label20.Text = "Domicilio Legal";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(42, 100);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(74, 13);
            this.label21.TabIndex = 25;
            this.label21.Text = "Departamento";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(59, 122);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(51, 13);
            this.label22.TabIndex = 24;
            this.label22.Text = "Provincia";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(67, 147);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(39, 13);
            this.label23.TabIndex = 28;
            this.label23.Text = "Distrito";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(67, 74);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(49, 13);
            this.label26.TabIndex = 21;
            this.label26.Text = "Nombres";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(11, 48);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(107, 13);
            this.label27.TabIndex = 20;
            this.label27.Text = "Id tipo de documento";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(59, 22);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(57, 13);
            this.label28.TabIndex = 19;
            this.label28.Text = "Id persona";
            // 
            // txt_ruc_persoJ
            // 
            this.txt_ruc_persoJ.Location = new System.Drawing.Point(389, 45);
            this.txt_ruc_persoJ.MaxLength = 8;
            this.txt_ruc_persoJ.Name = "txt_ruc_persoJ";
            this.txt_ruc_persoJ.Size = new System.Drawing.Size(100, 20);
            this.txt_ruc_persoJ.TabIndex = 17;
            // 
            // txt_domic_persoJ
            // 
            this.txt_domic_persoJ.Location = new System.Drawing.Point(122, 171);
            this.txt_domic_persoJ.MaxLength = 20;
            this.txt_domic_persoJ.Name = "txt_domic_persoJ";
            this.txt_domic_persoJ.Size = new System.Drawing.Size(180, 20);
            this.txt_domic_persoJ.TabIndex = 16;
            // 
            // txt_nom_persoJ
            // 
            this.txt_nom_persoJ.Location = new System.Drawing.Point(122, 71);
            this.txt_nom_persoJ.MaxLength = 20;
            this.txt_nom_persoJ.Name = "txt_nom_persoJ";
            this.txt_nom_persoJ.Size = new System.Drawing.Size(180, 20);
            this.txt_nom_persoJ.TabIndex = 9;
            // 
            // txt_id_Doc_persoJ
            // 
            this.txt_id_Doc_persoJ.Enabled = false;
            this.txt_id_Doc_persoJ.Location = new System.Drawing.Point(122, 45);
            this.txt_id_Doc_persoJ.Name = "txt_id_Doc_persoJ";
            this.txt_id_Doc_persoJ.Size = new System.Drawing.Size(53, 20);
            this.txt_id_Doc_persoJ.TabIndex = 18;
            // 
            // txt_id_persoJ
            // 
            this.txt_id_persoJ.Enabled = false;
            this.txt_id_persoJ.Location = new System.Drawing.Point(122, 19);
            this.txt_id_persoJ.Name = "txt_id_persoJ";
            this.txt_id_persoJ.Size = new System.Drawing.Size(53, 20);
            this.txt_id_persoJ.TabIndex = 8;
            // 
            // Reg_PErso_Juridica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 462);
            this.Controls.Add(this.groupBox3);
            this.Name = "Reg_PErso_Juridica";
            this.Text = "Reg_PErso_Juridica";
            this.Load += new System.EventHandler(this.Reg_PErso_Juridica_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_jurid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_mod_pj;
        private System.Windows.Forms.Button btn_guar_perj;
        private System.Windows.Forms.ComboBox cb_distritos_persoJ;
        private System.Windows.Forms.ComboBox cb_provin_persoJ;
        private System.Windows.Forms.ComboBox cb_dpto_persoJ;
        private System.Windows.Forms.DateTimePicker dp_cre_persoJ;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_ruc_bus;
        private System.Windows.Forms.DataGridView dgv_jurid;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_email_persoJ;
        private System.Windows.Forms.TextBox txt_tel_persoJ;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txt_ruc_persoJ;
        private System.Windows.Forms.TextBox txt_domic_persoJ;
        private System.Windows.Forms.TextBox txt_nom_persoJ;
        private System.Windows.Forms.TextBox txt_id_Doc_persoJ;
        private System.Windows.Forms.TextBox txt_id_persoJ;
    }
}