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
    public partial class frmNacimiento : Form
    {
        public frmNacimiento()
        {
            InitializeComponent();
        }
        //Objeto
        clasNacimiento Objnacimiento = new clasNacimiento();

        private void frmNacimiento_Load(object sender, EventArgs e)
        {
            Objnacimiento.BuscarCategorias(txtBuscar.Text, dgvNacimiento); // son este se refencia al datagrid para que muestre los datos dategrid
            Objnacimiento.getnumeros(cmbNumero);// muestra en un combobox a la llave foranea
        }

        // netedo para realizar la fiuncion de busqueda

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            Objnacimiento.BuscarCategorias(txtBuscar.Text, dgvNacimiento);
        }

      
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {

            if (txtNumeroCrias.Text == "" && dtpFechaNacimiento.Text == "")
            {
                MessageBox.Show("¡Llene los campos los campos correspondientes!");
            }

            else if (txtNumeroCrias.Text == "")
            {
                MessageBox.Show("¡Escriba la cantidad correcta!");
            }
            else
            {
                Objnacimiento.numero = Convert.ToInt32(cmbNumero.SelectedValue.ToString());
                Objnacimiento.numero_crias = Convert.ToInt32(txtNumeroCrias.Text.ToString());
                Objnacimiento.fecha_nacimiento = dtpFechaNacimiento.Value.ToString("yyyy/MM/dd");


                Objnacimiento.guardar();
                Objnacimiento.BuscarCategorias(txtBuscar.Text, dgvNacimiento);

                txtBuscar.Focus();


         



        }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de eliminar", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                string clave = dgvNacimiento[0, dgvNacimiento.CurrentCellAddress.Y].Value.ToString();
                Objnacimiento.Eliminar(clave);
                Objnacimiento.BuscarCategorias(txtBuscar.Text, dgvNacimiento);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtIdNacimiento.Text = dgvNacimiento[0, dgvNacimiento.CurrentCellAddress.Y].Value.ToString();
            cmbNumero.Text = dgvNacimiento[1, dgvNacimiento.CurrentCellAddress.Y].Value.ToString();       
            dtpFechaNacimiento.Text = dgvNacimiento[2, dgvNacimiento.CurrentCellAddress.Y].Value.ToString();
            txtNumeroCrias.Text = dgvNacimiento[3, dgvNacimiento.CurrentCellAddress.Y].Value.ToString();



            btnActualizar.Visible = true;
            btnGuardar.Visible = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtNumeroCrias.Text == "")
            {
                MessageBox.Show("Llene los datos correspondientes");
            }

            else
            {
                Objnacimiento.update(txtIdNacimiento.Text, Convert.ToInt32(cmbNumero.SelectedValue.ToString()), Convert.ToInt32(txtNumeroCrias.Text), dtpFechaNacimiento.Value.ToString("yyyy/MM/dd"));
                Objnacimiento.BuscarCategorias(txtBuscar.Text, dgvNacimiento);
                txtNumeroCrias.Clear();
                txtIdNacimiento.Clear();

                btnActualizar.Visible = false;
                btnGuardar.Visible = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
