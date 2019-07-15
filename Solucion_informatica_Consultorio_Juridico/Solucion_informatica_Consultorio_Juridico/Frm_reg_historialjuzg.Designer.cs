namespace Solucion_informatica_Consultorio_Juridico
{
    partial class Frm_reg_historialjuzg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_reg_historialjuzg));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.dgdatos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dt_recepcion = new System.Windows.Forms.DateTimePicker();
            this.dt_derivacion = new System.Windows.Forms.DateTimePicker();
            this.dt_resolucion = new System.Windows.Forms.DateTimePicker();
            this.dt_notificacion = new System.Windows.Forms.DateTimePicker();
            this.dt_solucion = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.dt1 = new System.Windows.Forms.DateTimePicker();
            this.button5 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_descripcion = new Capas.ErrorTxtBox();
            this.txt_pronunciamiento = new Capas.ErrorTxtBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgdatos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(83, 40);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(75, 20);
            this.txt_id.TabIndex = 1;
            this.txt_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_KeyPress);
            // 
            // dgdatos
            // 
            this.dgdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdatos.Location = new System.Drawing.Point(393, 259);
            this.dgdatos.Name = "dgdatos";
            this.dgdatos.Size = new System.Drawing.Size(459, 234);
            this.dgdatos.TabIndex = 2;
            this.dgdatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdatos_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton8);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.txt_buscar);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(393, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 91);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bùsqueda por :";
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(18, 19);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(36, 17);
            this.radioButton8.TabIndex = 30;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "ID";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(178, 16);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(104, 17);
            this.radioButton2.TabIndex = 29;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Pronunciamiento";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(11, 49);
            this.txt_buscar.MaxLength = 30;
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(240, 20);
            this.txt_buscar.TabIndex = 28;
            this.txt_buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_buscar_KeyPress);
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(318, 34);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 40);
            this.button4.TabIndex = 28;
            this.button4.Text = "Buscar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(91, 18);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(81, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Descripcion";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Recepcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pronunciamiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Derivacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Emision Resoluciòn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Notificaciòn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 356);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Soluciòn";
            // 
            // dt_recepcion
            // 
            this.dt_recepcion.CustomFormat = "dd-MM-yyyy";
            this.dt_recepcion.Enabled = false;
            this.dt_recepcion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_recepcion.Location = new System.Drawing.Point(113, 116);
            this.dt_recepcion.Name = "dt_recepcion";
            this.dt_recepcion.Size = new System.Drawing.Size(200, 20);
            this.dt_recepcion.TabIndex = 20;
            this.dt_recepcion.ValueChanged += new System.EventHandler(this.dt_recepcion_ValueChanged);
            this.dt_recepcion.Validating += new System.ComponentModel.CancelEventHandler(this.dt_recepcion_Validating);
            // 
            // dt_derivacion
            // 
            this.dt_derivacion.CustomFormat = "dd-MM-yyyy";
            this.dt_derivacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_derivacion.Location = new System.Drawing.Point(113, 208);
            this.dt_derivacion.Name = "dt_derivacion";
            this.dt_derivacion.Size = new System.Drawing.Size(200, 20);
            this.dt_derivacion.TabIndex = 22;
            this.dt_derivacion.ValueChanged += new System.EventHandler(this.dt_derivacion_ValueChanged);
            this.dt_derivacion.Validating += new System.ComponentModel.CancelEventHandler(this.dt_derivacion_Validating);
            // 
            // dt_resolucion
            // 
            this.dt_resolucion.CustomFormat = "dd-MM-yyyy";
            this.dt_resolucion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_resolucion.Location = new System.Drawing.Point(113, 259);
            this.dt_resolucion.Name = "dt_resolucion";
            this.dt_resolucion.Size = new System.Drawing.Size(200, 20);
            this.dt_resolucion.TabIndex = 23;
            this.dt_resolucion.Validating += new System.ComponentModel.CancelEventHandler(this.dt_resolucion_Validating);
            // 
            // dt_notificacion
            // 
            this.dt_notificacion.CustomFormat = "dd-MM-yyyy";
            this.dt_notificacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_notificacion.Location = new System.Drawing.Point(113, 311);
            this.dt_notificacion.Name = "dt_notificacion";
            this.dt_notificacion.Size = new System.Drawing.Size(200, 20);
            this.dt_notificacion.TabIndex = 24;
            this.dt_notificacion.Validating += new System.ComponentModel.CancelEventHandler(this.dt_notificacion_Validating);
            // 
            // dt_solucion
            // 
            this.dt_solucion.CustomFormat = "dd-MM-yyyy";
            this.dt_solucion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_solucion.Location = new System.Drawing.Point(113, 350);
            this.dt_solucion.Name = "dt_solucion";
            this.dt_solucion.Size = new System.Drawing.Size(200, 20);
            this.dt_solucion.TabIndex = 25;
            this.dt_solucion.Validating += new System.ComponentModel.CancelEventHandler(this.dt_solucion_Validating);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(138, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 44);
            this.button2.TabIndex = 26;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(273, 405);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 44);
            this.button3.TabIndex = 27;
            this.button3.Text = "Nuevo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton7);
            this.groupBox2.Controls.Add(this.radioButton6);
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dt1);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Location = new System.Drawing.Point(393, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 116);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bùsqueda por :";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(352, 40);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(66, 17);
            this.radioButton7.TabIndex = 35;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Solucion";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(265, 40);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(81, 17);
            this.radioButton6.TabIndex = 34;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Notificacion";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(188, 38);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(61, 17);
            this.radioButton5.TabIndex = 33;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Emision";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(106, 37);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(76, 17);
            this.radioButton4.TabIndex = 32;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Derivacion";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(9, 36);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(77, 17);
            this.radioButton3.TabIndex = 30;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Recepcion";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Fecha";
            // 
            // dt1
            // 
            this.dt1.CustomFormat = "yyyy-MM-dd";
            this.dt1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt1.Location = new System.Drawing.Point(71, 76);
            this.dt1.Name = "dt1";
            this.dt1.Size = new System.Drawing.Size(200, 20);
            this.dt1.TabIndex = 31;
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(320, 63);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 43);
            this.button5.TabIndex = 28;
            this.button5.Text = "Buscar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(23, 473);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(244, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Nota : No podràs modificar la fecha de Recepciòn";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(97, 73);
            this.txt_descripcion.MaxLength = 50;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(216, 20);
            this.txt_descripcion.TabIndex = 32;
            this.txt_descripcion.Validar = true;
            this.txt_descripcion.TextChanged += new System.EventHandler(this.txt_descripcion_TextChanged);
            // 
            // txt_pronunciamiento
            // 
            this.txt_pronunciamiento.Location = new System.Drawing.Point(113, 161);
            this.txt_pronunciamiento.MaxLength = 50;
            this.txt_pronunciamiento.Name = "txt_pronunciamiento";
            this.txt_pronunciamiento.Size = new System.Drawing.Size(200, 20);
            this.txt_pronunciamiento.TabIndex = 33;
            this.txt_pronunciamiento.Validar = true;
            this.txt_pronunciamiento.TextChanged += new System.EventHandler(this.txt_pronunciamiento_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Frm_reg_historialjuzg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(874, 505);
            this.Controls.Add(this.txt_pronunciamiento);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dt_solucion);
            this.Controls.Add(this.dt_notificacion);
            this.Controls.Add(this.dt_resolucion);
            this.Controls.Add(this.dt_derivacion);
            this.Controls.Add(this.dt_recepcion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgdatos);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label1);
            this.Name = "Frm_reg_historialjuzg";
            this.Text = "Historial juzgado";
            this.Activated += new System.EventHandler(this.Frm_reg_historialjuzg_Activated);
            this.Load += new System.EventHandler(this.Frm_reg_historialjuzg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdatos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.DataGridView dgdatos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dt_recepcion;
        private System.Windows.Forms.DateTimePicker dt_derivacion;
        private System.Windows.Forms.DateTimePicker dt_resolucion;
        private System.Windows.Forms.DateTimePicker dt_notificacion;
        private System.Windows.Forms.DateTimePicker dt_solucion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dt1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton radioButton8;
        private Capas.ErrorTxtBox txt_descripcion;
        private Capas.ErrorTxtBox txt_pronunciamiento;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}