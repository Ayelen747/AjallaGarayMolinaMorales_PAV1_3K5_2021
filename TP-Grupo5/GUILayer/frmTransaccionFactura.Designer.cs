
namespace TP_Grupo5.GUILayer
{
    partial class frmTransaccionFactura
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
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.gbFacturaDetalle = new System.Windows.Forms.GroupBox();
            this.gbGrilla = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.grbFacturaDetalle = new System.Windows.Forms.DataGridView();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDetalle = new System.Windows.Forms.GroupBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblProyecto = new System.Windows.Forms.Label();
            this.cboProyecto = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cboUCreador = new System.Windows.Forms.ComboBox();
            this.lblUCreador = new System.Windows.Forms.Label();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.gbFacturaDetalle.SuspendLayout();
            this.gbGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grbFacturaDetalle)).BeginInit();
            this.gbDetalle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(518, 15);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(41, 15);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Location = new System.Drawing.Point(565, 12);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(215, 23);
            this.dtpFecha.TabIndex = 3;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(16, 15);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(47, 15);
            this.lblCliente.TabIndex = 4;
            this.lblCliente.Text = "Cliente:";
            // 
            // cboCliente
            // 
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(69, 12);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(185, 23);
            this.cboCliente.TabIndex = 5;
            // 
            // gbFacturaDetalle
            // 
            this.gbFacturaDetalle.Controls.Add(this.gbGrilla);
            this.gbFacturaDetalle.Controls.Add(this.gbDetalle);
            this.gbFacturaDetalle.Location = new System.Drawing.Point(12, 74);
            this.gbFacturaDetalle.Name = "gbFacturaDetalle";
            this.gbFacturaDetalle.Size = new System.Drawing.Size(766, 250);
            this.gbFacturaDetalle.TabIndex = 7;
            this.gbFacturaDetalle.TabStop = false;
            // 
            // gbGrilla
            // 
            this.gbGrilla.Controls.Add(this.lblTotal);
            this.gbGrilla.Controls.Add(this.txtTotal);
            this.gbGrilla.Controls.Add(this.btnEliminar);
            this.gbGrilla.Controls.Add(this.grbFacturaDetalle);
            this.gbGrilla.Location = new System.Drawing.Point(290, 22);
            this.gbGrilla.Name = "gbGrilla";
            this.gbGrilla.Size = new System.Drawing.Size(470, 222);
            this.gbGrilla.TabIndex = 12;
            this.gbGrilla.TabStop = false;
            this.gbGrilla.Text = "Detalle de Factura";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(388, 146);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(33, 15);
            this.lblTotal.TabIndex = 20;
            this.lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(388, 164);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(78, 23);
            this.txtTotal.TabIndex = 19;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(307, 193);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // grbFacturaDetalle
            // 
            this.grbFacturaDetalle.AllowUserToAddRows = false;
            this.grbFacturaDetalle.AllowUserToDeleteRows = false;
            this.grbFacturaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grbFacturaDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descripcion,
            this.precio});
            this.grbFacturaDetalle.Location = new System.Drawing.Point(6, 22);
            this.grbFacturaDetalle.Name = "grbFacturaDetalle";
            this.grbFacturaDetalle.ReadOnly = true;
            this.grbFacturaDetalle.RowTemplate.Height = 25;
            this.grbFacturaDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grbFacturaDetalle.Size = new System.Drawing.Size(376, 165);
            this.grbFacturaDetalle.TabIndex = 7;
            this.grbFacturaDetalle.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.grbFacturaDetalle_RowPostPaint);
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 200;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // gbDetalle
            // 
            this.gbDetalle.Controls.Add(this.txtPrecio);
            this.gbDetalle.Controls.Add(this.lblProducto);
            this.gbDetalle.Controls.Add(this.lblPrecio);
            this.gbDetalle.Controls.Add(this.cboProducto);
            this.gbDetalle.Controls.Add(this.btnAgregar);
            this.gbDetalle.Controls.Add(this.lblProyecto);
            this.gbDetalle.Controls.Add(this.cboProyecto);
            this.gbDetalle.Location = new System.Drawing.Point(6, 22);
            this.gbDetalle.Name = "gbDetalle";
            this.gbDetalle.Size = new System.Drawing.Size(278, 222);
            this.gbDetalle.TabIndex = 10;
            this.gbDetalle.TabStop = false;
            this.gbDetalle.Text = "Proyecto/Producto";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(69, 91);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 23);
            this.txtPrecio.TabIndex = 13;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(4, 65);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(59, 15);
            this.lblProducto.TabIndex = 16;
            this.lblProducto.Text = "Producto:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(23, 94);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(43, 15);
            this.lblPrecio.TabIndex = 12;
            this.lblPrecio.Text = "Precio:";
            // 
            // cboProducto
            // 
            this.cboProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(69, 62);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(167, 23);
            this.cboProducto.TabIndex = 15;
            this.cboProducto.SelectionChangeCommitted += new System.EventHandler(this.cboProducto_SelectionChangeCommitted);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(197, 193);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblProyecto
            // 
            this.lblProyecto.AutoSize = true;
            this.lblProyecto.Location = new System.Drawing.Point(6, 36);
            this.lblProyecto.Name = "lblProyecto";
            this.lblProyecto.Size = new System.Drawing.Size(57, 15);
            this.lblProyecto.TabIndex = 14;
            this.lblProyecto.Text = "Proyecto:";
            // 
            // cboProyecto
            // 
            this.cboProyecto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProyecto.FormattingEnabled = true;
            this.cboProyecto.Location = new System.Drawing.Point(69, 33);
            this.cboProyecto.Name = "cboProyecto";
            this.cboProyecto.Size = new System.Drawing.Size(167, 23);
            this.cboProyecto.TabIndex = 13;
            this.cboProyecto.SelectionChangeCommitted += new System.EventHandler(this.cboProyecto_SelectionChangeCommitted);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(596, 330);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(88, 46);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(692, 330);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(88, 46);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cboUCreador
            // 
            this.cboUCreador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUCreador.FormattingEnabled = true;
            this.cboUCreador.Location = new System.Drawing.Point(318, 12);
            this.cboUCreador.Name = "cboUCreador";
            this.cboUCreador.Size = new System.Drawing.Size(185, 23);
            this.cboUCreador.TabIndex = 13;
            // 
            // lblUCreador
            // 
            this.lblUCreador.AutoSize = true;
            this.lblUCreador.Location = new System.Drawing.Point(260, 15);
            this.lblUCreador.Name = "lblUCreador";
            this.lblUCreador.Size = new System.Drawing.Size(52, 15);
            this.lblUCreador.TabIndex = 12;
            this.lblUCreador.Text = "Creador:";
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Location = new System.Drawing.Point(69, 40);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoCliente.TabIndex = 14;
            this.btnNuevoCliente.Text = "Nuevo";
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // frmTransaccionFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 384);
            this.Controls.Add(this.btnNuevoCliente);
            this.Controls.Add(this.cboUCreador);
            this.Controls.Add(this.lblUCreador);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gbFacturaDetalle);
            this.Controls.Add(this.cboCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.Name = "frmTransaccionFactura";
            this.Text = "frmTransaccionFactura";

            this.gbFacturaDetalle.ResumeLayout(false);
            this.gbGrilla.ResumeLayout(false);
            this.gbGrilla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grbFacturaDetalle)).EndInit();
            this.gbDetalle.ResumeLayout(false);
            this.gbDetalle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.GroupBox gbFacturaDetalle;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox gbDetalle;
        private System.Windows.Forms.Label lblProyecto;
        private System.Windows.Forms.ComboBox cboProyecto;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox gbGrilla;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView grbFacturaDetalle;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.ComboBox cboUCreador;
        private System.Windows.Forms.Label lblUCreador;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
    }
}