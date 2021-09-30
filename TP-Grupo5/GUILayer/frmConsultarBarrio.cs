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
                



            else
            {
                llenarGrilla(dgvBarrios, oBarrioServicio.dameTodo());
            }

        }
        

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

        }
    }
}
