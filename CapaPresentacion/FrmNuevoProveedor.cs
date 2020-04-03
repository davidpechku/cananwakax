using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Ganadero.Clases;

namespace Sistema_Ganadero.CapaPresentacion
{
    public partial class FrmNuevoProveedor : Form
    {
        clasProveedor pro = new clasProveedor();
        public FrmNuevoProveedor()
        {
            InitializeComponent();
        }

        private void btnGuardarProveedor_Click(object sender, EventArgs e)
        {
            if (txtNombreEmpresaP.Text == "" &&
               txtDireccionProveedores.Text == "" &&
               txtTelefonoProveedores.Text == "" &&
               txtRfcProveedores.Text == "" &&
               txtCiudadProveedores.Text == "" &&
               txtCodigoPostalProveedores.Text == "" &&
               txtCorreoProveedores.Text == "")
            {
                MessageBox.Show("Todos los campos son obligatorios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                clasProveedor pro = new clasProveedor();

                pro.nombre = txtNombreEmpresaP.Text;
                pro.direccion = txtDireccionProveedores.Text;
                pro.telefono = txtTelefonoProveedores.Text;
                pro.rfc = txtRfcProveedores.Text;
                pro.codigo_postal = txtCodigoPostalProveedores.Text;
                pro.ciudad = txtCiudadProveedores.Text;
                pro.correo_electronico = txtCorreoProveedores.Text;
                pro.agregarProveedor();

                MessageBox.Show("Registro guardado exitosamente", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnActualizarProveedor_Click(object sender, EventArgs e)
        {
            frmProveedores frmPro = new frmProveedores();
            pro.editarProveedor(Convert.ToInt32(txtIdProveedor.Text), txtNombreEmpresaP.Text, txtTelefonoProveedores.Text, txtDireccionProveedores.Text, txtRfcProveedores.Text, txtCodigoPostalProveedores.Text, txtCiudadProveedores.Text, txtCorreoProveedores.Text);
            //pro.BuscarProveedor(frmPro.dataGridView1);
            MessageBox.Show("Registro actualizado exitosamente", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancelarProveedor_Click(object sender, EventArgs e)
        {

        }

        private void FrmNuevoProveedor_Load(object sender, EventArgs e)
        {

        }

        private void txtCodigoPostalProveedores_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
