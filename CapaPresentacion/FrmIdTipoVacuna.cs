using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoADatos; // Permite acceder a el FrameBD

using Sistema_Ganadero.Clases; // Permite acceder a la carpeta de controladores
// para realizar este paso se( necesita el nombre del proyeto + . + nombre de la carpeta)


namespace modulodeaplicaciones
{
    public partial class frmIdTipoVacuna : Form
    {
        clasIdTipoVacuna1 ovacuna = new clasIdTipoVacuna1();

        // Primero se realiza un objeto que sera necesario para poder acceder a los
        //metodos de fremeBD,l

       


        

        public frmIdTipoVacuna()
        {
            InitializeComponent();
        }

        private void frmIdTipoVacuna_Load(object sender, EventArgs e)
        {
            ovacuna.BuscarCategorias(txtBuscar.Text, dgvTipoVacuna);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            ovacuna.BuscarCategorias(txtBuscar.Text, dgvTipoVacuna);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {


            if (txtTipo.Text == "")
            {
                MessageBox.Show("¡Escribir el nombre de la vacuna!");
            }

            else 
            {
                ovacuna.tipo_vacuna = txtTipo.Text;
                //oGenero.store();//guardamos los dat       os capturados
                ovacuna.store();//guardar sp

                ovacuna.BuscarCategorias(txtBuscar.Text, dgvTipoVacuna);//actuzalizanofo el datagrid
                txtIdTipo.Clear();
                txtTipo.Clear();
                txtBuscar.Focus();
            }




           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de eliminar", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                string clave = dgvTipoVacuna[0, dgvTipoVacuna.CurrentCellAddress.Y].Value.ToString();
                ovacuna.Eliminar(clave);
                ovacuna.BuscarCategorias(txtBuscar.Text, dgvTipoVacuna);
            }


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

           
            
                txtIdTipo.Text = dgvTipoVacuna[0, dgvTipoVacuna.CurrentCellAddress.Y].Value.ToString();
                txtTipo.Text = dgvTipoVacuna[1, dgvTipoVacuna.CurrentCellAddress.Y].Value.ToString();

                txtTipo.Focus();
                btnActualizar.Visible = true;
                btnGuardar.Visible = false;
            

           
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            if (txtTipo.Text == "")
            {
                MessageBox.Show("¡Escribir el nombre de la vacuna!");
            }
            else{

                ovacuna.update(txtIdTipo.Text, txtTipo.Text);
                ovacuna.BuscarCategorias(txtBuscar.Text, dgvTipoVacuna);
                txtIdTipo.Clear();
                txtTipo.Clear();
                btnActualizar.Visible = false;
                btnGuardar.Visible = true;
            }
           
        }




        
        private void txtTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
         

        }
    }
}
