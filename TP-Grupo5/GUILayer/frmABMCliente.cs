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
        
        private FormMode formMode = FormMode.insert;
        public frmABMCliente()
        {
            InitializeComponent();
            oBarrioServicio = new BarrioServicio();
            LlenarCombo(cboBarrio, oBarrioServicio.dameTodo(), "Nombre", "Id_barrio");
        }

        public enum FormMode
        { 
            insert,
            update,
            delete,
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
                            var Cliente = new Cliente
                            {
                                Razon_social = txtRazonSocial.Text,
                                Barrio = new Barrio
                                {
                                    Nombre = cboBarrio.Text
                                },
                                Calle = txtCalle.Text,
                                Numero = Convert.ToInt32(txtNroCalle.Text),
                                Contacto = new Contacto
                                {
                                    Id_Contacto = Convert.ToInt32(cboContacto.SelectedValue)
                                },
                                Fecha_alta = dtpFechaAlta.Value
                            };

                        }
                        break;
                    };
                case FormMode.update:
                    {
                        MessageBox.Show("actualizado");
                        break;
                    };
                case FormMode.delete:
                    {
                        MessageBox.Show("borrado");
                        break;
                    }





            }
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
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void chkSinContacto_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSinContacto.Checked)
                cboContacto.Enabled = false;
            else
                cboContacto.SelectedIndex = -1;
                cboContacto.Enabled = true;
        }

        private void frmABMCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
