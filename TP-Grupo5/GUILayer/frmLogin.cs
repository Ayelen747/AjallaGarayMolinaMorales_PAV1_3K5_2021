using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TP_Grupo5.DataAccesLayer;

namespace TP_Grupo5.GUILayer
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if ((txtUsuario.Text == ""))
            {
                MessageBox.Show("Se debe ingresar un usuario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if ((txtContraseña.Text == ""))
            {
                MessageBox.Show("Se debe ingresar una contraseña.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (ValidarUsuario(txtUsuario.Text, txtContraseña.Text))
            {
                this.Close();
            }
            else
            {
                txtContraseña.Text = "";
                txtContraseña.Focus();
                MessageBox.Show("Debe ingresar usuario y/o contraseña válidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool ValidarUsuario(string pUsuario, string pPassword)
            {

                bool usuarioValido = false;


                try
                {
                    String consultaSql = string.Concat(" SELECT * ",
                                                       "   FROM Usuarios ",
                                                       "  WHERE usuario =  '", pUsuario, "'");

                    //Usando el método GetDBHelper obtenemos la instancia unica de DBHelper (Patrón Singleton) y ejecutamos el método ConsultaSQL()
                    DataTable resultado = DBHelper.GetDBHelper().ConsultaSQL(consultaSql);

                    // Validamos que el resultado tenga al menos una fila.
                    if (resultado.Rows.Count >= 1)
                    {
                        //En caso de que exista el usuario, validamos que password corresponda al usuario
                        if (resultado.Rows[0]["password"].ToString() == pPassword)
                        {
                            usuarioValido = true;
                        }
                    }

                }
                catch (SqlException ex)
                {
                    //Mostramos un mensaje de error indicando que hubo un error en la base de datos.
                    MessageBox.Show(string.Concat("Error de base de datos: ", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Retornamos el valor de usuarioValido. 
                return usuarioValido;
            }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
 }
