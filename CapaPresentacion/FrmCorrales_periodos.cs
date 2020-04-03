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
    public partial class frmCorrales_periodos : Form
    {

        ClasCorralesPeriodos op = new ClasCorralesPeriodos();
        public frmCorrales_periodos()
        {
            InitializeComponent();
        }


        private void frmCorrales_periodos_Load(object sender, EventArgs e)
        {
            op.BuscarCorral(txtBuscarCorral.Text, dgvCorrales);
            op.BuscarPeriodo(txtBuscarPeriodos.Text, dgvPeriodos);
        }

        private void txtBuscarCorral_TextChanged(object sender, EventArgs e)
        {
            op.BuscarCorral(txtBuscarCorral.Text, dgvCorrales);
        }

        private void txtBuscarPeriodos_TextChanged(object sender, EventArgs e)
        {
            op.BuscarPeriodo(txtBuscarPeriodos.Text, dgvPeriodos);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtClaveCorral.Text != "" && txtCorral.Text != "" )
            {
                op.id_corral = Convert.ToInt32(txtClaveCorral.Text);
                op.corral = Convert.ToString(txtCorral.Text);
                op.GuardarCorrales();
                op.BuscarCorral(txtBuscarCorral.Text, dgvCorrales);
                op.limpiar( txtClaveCorral, txtCorral, txtClavePeriodo);
                MessageBox.Show("Guardado");
            }else
                if(txtClaveCorral.Text == "" && txtCorral.Text == "")
            {
                MessageBox.Show("Llenar los campos");
            }
               
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(dgvCorrales.RowCount>1)
            {
                if(MessageBox.Show("Estas seguro de eliminar el corral", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string clave = dgvCorrales[0, dgvCorrales.CurrentCellAddress.Y].Value.ToString();
                    op.EliminarCorrales(clave);
                    op.BuscarCorral(txtBuscarCorral.Text, dgvCorrales);
                    MessageBox.Show("Elimado");
                }
            }
            else
                MessageBox.Show("Selecionar fila");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(dgvCorrales.RowCount>1)
            {
                txtClaveCorral.Text = dgvCorrales[0, dgvCorrales.CurrentCellAddress.Y].Value.ToString();
                txtClaveCorral.Tag = dgvCorrales[0, dgvCorrales.CurrentCellAddress.Y].Value.ToString();
                txtCorral.Text = dgvCorrales[1, dgvCorrales.CurrentCellAddress.Y].Value.ToString();
                txtClaveCorral.Enabled = false;
                btnGuardarCambios.Visible = true;
                btnGuardar.Visible = false;
            }
            else
                MessageBox.Show("Seleccione Un Valor", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if(txtClaveCorral.Text!="")
            {
                op.EditarCorrales(Convert.ToString(txtClaveCorral.Text), Convert.ToString(txtCorral.Text), Convert.ToString(txtClaveCorral.Tag));
                op.BuscarCorral(txtBuscarCorral.Text, dgvCorrales);
                MessageBox.Show("Actualizado");
                op.limpiar(txtClaveCorral, txtCorral, txtClavePeriodo);
                txtClaveCorral.Enabled = true;
                btnGuardarCambios.Visible = false;
                btnGuardar.Visible = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            op.limpiar(txtClaveCorral, txtCorral, txtClavePeriodo);
            txtClaveCorral.Enabled = true;
            btnGuardarCambios.Visible = false;
            btnGuardar.Visible = true;
        }









        //==================================PERIODOS==================================================================================


        private void btnGuardarP_Click(object sender, EventArgs e)
        {
            if(txtClavePeriodo.Text != "" && dtpPeriodo.Text != "")
            {
                op.id_periodo = Convert.ToInt32(txtClavePeriodo.Text);
                op.periodo = dtpPeriodo.Value.ToString("yyyy-MM-dd");
                op.Guardarp();
                op.BuscarPeriodo(txtBuscarPeriodos.Text, dgvPeriodos);
                op.limpiar(txtClaveCorral, txtCorral, txtClavePeriodo);
                MessageBox.Show("Guardado");
            }else
                if (txtClavePeriodo.Text == "")
                {
                    MessageBox.Show("Llenar los campos");
                }
        }

        private void btnElimnarP_Click(object sender, EventArgs e)
        {
            if (dgvPeriodos.RowCount > 1)
            {
                if (MessageBox.Show("Estas seguro de eliminar el periodo", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string clave = dgvPeriodos[0, dgvPeriodos.CurrentCellAddress.Y].Value.ToString();
                    op.Eliminarp(clave);
                    op.BuscarPeriodo(txtBuscarPeriodos.Text, dgvPeriodos);
                    MessageBox.Show("Elimado");
                }
            }
            else
                MessageBox.Show("Selecionar fila");
        }

        private void btnEditarP_Click(object sender, EventArgs e)
        {
            if (dgvPeriodos.RowCount > 1)
            {
                txtClavePeriodo.Text = dgvPeriodos[0, dgvPeriodos.CurrentCellAddress.Y].Value.ToString();
                txtClavePeriodo.Tag = dgvPeriodos[0, dgvPeriodos.CurrentCellAddress.Y].Value.ToString();
                dtpPeriodo.Text = dgvPeriodos[1, dgvPeriodos.CurrentCellAddress.Y].Value.ToString();
                txtClavePeriodo.Enabled = false;
                btnGuardarCP.Visible = true;
                btnGuardarP.Visible = false;
            }
            else
                MessageBox.Show("Seleccione Un Valor", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnGuardarCP_Click(object sender, EventArgs e)
        {
            if (txtClavePeriodo.Text != "")
            {
                op.EditarPeriodos(Convert.ToString(txtClavePeriodo.Text), dtpPeriodo.Value.ToString("yyyy-MM-dd"), Convert.ToString(txtClavePeriodo.Tag));
                op.BuscarPeriodo(txtBuscarPeriodos.Text, dgvPeriodos);
                MessageBox.Show("Actualizado");
                op.limpiar(txtClaveCorral, txtCorral, txtClavePeriodo);
                txtClavePeriodo.Enabled = true;
                btnGuardarCP.Visible = false;
                btnGuardarP.Visible = true;
            }
        }

        private void btnCancelarP_Click(object sender, EventArgs e)
        {
            op.limpiar(txtClaveCorral, txtCorral, txtClavePeriodo);
            txtClavePeriodo.Enabled = true;
            btnGuardarCP.Visible = false;
            btnGuardarP.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
