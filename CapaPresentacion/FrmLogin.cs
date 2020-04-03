using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoADatos;

namespace Sistema_Ganadero.CapaPresentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtContrasenia.Text == "" & txtNombreUsuario.Text == "")
            {
                MessageBox.Show("¡Es Necesario escribir el nombre de usuario y contraseña!");
            }
            else
            {
                if (txtNombreUsuario.Text == "")
                {
                    MessageBox.Show("¡Es necesario escribir el nombre de usuario!");
                    txtContrasenia.Clear();
                    txtNombreUsuario.Focus();
                }
                else if (txtContrasenia.Text == "")
                {
                    MessageBox.Show("¡Es necesario escribir la contraseña!");
                    txtContrasenia.Focus();
                }
                else
                {
                    string condicion = string.Format("nombreusuario='{0}'", txtNombreUsuario.Text);
                    string[] datos = FrameBD.ObtieneCampos("empleados", condicion, "nombreusuario, contrasenia,idrol,nombres");

                    if (datos.Length > 0)
                    {
                        if (datos[1] == txtContrasenia.Text)
                        {

                            if (datos[2] == "1")
                            {
                                FrameBD.rol = datos[2];
                                FrameBD.quienAccede = datos[3];
                                FrmPrincipal oMenu = new FrmPrincipal();
                                this.Hide();
                                oMenu.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                FrmPrincipal m = new FrmPrincipal();


                                this.Hide();
                                m.ShowDialog();
                                this.Close();
                            }
                        }
                        else
                            MessageBox.Show("¡La contraseña es incorrecta!");
                        txtContrasenia.Clear();
                        txtContrasenia.Focus();
                    }
                    else
                        MessageBox.Show("¡El Usuario no existe!");
                    txtNombreUsuario.Focus();
                    txtContrasenia.Clear();
                }
            }
        }
        private void txtContrasenia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtContrasenia.Text == "" & txtNombreUsuario.Text == "")
                {
                    MessageBox.Show("¡Es Necesario escribir el nombre de usuario y contraseña!");
                }
                else
                {
                    if (txtNombreUsuario.Text == "")
                    {
                        MessageBox.Show("¡Es necesario escribir el nombre de usuario!");
                        txtContrasenia.Clear();
                        txtNombreUsuario.Focus();
                    }
                    else if (txtContrasenia.Text == "")
                    {
                        MessageBox.Show("¡Es necesario escribir la contraseña!");
                        txtContrasenia.Focus();
                    }
                    else
                    {
                        string condicion = string.Format("nombreusuario='{0}'", txtNombreUsuario.Text);
                        string[] datos = FrameBD.ObtieneCampos("empleados", condicion, "nombreusuario, contrasenia,idrol,nombres");

                        if (datos.Length > 0)
                        {
                            if (datos[1] == txtContrasenia.Text)
                            {
                                if (datos[2] == "1")
                                {
                                    FrameBD.rol = datos[2];
                                    FrameBD.quienAccede = datos[3];
                                    FrmPrincipal oMenu = new FrmPrincipal();
                                    this.Hide();
                         
                                    oMenu.ShowDialog();
                                    this.Close();
                                }
                        else
                            MessageBox.Show("¡El Usuario no existe!");
                        txtNombreUsuario.Focus();
                        txtContrasenia.Clear();
                    }
                }
            }
          }
       }
    }
        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas Salir?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
                private void txtNombreUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txtContrasenia.Focus();
            }
        }
    }
}
