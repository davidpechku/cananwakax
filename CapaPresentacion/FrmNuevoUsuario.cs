using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoADatos;
using Sistema_Ganadero.Clases;

namespace Sistema_Ganadero.CapaPresentacion
{
    public partial class FrmNuevoUsuario : Form
    {
        clasEmpleado em = new clasEmpleado();
        public FrmNuevoUsuario()
        {
            InitializeComponent();

       
        }
        private void btnCerrarForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas cancelar?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        //private void btnGuardarUsuario_Click(object sender, EventArgs e)
        //{

        //    FrmUsuarios frm = new FrmUsuarios();
        //    if (txtNombresEmpleado.Text == "" & txtApellidosEmpleado.Text == "" & txtDireccionEmpleado.Text == "" & txtTelefonoEmpleado.Text == "" & txtContraseniaEmpleado.Text == "" & txtNombreUsuario.Text == "")
        //    {
        //        MessageBox.Show("Es necesario llenar todos los campos");
        //    }
        //    else
        //    {
        //        txtNombresEmpleado.Focus();
        //        em.nombresEmpleado = txtNombresEmpleado.Text;
        //        em.apellidosEmpleado = txtApellidosEmpleado.Text;
        //        em.nombreUsuario = txtNombreUsuario.Text;
        //        em.direccionEmpleado = txtDireccionEmpleado.Text;
        //        em.telefonoEmpleado = txtTelefonoEmpleado.Text;
        //        em.contraseniaEmpleado = txtContraseniaEmpleado.Text;
        //        em.idRol = cmbRolEmpleado.SelectedValue.ToString();
        //        em.AgregarEmpleado();
        //        em.BuscarEmpleado(txtIdEmpleado.Text, frm.dgvEmpleados);
        //        MessageBox.Show("Se agrego un nuevo empleado");
        //        this.Close();
        //    }
        //}
        private void frmNuevoUsuario_Load(object sender, EventArgs e)
        {
            //string sql = "SELECT * FROM roles";
            //cmbRolEmpleado.DataSource = FrameBD.SQLCOMBO(sql);
            //cmbRolEmpleado.DisplayMember = "rol";
            //cmbRolEmpleado.ValueMember = "idRol";
        }
        //private void btnActualizar_Click(object sender, EventArgs e)
        //{
        //    FrmUsuarios frm = new FrmUsuarios();
        //    em.EditarEmpleado(Convert.ToInt32(txtIdEmpleado.Text), txtNombresEmpleado.Text, txtApellidosEmpleado.Text, txtNombreUsuario.Text, txtTelefonoEmpleado.Text, txtDireccionEmpleado.Text, txtContraseniaEmpleado.Text, Convert.ToInt32(cmbRolEmpleado.SelectedValue.ToString()));
        //    em.BuscarEmpleado(txtIdEmpleado.Text, frm.dgvEmpleados);
        //    MessageBox.Show("Se actualizo correctamente");
        //    this.Close();
        //}

        private void cmbRolEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            em.GetRoles(cmbRolEmpleado);

        }

        private void FrmNuevoUsuario_Load_1(object sender, EventArgs e)
        {
            em.GetRoles(cmbRolEmpleado);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            FrmUsuarios frm = new FrmUsuarios();
            em.EditarEmpleado(Convert.ToInt32(txtIdEmpleado.Text), txtNombresEmpleado.Text, txtApellidosEmpleado.Text, txtNombreUsuario.Text, txtTelefonoEmpleado.Text, txtDireccionEmpleado.Text, txtContraseniaEmpleado.Text, Convert.ToInt32(cmbRolEmpleado.SelectedValue.ToString()));
            em.BuscarEmpleado(txtIdEmpleado.Text, frm.dgvEmpleados);
            MessageBox.Show("Se actualizo correctamente");
            this.Close();
        }

        private void btnGuardarUsuario_Click_1(object sender, EventArgs e)
        {

            FrmUsuarios frm = new FrmUsuarios();
            if (txtNombresEmpleado.Text == "" & txtApellidosEmpleado.Text == "" & txtDireccionEmpleado.Text == "" & txtTelefonoEmpleado.Text == "" & txtContraseniaEmpleado.Text == "" & txtNombreUsuario.Text == "")
            {
                MessageBox.Show("Es necesario llenar todos los campos");
            }
            else
            {
                txtNombresEmpleado.Focus();
                em.nombresEmpleado = txtNombresEmpleado.Text;
                em.apellidosEmpleado = txtApellidosEmpleado.Text;
                em.nombreUsuario = txtNombreUsuario.Text;
                em.direccionEmpleado = txtDireccionEmpleado.Text;
                em.telefonoEmpleado = txtTelefonoEmpleado.Text;
                em.contraseniaEmpleado = txtContraseniaEmpleado.Text;
                em.idRol = cmbRolEmpleado.SelectedValue.ToString();
                em.AgregarEmpleado();
                em.BuscarEmpleado(txtIdEmpleado.Text, frm.dgvEmpleados);
                MessageBox.Show("Se agrego un nuevo empleado");
                this.Close();
            }
        }
    }
}
