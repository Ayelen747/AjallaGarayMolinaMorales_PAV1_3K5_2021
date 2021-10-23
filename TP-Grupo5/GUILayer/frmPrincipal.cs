using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TP_Grupo5.GUILayer
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            frmLogin ofrmLogin = new frmLogin();
            ofrmLogin.ShowDialog();
            this.Text = "Nombre de usuario: "+ofrmLogin.Text;
        }

        

        

        private void consultarProyectosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProyecto ofrmProyecto = new frmProyecto();
            ofrmProyecto.ShowDialog();
        }

        private void consultarBarriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarBarrio ofrmConsultaBarrio = new frmConsultarBarrio();
            ofrmConsultaBarrio.ShowDialog();
        }

        private void consularClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaCliente ofrmConsultaCliente = new frmConsultaCliente();
            ofrmConsultaCliente.ShowDialog();
        }
    }
}
