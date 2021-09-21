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
using TP_Grupo5.GUILayer;

namespace TP_Grupo5
{
    public partial class frmConsultaCliente : Form
    {
        
        public frmConsultaCliente()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmConsultarCliente_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }
    }
}
