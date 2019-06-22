namespace Solucion_informatica_Consultorio_Juridico
{
    partial class frm_Menu_Admin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.maestroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abogadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarDemandadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarDemandanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maestroToolStripMenuItem,
            this.accionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(682, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // maestroToolStripMenuItem
            // 
            this.maestroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarUsuarioToolStripMenuItem,
            this.abogadoToolStripMenuItem,
            this.personaToolStripMenuItem});
            this.maestroToolStripMenuItem.Name = "maestroToolStripMenuItem";
            this.maestroToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.maestroToolStripMenuItem.Text = "Maestro";
            // 
            // registrarUsuarioToolStripMenuItem
            // 
            this.registrarUsuarioToolStripMenuItem.Name = "registrarUsuarioToolStripMenuItem";
            this.registrarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.registrarUsuarioToolStripMenuItem.Text = "Usuario";
            this.registrarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.registrarUsuarioToolStripMenuItem_Click);
            // 
            // abogadoToolStripMenuItem
            // 
            this.abogadoToolStripMenuItem.Name = "abogadoToolStripMenuItem";
            this.abogadoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.abogadoToolStripMenuItem.Text = "Abogado";
            this.abogadoToolStripMenuItem.Click += new System.EventHandler(this.abogadoToolStripMenuItem_Click);
            // 
            // personaToolStripMenuItem
            // 
            this.personaToolStripMenuItem.Name = "personaToolStripMenuItem";
            this.personaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.personaToolStripMenuItem.Text = "Persona";
            this.personaToolStripMenuItem.Click += new System.EventHandler(this.personaToolStripMenuItem_Click);
            // 
            // accionesToolStripMenuItem
            // 
            this.accionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarDemandadoToolStripMenuItem,
            this.registrarDemandanteToolStripMenuItem});
            this.accionesToolStripMenuItem.Name = "accionesToolStripMenuItem";
            this.accionesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.accionesToolStripMenuItem.Text = "Acciones";
            // 
            // registrarDemandadoToolStripMenuItem
            // 
            this.registrarDemandadoToolStripMenuItem.Name = "registrarDemandadoToolStripMenuItem";
            this.registrarDemandadoToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.registrarDemandadoToolStripMenuItem.Text = "Registrar Demandado";
            this.registrarDemandadoToolStripMenuItem.Click += new System.EventHandler(this.registrarDemandadoToolStripMenuItem_Click);
            // 
            // registrarDemandanteToolStripMenuItem
            // 
            this.registrarDemandanteToolStripMenuItem.Name = "registrarDemandanteToolStripMenuItem";
            this.registrarDemandanteToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.registrarDemandanteToolStripMenuItem.Text = "Registrar Demandante";
            this.registrarDemandanteToolStripMenuItem.Click += new System.EventHandler(this.registrarDemandanteToolStripMenuItem_Click);
            // 
            // frm_Menu_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 392);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_Menu_Admin";
            this.Text = "Menu Admin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem maestroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abogadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarDemandadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarDemandanteToolStripMenuItem;
    }
}