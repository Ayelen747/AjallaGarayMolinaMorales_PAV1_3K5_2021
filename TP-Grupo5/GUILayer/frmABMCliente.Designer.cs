
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
<<<<<<< HEAD
            this.chkSinContacto = new System.Windows.Forms.CheckBox();
            this.cboContacto = new System.Windows.Forms.ComboBox();
            this.lblContacto = new System.Windows.Forms.Label();
=======
>>>>>>> 3fe81ccef3c7d9fa9ed022096600c2b84e2f14a4
            this.lblFecha_Alta = new System.Windows.Forms.Label();
            this.dtpFechaAlta = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(87, 25);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 15);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(114, 22);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 23);
            this.txtId.TabIndex = 1;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(114, 51);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(100, 23);
            this.txtRazonSocial.TabIndex = 3;
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(33, 54);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(75, 15);
            this.lblRazonSocial.TabIndex = 2;
            this.lblRazonSocial.Text = "Razon social:";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(114, 109);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(100, 23);
            this.txtCalle.TabIndex = 5;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(72, 112);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(36, 15);
            this.lblCalle.TabIndex = 4;
            this.lblCalle.Text = "Calle:";
            // 
            // txtNroCalle
            // 
            this.txtNroCalle.Location = new System.Drawing.Point(114, 138);
            this.txtNroCalle.Name = "txtNroCalle";
            this.txtNroCalle.Size = new System.Drawing.Size(100, 23);
            this.txtNroCalle.TabIndex = 7;
            this.txtNroCalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(9, 141);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(99, 15);
            this.lblNumero.TabIndex = 6;
            this.lblNumero.Text = "Numero de Calle:";
            // 
            // cboBarrio
            // 
            this.cboBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBarrio.FormattingEnabled = true;
            this.cboBarrio.Location = new System.Drawing.Point(114, 80);
            this.cboBarrio.Name = "cboBarrio";
            this.cboBarrio.Size = new System.Drawing.Size(121, 23);
            this.cboBarrio.TabIndex = 8;
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Location = new System.Drawing.Point(67, 83);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(41, 15);
            this.lblBarrio.TabIndex = 9;
            this.lblBarrio.Text = "Barrio:";
            // 
            // groupBox1
            // 
<<<<<<< HEAD
            this.groupBox1.Controls.Add(this.chkSinContacto);
            this.groupBox1.Controls.Add(this.cboContacto);
            this.groupBox1.Controls.Add(this.lblContacto);
=======
>>>>>>> 3fe81ccef3c7d9fa9ed022096600c2b84e2f14a4
            this.groupBox1.Controls.Add(this.lblFecha_Alta);
            this.groupBox1.Controls.Add(this.dtpFechaAlta);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.lblBarrio);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.cboBarrio);
            this.groupBox1.Controls.Add(this.lblRazonSocial);
            this.groupBox1.Controls.Add(this.txtNroCalle);
            this.groupBox1.Controls.Add(this.txtRazonSocial);
            this.groupBox1.Controls.Add(this.lblNumero);
            this.groupBox1.Controls.Add(this.lblCalle);
            this.groupBox1.Controls.Add(this.txtCalle);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
<<<<<<< HEAD
            this.groupBox1.Size = new System.Drawing.Size(338, 242);
=======
            this.groupBox1.Size = new System.Drawing.Size(326, 214);
>>>>>>> 3fe81ccef3c7d9fa9ed022096600c2b84e2f14a4
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
<<<<<<< HEAD
            // chkSinContacto
            // 
            this.chkSinContacto.AutoSize = true;
            this.chkSinContacto.Location = new System.Drawing.Point(242, 170);
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
            this.cboContacto.Location = new System.Drawing.Point(114, 167);
            this.cboContacto.Name = "cboContacto";
            this.cboContacto.Size = new System.Drawing.Size(121, 23);
            this.cboContacto.TabIndex = 13;
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.Location = new System.Drawing.Point(49, 170);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(59, 15);
            this.lblContacto.TabIndex = 12;
            this.lblContacto.Text = "Contacto:";
            // 
            // lblFecha_Alta
            // 
            this.lblFecha_Alta.AutoSize = true;
            this.lblFecha_Alta.Location = new System.Drawing.Point(29, 202);
=======
            // lblFecha_Alta
            // 
            this.lblFecha_Alta.AutoSize = true;
            this.lblFecha_Alta.Location = new System.Drawing.Point(29, 174);
>>>>>>> 3fe81ccef3c7d9fa9ed022096600c2b84e2f14a4
            this.lblFecha_Alta.Name = "lblFecha_Alta";
            this.lblFecha_Alta.Size = new System.Drawing.Size(79, 15);
            this.lblFecha_Alta.TabIndex = 11;
            this.lblFecha_Alta.Text = "Fecha de alta:";
            // 
            // dtpFechaAlta
            // 
<<<<<<< HEAD
            this.dtpFechaAlta.Location = new System.Drawing.Point(114, 196);
=======
            this.dtpFechaAlta.Location = new System.Drawing.Point(114, 168);
>>>>>>> 3fe81ccef3c7d9fa9ed022096600c2b84e2f14a4
            this.dtpFechaAlta.Name = "dtpFechaAlta";
            this.dtpFechaAlta.Size = new System.Drawing.Size(200, 23);
            this.dtpFechaAlta.TabIndex = 10;
            // 
            // btnCancelar
            // 
<<<<<<< HEAD
            this.btnCancelar.Location = new System.Drawing.Point(275, 260);
=======
            this.btnCancelar.Location = new System.Drawing.Point(263, 232);
>>>>>>> 3fe81ccef3c7d9fa9ed022096600c2b84e2f14a4
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
<<<<<<< HEAD
            this.btnAceptar.Location = new System.Drawing.Point(194, 260);
=======
            this.btnAceptar.Location = new System.Drawing.Point(182, 232);
>>>>>>> 3fe81ccef3c7d9fa9ed022096600c2b84e2f14a4
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
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(362, 294);
=======
            this.ClientSize = new System.Drawing.Size(356, 265);
>>>>>>> 3fe81ccef3c7d9fa9ed022096600c2b84e2f14a4
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmABMCliente";
            this.Text = "frmABMCliente";
<<<<<<< HEAD
            this.Load += new System.EventHandler(this.frmABMCliente_Load);
=======
>>>>>>> 3fe81ccef3c7d9fa9ed022096600c2b84e2f14a4
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFecha_Alta;
        private System.Windows.Forms.DateTimePicker dtpFechaAlta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
<<<<<<< HEAD
        private System.Windows.Forms.CheckBox chkSinContacto;
        private System.Windows.Forms.ComboBox cboContacto;
        private System.Windows.Forms.Label lblContacto;
=======
>>>>>>> 3fe81ccef3c7d9fa9ed022096600c2b84e2f14a4
    }
}