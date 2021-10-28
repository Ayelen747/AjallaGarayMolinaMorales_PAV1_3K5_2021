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
    public partial class Contactos : Form
    {
        private ContactoServicio oContactoServicio;
        public Contactos()
        {
            InitializeComponent();
            oContactoServicio = new ContactoServicio();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = string.Empty;

            if (!chbTodos.Checked)
            {
                if (txtNombre.Text == string.Empty && txtApellido.Text == string.Empty)
                {
                    MessageBox.Show("ingrese datos", "adv");
                }
                else
                {
                    if (txtNombre.Text != string.Empty)
                    {
                        filtro = filtro + " AND c.nombre LIKE '%" + txtNombre.Text + "%'";
                        llenarGrilla(dgvContactos, oContactoServicio.consultaConFiltros(filtro));
                    }

                    if (txtApellido.Text != string.Empty)
                    {
                        filtro = filtro + " AND c.apellido LIKE '%" + txtApellido.Text + "%'";
                        llenarGrilla(dgvContactos, oContactoServicio.consultaConFiltros(filtro));
                    }
                }
                

            }
            else
            {
                llenarGrilla(dgvContactos, oContactoServicio.dameTodo());
            }
        }

        private void habilitarCampos(Boolean valor)
        {
            grbContactos.Enabled = true;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            dgvContactos.Rows.Clear();
            btnActualizar.Enabled = !valor;
            btnEliminar.Enabled = !valor;
        }

        private void llenarGrilla(DataGridView grilla, IList<Contacto> lista)
        {
            grilla.Rows.Clear();
            if (lista.Count > 0)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    
                    dgvContactos.Rows.Add(
                        lista[i].Id_Contacto,
                        lista[i].Nombre,
                        lista[i].Apellido,
                        lista[i].Email,
                        lista[i].Telefono
                        );
                }
                dgvContactos.CurrentRow.Selected = false;
                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se encontraron Contactos", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnEliminar.Enabled = false;
                btnActualizar.Enabled = false;
            }
                
        
        }

        private void chbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chbTodos.Checked)
            {
                txtNombre.Text = string.Empty;
                txtApellido.Text = string.Empty;
                grbContactos.Enabled = false;
            }

            else
                grbContactos.Enabled = true;
        }



        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            chbTodos.Checked = false;
            habilitarCampos(true);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmABMContacto ofrmABMContacto = new frmABMContacto();
            ofrmABMContacto.ShowDialog();
            chbTodos.Checked = true;
            btnBuscar_Click(sender, e);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvContactos.CurrentRow == null)
                MessageBox.Show("Seleccione una fila de la grilla", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                frmABMContacto ofrmABMContacto = new frmABMContacto();
                ofrmABMContacto.SeleccionarContacto(frmABMContacto.FormMode.update, (int)dgvContactos.CurrentRow.Cells[0].Value);
                ofrmABMContacto.ShowDialog();
                chbTodos.Checked = true;
                btnBuscar_Click(sender, e);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvContactos.CurrentRow == null)
                MessageBox.Show("Seleccione una fila de la grilla", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                frmABMContacto ofrmABMContacto = new frmABMContacto();
                ofrmABMContacto.SeleccionarContacto(frmABMContacto.FormMode.delete, (int)dgvContactos.CurrentRow.Cells[0].Value);
                ofrmABMContacto.borrar_contacto();
                chbTodos.Checked = true;
                btnBuscar_Click(sender, e);
            }
        }
    }
}
