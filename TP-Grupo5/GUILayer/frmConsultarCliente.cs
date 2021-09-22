using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Grupo5.DataAccesLayer;
using TP_Grupo5.BusinesLayer;
using TP_Grupo5.Entities;

namespace TP_Grupo5
{
    public partial class frmConsultaCliente : Form
    {
        private BarrioServicio oBarrioServicio;
        private ClienteServicio oClienteServicio;
        public frmConsultaCliente()
        {
            InitializeComponent();
            oBarrioServicio = new BarrioServicio();
            oClienteServicio = new ClienteServicio();
            LlenarCombo(cboBarrio,oBarrioServicio.dameTodo(),"Nombre","Id_barrio");
            habilitarCampos(true);
        }
        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = string.Empty;

            if (!chkTodos.Checked)
            {
                if (txtRazonSocial.Text != string.Empty)
                {
                    filtro = filtro + " AND c.razon_social LIKE '%" + txtRazonSocial.Text + "%'";
                }
                if (cboBarrio.SelectedIndex != -1)
                {
                    filtro = filtro + " AND c.id_barrio=" + cboBarrio.SelectedValue;
                }
                if (txtCuit.Text != string.Empty)
                {
                    filtro = filtro + " AND c.cuit=" + Convert.ToInt32(txtCuit.Text);
                }
                if (rbAntes.Checked)
                {
                    filtro = filtro + " AND c.fecha_alta<=Convert(DateTime, " + "'" + dtpFechaAlta.Value.ToShortDateString() + "'" + ", 103)";
                }
                if (rbActual.Checked)
                {
                    filtro = filtro + " AND c.fecha_alta=Convert(DateTime, " + "'" + dtpFechaAlta.Value.ToShortDateString() + "'" + ", 103)";
                }
                if (rbDespues.Checked)
                {
                    filtro = filtro + " AND c.fecha_alta>=Convert(DateTime, " + "'" + dtpFechaAlta.Value.ToShortDateString() + "'" + ", 103)";
                }

                llenarGrilla(grdClientes, oClienteServicio.consultaConFiltros(filtro));
            }
            else
                llenarGrilla(grdClientes, oClienteServicio.dameTodo());

        }

        private void habilitarCampos(Boolean valor)
        {
            txtRazonSocial.Text = string.Empty;
            txtCuit.Text = string.Empty;
            rbAntes.Checked = true;
            cboBarrio.SelectedIndex = -1;
            grdClientes.Rows.Clear();
            btnActualizar.Enabled = !valor;
            btnEliminar.Enabled = !valor;
        }

        private void llenarGrilla(DataGridView grilla, IList<Cliente> lista)
        {
            grilla.Rows.Clear();
            if (lista.Count > 0)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    grdClientes.Rows.Add(
                        lista[i].Id_cliente,
                        lista[i].Razon_social,
                        lista[i].Cuit,
                        lista[i].Calle,
                        lista[i].Numero,
                        lista[i].Fecha_alta,
                        lista[i].Barrio.Nombre,
                        lista[i].Contacto.Nombre
                        );
                }
                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se encontraron Clientes", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnEliminar.Enabled = false;
                btnActualizar.Enabled = false;
            }
                
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
                gbBuscarCliente.Enabled = false;
            else
                gbBuscarCliente.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            habilitarCampos(true);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
