namespace Sistema_Ganadero.CapaPresentacion
{
    partial class FrmApliaciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNacimentos = new System.Windows.Forms.Button();
            this.btnVacunas = new System.Windows.Forms.Button();
            this.btnCrias = new System.Windows.Forms.Button();
            this.btnTipo = new System.Windows.Forms.Button();
            this.BtnCorrales = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNacimentos
            // 
            this.btnNacimentos.Location = new System.Drawing.Point(21, 67);
            this.btnNacimentos.Name = "btnNacimentos";
            this.btnNacimentos.Size = new System.Drawing.Size(144, 49);
            this.btnNacimentos.TabIndex = 52;
            this.btnNacimentos.Text = "NACIMENTO";
            this.btnNacimentos.UseVisualStyleBackColor = true;
            this.btnNacimentos.Click += new System.EventHandler(this.btnNacimentos_Click);
            // 
            // btnVacunas
            // 
            this.btnVacunas.Location = new System.Drawing.Point(21, 12);
            this.btnVacunas.Name = "btnVacunas";
            this.btnVacunas.Size = new System.Drawing.Size(144, 49);
            this.btnVacunas.TabIndex = 51;
            this.btnVacunas.Text = "VACUNAS";
            this.btnVacunas.UseVisualStyleBackColor = true;
            this.btnVacunas.Click += new System.EventHandler(this.btnVacunas_Click);
            // 
            // btnCrias
            // 
            this.btnCrias.Location = new System.Drawing.Point(21, 126);
            this.btnCrias.Name = "btnCrias";
            this.btnCrias.Size = new System.Drawing.Size(144, 49);
            this.btnCrias.TabIndex = 50;
            this.btnCrias.Text = "Aplicaciones Crias";
            this.btnCrias.UseVisualStyleBackColor = true;
            this.btnCrias.Click += new System.EventHandler(this.btnCrias_Click);
            // 
            // btnTipo
            // 
            this.btnTipo.Location = new System.Drawing.Point(21, 181);
            this.btnTipo.Name = "btnTipo";
            this.btnTipo.Size = new System.Drawing.Size(144, 49);
            this.btnTipo.TabIndex = 53;
            this.btnTipo.Text = "Tipos Vacunas";
            this.btnTipo.UseVisualStyleBackColor = true;
            this.btnTipo.Click += new System.EventHandler(this.btnTipo_Click);
            // 
            // BtnCorrales
            // 
            this.BtnCorrales.Location = new System.Drawing.Point(21, 236);
            this.BtnCorrales.Name = "BtnCorrales";
            this.BtnCorrales.Size = new System.Drawing.Size(144, 49);
            this.BtnCorrales.TabIndex = 54;
            this.BtnCorrales.Text = "Corrales";
            this.BtnCorrales.UseVisualStyleBackColor = true;
            this.BtnCorrales.Click += new System.EventHandler(this.BtnCorrales_Click);
            // 
            // FrmApliaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 317);
            this.Controls.Add(this.BtnCorrales);
            this.Controls.Add(this.btnTipo);
            this.Controls.Add(this.btnNacimentos);
            this.Controls.Add(this.btnVacunas);
            this.Controls.Add(this.btnCrias);
            this.Name = "FrmApliaciones";
            this.Load += new System.EventHandler(this.FrmApliaciones_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnNacimentos;
        public System.Windows.Forms.Button btnVacunas;
        public System.Windows.Forms.Button btnCrias;
        public System.Windows.Forms.Button btnTipo;
        public System.Windows.Forms.Button BtnCorrales;
    }
}