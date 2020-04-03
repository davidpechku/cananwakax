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
    public partial class frmProveedores : Form
    {
        clasProveedor pro = new clasProveedor();
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            pro.BuscarProveedor(dgvMostrar);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrarProveedores_Click(object sender, EventArgs e)
        {
            FrmNuevoProveedor frmNuevoProveedor = new FrmNuevoProveedor();
            frmNuevoProveedor.btnGuardarProveedor.Visible = true;
            frmNuevoProveedor.btnActualizarProveedor.Visible = false;
            frmNuevoProveedor.ShowDialog();
            pro.BuscarProveedor(dgvMostrar);
        }

        private void btnActualizarProveedores_Click(object sender, EventArgs e)
        {
            FrmNuevoProveedor frmNuevoProveedor = new FrmNuevoProveedor();
            frmNuevoProveedor.btnActualizarProveedor.Visible = true;
            frmNuevoProveedor.btnGuardarProveedor.Visible = false;
            if (dgvMostrar.SelectedRows.Count > 0)
            {
                frmNuevoProveedor.txtIdProveedor.Text = dgvMostrar.CurrentRow.Cells[0].Value.ToString();
                frmNuevoProveedor.txtNombreEmpresaP.Text = dgvMostrar.CurrentRow.Cells[1].Value.ToString();
                frmNuevoProveedor.txtTelefonoProveedores.Text = dgvMostrar.CurrentRow.Cells[2].Value.ToString();
                frmNuevoProveedor.txtDireccionProveedores.Text = dgvMostrar.CurrentRow.Cells[3].Value.ToString();
                frmNuevoProveedor.txtRfcProveedores.Text = dgvMostrar.CurrentRow.Cells[4].Value.ToString();
                frmNuevoProveedor.txtCodigoPostalProveedores.Text = dgvMostrar.CurrentRow.Cells[5].Value.ToString();
                frmNuevoProveedor.txtCiudadProveedores.Text = dgvMostrar.CurrentRow.Cells[6].Value.ToString();
                frmNuevoProveedor.txtCorreoProveedores.Text = dgvMostrar.CurrentRow.Cells[7].Value.ToString();
                frmNuevoProveedor.ShowDialog();
                pro.BuscarProveedor(dgvMostrar);
            }
            else
                MessageBox.Show("¡Debe seleccionar la fila!");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            FrmNuevoProveedor frm = new FrmNuevoProveedor();
            if (dgvMostrar.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Deseas Eliminar?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string claveP = dgvMostrar.CurrentRow.Cells[0].Value.ToString();
                    pro.EliminarProveedor(Convert.ToInt32(claveP));
                    pro.BuscarProveedor(dgvMostrar);
                }
            }
            else
                MessageBox.Show("Debe Seleccionar la fila");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTituloCompras_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmNuevoProveedor frm = new FrmNuevoProveedor();
            frm.Show();
        }
    }
}
