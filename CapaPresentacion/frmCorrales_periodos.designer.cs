namespace Sistema_Ganadero.CapaPresentacion
{
    partial class frmCorrales_periodos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCorrales_periodos));
            this.txtClaveCorral = new System.Windows.Forms.TextBox();
            this.txtClavePeriodo = new System.Windows.Forms.TextBox();
            this.txtCorral = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpPeriodo = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvCorrales = new System.Windows.Forms.DataGridView();
            this.dgvPeriodos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancelarP = new System.Windows.Forms.Button();
            this.txtBuscarPeriodos = new System.Windows.Forms.TextBox();
            this.btnEditarP = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnElimnarP = new System.Windows.Forms.Button();
            this.btnGuardarCP = new System.Windows.Forms.Button();
            this.btnGuardarP = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtBuscarCorral = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTituloCompras = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DATOS = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorrales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeriodos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtClaveCorral
            // 
            this.txtClaveCorral.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveCorral.Location = new System.Drawing.Point(141, 76);
            this.txtClaveCorral.Name = "txtClaveCorral";
            this.txtClaveCorral.Size = new System.Drawing.Size(252, 26);
            this.txtClaveCorral.TabIndex = 0;
            // 
            // txtClavePeriodo
            // 
            this.txtClavePeriodo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClavePeriodo.Location = new System.Drawing.Point(154, 74);
            this.txtClavePeriodo.Name = "txtClavePeriodo";
            this.txtClavePeriodo.Size = new System.Drawing.Size(235, 26);
            this.txtClavePeriodo.TabIndex = 2;
            // 
            // txtCorral
            // 
            this.txtCorral.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorral.Location = new System.Drawing.Point(93, 120);
            this.txtCorral.Name = "txtCorral";
            this.txtCorral.Size = new System.Drawing.Size(300, 26);
            this.txtCorral.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Clave de corral";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Periodo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Clave de periodo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Corral";
            // 
            // dtpPeriodo
            // 
            this.dtpPeriodo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPeriodo.Location = new System.Drawing.Point(87, 118);
            this.dtpPeriodo.Name = "dtpPeriodo";
            this.dtpPeriodo.Size = new System.Drawing.Size(302, 26);
            this.dtpPeriodo.TabIndex = 8;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Teal;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(398, 110);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 45);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.BackColor = System.Drawing.Color.Teal;
            this.btnGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCambios.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCambios.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCambios.Location = new System.Drawing.Point(399, 110);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(110, 45);
            this.btnGuardarCambios.TabIndex = 10;
            this.btnGuardarCambios.Text = "GUARDAR";
            this.btnGuardarCambios.UseVisualStyleBackColor = false;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(399, 167);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(110, 45);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(398, 228);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(110, 45);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Green;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(398, 289);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 45);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvCorrales
            // 
            this.dgvCorrales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCorrales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCorrales.Location = new System.Drawing.Point(15, 172);
            this.dgvCorrales.Name = "dgvCorrales";
            this.dgvCorrales.Size = new System.Drawing.Size(378, 223);
            this.dgvCorrales.TabIndex = 14;
            // 
            // dgvPeriodos
            // 
            this.dgvPeriodos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPeriodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeriodos.Location = new System.Drawing.Point(11, 173);
            this.dgvPeriodos.Name = "dgvPeriodos";
            this.dgvPeriodos.Size = new System.Drawing.Size(378, 223);
            this.dgvPeriodos.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnCancelarP);
            this.groupBox1.Controls.Add(this.txtBuscarPeriodos);
            this.groupBox1.Controls.Add(this.btnEditarP);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnElimnarP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnGuardarCP);
            this.groupBox1.Controls.Add(this.btnGuardarP);
            this.groupBox1.Controls.Add(this.dgvPeriodos);
            this.groupBox1.Controls.Add(this.txtClavePeriodo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpPeriodo);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(594, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 424);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Periodos";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(395, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 45);
            this.button1.TabIndex = 69;
            this.button1.Text = "SALIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelarP
            // 
            this.btnCancelarP.BackColor = System.Drawing.Color.Green;
            this.btnCancelarP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelarP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarP.ForeColor = System.Drawing.Color.White;
            this.btnCancelarP.Location = new System.Drawing.Point(395, 294);
            this.btnCancelarP.Name = "btnCancelarP";
            this.btnCancelarP.Size = new System.Drawing.Size(110, 45);
            this.btnCancelarP.TabIndex = 22;
            this.btnCancelarP.Text = "CANCELAR";
            this.btnCancelarP.UseVisualStyleBackColor = false;
            this.btnCancelarP.Click += new System.EventHandler(this.btnCancelarP_Click);
            // 
            // txtBuscarPeriodos
            // 
            this.txtBuscarPeriodos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarPeriodos.Location = new System.Drawing.Point(86, 30);
            this.txtBuscarPeriodos.Name = "txtBuscarPeriodos";
            this.txtBuscarPeriodos.Size = new System.Drawing.Size(298, 26);
            this.txtBuscarPeriodos.TabIndex = 18;
            this.txtBuscarPeriodos.TextChanged += new System.EventHandler(this.txtBuscarPeriodos_TextChanged);
            // 
            // btnEditarP
            // 
            this.btnEditarP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEditarP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditarP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarP.ForeColor = System.Drawing.Color.White;
            this.btnEditarP.Location = new System.Drawing.Point(395, 238);
            this.btnEditarP.Name = "btnEditarP";
            this.btnEditarP.Size = new System.Drawing.Size(110, 45);
            this.btnEditarP.TabIndex = 21;
            this.btnEditarP.Text = "EDITAR";
            this.btnEditarP.UseVisualStyleBackColor = false;
            this.btnEditarP.Click += new System.EventHandler(this.btnEditarP_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Buscar:";
            // 
            // btnElimnarP
            // 
            this.btnElimnarP.BackColor = System.Drawing.Color.DarkOrange;
            this.btnElimnarP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnElimnarP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimnarP.ForeColor = System.Drawing.Color.White;
            this.btnElimnarP.Location = new System.Drawing.Point(395, 177);
            this.btnElimnarP.Name = "btnElimnarP";
            this.btnElimnarP.Size = new System.Drawing.Size(110, 45);
            this.btnElimnarP.TabIndex = 20;
            this.btnElimnarP.Text = "ELIMINAR";
            this.btnElimnarP.UseVisualStyleBackColor = false;
            this.btnElimnarP.Click += new System.EventHandler(this.btnElimnarP_Click);
            // 
            // btnGuardarCP
            // 
            this.btnGuardarCP.BackColor = System.Drawing.Color.Teal;
            this.btnGuardarCP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCP.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCP.Location = new System.Drawing.Point(395, 118);
            this.btnGuardarCP.Name = "btnGuardarCP";
            this.btnGuardarCP.Size = new System.Drawing.Size(110, 45);
            this.btnGuardarCP.TabIndex = 19;
            this.btnGuardarCP.Text = "GUARDAR";
            this.btnGuardarCP.UseVisualStyleBackColor = false;
            this.btnGuardarCP.Click += new System.EventHandler(this.btnGuardarCP_Click);
            // 
            // btnGuardarP
            // 
            this.btnGuardarP.BackColor = System.Drawing.Color.Teal;
            this.btnGuardarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarP.ForeColor = System.Drawing.Color.White;
            this.btnGuardarP.Location = new System.Drawing.Point(395, 118);
            this.btnGuardarP.Name = "btnGuardarP";
            this.btnGuardarP.Size = new System.Drawing.Size(110, 45);
            this.btnGuardarP.TabIndex = 18;
            this.btnGuardarP.Text = "GUARDAR";
            this.btnGuardarP.UseVisualStyleBackColor = false;
            this.btnGuardarP.Click += new System.EventHandler(this.btnGuardarP_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.Controls.Add(this.txtBuscarCorral);
            this.groupBox2.Controls.Add(this.btnCancelar);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dgvCorrales);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.txtClaveCorral);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Controls.Add(this.btnGuardarCambios);
            this.groupBox2.Controls.Add(this.txtCorral);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(31, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(520, 424);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Corrales";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Navy;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(398, 350);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(110, 45);
            this.btnSalir.TabIndex = 68;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtBuscarCorral
            // 
            this.txtBuscarCorral.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCorral.Location = new System.Drawing.Point(106, 29);
            this.txtBuscarCorral.Name = "txtBuscarCorral";
            this.txtBuscarCorral.Size = new System.Drawing.Size(287, 26);
            this.txtBuscarCorral.TabIndex = 16;
            this.txtBuscarCorral.TextChanged += new System.EventHandler(this.txtBuscarCorral_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Buscar:";
            // 
            // lblTituloCompras
            // 
            this.lblTituloCompras.AutoSize = true;
            this.lblTituloCompras.BackColor = System.Drawing.Color.White;
            this.lblTituloCompras.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCompras.Location = new System.Drawing.Point(451, 33);
            this.lblTituloCompras.Name = "lblTituloCompras";
            this.lblTituloCompras.Size = new System.Drawing.Size(375, 37);
            this.lblTituloCompras.TabIndex = 67;
            this.lblTituloCompras.Text = "CORRALES/PERIODOS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1154, 124);
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // DATOS
            // 
            this.DATOS.BackColor = System.Drawing.Color.White;
            this.DATOS.ForeColor = System.Drawing.Color.Black;
            this.DATOS.Location = new System.Drawing.Point(14, 128);
            this.DATOS.Name = "DATOS";
            this.DATOS.Size = new System.Drawing.Size(1125, 468);
            this.DATOS.TabIndex = 68;
            this.DATOS.TabStop = false;
            // 
            // frmCorrales_periodos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1151, 609);
            this.Controls.Add(this.lblTituloCompras);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DATOS);
            this.Name = "frmCorrales_periodos";
            this.Text = "frmCorrales_periodos";
            this.Load += new System.EventHandler(this.frmCorrales_periodos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorrales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeriodos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClaveCorral;
        private System.Windows.Forms.TextBox txtClavePeriodo;
        private System.Windows.Forms.TextBox txtCorral;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpPeriodo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvCorrales;
        private System.Windows.Forms.DataGridView dgvPeriodos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBuscarCorral;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBuscarPeriodos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancelarP;
        private System.Windows.Forms.Button btnEditarP;
        private System.Windows.Forms.Button btnElimnarP;
        private System.Windows.Forms.Button btnGuardarCP;
        private System.Windows.Forms.Button btnGuardarP;
        private System.Windows.Forms.Label lblTituloCompras;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox DATOS;
    }
}

