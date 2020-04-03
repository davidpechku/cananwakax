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
    public partial class FrmNuevoCliente : Form
    {
        clasCliente cliente = new clasCliente();

        public FrmNuevoCliente()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            FrmClientes frm = new FrmClientes();
            if (txtNombre.Text == "" & txtApellidos.Text == "" & txtDireccion.Text == "" & txtCorreo.Text == "" & txtTelefono.Text == "" )
            {
                MessageBox.Show("Es necesario llenar todos los campos");
            }
            else
            {
                txtNombre.Focus();
                cliente.nombreCliente = txtNombre.Text;
                cliente.apellidoCliente = txtApellidos.Text;
                cliente.direccionCliente = txtDireccion.Text;
                cliente.correoCliente= txtCorreo.Text;
                cliente.telefonoCliente = txtTelefono.Text;
                cliente.AgregarCliente();
                cliente.BuscarCliente(txtId.Text, frm.dgvClientes);
                MessageBox.Show("Se ha agregado un nuevo cliente");
                this.Close();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            FrmClientes frm = new FrmClientes();
            cliente.EditarCliente(Convert.ToInt32(txtId.Text), txtNombre.Text, txtApellidos.Text, txtDireccion.Text, txtCorreo.Text, txtTelefono.Text);
            cliente.BuscarCliente(txtId.Text, frm.dgvClientes);
            MessageBox.Show("Se ha actualizado correctamente");
            this.Close();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloLetras(e);
        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloLetras(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
