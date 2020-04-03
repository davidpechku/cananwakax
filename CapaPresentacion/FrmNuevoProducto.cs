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
    public partial class FrmNuevoProducto : Form
    {
        public NumericUpDown nudExistenciaProducto;
        public Label lblExistenciaProducto;
        public TextBox txtIdProducto;
        public TextBox txtNombreProducto;
        private Label lblNombreProducto;
        private Button btnCancelarProducto;
        public Button btnActualizarProducto;
        public Button btnGuardarProducto;
        private Label lblTituloProductos;

        public FrmNuevoProducto()
        {
            InitializeComponent();
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizarProducto_Click(object sender, EventArgs e)
        {

        }

        private void FrmNuevoProducto_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.nudExistenciaProducto = new System.Windows.Forms.NumericUpDown();
            this.lblExistenciaProducto = new System.Windows.Forms.Label();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.btnCancelarProducto = new System.Windows.Forms.Button();
            this.btnActualizarProducto = new System.Windows.Forms.Button();
            this.btnGuardarProducto = new System.Windows.Forms.Button();
            this.lblTituloProductos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudExistenciaProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // nudExistenciaProducto
            // 
            this.nudExistenciaProducto.Location = new System.Drawing.Point(86, 99);
            this.nudExistenciaProducto.Name = "nudExistenciaProducto";
            this.nudExistenciaProducto.Size = new System.Drawing.Size(74, 20);
            this.nudExistenciaProducto.TabIndex = 43;
            this.nudExistenciaProducto.Visible = false;
            // 
            // lblExistenciaProducto
            // 
            this.lblExistenciaProducto.AutoSize = true;
            this.lblExistenciaProducto.Location = new System.Drawing.Point(21, 106);
            this.lblExistenciaProducto.Name = "lblExistenciaProducto";
            this.lblExistenciaProducto.Size = new System.Drawing.Size(55, 13);
            this.lblExistenciaProducto.TabIndex = 42;
            this.lblExistenciaProducto.Text = "Existencia";
            this.lblExistenciaProducto.Visible = false;
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(10, 13);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(21, 20);
            this.txtIdProducto.TabIndex = 41;
            this.txtIdProducto.Visible = false;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(86, 64);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(265, 20);
            this.txtNombreProducto.TabIndex = 40;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(21, 71);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(44, 13);
            this.lblNombreProducto.TabIndex = 39;
            this.lblNombreProducto.Text = "Nombre";
            // 
            // btnCancelarProducto
            // 
            this.btnCancelarProducto.Location = new System.Drawing.Point(247, 144);
            this.btnCancelarProducto.Name = "btnCancelarProducto";
            this.btnCancelarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarProducto.TabIndex = 38;
            this.btnCancelarProducto.Text = "Cancelar";
            this.btnCancelarProducto.UseVisualStyleBackColor = true;
            this.btnCancelarProducto.Click += new System.EventHandler(this.btnCancelarProducto_Click);
            // 
            // btnActualizarProducto
            // 
            this.btnActualizarProducto.Location = new System.Drawing.Point(166, 144);
            this.btnActualizarProducto.Name = "btnActualizarProducto";
            this.btnActualizarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarProducto.TabIndex = 37;
            this.btnActualizarProducto.Text = "Actualizar";
            this.btnActualizarProducto.UseVisualStyleBackColor = true;
            this.btnActualizarProducto.Click += new System.EventHandler(this.btnActualizarProducto_Click_1);
            // 
            // btnGuardarProducto
            // 
            this.btnGuardarProducto.Location = new System.Drawing.Point(85, 144);
            this.btnGuardarProducto.Name = "btnGuardarProducto";
            this.btnGuardarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarProducto.TabIndex = 36;
            this.btnGuardarProducto.Text = "Guardar";
            this.btnGuardarProducto.UseVisualStyleBackColor = true;
            this.btnGuardarProducto.Click += new System.EventHandler(this.btnGuardarProducto_Click_1);
            // 
            // lblTituloProductos
            // 
            this.lblTituloProductos.AutoSize = true;
            this.lblTituloProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloProductos.Location = new System.Drawing.Point(80, 9);
            this.lblTituloProductos.Name = "lblTituloProductos";
            this.lblTituloProductos.Size = new System.Drawing.Size(207, 25);
            this.lblTituloProductos.TabIndex = 35;
            this.lblTituloProductos.Text = "Registrar producto";
            // 
            // FrmNuevoProducto
            // 
            this.ClientSize = new System.Drawing.Size(372, 202);
            this.Controls.Add(this.nudExistenciaProducto);
            this.Controls.Add(this.lblExistenciaProducto);
            this.Controls.Add(this.txtIdProducto);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.lblNombreProducto);
            this.Controls.Add(this.btnCancelarProducto);
            this.Controls.Add(this.btnActualizarProducto);
            this.Controls.Add(this.btnGuardarProducto);
            this.Controls.Add(this.lblTituloProductos);
            this.Name = "FrmNuevoProducto";
            ((System.ComponentModel.ISupportInitialize)(this.nudExistenciaProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnGuardarProducto_Click_1(object sender, EventArgs e)
        {
            if (txtNombreProducto.Text == "")
            {
                MessageBox.Show("Todos los campos son obligatorios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                clasProducto pro = new clasProducto();

                pro.nombre = txtNombreProducto.Text;
                pro.AgregarProducto();
                MessageBox.Show("Registro guardado exitosamente", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnActualizarProducto_Click_1(object sender, EventArgs e)
        {
            FrmProducto frmPro = new FrmProducto();
            clasProducto pro = new clasProducto();
            pro.editarProducto(Convert.ToInt32(txtIdProducto.Text), txtNombreProducto.Text, Convert.ToInt32(nudExistenciaProducto.Text));
            pro.buscarProducto(frmPro.dgvProductos);
            MessageBox.Show("Registro actualizado exitosamente", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancelarProducto_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
