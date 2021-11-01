namespace TP_Grupo5.GUILayer
{
    partial class frmProyecto
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
            this.gbProyecto = new System.Windows.Forms.GroupBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.rbActivos = new System.Windows.Forms.RadioButton();
            this.rbEliminado = new System.Windows.Forms.RadioButton();
            this.grdProyecto = new System.Windows.Forms.DataGridView();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.cboResponsable = new System.Windows.Forms.ComboBox();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblProducto = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.tTbtn = new System.Windows.Forms.ToolTip(this.components);
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.version = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alcance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbProyecto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProyecto)).BeginInit();
            this.SuspendLayout();
            // 
            // gbProyecto
            // 
            this.gbProyecto.Controls.Add(this.txtDescripcion);
            this.gbProyecto.Controls.Add(this.lblDescripcion);
            this.gbProyecto.Controls.Add(this.rbTodos);
            this.gbProyecto.Controls.Add(this.rbActivos);
            this.gbProyecto.Controls.Add(this.rbEliminado);
            this.gbProyecto.Controls.Add(this.grdProyecto);
            this.gbProyecto.Controls.Add(this.lblResponsable);
            this.gbProyecto.Controls.Add(this.cboResponsable);
            this.gbProyecto.Controls.Add(this.cboProducto);
            this.gbProyecto.Controls.Add(this.btnConsultar);
            this.gbProyecto.Controls.Add(this.lblProducto);
            this.gbProyecto.Location = new System.Drawing.Point(15, 15);
            this.gbProyecto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbProyecto.Name = "gbProyecto";
            this.gbProyecto.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbProyecto.Size = new System.Drawing.Size(777, 340);
            this.gbProyecto.TabIndex = 0;
            this.gbProyecto.TabStop = false;
            this.gbProyecto.Text = "Proyecto";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(107, 29);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(150, 23);
            this.txtDescripcion.TabIndex = 13;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(29, 33);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(72, 15);
            this.lblDescripcion.TabIndex = 12;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Location = new System.Drawing.Point(681, 79);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(57, 19);
            this.rbTodos.TabIndex = 11;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            this.rbTodos.CheckedChanged += new System.EventHandler(this.rbTodos_CheckedChanged);
            // 
            // rbActivos
            // 
            this.rbActivos.AutoSize = true;
            this.rbActivos.Location = new System.Drawing.Point(681, 29);
            this.rbActivos.Name = "rbActivos";
            this.rbActivos.Size = new System.Drawing.Size(64, 19);
            this.rbActivos.TabIndex = 10;
            this.rbActivos.TabStop = true;
            this.rbActivos.Text = "Activos";
            this.rbActivos.UseVisualStyleBackColor = true;
            // 
            // rbEliminado
            // 
            this.rbEliminado.AutoSize = true;
            this.rbEliminado.Location = new System.Drawing.Point(681, 54);
            this.rbEliminado.Name = "rbEliminado";
            this.rbEliminado.Size = new System.Drawing.Size(83, 19);
            this.rbEliminado.TabIndex = 9;
            this.rbEliminado.TabStop = true;
            this.rbEliminado.Text = "Eliminados";
            this.rbEliminado.UseVisualStyleBackColor = true;
            // 
            // grdProyecto
            // 
            this.grdProyecto.AllowUserToAddRows = false;
            this.grdProyecto.AllowUserToDeleteRows = false;
            this.grdProyecto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProyecto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.descripcion,
            this.version,
            this.alcance,
            this.responsable,
            this.producto,
            this.borrado});
            this.grdProyecto.Location = new System.Drawing.Point(8, 137);
            this.grdProyecto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grdProyecto.MultiSelect = false;
            this.grdProyecto.Name = "grdProyecto";
            this.grdProyecto.ReadOnly = true;
            this.grdProyecto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProyecto.Size = new System.Drawing.Size(761, 197);
            this.grdProyecto.TabIndex = 5;
            this.grdProyecto.SelectionChanged += new System.EventHandler(this.grdProyecto_SelectionChanged);
            // 
            // lblResponsable
            // 
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Location = new System.Drawing.Point(264, 62);
            this.lblResponsable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(76, 15);
            this.lblResponsable.TabIndex = 3;
            this.lblResponsable.Text = "Responsable:";
            // 
            // cboResponsable
            // 
            this.cboResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboResponsable.FormattingEnabled = true;
            this.cboResponsable.Location = new System.Drawing.Point(348, 59);
            this.cboResponsable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboResponsable.Name = "cboResponsable";
            this.cboResponsable.Size = new System.Drawing.Size(140, 23);
            this.cboResponsable.TabIndex = 2;
            // 
            // cboProducto
            // 
            this.cboProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(348, 30);
            this.cboProducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(204, 23);
            this.cboProducto.TabIndex = 1;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(681, 104);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(88, 27);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(276, 33);
            this.lblProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(64, 15);
            this.lblProducto.TabIndex = 0;
            this.lblProducto.Text = "Productos:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(696, 361);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(88, 46);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.tTbtn.SetToolTip(this.btnSalir, "Salir");
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(217, 361);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 46);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.tTbtn.SetToolTip(this.btnEliminar, "Eliminar");
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(122, 361);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(88, 46);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.tTbtn.SetToolTip(this.btnEditar, "Editar");
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(23, 361);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(88, 46);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Agregar";
            this.tTbtn.SetToolTip(this.btnNuevo, "Nuevo\r\n");
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 150;
            // 
            // version
            // 
            this.version.HeaderText = "Versión";
            this.version.Name = "version";
            this.version.ReadOnly = true;
            this.version.Width = 50;
            // 
            // alcance
            // 
            this.alcance.HeaderText = "Alcance";
            this.alcance.Name = "alcance";
            this.alcance.ReadOnly = true;
            this.alcance.Width = 150;
            // 
            // responsable
            // 
            this.responsable.HeaderText = "Responsable";
            this.responsable.Name = "responsable";
            this.responsable.ReadOnly = true;
            // 
            // producto
            // 
            this.producto.HeaderText = "Producto";
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            this.producto.Width = 200;
            // 
            // borrado
            // 
            this.borrado.HeaderText = "Borrado";
            this.borrado.Name = "borrado";
            this.borrado.ReadOnly = true;
            this.borrado.Visible = false;
            // 
            // frmProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 421);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gbProyecto);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "frmProyecto";
            this.Text = "Soporte de proyecto";
            this.Load += new System.EventHandler(this.frmProyecto_Load);
            this.gbProyecto.ResumeLayout(false);
            this.gbProyecto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProyecto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProyecto;
        private System.Windows.Forms.DataGridView grdProyecto;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.ComboBox cboResponsable;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolTip tTbtn;
        private System.Windows.Forms.RadioButton rbActivos;
        private System.Windows.Forms.RadioButton rbEliminado;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn version;
        private System.Windows.Forms.DataGridViewTextBoxColumn alcance;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrado;
    }
}