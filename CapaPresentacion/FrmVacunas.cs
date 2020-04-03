using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // se utiliza para poder accerder a las herramientas
using Sistema_Ganadero.Clases;// se necesita para poder acceder a las carpetas de clases 

namespace Sistema_Ganadero.CapaPresentacion
{
    public partial class FrmVacunas : Form
    {
        public FrmVacunas()
        {
            InitializeComponent();
        }

        // objeto de clase
        clasVacunas otipo = new clasVacunas();


        
        //  sirce para mostrar datos en datagrid
        private void frmVacunas_Load(object sender, EventArgs e)
        {
            
            otipo.BuscarCategorias(txtBuscar.Text, dgvVacunas);// son este se refencia al datagrid para que muestre los datos dategrid
            otipo.getcategorias(cmbClave);// muestra en un combobox a la llave foranea
        }

        // netedo para realizar la fiuncion de busqueda
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            otipo.BuscarCategorias(txtBuscar.Text, dgvVacunas);
        }

        //  hace referencia al boton de guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {

           



        }
        
        // hace refencia al boton de modificar
        
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (txtVacuna.Text ==  "" && cmbClave.SelectedValue.ToString() == "")
            {
                MessageBox.Show("¡Lllene los campos!");
            }
            else if (txtVacuna.Text == "")
            {
                MessageBox.Show("¡Escriba el nombre de la Vacuna!");
            }

            else
            {

                otipo.vacuna = txtVacuna.Text; // texbox
             
                otipo.id_tipo_vacuna = Convert.ToInt32(cmbClave.SelectedValue.ToString());


                otipo.store();// hace refencia al metodo de guardar 

                otipo.BuscarCategorias(txtBuscar.Text, dgvVacunas);//actuzalizanofo el datagrid
                txtVacuna.Clear();

                txtBuscar.Focus();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            if (txtVacuna.Text == "")
            {
                MessageBox.Show("¡Escriba el nombre de la Vacuna!");        
            }

            else
            {
                otipo.update(txtIdVacuna.Text, txtVacuna.Text,Convert.ToInt32(cmbClave.SelectedValue.ToString()));
                otipo.BuscarCategorias(txtBuscar.Text, dgvVacunas);
                txtVacuna.Clear();
                txtIdVacuna.Clear();

                btnActualizar.Visible = false;
                btnGuardar.Visible = true;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtIdVacuna.Text = dgvVacunas[0, dgvVacunas.CurrentCellAddress.Y].Value.ToString();
            txtVacuna.Text = dgvVacunas[2, dgvVacunas.CurrentCellAddress.Y].Value.ToString();
            cmbClave.Text = dgvVacunas[1, dgvVacunas.CurrentCellAddress.Y].Value.ToString();
           
          


                txtVacuna.Focus();
                btnActualizar.Visible = true;
                btnGuardar.Visible = false;
            

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de eliminar", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                string clave = dgvVacunas[0, dgvVacunas.CurrentCellAddress.Y].Value.ToString();
                otipo.Eliminar(clave);
                otipo.BuscarCategorias(txtBuscar.Text, dgvVacunas);
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
