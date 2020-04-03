using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Ganadero.CapaPresentacion
{
    public partial class FrmPrincipal : Form
   
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (menu.Width == 190)
            {
                menu.Width = 65;
            }
            else
            {
                menu.Width = 190;
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas cerrar sesión?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FrmLoginn l = new FrmLoginn();
                this.Hide();
                l.ShowDialog();
                this.Close();
            }
        }
        private void CambiarColorBoton(object sender, FormClosedEventArgs e)
        {
            //if (Application.OpenForms["frmUsuarios"] == null)
            //    btnUsuarios.BackColor = Color.FromArgb(26, 32, 40);
            //if (Application.OpenForms["frmAnimales"] == null)
            //    btnUsuarios.BackColor = Color.FromArgb(26, 32, 40);
            //if (Application.OpenForms["frmAplicaciones"] == null)
            //    btnUsuarios.BackColor = Color.FromArgb(26, 32, 40);
            //if (Application.OpenForms["frmVentas"] == null)
            //    btnUsuarios.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void ContenedorForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
                AbrirUsuario<FrmUsuarios>();
                //btnUsuarios.BackColor = Color.FromArgb(0, 80, 200);
                btnAnimal.Visible = false;
                btnNacimiento.Visible = false;
                btnCorral.Visible = false;
                btnVacuna.Visible = false;
                btnApkAnimal.Visible = false;
                btnApkCria.Visible = false;
                BtnCliente.Visible = false;
                btnProveedor.Visible = false;
                btnCompra.Visible = false;
                btnVenta.Visible = false;
                ContenedorForm.Visible = true;
        }
                public void AbrirUsuario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = ContenedorForm.Controls.OfType<MiForm>().FirstOrDefault();//BUSCA EN LA COLECCION EL FORMULARIO
            //SI EL FORMULARIO NO EXISTE
            if(formulario==null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                ContenedorForm.Controls.Add(formulario);
                ContenedorForm.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CambiarColorBoton);
            }
            //SI EL FORMULARIO EXISTE
            else
            {
                formulario.BringToFront();
            }
        }

        //private void button4_Click(object sender, EventArgs e)
        //{
        //    AbrirCompras<frmCompras>();
        //    //btnUsuarios.BackColor = Color.FromArgb(0, 80, 200);
        //}
        //public void AbrirCompras<MiForm>() where MiForm : Form, new()
        //{
        //    Form formulario;
        //    formulario = ContenedorForm.Controls.OfType<MiForm>().FirstOrDefault();//BUSCA EN LA COLECCION EL FORMULARIO
        //    //SI EL FORMULARIO NO EXISTE
        //    if (formulario == null)
        //    {
        //        formulario = new MiForm();
        //        formulario.TopLevel = false;
        //        formulario.FormBorderStyle = FormBorderStyle.None;
        //        formulario.Dock = DockStyle.Fill;
        //        ContenedorForm.Controls.Add(formulario);
        //        ContenedorForm.Tag = formulario;
        //        formulario.Show();
        //        formulario.BringToFront();
        //        formulario.FormClosed += new FormClosedEventHandler(CambiarColorBoton);
        //    }
        //    //SI EL FORMULARIO EXISTE
        //    else
        //    {
        //        formulario.BringToFront();
        //    }
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    AbrirProveedores<frmProveedores>();
        //    //btnUsuarios.BackColor = Color.FromArgb(0, 80, 200);
        //}
        //public void AbrirProveedores<MiForm>() where MiForm : Form, new()
        //{
        //    Form formulario;
        //    formulario = ContenedorForm.Controls.OfType<MiForm>().FirstOrDefault();//BUSCA EN LA COLECCION EL FORMULARIO
        //    //SI EL FORMULARIO NO EXISTE
        //    if (formulario == null)
        //    {
        //        formulario = new MiForm();
        //        formulario.TopLevel = false;
        //        formulario.FormBorderStyle = FormBorderStyle.None;
        //        formulario.Dock = DockStyle.Fill;
        //        ContenedorForm.Controls.Add(formulario);
        //        ContenedorForm.Tag = formulario;
        //        formulario.Show();
        //        formulario.BringToFront();
        //        formulario.FormClosed += new FormClosedEventHandler(CambiarColorBoton);
        //    }
        //    //SI EL FORMULARIO EXISTE
        //    else
        //    {
        //        formulario.BringToFront();
        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
            {
                //AbrirApliaciones<FrmApliaciones>();
                //btnAplicaciones.BackColor = Color.FromArgb(0, 80, 200);
                btnAnimal.Visible = false;
                btnNacimiento.Visible = false;
                btnCorral.Visible = false;
                btnVacuna.Visible = true;
                btnApkAnimal.Visible = true;
                btnApkCria.Visible = true;
                BtnCliente.Visible = false;
                btnProveedor.Visible = false;
                btnCompra.Visible = false;
                btnVenta.Visible = false;
                ContenedorForm.Visible = true;
        }
        public void AbrirApliaciones<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = ContenedorForm.Controls.OfType<MiForm>().FirstOrDefault();//BUSCA EN LA COLECCION EL FORMULARIO
            //SI EL FORMULARIO NO EXISTE
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                ContenedorForm.Controls.Add(formulario);
                ContenedorForm.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CambiarColorBoton);
            }
            //SI EL FORMULARIO EXISTE
            else
            {
                formulario.BringToFront();
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            AbrirVentas<FrmVentas>();
            //btnVentas.BackColor = Color.FromArgb(0, 80, 200);
            btnAnimal.Visible = false;
            btnNacimiento.Visible = false;
            btnCorral.Visible = false;
            btnVacuna.Visible = false;
            btnApkAnimal.Visible = false;
            btnApkCria.Visible = false;
            BtnCliente.Visible = true;
            btnProveedor.Visible = true;
            btnCompra.Visible = true;
            btnVenta.Visible = true;
            ContenedorForm.Visible = true;
        }
        public void AbrirVentas<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = ContenedorForm.Controls.OfType<MiForm>().FirstOrDefault();//BUSCA EN LA COLECCION EL FORMULARIO
            //SI EL FORMULARIO NO EXISTE
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                ContenedorForm.Controls.Add(formulario);
                ContenedorForm.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CambiarColorBoton);
            }
            //SI EL FORMULARIO EXISTE
            else
            {
                formulario.BringToFront();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
                //AbrirAnimales<frmAnimales>();
                //btnAnimales.BackColor = Color.FromArgb(0, 80, 200);
                btnAnimal.Visible = true;
                btnNacimiento.Visible = true;
                btnCorral.Visible = true;
                btnVacuna.Visible = false;
                btnApkAnimal.Visible = false;
                btnApkCria.Visible = false;
                BtnCliente.Visible = false;
                btnProveedor.Visible = false;
                btnCompra.Visible = false;
                btnVenta.Visible = false;
                ContenedorForm.Visible = true;
     
                
        }
        public void AbrirAnimales<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = ContenedorForm.Controls.OfType<MiForm>().FirstOrDefault();//BUSCA EN LA COLECCION EL FORMULARIO
            //SI EL FORMULARIO NO EXISTE
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                ContenedorForm.Controls.Add(formulario);
                ContenedorForm.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CambiarColorBoton);
            }
            //SI EL FORMULARIO EXISTE
            else
            {
                formulario.BringToFront();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas cerrar sesión?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FrmLoginn l = new FrmLoginn();
                this.Hide();
                l.ShowDialog();
                this.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            btnAnimal.Visible = false;
            btnNacimiento.Visible = false;
            btnCorral.Visible = false;
            btnVacuna.Visible = false;
            btnApkAnimal.Visible = false;
            btnApkCria.Visible = false;
            BtnCliente.Visible = false;
            btnProveedor.Visible = false;
            btnCompra.Visible = false;
            btnVenta.Visible = false;
            ContenedorForm.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        //private void button1_Click_1(object sender, EventArgs e)
        //{
        //    AbrirProductos<FrmProducto>();
        //    //btnUsuarios.BackColor = Color.FromArgb(0, 80, 200);
        //}
        //public void AbrirProductos<MiForm>() where MiForm : Form, new()
        //{
        //    Form formulario;
        //    formulario = ContenedorForm.Controls.OfType<MiForm>().FirstOrDefault();//BUSCA EN LA COLECCION EL FORMULARIO
        //    //SI EL FORMULARIO NO EXISTE
        //    if (formulario == null)
        //    {
        //        formulario = new MiForm();
        //        formulario.TopLevel = false;
        //        formulario.FormBorderStyle = FormBorderStyle.None;
        //        formulario.Dock = DockStyle.Fill;
        //        ContenedorForm.Controls.Add(formulario);
        //        ContenedorForm.Tag = formulario;
        //        formulario.Show();
        //        formulario.BringToFront();
        //        formulario.FormClosed += new FormClosedEventHandler(CambiarColorBoton);
        //    }
        //    //SI EL FORMULARIO EXISTE
        //    else
        //    {
        //        formulario.BringToFront();
        //    }
        //}

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ssss");
        }

        private void btnAnimales_Click(object sender, EventArgs e)
        {
            //frmAnimales AbrirAnimales = new frmAnimales();
            //AbrirAnimales.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAnimal_Click(object sender, EventArgs e)
        {
            AbrirAnimal<frmAnimales>();
        }
        public void AbrirAnimal<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = ContenedorForm.Controls.OfType<MiForm>().FirstOrDefault();//BUSCA EN LA COLECCION EL FORMULARIO
            //SI EL FORMULARIO NO EXISTE
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                ContenedorForm.Controls.Add(formulario);
                ContenedorForm.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CambiarColorBoton);
            }
            //SI EL FORMULARIO EXISTE
            else
            {
                formulario.BringToFront();
            }
        }

        private void btnNacimiento_Click(object sender, EventArgs e)
            {
                AbrirNacimiento<frmNacimiento>();
            }
        public void AbrirNacimiento<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = ContenedorForm.Controls.OfType<MiForm>().FirstOrDefault();//BUSCA EN LA COLECCION EL FORMULARIO
            //SI EL FORMULARIO NO EXISTE
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                ContenedorForm.Controls.Add(formulario);
                ContenedorForm.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CambiarColorBoton);
            }
            //SI EL FORMULARIO EXISTE
            else
            {
                formulario.BringToFront();
            }
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCorral_Click(object sender, EventArgs e)
        {
            AbrirCorrales<frmCorrales_periodos>();
        }
        public void AbrirCorrales<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = ContenedorForm.Controls.OfType<MiForm>().FirstOrDefault();//BUSCA EN LA COLECCION EL FORMULARIO
            //SI EL FORMULARIO NO EXISTE
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                ContenedorForm.Controls.Add(formulario);
                ContenedorForm.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CambiarColorBoton);
            }
            //SI EL FORMULARIO EXISTE
            else
            {
                formulario.BringToFront();
            }
        }

        private void btnVacuna_Click(object sender, EventArgs e)
        {
            AbrirVacunas<FrmVacunas>();
        }
        public void AbrirVacunas<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = ContenedorForm.Controls.OfType<MiForm>().FirstOrDefault();//BUSCA EN LA COLECCION EL FORMULARIO
            //SI EL FORMULARIO NO EXISTE
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                ContenedorForm.Controls.Add(formulario);
                ContenedorForm.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CambiarColorBoton);
            }
            //SI EL FORMULARIO EXISTE
            else
            {
                formulario.BringToFront();
            }
        }

        private void btnApkAnimal_Click(object sender, EventArgs e)
        {
            AbrirVacunas1<frmTipoVacuna>();
        }
        public void AbrirVacunas1<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = ContenedorForm.Controls.OfType<MiForm>().FirstOrDefault();//BUSCA EN LA COLECCION EL FORMULARIO
            //SI EL FORMULARIO NO EXISTE
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                ContenedorForm.Controls.Add(formulario);
                ContenedorForm.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CambiarColorBoton);
            }
            //SI EL FORMULARIO EXISTE
            else
            {
                formulario.BringToFront();
            }
        }


        private void btnApkCria_Click(object sender, EventArgs e)
        {
                AbrirApliCria<frmApliCria>();
            }
        public void AbrirApliCria<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = ContenedorForm.Controls.OfType<MiForm>().FirstOrDefault();//BUSCA EN LA COLECCION EL FORMULARIO
            //SI EL FORMULARIO NO EXISTE
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                ContenedorForm.Controls.Add(formulario);
                ContenedorForm.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CambiarColorBoton);
            }
            //SI EL FORMULARIO EXISTE
            else
            {
                formulario.BringToFront();
            }
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            AbrirCliente<FrmClientes>();
        }
        public void AbrirCliente<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = ContenedorForm.Controls.OfType<MiForm>().FirstOrDefault();//BUSCA EN LA COLECCION EL FORMULARIO
            //SI EL FORMULARIO NO EXISTE
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                ContenedorForm.Controls.Add(formulario);
                ContenedorForm.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CambiarColorBoton);
            }
            //SI EL FORMULARIO EXISTE
            else
            {
                formulario.BringToFront();
            }
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            AbrirProveedores<frmProveedores>();
        }
        public void AbrirProveedores<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = ContenedorForm.Controls.OfType<MiForm>().FirstOrDefault();//BUSCA EN LA COLECCION EL FORMULARIO
            //SI EL FORMULARIO NO EXISTE
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                ContenedorForm.Controls.Add(formulario);
                ContenedorForm.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CambiarColorBoton);
            }
            //SI EL FORMULARIO EXISTE
            else
            {
                formulario.BringToFront();
            }
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            AbrirCompras<frmCompras>();
        }
        public void AbrirCompras<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = ContenedorForm.Controls.OfType<MiForm>().FirstOrDefault();//BUSCA EN LA COLECCION EL FORMULARIO
            //SI EL FORMULARIO NO EXISTE
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                ContenedorForm.Controls.Add(formulario);
                ContenedorForm.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CambiarColorBoton);
            }
            //SI EL FORMULARIO EXISTE
            else
            {
                formulario.BringToFront();
            }
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            Abrirventas<FrmVentas>();
        }
        public void Abrirventas<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = ContenedorForm.Controls.OfType<MiForm>().FirstOrDefault();//BUSCA EN LA COLECCION EL FORMULARIO
            //SI EL FORMULARIO NO EXISTE
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                ContenedorForm.Controls.Add(formulario);
                ContenedorForm.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CambiarColorBoton);
            }
            //SI EL FORMULARIO EXISTE
            else
            {
                formulario.BringToFront();
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }
    }
}
