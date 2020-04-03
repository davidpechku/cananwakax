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
    public partial class FrmLoginn : Form
    {

        public FrmLoginn()
        {
            InitializeComponent();
        }
		void TxtNombreUsuarioEnter(object sender, EventArgs e)
		{
			if (txtNombreUsuario.Text == "USUARIO") {
				txtNombreUsuario.Text = "";
				txtNombreUsuario.ForeColor = Color.LightGray;
			}
		}
		void TxtNombreUsuarioLeave(object sender, EventArgs e)
		{
			if (txtNombreUsuario.Text=="") {
				txtNombreUsuario.Text = "USUARIO";
				txtNombreUsuario.ForeColor = Color.DimGray;
			}
		}
		void TxtContraseniaEnter(object sender, EventArgs e)
		{
			if (txtContrasenia.Text=="CONTRASEÑA") {
				txtContrasenia.Text="";
				txtContrasenia.ForeColor=Color.LightGray;
				txtContrasenia.UseSystemPasswordChar = true;
			}
		}
		void TxtContraseniaLeave(object sender, EventArgs e)
		{
			if (txtContrasenia.Text == "") {
				txtContrasenia.Text = "CONTRASEÑA";
				txtContrasenia.ForeColor = Color.DimGray;
				txtContrasenia.UseSystemPasswordChar = false;
			}
		}
		
		void BtnAccederClick(object sender, EventArgs e)
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
                    string condicion = string.Format("user='{0}'", txtNombreUsuario.Text);
                    string[] datos = FrameBD.ObtieneCampos("empleados", condicion, "user, contrasenia,id_rol,nombre");

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
                        string condicion = string.Format("user='{0}'", txtNombreUsuario.Text);
                        string[] datos = FrameBD.ObtieneCampos("empleados", condicion, "user, contrasenia,id_rol,nombre");

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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmLoginn_Load(object sender, EventArgs e)
        {

        }
    }
}
