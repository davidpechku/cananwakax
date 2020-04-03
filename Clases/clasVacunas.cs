using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoADatos;

namespace Sistema_Ganadero.Clases
{
   public  class clasVacunas
    {
        

        public string vacuna { get; set; }

    
        public int id_tipo_vacuna { get; set; }

        public clasVacunas(){

        }

        public void BuscarCategorias(string cat, DataGridView dgv)
        {
            string sql = "SELECT vacunas.id_vacuna AS 'Clave',tipo_vacunas.tipo_vacuna AS 'Tipo de vacuna', vacunas.vacuna AS 'Vacuna' FROM vacunas INNER JOIN tipo_vacunas ON vacunas.id_tipo_vacuna = tipo_vacunas.id_tipo_vacuna where vacuna LIKE'" + cat + "%'";

            dgv.DataSource = FrameBD.SQLSEL(sql);
            dgv.DataMember = "datos";


        }

        // metodo para guardar
        public void store()
        {
            
            string sql = string.Format("INSERT INTO vacunas(vacuna, id_tipo_vacuna)VALUES('{0}',{1})",
                                      vacuna, id_tipo_vacuna);
            FrameBD.SQLIDU(sql);
        }

        public void Eliminar(string pk)

        {
            string sql = string.Format("DELETE FROM vacunas WHERE id_vacuna='{0}';", pk);
            //MessageBox.Show(sql);
            FrameBD.SQLIDU(sql);
        }


        // metodo para actualizar
        public void update(string pk, string cat  ,int clave)
        {
            //METODO PARA ACTUALIZAR UNA CATEGORIA
            string sql = string.Format("UPDATE vacunas SET vacuna='{1}',id_tipo_vacuna={2} WHERE id_vacuna='{0}';", pk,cat, clave );
            FrameBD.SQLIDU(sql);
        }


        // metodo para mostrar una llave foranea en un combobox

        public void getcategorias(ComboBox cmb)
        {
            // definimos los datos  que llenaran al combobox
            string consulta = "SELECT id_tipo_vacuna,tipo_vacuna FROM tipo_vacunas";

            // paso 2:  Vinculamos los  datps al dataspurse del como			
            cmb.DataSource = FrameBD.SQLCOMBO(consulta);

            //paso 3: espesifica el valor a mostrar al usuario
            cmb.DisplayMember = "tipo_vacuna";

            //Paso 4:  Definimos la clave primaria
            cmb.ValueMember = "id_tipo_vacuna";

        }

    }
}
