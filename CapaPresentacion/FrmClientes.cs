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
    public partial class FrmClientes : Form
    {

        clasCliente cliente = new clasCliente();

        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            cliente.BuscarCliente(txtBuscar.Text, dgvClientes);
            txtBuscar.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoCliente frm = new FrmNuevoCliente();
            frm.btnGuardar.Visible = true;
            frm.btnActualizar.Visible = false;
            frm.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmNuevoCliente frm = new FrmNuevoCliente();
            frm.btnGuardar.Visible = false;
            frm.btnActualizar.Visible = true;
            
                frm.txtId.Text = dgvClientes.CurrentRow.Cells[0].Value.ToString();
                frm.txtNombre.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
                frm.txtApellidos.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
                frm.txtDireccion.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
                frm.txtCorreo.Text = dgvClientes.CurrentRow.Cells[4].Value.ToString();
                frm.txtTelefono.Text = dgvClientes.CurrentRow.Cells[5].Value.ToString();


                frm.ShowDialog();
                ActualizarCliente();
            
        }

        public void ActualizarCliente()
        {
            cliente.BuscarCliente(txtBuscar.Text, dgvClientes);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas Eliminar?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string claveE = dgvClientes.CurrentRow.Cells[0].Value.ToString();
                cliente.EliminarCliente(Convert.ToInt32(claveE));
                cliente.BuscarCliente(txtBuscar.Text, dgvClientes);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            cliente.BuscarCliente(txtBuscar.Text, dgvClientes);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmNuevoCliente frm = new FrmNuevoCliente();
            frm.Show();
        }
    }
}
