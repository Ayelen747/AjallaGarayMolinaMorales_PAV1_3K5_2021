
namespace TP_Grupo5.GUILayer
{
    partial class frmConsultarBarrio
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblNombreBarrio = new System.Windows.Forms.Label();
            this.txtNombreBarrio = new System.Windows.Forms.TextBox();
            this.dgvBarrios = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarrios)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.lblNombreBarrio);
            this.groupBox1.Controls.Add(this.txtNombreBarrio);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listar Barrios";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(175, 81);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblNombreBarrio
            // 
            this.lblNombreBarrio.AutoSize = true;
            this.lblNombreBarrio.Location = new System.Drawing.Point(30, 51);
            this.lblNombreBarrio.Name = "lblNombreBarrio";
            this.lblNombreBarrio.Size = new System.Drawing.Size(54, 15);
            this.lblNombreBarrio.TabIndex = 3;
            this.lblNombreBarrio.Text = "Nombre:";
            // 
            // txtNombreBarrio
            // 
            this.txtNombreBarrio.Location = new System.Drawing.Point(90, 43);
            this.txtNombreBarrio.Name = "txtNombreBarrio";
            this.txtNombreBarrio.Size = new System.Drawing.Size(160, 23);
            this.txtNombreBarrio.TabIndex = 1;
            // 
            // dgvBarrios
            // 
<<<<<<< HEAD
            this.dgvBarrios.AllowUserToAddRows = false;
            this.dgvBarrios.AllowUserToDeleteRows = false;
=======
>>>>>>> 4b7d4a5553e316d9810018732cb2a9ee2106991b
            this.dgvBarrios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBarrios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre});
            this.dgvBarrios.Location = new System.Drawing.Point(22, 163);
            this.dgvBarrios.Name = "dgvBarrios";
<<<<<<< HEAD
            this.dgvBarrios.ReadOnly = true;
            this.dgvBarrios.RowTemplate.Height = 25;
            this.dgvBarrios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
=======
            this.dgvBarrios.RowTemplate.Height = 25;
>>>>>>> 4b7d4a5553e316d9810018732cb2a9ee2106991b
            this.dgvBarrios.Size = new System.Drawing.Size(270, 150);
            this.dgvBarrios.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
<<<<<<< HEAD
            this.ID.ReadOnly = true;
=======
>>>>>>> 4b7d4a5553e316d9810018732cb2a9ee2106991b
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
<<<<<<< HEAD
            this.Nombre.ReadOnly = true;
=======
>>>>>>> 4b7d4a5553e316d9810018732cb2a9ee2106991b
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(315, 337);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(103, 337);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
<<<<<<< HEAD
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
=======
>>>>>>> 4b7d4a5553e316d9810018732cb2a9ee2106991b
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(315, 290);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
<<<<<<< HEAD
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
=======
>>>>>>> 4b7d4a5553e316d9810018732cb2a9ee2106991b
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(22, 337);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
<<<<<<< HEAD
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
=======
>>>>>>> 4b7d4a5553e316d9810018732cb2a9ee2106991b
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(184, 337);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // frmConsultarBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(397, 373);
=======
            this.ClientSize = new System.Drawing.Size(397, 364);
>>>>>>> 4b7d4a5553e316d9810018732cb2a9ee2106991b
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvBarrios);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmConsultarBarrio";
<<<<<<< HEAD
            this.Text = "Consultar Barrios";
=======
            this.Text = "frmConsultarBarrio";
>>>>>>> 4b7d4a5553e316d9810018732cb2a9ee2106991b
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarrios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNombreBarrio;
        private System.Windows.Forms.TextBox txtNombreBarrio;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvBarrios;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
    }
}