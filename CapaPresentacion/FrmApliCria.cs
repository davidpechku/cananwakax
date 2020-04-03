using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 // se utiliza para poder accerder a las herramientas
using Sistema_Ganadero.Clases;// se necesita para poder acceder a las carpetas de clases 

namespace Sistema_Ganadero.CapaPresentacion
{
    public partial class frmApliCria : Form
    {

        clasApliCria oapli = new clasApliCria();
        public frmApliCria()
        {
            InitializeComponent();
        }

        private void frmApliCria_Load(object sender, EventArgs e)
        {
            oapli.BuscarCategorias(txtBuscar.Text, dgvApliCria);
            oapli.getCria(cmbIdCria);
            oapli.getVacuna(cmbIdVacuna);
            oapli.getEmple(cmbEmpleado);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            oapli.BuscarCategorias(txtBuscar.Text, dgvApliCria);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbIdCria.SelectedValue.ToString() == "" && cmbIdVacuna.SelectedValue.ToString() == "" && cmbEmpleado.SelectedValue.ToString() == "" && dtpProxima.Text == "" && dtpHora.Text == "")
            {
                MessageBox.Show("¡Lllene los campos!");
            }
          
            else
            {

            
                oapli.id_cria = Convert.ToInt32(cmbIdCria.SelectedValue.ToString());// datetimepiker
                oapli.id_vacuna = Convert.ToInt32(cmbIdVacuna.SelectedValue.ToString());
                oapli.fecha_aplicacion = dtpProxima.Value.ToString("yyyy/MM/dd");
                oapli.proxima_fecha = dtpProxima.Value.ToString("yyyy/MM/dd");
                oapli.hora_aplicacion = dtpHora.Value.ToString("hh:mm:ss");
                oapli.id_empleado= Convert.ToInt32(cmbEmpleado.SelectedValue.ToString());


            //    oapli.store();// hace refencia al metodo de guardar 
                oapli.transaccion();

                oapli.BuscarCategorias(txtBuscar.Text, dgvApliCria);//actuzalizanofo el datagrid
                


                txtBuscar.Focus();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de eliminar", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                string clave = dgvApliCria[0, dgvApliCria.CurrentCellAddress.Y].Value.ToString();
                oapli.Eliminar(clave);
                oapli.BuscarCategorias(txtBuscar.Text, dgvApliCria);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtIdApliCria.Text = dgvApliCria[0, dgvApliCria.CurrentCellAddress.Y].Value.ToString();
            cmbIdCria.Text = dgvApliCria[1, dgvApliCria.CurrentCellAddress.Y].Value.ToString();
            cmbIdVacuna.Text = dgvApliCria[2, dgvApliCria.CurrentCellAddress.Y].Value.ToString();
            dtpFecha.Text = dgvApliCria[3, dgvApliCria.CurrentCellAddress.Y].Value.ToString();
            dtpHora.Text = dgvApliCria[4, dgvApliCria.CurrentCellAddress.Y].Value.ToString();
            dtpProxima.Text = dgvApliCria[5, dgvApliCria.CurrentCellAddress.Y].Value.ToString();
            cmbEmpleado.Text= dgvApliCria[6, dgvApliCria.CurrentCellAddress.Y].Value.ToString();

            btnActualizar.Visible = true;
            btnGuardar.Visible = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)



        {


            if (cmbIdCria.SelectedValue.ToString() == "" && cmbIdVacuna.SelectedValue.ToString() == "" && cmbEmpleado.SelectedValue.ToString() == "" && dtpProxima.Text == "" && dtpHora.Text == "")
            {
                MessageBox.Show("¡Lllene los campos!");
            }

            else
            {
                oapli.update(txtIdApliCria.Text, Convert.ToInt32(cmbIdCria.SelectedValue.ToString()), Convert.ToInt32(cmbIdVacuna.SelectedValue.ToString()),
              dtpFecha.Value.ToString("yyyy/MM/dd"), dtpHora.Value.ToString("hh:mm:ss"), dtpProxima.Value.ToString("yyyy/MM/dd"), Convert.ToInt32(cmbEmpleado.SelectedValue.ToString()));
                oapli.BuscarCategorias(txtBuscar.Text, dgvApliCria);

                txtIdApliCria.Clear();
                btnActualizar.Visible = false;
                btnGuardar.Visible = true;

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
  