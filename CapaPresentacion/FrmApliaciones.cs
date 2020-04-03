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
using AccesoADatos;
using modulodeaplicaciones;

namespace Sistema_Ganadero.CapaPresentacion
    
{
    //clasApliCria o = new clasApliCria();
    public partial class FrmApliaciones : Form
    {
        public FrmApliaciones()
        {
            InitializeComponent();
        }

        private void btnCrias_Click(object sender, EventArgs e)
            {
             frmApliCria formcria= new frmApliCria();
            formcria.ShowDialog();
        }

        private void FrmApliaciones_Load(object sender, EventArgs e)
        {

        }

        private void btnVacunas_Click(object sender, EventArgs e)
        {
            FrmVacunas formvacunas = new FrmVacunas();
            formvacunas.ShowDialog();
        }

        private void btnNacimentos_Click(object sender, EventArgs e)
        {
            frmNacimiento formnaci = new frmNacimiento();
            formnaci.ShowDialog();
        }

        private void btnTipo_Click(object sender, EventArgs e)
        {
            frmIdTipoVacuna formhola = new frmIdTipoVacuna();
            formhola.ShowDialog();

        }

        private void BtnCorrales_Click(object sender, EventArgs e)
        {
            frmCorrales_periodos Corral = new frmCorrales_periodos();
            Corral.ShowDialog();
        }
    }
    }
