using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TP_Grupo5.BusinesLayer;

namespace TP_Grupo5.GUILayer
{
    public partial class frmTransaccionFactura : Form
    {
        private ClienteServicio oClienteServicio;
        public frmTransaccionFactura()
        {
            InitializeComponent();
            oClienteServicio = new ClienteServicio();
            LlenarCombo(cboCliente,oClienteServicio.dameTodo(), "Razon_social", "Id_cliente");
        }
        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }
        private void frmTransaccionFactura_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private bool validarAgregarDetalle()
        {
            
            return false;
        }
    }
}
