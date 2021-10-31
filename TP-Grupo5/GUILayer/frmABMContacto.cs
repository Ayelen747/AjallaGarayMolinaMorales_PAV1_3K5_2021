using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TP_Grupo5.BusinesLayer;
using TP_Grupo5.Entities;

namespace TP_Grupo5.GUILayer
{
    public partial class frmABMContacto : Form
    {
        private ContactoServicio oContactoServicio;
        private int idContacto;
        private FormMode formMode = FormMode.insert;
        public bool bandera { get; set; }
        public frmABMContacto()
        {
            InitializeComponent();
            oContactoServicio = new ContactoServicio();
        }

        public enum FormMode
        {
            insert,
            update,
            delete,
        }

        public void SeleccionarContacto(FormMode op, int id)
        {
            formMode = op;
            idContacto = id;
        }

        private void frmABMContacto_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Nuevo Contacto";
                        break;
                    }
                case FormMode.update:
                    {
                        this.Text = "Actualizar Contacto";
                        LlenarCampos();
                        break;
                    };
                case FormMode.delete:
                    {
                        this.Text = "Eliminar Contacto";
                        LlenarCampos();
                        grbContacto.Enabled = false;
                        break;
                    }
            }
        }

        private void LlenarCampos()
        {
            Contacto oContacto = oContactoServicio.consultaConFiltros(" AND c.id_contacto=" + idContacto)[0];
            txtID.Text = oContacto.Id_Contacto.ToString();
            txtNombre.Text = oContacto.Nombre;
            txtApellido.Text = oContacto.Apellido;
            txtEmail.Text = oContacto.Email;
            txtTelefono.Text = oContacto.Telefono.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private bool validarCampos()
        {
            if (txtNombre.Text == string.Empty)
            {
                txtNombre.BackColor = Color.LightPink;
                txtNombre.Focus();
                return false;
            }
            if (txtApellido.Text == string.Empty)
            {
                txtApellido.BackColor = Color.LightPink;
                txtApellido.Focus();
                return false;
            }
            if (txtEmail.Text == string.Empty)
            {
                txtEmail.BackColor = Color.LightPink;
                txtEmail.Focus();
                return false;
            }
            if (txtTelefono.Text == string.Empty)
            {
                txtTelefono.BackColor = Color.LightPink;
                txtTelefono.Focus();
                return false;
            }
            return true;
        }

        public void borrar_contacto()

        {
            Contacto oContacto = new Contacto
            {
                Id_Contacto = idContacto
            };
            var info = MessageBox.Show("¿Esta seguro que desea eliminar este contacto?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (info == DialogResult.Yes)
            {
                bool valor = oContactoServicio.EliminarContacto(oContacto);
                if (valor)
                {
                    MessageBox.Show("Eliminado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            bandera = true;
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        if (validarCampos())
                        {
                            Contacto oContacto = new Contacto
                            {
                                Nombre = txtNombre.Text,
                                Apellido = txtApellido.Text,
                                Email = txtEmail.Text,
                                Telefono = txtTelefono.Text
                            };

                            bool valor = oContactoServicio.InsertarContacto(oContacto);
                            if (valor)
                            {
                                MessageBox.Show("Creado", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Error", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        break;
                    };
                case FormMode.update:
                    {
                        if (validarCampos())
                        {
                            Contacto oContacto = new Contacto
                            {
                                Id_Contacto = Convert.ToInt32(txtID.Text),
                                Nombre = txtNombre.Text,
                                Apellido = txtApellido.Text,
                                Email = txtEmail.Text,
                                Telefono = txtTelefono.Text
                            };

                            bool valor = oContactoServicio.ActualizarContacto(oContacto);
                            if (valor)
                            {
                                MessageBox.Show("Actualizado", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Error", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        break;
                    };
                case FormMode.delete:
                    {
                        Contacto oContacto = new Contacto
                        {
                            Id_Contacto = idContacto
                        };
                        bool valor = oContactoServicio.EliminarContacto(oContacto);
                        if (valor)
                        {
                            MessageBox.Show("Eliminado", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Error", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;

                    }
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
            bandera = false;
        }

    }
}

