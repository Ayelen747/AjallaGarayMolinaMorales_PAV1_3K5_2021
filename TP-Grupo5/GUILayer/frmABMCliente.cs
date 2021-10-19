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
    public partial class frmABMCliente : Form
    {
        private BarrioServicio oBarrioServicio;
        private ContactoServicio oContactoServicio;
        private ClienteServicio oClienteServicio;
        private int idCliente;
        private FormMode formMode = FormMode.insert;
        public frmABMCliente()
        {
            InitializeComponent();
            oBarrioServicio = new BarrioServicio();
            oContactoServicio = new ContactoServicio();
            oClienteServicio = new ClienteServicio();
            LlenarCombo(cboBarrio, oBarrioServicio.dameTodo(), "Nombre", "Id_barrio");
            LlenarCombo(cboContacto,oContactoServicio.dameTodo(),"Apellido", "Id_Contacto");
        }

        public enum FormMode
        { 
            insert,
            update,
            delete,
        }

        public void SeleccionarCliente(FormMode op, int id)
        {
            formMode = op;
            idCliente = id;
        }

        private void frmABMCliente_Load(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Nuevo Cliente";
                        break;
                    }
                case FormMode.update:
                    {
                        this.Text = "Actualizar Cliente";
                        LlenarCampos();
                        break; 
                    };
                case FormMode.delete:
                    {
                        this.Text = "Eliminar Cliente";
                        LlenarCampos();
                        grbCliente.Enabled = false;
                        break;
                    }
            }
        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        if (validarCampos())
                        {
                            Cliente oCliente = new Cliente
                            {
                                Razon_social = txtRazonSocial.Text,
                                Cuit = Convert.ToInt32(txtCuit.Text),
                                Barrio = new Barrio
                                {
                                    Id_Barrio = Convert.ToInt32(cboBarrio.SelectedValue)
                                },
                                Calle = txtCalle.Text,
                                Numero = Convert.ToInt32(txtNroCalle.Text),
                                Contacto = new Contacto
                                {
                                    Id_Contacto = Convert.ToInt32(cboContacto.SelectedValue)
                                },
                                Fecha_alta = dtpFechaAlta.Value
                            };
                            bool valor = oClienteServicio.InsertarCliente(oCliente);
                            if (valor)
                            {
                                MessageBox.Show("Creado");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Error");
                            }
                        }
                        break;
                    };
                case FormMode.update:
                    {
                        if (validarCampos())
                        {
                            Cliente oCliente = new Cliente
                            {
                                Id_cliente = Convert.ToInt32(txtId.Text),
                                Razon_social = txtRazonSocial.Text,
                                Cuit = Convert.ToInt32(txtCuit.Text),
                                Barrio = new Barrio
                                {
                                    Id_Barrio = Convert.ToInt32(cboBarrio.SelectedValue)
                                },
                                Calle = txtCalle.Text,
                                Numero = Convert.ToInt32(txtNroCalle.Text),
                                Contacto = new Contacto
                                {
                                    Id_Contacto = Convert.ToInt32(cboContacto.SelectedValue)
                                }
                            };
                            bool valor = oClienteServicio.ActualizarCliente(oCliente);
                            if (valor)
                            {
                                MessageBox.Show("Actualizado");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Error");
                            }
                        }
                        break;
                    };
                case FormMode.delete:
                    {
                        Cliente oCliente = new Cliente
                        {
                            Id_cliente = idCliente
                        };
                        bool valor = oClienteServicio.EliminarCliente(oCliente);
                        if (valor)
                        {
                            MessageBox.Show("Eliminado");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Error");
                        }
                        break;
                    }
            }
        }

        private void LlenarCampos()
        {
            Cliente oCliente = oClienteServicio.consultaConFiltros(" AND c.id_cliente=" + idCliente)[0];
            txtId.Text = oCliente.Id_cliente.ToString();
            txtRazonSocial.Text = oCliente.Razon_social;
            txtCuit.Text = oCliente.Cuit.ToString();
            cboBarrio.SelectedValue = oCliente.Barrio.Id_Barrio;
            txtCalle.Text = oCliente.Calle;
            txtNroCalle.Text = oCliente.Numero.ToString();
            cboContacto.SelectedValue = oCliente.Contacto.Id_Contacto;
            dtpFechaAlta.Value = oCliente.Fecha_alta;
        }
        private bool validarCampos()
        {
            if (txtRazonSocial.Text == string.Empty)
            {
                txtRazonSocial.BackColor = Color.LightPink;
                txtRazonSocial.Focus();
                return false;
            }
            if (cboBarrio.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Barrio", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboBarrio.Focus();
                return false;
            }
            if (txtCalle.Text == string.Empty)
            {
                txtCalle.BackColor = Color.LightPink;
                txtRazonSocial.Focus();
                return false;
            }
            if (txtNroCalle.Text == string.Empty)
            {
                txtNroCalle.BackColor = Color.LightPink;
                txtNroCalle.Focus();
                return false;
            }
            if (chkSinContacto.Checked==false)
            {
                if (cboContacto.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un Contacto", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboBarrio.Focus();
                    return false;
                }
            }
            return true;
        }

        private void chkSinContacto_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSinContacto.Checked)
            {
                cboContacto.Enabled = false;
                cboContacto.SelectedIndex = -1;
            }
            else
            {
                cboContacto.Enabled = true;
            }       
        }

        private void txtNroCalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        
    }
}
