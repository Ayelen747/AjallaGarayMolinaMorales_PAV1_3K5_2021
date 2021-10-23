
namespace TP_Grupo5.GUILayer
{
    partial class frmPrincipal
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
            this.soporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consularClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
<<<<<<< HEAD
            this.consultarBarriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarProyectosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
=======
            this.soporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarBarriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
>>>>>>> 4b7d4a5553e316d9810018732cb2a9ee2106991b
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soporteToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // soporteToolStripMenuItem
            // 
            this.soporteToolStripMenuItem.Name = "soporteToolStripMenuItem";
            this.soporteToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.soporteToolStripMenuItem.Text = "Archivo";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consularClientesToolStripMenuItem,
<<<<<<< HEAD
            this.consultarBarriosToolStripMenuItem,
            this.consultarProyectosToolStripMenuItem});
=======
            this.consultarBarriosToolStripMenuItem});
>>>>>>> 4b7d4a5553e316d9810018732cb2a9ee2106991b
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.clientesToolStripMenuItem.Text = "Soporte";
            // 
            // consularClientesToolStripMenuItem
            // 
            this.consularClientesToolStripMenuItem.Name = "consularClientesToolStripMenuItem";
            this.consularClientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consularClientesToolStripMenuItem.Text = "Consular Clientes";
            this.consularClientesToolStripMenuItem.Click += new System.EventHandler(this.consularClientesToolStripMenuItem_Click);
            // 
            // consultarBarriosToolStripMenuItem
            // 
            this.consultarBarriosToolStripMenuItem.Name = "consultarBarriosToolStripMenuItem";
            this.consultarBarriosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarBarriosToolStripMenuItem.Text = "Consultar Barrios";
            this.consultarBarriosToolStripMenuItem.Click += new System.EventHandler(this.consultarBarriosToolStripMenuItem_Click);
            // 
            // consultarProyectosToolStripMenuItem
            // 
            this.consultarProyectosToolStripMenuItem.Name = "consultarProyectosToolStripMenuItem";
            this.consultarProyectosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarProyectosToolStripMenuItem.Text = "Consultar Proyectos";
            this.consultarProyectosToolStripMenuItem.Click += new System.EventHandler(this.consultarProyectosToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // consultarBarriosToolStripMenuItem
            // 
            this.consultarBarriosToolStripMenuItem.Name = "consultarBarriosToolStripMenuItem";
            this.consultarBarriosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarBarriosToolStripMenuItem.Text = "Consultar Barrios";
            this.consultarBarriosToolStripMenuItem.Click += new System.EventHandler(this.consultarBarriosToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem soporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consularClientesToolStripMenuItem;
<<<<<<< HEAD
        private System.Windows.Forms.ToolStripMenuItem consultarBarriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarProyectosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
=======
        private System.Windows.Forms.ToolStripMenuItem soporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarBarriosToolStripMenuItem;
>>>>>>> 4b7d4a5553e316d9810018732cb2a9ee2106991b
    }
}