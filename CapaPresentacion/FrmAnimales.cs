using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoADatos; // Para tener acceso al archivo frameDB
using Sistema_Ganadero.Clases;


namespace Sistema_Ganadero.CapaPresentacion
{
    public partial class frmAnimales : Form
    {
        // ser crea un objeto para reniobrarlo
        ClaseAnimal anima = new ClaseAnimal();
        public frmAnimales()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

 

        private void Form1_Load(object sender, EventArgs e)
        {
            anima.BuscarCate(txtBuscar.Text, dgvMostrar);
            anima.getcategorias(cmbIduso);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtEstatus.Text == "" && txtGenero.Text == "" && txtDisponi.Text == "" && txtAlias.Text == "")
            {
                MessageBox.Show("¡Lllene los campos!");
            }
            //&& cmbIduso.SelectedValue.ToString() == ""

            else
            {
                anima.numero = Convert.ToInt32(txtNumero.Text);
                anima.id_uso = Convert.ToString(cmbIduso.SelectedValue.ToString());
                anima.estatus = Convert.ToString(txtEstatus.Text);
                anima.genero = Convert.ToString(txtGenero.Text);
                anima.disponibilidad = Convert.ToString(txtDisponi.Text);
                anima.alias = Convert.ToString(txtAlias.Text);

                anima.store();// hace refencia al metodo de guardar 
                anima.BuscarCate(txtBuscar.Text, dgvMostrar);//actuzalizanofo el datagrid

                txtNumero.Clear();
                txtEstatus.Clear();
                txtGenero.Clear();
                txtDisponi.Clear();
                txtAlias.Clear();


                txtBuscar.Focus();
            }
        }

        private void dgvMostrar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //este sive para guardar
            txtNumero.Text = dgvMostrar[0, dgvMostrar.CurrentCellAddress.Y].Value.ToString();
            txtEstatus.Text=dgvMostrar[2, dgvMostrar.CurrentCellAddress.Y].Value.ToString();
            txtGenero.Text=dgvMostrar[3, dgvMostrar.CurrentCellAddress.Y].Value.ToString();
            txtDisponi.Text=dgvMostrar[4, dgvMostrar.CurrentCellAddress.Y].Value.ToString();
            txtAlias.Text=dgvMostrar[0, dgvMostrar.CurrentCellAddress.Y].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            //sierra las ventana
        }

        private void btnNuevoUso_Click(object sender, EventArgs e)
        {
            // se llama otra vista y se cra un objeto AbrirUso y se hace referencia abajo.
           // Uso AbrirUso = new Uso();
           //AbrirUso.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
