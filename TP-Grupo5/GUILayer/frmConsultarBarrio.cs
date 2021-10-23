using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TP_Grupo5.BusinesLayer;
using TP_Grupo5.Entities;
using TP_Grupo5.DataAccesLayer;

namespace TP_Grupo5.GUILayer
{
    public partial class frmConsultarBarrio : Form
    {
        private BarrioServicio oBarrioServicio;
        public frmConsultarBarrio()
        {
            InitializeComponent();
            oBarrioServicio = new BarrioServicio();
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

            if (txtNombreBarrio.Text != string.Empty)
            {
                //filtro = filtro + " AND b.barrio LIKE '%" + txtNombreBarrio.Text + "%'";
                filtro = filtro + " AND b.nombre LIKE '%" + txtNombreBarrio.Text + "%'";
                llenarGrilla(dgvBarrios, oBarrioServicio.consultaConFiltros(filtro));
            }
                
<<<<<<< HEAD
=======



>>>>>>> 4b7d4a5553e316d9810018732cb2a9ee2106991b
            else
            {
                llenarGrilla(dgvBarrios, oBarrioServicio.dameTodo());
            }

        }
<<<<<<< HEAD

=======
        
>>>>>>> 4b7d4a5553e316d9810018732cb2a9ee2106991b

        private void llenarGrilla(DataGridView grilla, IList<Barrio> lista)
        {
            grilla.Rows.Clear();
            if (lista.Count > 0)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    dgvBarrios.Rows.Add(
                        lista[i].Id_Barrio,
                        lista[i].Nombre
                        );
                }
            }
            else
            {
                MessageBox.Show("No se encontraron Barrios", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (dgvBarrios.CurrentRow == null)
                MessageBox.Show("Seleccione una fila de la grilla");
            else
            {
                frmABMBarrio ofrmABMBarrio = new frmABMBarrio();
                ofrmABMBarrio.SeleccionarBarrio(frmABMBarrio.FormMode.update, (int)dgvBarrios.CurrentRow.Cells[0].Value);
                ofrmABMBarrio.ShowDialog();
            }
        }


        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            frmABMBarrio ofrmABMBarrio = new frmABMBarrio();
            ofrmABMBarrio.ShowDialog();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dgvBarrios.CurrentRow == null)
                MessageBox.Show("Seleccione una fila de la grilla");
            else
            {
                frmABMBarrio ofrmABMBarrio = new frmABMBarrio();
                ofrmABMBarrio.SeleccionarBarrio(frmABMBarrio.FormMode.delete, (int)dgvBarrios.CurrentRow.Cells[0].Value);
                ofrmABMBarrio.borrar_barrio();
                btnBuscar_Click(sender, e);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvBarrios.Rows.Clear();
=======

>>>>>>> 4b7d4a5553e316d9810018732cb2a9ee2106991b
        }
    }
}
