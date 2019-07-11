namespace Solucion_informatica_Consultorio_Juridico
{
    partial class frm_registrar_abogado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_registrar_abogado));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.cb_nombre = new System.Windows.Forms.ComboBox();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.txt_apemat = new System.Windows.Forms.TextBox();
            this.txt_apepat = new System.Windows.Forms.TextBox();
            this.txt_nomb = new System.Windows.Forms.TextBox();
            this.TXT_IDESTADO = new System.Windows.Forms.TextBox();
            this.txt_idtipabogado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_idAbogado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbt_nombape = new System.Windows.Forms.RadioButton();
            this.rbt_dni = new System.Windows.Forms.RadioButton();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.dgv_datos_abo = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos_abo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_estado);
            this.groupBox1.Controls.Add(this.cb_nombre);
            this.groupBox1.Controls.Add(this.txt_dni);
            this.groupBox1.Controls.Add(this.txt_apemat);
            this.groupBox1.Controls.Add(this.txt_apepat);
            this.groupBox1.Controls.Add(this.txt_nomb);
            this.groupBox1.Controls.Add(this.TXT_IDESTADO);
            this.groupBox1.Controls.Add(this.txt_idtipabogado);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_idAbogado);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 327);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Abogado";
            // 
            // cb_estado
            // 
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Location = new System.Drawing.Point(158, 240);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(114, 21);
            this.cb_estado.TabIndex = 2;
            // 
            // cb_nombre
            // 
            this.cb_nombre.FormattingEnabled = true;
            this.cb_nombre.Location = new System.Drawing.Point(158, 67);
            this.cb_nombre.Name = "cb_nombre";
            this.cb_nombre.Size = new System.Drawing.Size(114, 21);
            this.cb_nombre.TabIndex = 2;
            // 
            // txt_dni
            // 
            this.txt_dni.Location = new System.Drawing.Point(105, 279);
            this.txt_dni.MaxLength = 8;
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(118, 20);
            this.txt_dni.TabIndex = 1;
            this.txt_dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dni_KeyPress);
            // 
            // txt_apemat
            // 
            this.txt_apemat.Location = new System.Drawing.Point(105, 197);
            this.txt_apemat.MaxLength = 20;
            this.txt_apemat.Name = "txt_apemat";
            this.txt_apemat.Size = new System.Drawing.Size(118, 20);
            this.txt_apemat.TabIndex = 1;
            this.txt_apemat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_apemat_KeyPress);
            // 
            // txt_apepat
            // 
            this.txt_apepat.Location = new System.Drawing.Point(105, 153);
            this.txt_apepat.MaxLength = 20;
            this.txt_apepat.Name = "txt_apepat";
            this.txt_apepat.Size = new System.Drawing.Size(118, 20);
            this.txt_apepat.TabIndex = 1;
            this.txt_apepat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_apepat_KeyPress);
            // 
            // txt_nomb
            // 
            this.txt_nomb.Location = new System.Drawing.Point(105, 110);
            this.txt_nomb.MaxLength = 20;
            this.txt_nomb.Name = "txt_nomb";
            this.txt_nomb.Size = new System.Drawing.Size(118, 20);
            this.txt_nomb.TabIndex = 1;
            this.txt_nomb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nomb_KeyPress);
            // 
            // TXT_IDESTADO
            // 
            this.TXT_IDESTADO.Location = new System.Drawing.Point(105, 240);
            this.TXT_IDESTADO.Name = "TXT_IDESTADO";
            this.TXT_IDESTADO.Size = new System.Drawing.Size(47, 20);
            this.TXT_IDESTADO.TabIndex = 1;
            // 
            // txt_idtipabogado
            // 
            this.txt_idtipabogado.Enabled = false;
            this.txt_idtipabogado.Location = new System.Drawing.Point(105, 67);
            this.txt_idtipabogado.Name = "txt_idtipabogado";
            this.txt_idtipabogado.Size = new System.Drawing.Size(47, 20);
            this.txt_idtipabogado.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Dni";
            // 
            // txt_idAbogado
            // 
            this.txt_idAbogado.Enabled = false;
            this.txt_idAbogado.Location = new System.Drawing.Point(105, 27);
            this.txt_idAbogado.Name = "txt_idAbogado";
            this.txt_idAbogado.Size = new System.Drawing.Size(100, 20);
            this.txt_idAbogado.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Apellido Materno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Apellido Paterno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Id Tipo de Abogado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Abogado";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(66, 364);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 1;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(196, 364);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 1;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(66, 403);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar.TabIndex = 1;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(196, 403);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cerrar.TabIndex = 1;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbt_nombape);
            this.groupBox2.Controls.Add(this.rbt_dni);
            this.groupBox2.Controls.Add(this.txt_buscar);
            this.groupBox2.Controls.Add(this.dgv_datos_abo);
            this.groupBox2.Location = new System.Drawing.Point(346, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 426);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busqueda Por";
            // 
            // rbt_nombape
            // 
            this.rbt_nombape.AutoSize = true;
            this.rbt_nombape.Location = new System.Drawing.Point(6, 40);
            this.rbt_nombape.Name = "rbt_nombape";
            this.rbt_nombape.Size = new System.Drawing.Size(110, 17);
            this.rbt_nombape.TabIndex = 2;
            this.rbt_nombape.TabStop = true;
            this.rbt_nombape.Text = "Nombre y Apellido";
            this.rbt_nombape.UseVisualStyleBackColor = true;
            // 
            // rbt_dni
            // 
            this.rbt_dni.AutoSize = true;
            this.rbt_dni.Location = new System.Drawing.Point(170, 40);
            this.rbt_dni.Name = "rbt_dni";
            this.rbt_dni.Size = new System.Drawing.Size(44, 17);
            this.rbt_dni.TabIndex = 2;
            this.rbt_dni.TabStop = true;
            this.rbt_dni.Text = "DNI";
            this.rbt_dni.UseVisualStyleBackColor = true;
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(220, 37);
            this.txt_buscar.MaxLength = 30;
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(214, 20);
            this.txt_buscar.TabIndex = 1;
            // 
            // dgv_datos_abo
            // 
            this.dgv_datos_abo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datos_abo.Location = new System.Drawing.Point(6, 63);
            this.dgv_datos_abo.Name = "dgv_datos_abo";
            this.dgv_datos_abo.Size = new System.Drawing.Size(428, 351);
            this.dgv_datos_abo.TabIndex = 0;
            // 
            // frm_registrar_abogado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_registrar_abogado";
            this.Text = "Registrar Abogado";
            this.Load += new System.EventHandler(this.frm_registrar_abogado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos_abo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.TextBox txt_apemat;
        private System.Windows.Forms.TextBox txt_apepat;
        private System.Windows.Forms.TextBox txt_nomb;
        private System.Windows.Forms.TextBox txt_idtipabogado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_idAbogado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_datos_abo;
        private System.Windows.Forms.RadioButton rbt_nombape;
        private System.Windows.Forms.RadioButton rbt_dni;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.ComboBox cb_estado;
        private System.Windows.Forms.ComboBox cb_nombre;
        private System.Windows.Forms.TextBox TXT_IDESTADO;
    }
}