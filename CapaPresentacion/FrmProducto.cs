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

    public partial class FrmProducto : Form
    {
        clasProducto nPro = new clasProducto();
        public FrmProducto()
        {

            InitializeComponent();
        }

        private void btnRegistrarProductos_Click(object sender, EventArgs e)
        {
            FrmNuevoProducto pro = new FrmNuevoProducto();
            pro.ShowDialog();
            nPro.buscarProducto(dgvProductos);
        }

        private void btnActualizarProductos_Click(object sender, EventArgs e)
        {
            int valor;
            FrmNuevoProducto frmNuevoProducto = new FrmNuevoProducto();
            frmNuevoProducto.btnActualizarProducto.Visible = true;
            frmNuevoProducto.btnGuardarProducto.Visible = false;
            if (dgvProductos.SelectedRows.Count > 0)
            {
                frmNuevoProducto.txtIdProducto.Text = dgvProductos.CurrentRow.Cells[0].Value.ToString();
                frmNuevoProducto.txtNombreProducto.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
                valor = Convert.ToInt32(dgvProductos.CurrentRow.Cells[2].Value);
                if (valor > 0)
                {
                    frmNuevoProducto.nudExistenciaProducto.Text = dgvProductos.CurrentRow.Cells[2].Value.ToString();
                    frmNuevoProducto.nudExistenciaProducto.Visible = true;
                    frmNuevoProducto.lblExistenciaProducto.Visible = true;
                }
                frmNuevoProducto.ShowDialog();
                nPro.buscarProducto(dgvProductos);
            }
            else
                MessageBox.Show("¡Debe seleccionar la fila!");
        }

        private void btnEliminarProductos_Click(object sender, EventArgs e)
        {
            FrmNuevoProducto frm = new FrmNuevoProducto();
            if (dgvProductos.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Deseas Eliminar?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string claveP = dgvProductos.CurrentRow.Cells[0].Value.ToString();
                    nPro.EliminarProducto(Convert.ToInt32(claveP));
                    nPro.buscarProducto(dgvProductos);
                }
            }
            else
                MessageBox.Show("Debe Seleccionar la fila");
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            nPro.buscarProducto(dgvProductos);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
