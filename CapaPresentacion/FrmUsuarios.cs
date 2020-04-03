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
    public partial class FrmUsuarios : Form
    {
        clasEmpleado em = new clasEmpleado();
        public FrmUsuarios()
        {
            InitializeComponent();
        }
        private void btnCerrarFormulario_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            em.BuscarEmpleado(txtBuscarUsuarios.Text, dgvEmpleados);
            txtBuscarUsuarios.Focus();
        }
        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            FrmNuevoUsuario frm = new FrmNuevoUsuario();
            frm.btnGuardarUsuario.Visible = true;
            frm.btnActualizar.Visible = false;
            frm.ShowDialog();
        }
        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            FrmNuevoUsuario frm = new FrmNuevoUsuario();
            frm.btnActualizar.Visible = true;
            frm.btnGuardarUsuario.Visible = false;
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                frm.txtIdEmpleado.Text = dgvEmpleados.CurrentRow.Cells[0].Value.ToString();
                frm.txtNombresEmpleado.Text = dgvEmpleados.CurrentRow.Cells[1].Value.ToString();
                frm.txtApellidosEmpleado.Text = dgvEmpleados.CurrentRow.Cells[2].Value.ToString();
                frm.txtNombreUsuario.Text = dgvEmpleados.CurrentRow.Cells[3].Value.ToString();
                frm.txtTelefonoEmpleado.Text = dgvEmpleados.CurrentRow.Cells[4].Value.ToString();
                frm.txtDireccionEmpleado.Text = dgvEmpleados.CurrentRow.Cells[5].Value.ToString();
 

                frm.ShowDialog();
                ActualizarEmpleado();
            }
            else
                MessageBox.Show("¡Debe seleccionar la fila!");
        }
        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            FrmNuevoUsuario frm = new FrmNuevoUsuario();
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Deseas Eliminar?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string claveE = dgvEmpleados.CurrentRow.Cells[0].Value.ToString();
                    em.EliminarEmpleado(Convert.ToInt32(claveE));
                    em.BuscarEmpleado(txtBuscarUsuarios.Text, dgvEmpleados);
                }
            }
            else
                MessageBox.Show("Debe Seleccionar la fila");
        }
        public void ActualizarEmpleado()
        {
            em.BuscarEmpleado(txtBuscarUsuarios.Text, dgvEmpleados);
        }
        private void txtBuscarUsuarios_TextChanged(object sender, EventArgs e)
        {
            em.buscar = txtBuscarUsuarios.Text;
            em.BuscarEmpleado(txtBuscarUsuarios.Text, dgvEmpleados);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmUsuarios_Load_1(object sender, EventArgs e)
        {
            this.ActualizarEmpleado();
            em.BuscarEmpleado(txtBuscarUsuarios.Text, dgvEmpleados);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscarUsuarios_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dgvEmpleados_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
 
        }
    }
}