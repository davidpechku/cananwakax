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
    public partial class frmCompras : Form
         
    {
        clasCompra comp = new clasCompra();
        public frmCompras()
        {
            InitializeComponent();
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrarCompra_Click(object sender, EventArgs e)
        {
            FrmNuevaCompra frmNuevaCompra = new FrmNuevaCompra();
            //frmNuevaCompra.btnGuardarCompra.Visible = true;
            //frmNuevaCompra.btnActualizarCompra.Visible = false;
            frmNuevaCompra.ShowDialog();
            //comp.BuscarCompra(dgvCompras);
        }

        private void btnActualizarCompra_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarCompra_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmNuevaCompra frm = new FrmNuevaCompra();
            frm.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
