using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoADatos; // Para tener acceso al archivo frameDB
using System.Windows.Forms; // para tener acceso a los componenetes

namespace Sistema_Ganadero.Clases
{
    /*pasos para realizar un controlador    

    1 la clase original que se encuentra al abrir la clase se coloca como publica para que puedan accder a ell
    2 se crea un contructor dentro de la clase original que lleva el mismo nombre que el nombre de la clase

  */


    public class clasIdTipoVacuna1
    {
        // paso 3 se define los atributos a utilizar
        
        public string tipo_vacuna { get; set; }

        // Es el contructor de clase por lo general tiene el mismo nombre de la clase 
        public clasIdTipoVacuna1()
        {

        }

        // metodo para buscar 
        public void BuscarCategorias(string cat, DataGridView dgv)
        {
            string sql = "SELECT * FROM tipo_vacunas WHERE tipo_vacuna LIKE'" + cat + "%'";

            dgv.DataSource = FrameBD.SQLSEL(sql);
            dgv.DataMember = "datos";


        }

       // metodo para guardar
    
        public void store()
        {
            string sql = string.Format("INSERT INTO tipo_vacunas(tipo_vacuna)VALUES('{0}')",
                                      tipo_vacuna);
            FrameBD.SQLIDU(sql);
        }

        // metodo para eliminar
        public void Eliminar(string pk)

        {
            string sql = string.Format("DELETE FROM tipo_vacunas WHERE id_tipo_vacuna='{0}';", pk);
            //MessageBox.Show(sql);
            FrameBD.SQLIDU(sql);
        }
        
        // metodo para actualizar
        public void update(string pk, string cat)
        {
            //METODO PARA ACTUALIZAR UNA CATEGORIA
            string sql = string.Format("UPDATE tipo_vacunas SET tipo_vacuna='{0}' WHERE id_tipo_vacuna='{1}';", cat, pk);
            FrameBD.SQLIDU(sql);
        }


        // metodo para mostrar una llave foranea en un combobox

        public void getcategorias(ComboBox cmb)
        {
            // definimos los datos  que llenaran al combobox
            string consulta = "SELECT id_tipo_vacuna,vacuna FROM tipo_vacunas";

            // paso 2:  Vinculamos los  datps al dataspurse del como			
            cmb.DataSource = FrameBD.SQLCOMBO(consulta);

            //paso 3: espesifica el valor a mostrar al usuario
            cmb.DisplayMember = "vacuna";

            //Paso 4:  Definimos la clave primaria
            cmb.ValueMember = "id_tipo_vacuna";

        }

    }
}
