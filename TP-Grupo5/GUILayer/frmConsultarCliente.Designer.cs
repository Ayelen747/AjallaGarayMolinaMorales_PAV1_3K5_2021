
namespace TP_Grupo5
{
    partial class frmConsultaCliente
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbBuscarCliente = new System.Windows.Forms.GroupBox();
            this.rbDespues = new System.Windows.Forms.RadioButton();
            this.rbActual = new System.Windows.Forms.RadioButton();
            this.rbAntes = new System.Windows.Forms.RadioButton();
            this.lblNombreBarrio = new System.Windows.Forms.Label();
            this.dtpFechaAlta = new System.Windows.Forms.DateTimePicker();
            this.cboBarrio = new System.Windows.Forms.ComboBox();
            this.lblFechaAlta = new System.Windows.Forms.Label();
            this.lblCUIT = new System.Windows.Forms.Label();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.lblRazonS = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.gbListaClientes = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grdClientes = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroCalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbBuscarCliente.SuspendLayout();
            this.gbListaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBuscarCliente
            // 
            this.gbBuscarCliente.Controls.Add(this.rbDespues);
            this.gbBuscarCliente.Controls.Add(this.rbActual);
            this.gbBuscarCliente.Controls.Add(this.rbAntes);
            this.gbBuscarCliente.Controls.Add(this.lblNombreBarrio);
            this.gbBuscarCliente.Controls.Add(this.dtpFechaAlta);
            this.gbBuscarCliente.Controls.Add(this.cboBarrio);
            this.gbBuscarCliente.Controls.Add(this.lblFechaAlta);
            this.gbBuscarCliente.Controls.Add(this.lblCUIT);
            this.gbBuscarCliente.Controls.Add(this.txtCuit);
            this.gbBuscarCliente.Controls.Add(this.lblRazonS);
            this.gbBuscarCliente.Controls.Add(this.txtRazonSocial);
            this.gbBuscarCliente.Location = new System.Drawing.Point(12, 12);
            this.gbBuscarCliente.Name = "gbBuscarCliente";
            this.gbBuscarCliente.Size = new System.Drawing.Size(689, 148);
            this.gbBuscarCliente.TabIndex = 0;
            this.gbBuscarCliente.TabStop = false;
            this.gbBuscarCliente.Text = "Listar clientes";
            // 
            // rbDespues
            // 
            this.rbDespues.AutoSize = true;
            this.rbDespues.Location = new System.Drawing.Point(568, 67);
            this.rbDespues.Name = "rbDespues";
            this.rbDespues.Size = new System.Drawing.Size(69, 19);
            this.rbDespues.TabIndex = 12;
            this.rbDespues.TabStop = true;
            this.rbDespues.Text = "Despues";
            this.rbDespues.UseVisualStyleBackColor = true;
            // 
            // rbActual
            // 
            this.rbActual.AutoSize = true;
            this.rbActual.Location = new System.Drawing.Point(503, 67);
            this.rbActual.Name = "rbActual";
            this.rbActual.Size = new System.Drawing.Size(59, 19);
            this.rbActual.TabIndex = 11;
            this.rbActual.TabStop = true;
            this.rbActual.Text = "Actual";
            this.rbActual.UseVisualStyleBackColor = true;
            // 
            // rbAntes
            // 
            this.rbAntes.AutoSize = true;
            this.rbAntes.Location = new System.Drawing.Point(442, 67);
            this.rbAntes.Name = "rbAntes";
            this.rbAntes.Size = new System.Drawing.Size(55, 19);
            this.rbAntes.TabIndex = 10;
            this.rbAntes.TabStop = true;
            this.rbAntes.Text = "Antes";
            this.rbAntes.UseVisualStyleBackColor = true;
            // 
            // lblNombreBarrio
            // 
            this.lblNombreBarrio.AutoSize = true;
            this.lblNombreBarrio.Location = new System.Drawing.Point(197, 44);
            this.lblNombreBarrio.Name = "lblNombreBarrio";
            this.lblNombreBarrio.Size = new System.Drawing.Size(41, 15);
            this.lblNombreBarrio.TabIndex = 1;
            this.lblNombreBarrio.Text = "Barrio:";
            // 
            // dtpFechaAlta
            // 
            this.dtpFechaAlta.Location = new System.Drawing.Point(442, 38);
            this.dtpFechaAlta.Name = "dtpFechaAlta";
            this.dtpFechaAlta.Size = new System.Drawing.Size(200, 23);
            this.dtpFechaAlta.TabIndex = 9;
            // 
            // cboBarrio
            // 
            this.cboBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBarrio.FormattingEnabled = true;
            this.cboBarrio.Location = new System.Drawing.Point(244, 41);
            this.cboBarrio.Name = "cboBarrio";
            this.cboBarrio.Size = new System.Drawing.Size(121, 23);
            this.cboBarrio.TabIndex = 0;
            // 
            // lblFechaAlta
            // 
            this.lblFechaAlta.AutoSize = true;
            this.lblFechaAlta.Location = new System.Drawing.Point(371, 44);
            this.lblFechaAlta.Name = "lblFechaAlta";
            this.lblFechaAlta.Size = new System.Drawing.Size(65, 15);
            this.lblFechaAlta.TabIndex = 8;
            this.lblFechaAlta.Text = "Fecha Alta:";
            // 
            // lblCUIT
            // 
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.Location = new System.Drawing.Point(49, 73);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(35, 15);
            this.lblCUIT.TabIndex = 3;
            this.lblCUIT.Text = "CUIT:";
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(91, 70);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(100, 23);
            this.txtCuit.TabIndex = 2;
            this.txtCuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuit_KeyPress);
            // 
            // lblRazonS
            // 
            this.lblRazonS.AutoSize = true;
            this.lblRazonS.Location = new System.Drawing.Point(6, 44);
            this.lblRazonS.Name = "lblRazonS";
            this.lblRazonS.Size = new System.Drawing.Size(75, 15);
            this.lblRazonS.TabIndex = 1;
            this.lblRazonS.Text = "Razon social:";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(91, 41);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(100, 23);
            this.txtRazonSocial.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(707, 137);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.Location = new System.Drawing.Point(707, 112);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(58, 19);
            this.chkTodos.TabIndex = 4;
            this.chkTodos.Text = "Todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged);
            // 
            // lblRazonS
            // 
            this.lblRazonS.AutoSize = true;
            this.lblRazonS.Location = new System.Drawing.Point(6, 44);
            this.lblRazonS.Name = "lblRazonS";
            this.lblRazonS.Size = new System.Drawing.Size(75, 15);
            this.lblRazonS.TabIndex = 1;
            this.lblRazonS.Text = "Razon social:";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(91, 41);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(100, 23);
            this.txtRazonSocial.TabIndex = 0;
            // 
            // gbListaClientes
            // 
            this.gbListaClientes.Controls.Add(this.btnEliminar);
            this.gbListaClientes.Controls.Add(this.btnAgregar);
            this.gbListaClientes.Controls.Add(this.btnActualizar);
            this.gbListaClientes.Controls.Add(this.btnCancelar);
            this.gbListaClientes.Controls.Add(this.btnSalir);
            this.gbListaClientes.Controls.Add(this.grdClientes);
            this.gbListaClientes.Location = new System.Drawing.Point(12, 166);
            this.gbListaClientes.Name = "gbListaClientes";
            this.gbListaClientes.Size = new System.Drawing.Size(776, 272);
            this.gbListaClientes.TabIndex = 1;
            this.gbListaClientes.TabStop = false;
            this.gbListaClientes.Text = "Lista de clientes";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(326, 243);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(245, 243);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(407, 243);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(614, 243);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(695, 243);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // grdClientes
            // 
            this.grdClientes.AllowUserToAddRows = false;
            this.grdClientes.AllowUserToDeleteRows = false;
            this.grdClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.razonS,
            this.cuit,
            this.calle,
            this.nroCalle,
            this.fechaAlta,
            this.barrio,
            this.contacto});
            this.grdClientes.Location = new System.Drawing.Point(0, 22);
            this.grdClientes.Name = "grdClientes";
            this.grdClientes.ReadOnly = true;
            this.grdClientes.RowTemplate.Height = 25;
            this.grdClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdClientes.Size = new System.Drawing.Size(770, 206);
            this.grdClientes.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // razonS
            // 
            this.razonS.HeaderText = "Razon Social";
            this.razonS.Name = "razonS";
            this.razonS.ReadOnly = true;
            // 
            // cuit
            // 
            this.cuit.HeaderText = "CUIT";
            this.cuit.Name = "cuit";
            this.cuit.ReadOnly = true;
            // 
            // calle
            // 
            this.calle.HeaderText = "Calle";
            this.calle.Name = "calle";
            this.calle.ReadOnly = true;
            // 
            // nroCalle
            // 
            this.nroCalle.HeaderText = "Nro";
            this.nroCalle.Name = "nroCalle";
            this.nroCalle.ReadOnly = true;
            // 
            // fechaAlta
            // 
            this.fechaAlta.HeaderText = "Fecha de Alta";
            this.fechaAlta.Name = "fechaAlta";
            this.fechaAlta.ReadOnly = true;
            // 
            // barrio
            // 
            this.barrio.HeaderText = "Barrio";
            this.barrio.Name = "barrio";
            this.barrio.ReadOnly = true;
            // 
            // contacto
            // 
            this.contacto.HeaderText = "Contacto";
            this.contacto.Name = "contacto";
            this.contacto.ReadOnly = true;
            // 
            // frmConsultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbListaClientes);
            this.Controls.Add(this.gbBuscarCliente);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.chkTodos);
            this.Name = "frmConsultaCliente";
            this.Text = "Clientes";
            this.gbBuscarCliente.ResumeLayout(false);
            this.gbBuscarCliente.PerformLayout();
            this.gbListaClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBuscarCliente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.CheckBox chkTodos;
        private System.Windows.Forms.Label lblCUIT;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.Label lblRazonS;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.GroupBox gbListaClientes;
        private System.Windows.Forms.DataGridView grdClientes;
        private System.Windows.Forms.Label lblNombreBarrio;
        private System.Windows.Forms.DateTimePicker dtpFechaAlta;
        private System.Windows.Forms.ComboBox cboBarrio;
        private System.Windows.Forms.Label lblFechaAlta;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalir;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton rbDespues;
        private System.Windows.Forms.RadioButton rbActual;
        private System.Windows.Forms.RadioButton rbAntes;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonS;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroCalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAlta;
        private System.Windows.Forms.DataGridViewTextBoxColumn barrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn contacto;
    }
}

