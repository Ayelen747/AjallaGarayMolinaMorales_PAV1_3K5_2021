
namespace TP_Grupo5.GUILayer
{
    partial class frmABMCliente
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
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.txtNroCalle = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.cboBarrio = new System.Windows.Forms.ComboBox();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.grbCliente = new System.Windows.Forms.GroupBox();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.lblCuit = new System.Windows.Forms.Label();
            this.chkSinContacto = new System.Windows.Forms.CheckBox();
            this.cboContacto = new System.Windows.Forms.ComboBox();
            this.lblContacto = new System.Windows.Forms.Label();
            this.lblFecha_Alta = new System.Windows.Forms.Label();
            this.dtpFechaAlta = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.grbCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(87, 23);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 15);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(114, 20);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 23);
            this.txtId.TabIndex = 1;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(114, 49);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(100, 23);
            this.txtRazonSocial.TabIndex = 3;
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(33, 52);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(75, 15);
            this.lblRazonSocial.TabIndex = 2;
            this.lblRazonSocial.Text = "Razon social:";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(114, 136);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(100, 23);
            this.txtCalle.TabIndex = 5;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(72, 139);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(36, 15);
            this.lblCalle.TabIndex = 4;
            this.lblCalle.Text = "Calle:";
            // 
            // txtNroCalle
            // 
            this.txtNroCalle.Location = new System.Drawing.Point(114, 165);
            this.txtNroCalle.Name = "txtNroCalle";
            this.txtNroCalle.Size = new System.Drawing.Size(100, 23);
            this.txtNroCalle.TabIndex = 7;
            this.txtNroCalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroCalle_KeyPress);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(29, 168);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(78, 15);
            this.lblNumero.TabIndex = 6;
            this.lblNumero.Text = "Nro. de Calle:";
            // 
            // cboBarrio
            // 
            this.cboBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBarrio.FormattingEnabled = true;
            this.cboBarrio.Location = new System.Drawing.Point(114, 107);
            this.cboBarrio.Name = "cboBarrio";
            this.cboBarrio.Size = new System.Drawing.Size(121, 23);
            this.cboBarrio.TabIndex = 8;
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Location = new System.Drawing.Point(67, 110);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(41, 15);
            this.lblBarrio.TabIndex = 9;
            this.lblBarrio.Text = "Barrio:";
            // 
            // grbCliente
            // 
            this.grbCliente.Controls.Add(this.txtCuit);
            this.grbCliente.Controls.Add(this.lblCuit);
            this.grbCliente.Controls.Add(this.chkSinContacto);
            this.grbCliente.Controls.Add(this.cboContacto);
            this.grbCliente.Controls.Add(this.lblContacto);
            this.grbCliente.Controls.Add(this.lblFecha_Alta);
            this.grbCliente.Controls.Add(this.dtpFechaAlta);
            this.grbCliente.Controls.Add(this.txtId);
            this.grbCliente.Controls.Add(this.lblBarrio);
            this.grbCliente.Controls.Add(this.lblId);
            this.grbCliente.Controls.Add(this.cboBarrio);
            this.grbCliente.Controls.Add(this.lblRazonSocial);
            this.grbCliente.Controls.Add(this.txtNroCalle);
            this.grbCliente.Controls.Add(this.txtRazonSocial);
            this.grbCliente.Controls.Add(this.lblNumero);
            this.grbCliente.Controls.Add(this.lblCalle);
            this.grbCliente.Controls.Add(this.txtCalle);
            this.grbCliente.Location = new System.Drawing.Point(12, 12);
            this.grbCliente.Name = "grbCliente";
            this.grbCliente.Size = new System.Drawing.Size(354, 265);
            this.grbCliente.TabIndex = 10;
            this.grbCliente.TabStop = false;
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(114, 78);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(100, 23);
            this.txtCuit.TabIndex = 16;
            this.txtCuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroCalle_KeyPress);
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(30, 81);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(78, 15);
            this.lblCuit.TabIndex = 15;
            this.lblCuit.Text = "Nro. de CUIT:";
            // 
            // chkSinContacto
            // 
            this.chkSinContacto.AutoSize = true;
            this.chkSinContacto.Location = new System.Drawing.Point(242, 197);
            this.chkSinContacto.Name = "chkSinContacto";
            this.chkSinContacto.Size = new System.Drawing.Size(92, 19);
            this.chkSinContacto.TabIndex = 14;
            this.chkSinContacto.Text = "Sin contacto";
            this.chkSinContacto.UseVisualStyleBackColor = true;
            this.chkSinContacto.CheckedChanged += new System.EventHandler(this.chkSinContacto_CheckedChanged);
            // 
            // cboContacto
            // 
            this.cboContacto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboContacto.FormattingEnabled = true;
            this.cboContacto.Location = new System.Drawing.Point(114, 194);
            this.cboContacto.Name = "cboContacto";
            this.cboContacto.Size = new System.Drawing.Size(121, 23);
            this.cboContacto.TabIndex = 13;
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.Location = new System.Drawing.Point(49, 197);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(59, 15);
            this.lblContacto.TabIndex = 12;
            this.lblContacto.Text = "Contacto:";
            // 
            // lblFecha_Alta
            // 
            this.lblFecha_Alta.AutoSize = true;
            this.lblFecha_Alta.Location = new System.Drawing.Point(29, 229);
            this.lblFecha_Alta.Name = "lblFecha_Alta";
            this.lblFecha_Alta.Size = new System.Drawing.Size(79, 15);
            this.lblFecha_Alta.TabIndex = 11;
            this.lblFecha_Alta.Text = "Fecha de alta:";
            // 
            // dtpFechaAlta
            // 
            this.dtpFechaAlta.Location = new System.Drawing.Point(114, 223);
            this.dtpFechaAlta.Name = "dtpFechaAlta";
            this.dtpFechaAlta.Size = new System.Drawing.Size(228, 23);
            this.dtpFechaAlta.TabIndex = 10;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(279, 283);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(198, 283);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmABMCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 319);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grbCliente);
            this.Name = "frmABMCliente";
            this.Text = "frmABMCliente";
            this.Load += new System.EventHandler(this.frmABMCliente_Load);
            this.grbCliente.ResumeLayout(false);
            this.grbCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.TextBox txtNroCalle;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.ComboBox cboBarrio;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.GroupBox grbCliente;
        private System.Windows.Forms.Label lblFecha_Alta;
        private System.Windows.Forms.DateTimePicker dtpFechaAlta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.CheckBox chkSinContacto;
        private System.Windows.Forms.ComboBox cboContacto;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.Label lblCuit;
    }
}