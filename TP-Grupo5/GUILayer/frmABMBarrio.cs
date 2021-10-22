using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TP_Grupo5.BusinesLayer;
using TP_Grupo5.Entities;
using TP_Grupo5.GUILayer;

namespace TP_Grupo5.GUILayer
{
    public partial class frmABMBarrio : Form
    {
        private BarrioServicio oBarrioServicio;
        private FormMode formMode = FormMode.insert;
        private int id_barrio;
        public frmABMBarrio()
        {
            InitializeComponent();
            oBarrioServicio = new BarrioServicio();
        }

        public enum FormMode
        {
            insert,
            update,
            delete,
        }

        public void SeleccionarBarrio(FormMode op, int id)
        {
            formMode = op;
            id_barrio = id;
        }

        private void ABMBarrio_Load(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Nuevo Barrio";
                        break;
                    }
                case FormMode.update:
                    {
                        this.Text = "Actualizar Barrio";
                        LlenarCampos();
                        break;
                    };
                case FormMode.delete:
                    {
                        this.Text = "Eliminar Barrio";
                        LlenarCampos();
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
                            Barrio oBarrio = new Barrio
                            {
                                Nombre = txtNombreBarrio.Text,
                            };
                            bool valor = oBarrioServicio.InsertarBarrio(oBarrio);
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
                            Barrio oBarrio = new Barrio
                            {
                                Nombre = txtNombreBarrio.Text,
                                Id_Barrio = id_barrio
                            };
                            bool valor = oBarrioServicio.ActualizarBarrio(oBarrio);
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
                        {
                            Barrio oBarrio = new Barrio
                            {
                                Id_Barrio = id_barrio
                            };
                            bool valor = oBarrioServicio.EliminarBarrio(oBarrio);
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
        }
        private void LlenarCampos()
        {
            Barrio oBarrio = oBarrioServicio.dameTodo()[0];
            txtIDBarrio.Text = oBarrio.Id_Barrio.ToString();
            txtNombreBarrio.Text = oBarrio.Nombre;
        }
        private bool validarCampos()
        {
            if (txtNombreBarrio.Text == string.Empty)
            {
                txtNombreBarrio.BackColor = Color.LightPink;
                txtNombreBarrio.Focus();
                return false;
            }

            return true;
        }

        public void borrar_barrio()
        
        {
            Barrio oBarrio = new Barrio
            {
                Id_Barrio = id_barrio
            };
            bool valor = oBarrioServicio.EliminarBarrio(oBarrio);
            if (valor)
            {
                MessageBox.Show("¿Esta seguro que desea eliminar este barrio?","Advertencia",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
        
    }
}

