using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoADatos;
using System.Windows.Forms;

namespace Sistema_Ganadero.Clases
{
    class ClasCorralesPeriodos
    {
        public int id_corral { get; set; }
        public string corral { get; set; }

        
        public void GuardarCorrales()
        {
            string insertarc = string.Format("INSERT INTO corrales (id_corral, corral) VALUES('{0}','{1}')",id_corral, corral);
            FrameBD.SQLIDU(insertarc);
        }

        public void EliminarCorrales(string id)
        {
            string eliminar = string.Format("DELETE FROM corrales WHERE id_corral='{0}'", id);
            FrameBD.SQLIDU(eliminar);
        }

        public void EditarCorrales(string v0, string v1, string vc0)
        {
            string editar = string.Format("UPDATE corrales SET id_corral='{0}', corral='{1}' WHERE id_corral='{0}';", v0, v1, vc0);
            FrameBD.SQLIDU(editar);
        }

        public void BuscarCorral(string clave, DataGridView dgv)
        {
            string buscar = "SET Names 'utf8';";
            buscar = buscar + "SELECT id_corral AS Clave, corral AS Corral FROM corrales WHERE id_corral LIKE'" + clave + "%'";
            dgv.DataSource = FrameBD.SQLSEL(buscar);
            dgv.DataMember = "datos";
        }



        //==================================PERIODOS==================================================================================

        public int id_periodo { get; set; }
        public string periodo { get; set; }

        public void Guardarp()
        {
            string insertap = string.Format("INSERT INTO periodos (id_periodo, periodo) VALUES('{0}','{1}')", id_periodo, periodo);
            FrameBD.SQLIDU(insertap);
        }

        public void Eliminarp(string id)
        {
            string eliminar = string.Format("DELETE FROM periodos WHERE id_periodo='{0}'", id);
            FrameBD.SQLIDU(eliminar);
        }

        public void EditarPeriodos(string v0, string v1, string vc0)
        {
            string editar = string.Format("UPDATE periodos SET id_periodo='{0}', periodo='{1}' WHERE id_periodo='{0}';", v0, v1, vc0);
            FrameBD.SQLIDU(editar);
        }


        public void BuscarPeriodo(string clave, DataGridView dgv)
        {
            string buscar = "SET Names 'utf8';";
            buscar = buscar + "SELECT id_periodo AS Clave, periodo AS Periodo FROM periodos WHERE id_periodo LIKE'" + clave + "%'";
            dgv.DataSource = FrameBD.SQLSEL(buscar);
            dgv.DataMember = "datos";
        }

        public void limpiar(TextBox txtClaveCorral, TextBox txtCorral, TextBox txtClavePeriodo)
        {
            txtClaveCorral.Clear();
            txtCorral.Clear();
            txtClavePeriodo.Clear();
        }
    }
}
