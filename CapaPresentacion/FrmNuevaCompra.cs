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
    public partial class FrmNuevaCompra : Form
    {
        clasCompra comp = new clasCompra();
        clasEmpleado emp = new clasEmpleado();
        private TextBox txtIdEmpresa;
        private TextBox txtIdEmpleado;
        private TextBox txtIdCompra;
        private NumericUpDown nudCantidadCompra;
        private TextBox txtEmpresaCompra;
        private Label lblEmpresa;
        public Button btnCancelarCompra;
        public Button btnActualizarCompra;
        public Button btnGuardarCompra;
        private TextBox txtEmpleado;
        private Label lblCantidad;
        private TextBox txtTotalCompra;
        private Label lblTotalCompra;
        private Label lblEmpleado;
        private Label lblTituloCompras;
        private GroupBox DATOS;
        private TextBox txtDisponi;
        private TextBox txtAlias;
        private PictureBox pictureBox1;
        clasProveedor pro = new clasProveedor();

        public FrmNuevaCompra()
        {
            InitializeComponent();
        }

        private void FrmNuevaCompra_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGuardarCompra_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuevaCompra));
            this.txtIdEmpresa = new System.Windows.Forms.TextBox();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.txtIdCompra = new System.Windows.Forms.TextBox();
            this.nudCantidadCompra = new System.Windows.Forms.NumericUpDown();
            this.txtEmpresaCompra = new System.Windows.Forms.TextBox();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.btnCancelarCompra = new System.Windows.Forms.Button();
            this.btnActualizarCompra = new System.Windows.Forms.Button();
            this.btnGuardarCompra = new System.Windows.Forms.Button();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtTotalCompra = new System.Windows.Forms.TextBox();
            this.lblTotalCompra = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblTituloCompras = new System.Windows.Forms.Label();
            this.DATOS = new System.Windows.Forms.GroupBox();
            this.txtDisponi = new System.Windows.Forms.TextBox();
            this.txtAlias = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadCompra)).BeginInit();
            this.DATOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdEmpresa
            // 
            this.txtIdEmpresa.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdEmpresa.Location = new System.Drawing.Point(369, 61);
            this.txtIdEmpresa.Name = "txtIdEmpresa";
            this.txtIdEmpresa.Size = new System.Drawing.Size(19, 26);
            this.txtIdEmpresa.TabIndex = 32;
            this.txtIdEmpresa.Visible = false;
            this.txtIdEmpresa.TextChanged += new System.EventHandler(this.txtIdEmpresa_TextChanged);
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdEmpleado.Location = new System.Drawing.Point(328, 61);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(24, 26);
            this.txtIdEmpleado.TabIndex = 31;
            this.txtIdEmpleado.Visible = false;
            this.txtIdEmpleado.TextChanged += new System.EventHandler(this.txtIdEmpleado_TextChanged);
            // 
            // txtIdCompra
            // 
            this.txtIdCompra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCompra.Location = new System.Drawing.Point(19, 61);
            this.txtIdCompra.Name = "txtIdCompra";
            this.txtIdCompra.Size = new System.Drawing.Size(27, 26);
            this.txtIdCompra.TabIndex = 30;
            this.txtIdCompra.Visible = false;
            this.txtIdCompra.TextChanged += new System.EventHandler(this.txtIdCompra_TextChanged);
            // 
            // nudCantidadCompra
            // 
            this.nudCantidadCompra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidadCompra.Location = new System.Drawing.Point(312, 219);
            this.nudCantidadCompra.Name = "nudCantidadCompra";
            this.nudCantidadCompra.Size = new System.Drawing.Size(70, 26);
            this.nudCantidadCompra.TabIndex = 29;
            this.nudCantidadCompra.ValueChanged += new System.EventHandler(this.nudCantidadCompra_ValueChanged);
            // 
            // txtEmpresaCompra
            // 
            this.txtEmpresaCompra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpresaCompra.Location = new System.Drawing.Point(109, 171);
            this.txtEmpresaCompra.Name = "txtEmpresaCompra";
            this.txtEmpresaCompra.Size = new System.Drawing.Size(273, 26);
            this.txtEmpresaCompra.TabIndex = 28;
            this.txtEmpresaCompra.TextChanged += new System.EventHandler(this.txtEmpresaCompra_TextChanged);
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.Location = new System.Drawing.Point(16, 174);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(79, 18);
            this.lblEmpresa.TabIndex = 27;
            this.lblEmpresa.Text = "Empresa";
            this.lblEmpresa.Click += new System.EventHandler(this.lblEmpresa_Click);
            // 
            // btnCancelarCompra
            // 
            this.btnCancelarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCompra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCompra.ForeColor = System.Drawing.Color.White;
            this.btnCancelarCompra.Location = new System.Drawing.Point(283, 284);
            this.btnCancelarCompra.Name = "btnCancelarCompra";
            this.btnCancelarCompra.Size = new System.Drawing.Size(115, 45);
            this.btnCancelarCompra.TabIndex = 26;
            this.btnCancelarCompra.Text = "CANCELAR";
            this.btnCancelarCompra.UseVisualStyleBackColor = false;
            // 
            // btnActualizarCompra
            // 
            this.btnActualizarCompra.BackColor = System.Drawing.Color.DarkOrange;
            this.btnActualizarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarCompra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarCompra.ForeColor = System.Drawing.Color.White;
            this.btnActualizarCompra.Location = new System.Drawing.Point(150, 284);
            this.btnActualizarCompra.Name = "btnActualizarCompra";
            this.btnActualizarCompra.Size = new System.Drawing.Size(110, 45);
            this.btnActualizarCompra.TabIndex = 25;
            this.btnActualizarCompra.Text = "EDITAR";
            this.btnActualizarCompra.UseVisualStyleBackColor = false;
            this.btnActualizarCompra.Click += new System.EventHandler(this.btnActualizarCompra_Click);
            // 
            // btnGuardarCompra
            // 
            this.btnGuardarCompra.BackColor = System.Drawing.Color.Teal;
            this.btnGuardarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCompra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCompra.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCompra.Location = new System.Drawing.Point(16, 284);
            this.btnGuardarCompra.Name = "btnGuardarCompra";
            this.btnGuardarCompra.Size = new System.Drawing.Size(110, 45);
            this.btnGuardarCompra.TabIndex = 24;
            this.btnGuardarCompra.Text = "GUARDAR";
            this.btnGuardarCompra.UseVisualStyleBackColor = false;
            this.btnGuardarCompra.Click += new System.EventHandler(this.btnGuardarCompra_Click_1);
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpleado.Location = new System.Drawing.Point(109, 118);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(273, 26);
            this.txtEmpleado.TabIndex = 23;
            this.txtEmpleado.TextChanged += new System.EventHandler(this.txtEmpleado_TextChanged);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(221, 221);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(80, 18);
            this.lblCantidad.TabIndex = 22;
            this.lblCantidad.Text = "Cantidad";
            this.lblCantidad.Click += new System.EventHandler(this.lblCantidad_Click);
            // 
            // txtTotalCompra
            // 
            this.txtTotalCompra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCompra.Location = new System.Drawing.Point(126, 217);
            this.txtTotalCompra.Name = "txtTotalCompra";
            this.txtTotalCompra.Size = new System.Drawing.Size(86, 26);
            this.txtTotalCompra.TabIndex = 21;
            this.txtTotalCompra.TextChanged += new System.EventHandler(this.txtTotalCompra_TextChanged);
            // 
            // lblTotalCompra
            // 
            this.lblTotalCompra.AutoSize = true;
            this.lblTotalCompra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCompra.Location = new System.Drawing.Point(12, 221);
            this.lblTotalCompra.Name = "lblTotalCompra";
            this.lblTotalCompra.Size = new System.Drawing.Size(111, 18);
            this.lblTotalCompra.TabIndex = 20;
            this.lblTotalCompra.Text = "TotalCompra";
            this.lblTotalCompra.Click += new System.EventHandler(this.lblTotalCompra_Click);
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(16, 121);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(87, 18);
            this.lblEmpleado.TabIndex = 19;
            this.lblEmpleado.Text = "Empleado";
            this.lblEmpleado.Click += new System.EventHandler(this.lblEmpleado_Click);
            // 
            // lblTituloCompras
            // 
            this.lblTituloCompras.AutoSize = true;
            this.lblTituloCompras.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloCompras.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCompras.Location = new System.Drawing.Point(105, 42);
            this.lblTituloCompras.Name = "lblTituloCompras";
            this.lblTituloCompras.Size = new System.Drawing.Size(187, 24);
            this.lblTituloCompras.TabIndex = 18;
            this.lblTituloCompras.Text = "Registrar compra";
            this.lblTituloCompras.Click += new System.EventHandler(this.lblTituloCompras_Click);
            // 
            // DATOS
            // 
            this.DATOS.BackColor = System.Drawing.Color.White;
            this.DATOS.Controls.Add(this.lblTituloCompras);
            this.DATOS.Controls.Add(this.txtIdEmpleado);
            this.DATOS.Controls.Add(this.txtIdEmpresa);
            this.DATOS.Controls.Add(this.txtDisponi);
            this.DATOS.Controls.Add(this.txtAlias);
            this.DATOS.Controls.Add(this.txtIdCompra);
            this.DATOS.Controls.Add(this.btnGuardarCompra);
            this.DATOS.Controls.Add(this.txtEmpresaCompra);
            this.DATOS.Controls.Add(this.nudCantidadCompra);
            this.DATOS.Controls.Add(this.lblEmpresa);
            this.DATOS.Controls.Add(this.btnActualizarCompra);
            this.DATOS.Controls.Add(this.txtEmpleado);
            this.DATOS.Controls.Add(this.btnCancelarCompra);
            this.DATOS.Controls.Add(this.txtTotalCompra);
            this.DATOS.Controls.Add(this.lblTotalCompra);
            this.DATOS.Controls.Add(this.lblCantidad);
            this.DATOS.Controls.Add(this.lblEmpleado);
            this.DATOS.ForeColor = System.Drawing.Color.Black;
            this.DATOS.Location = new System.Drawing.Point(12, 96);
            this.DATOS.Name = "DATOS";
            this.DATOS.Size = new System.Drawing.Size(414, 371);
            this.DATOS.TabIndex = 67;
            this.DATOS.TabStop = false;
            // 
            // txtDisponi
            // 
            this.txtDisponi.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisponi.Location = new System.Drawing.Point(788, 89);
            this.txtDisponi.Name = "txtDisponi";
            this.txtDisponi.Size = new System.Drawing.Size(322, 26);
            this.txtDisponi.TabIndex = 12;
            // 
            // txtAlias
            // 
            this.txtAlias.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlias.Location = new System.Drawing.Point(854, 56);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(256, 26);
            this.txtAlias.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(442, 100);
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // FrmNuevaCompra
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(438, 473);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DATOS);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmNuevaCompra";
            this.Opacity = 0.8D;
            this.Load += new System.EventHandler(this.FrmNuevaCompra_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadCompra)).EndInit();
            this.DATOS.ResumeLayout(false);
            this.DATOS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private void FrmNuevaCompra_Load_1(object sender, EventArgs e)
        {

        }

        private void btnGuardarCompra_Click_1(object sender, EventArgs e)
        {

        }

        private void txtEmpleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdEmpleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdEmpresa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdCompra_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmpleado_Click(object sender, EventArgs e)
        {

        }

        private void lblEmpresa_Click(object sender, EventArgs e)
        {

        }

        private void txtEmpresaCompra_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTotalCompra_Click(object sender, EventArgs e)
        {

        }

        private void txtTotalCompra_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCantidad_Click(object sender, EventArgs e)
        {

        }

        private void nudCantidadCompra_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnActualizarCompra_Click(object sender, EventArgs e)
        {

        }

        private void lblTituloCompras_Click(object sender, EventArgs e)
        {

        }
    }
}
