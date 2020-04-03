using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoADatos; // Para tener acceso al archivo frameDB
using System.Windows.Forms; // para tener acceso a los componenetes
namespace Sistema_Ganadero.Clases
{
    class ClaseAnimal
    {

        public int numero { get; set; }
        public string id_uso { get; set; }
        public string estatus { get; set; }
        public string genero { get; set; }
        public string disponibilidad { get; set; }
        public string alias { get; set; }

       
       

        public void BuscarCate(string num, DataGridView dgv)
        {
            //SELECT* FROM animales WHERE eliminar = "si" OR alias = "no"
            string sql = "SELECT * FROM animales WHERE  alias LIKE'" + num + "%'";
            dgv.DataSource = FrameBD.SQLSEL(sql);
            dgv.DataMember = "datos";

        }
        public void store()
        {

            string sql = string.Format("INSERT INTO animales(numero, id_uso, estatus, genero, disponibilidad, alias)VALUES('{0}','{1}','{2}','{3}','{4}','{5}')",
                                      numero, id_uso, estatus, genero, disponibilidad, alias );
            FrameBD.SQLIDU(sql);
        }


        public void Eliminar(string pk)

        {
            string sql = string.Format("UPDATE FROM animales SET eliminar='no' WHERE numero={0};", pk);
            //MessageBox.Show(sql);
            FrameBD.SQLIDU(sql);
        }

        public void update(string pk, string id_uso, string estatus, string genero, string disponibilidad, string alias)
        {
            //METODO PARA ACTUALIZAR UNA CATEGORIA
            string sql = string.Format("UPDATE animales SET   id_uso={1}, estatus='{2}', genero='{3}', disponibilidad={4}, alias='{5}'WHERE numero='{0}';", pk, numero, id_uso, estatus, genero, disponibilidad, alias);
            FrameBD.SQLIDU(sql);
        }
        public void getcategorias(ComboBox cmb)
        {
            // definimos los datos  que llenaran al combobox
            string consulta = "SELECT id_uso, uso FROM usos";
            //id_uso, uso

            // paso 2:  Vinculamos los  datps al dataspurse del como			
            cmb.DataSource = FrameBD.SQLCOMBO(consulta);

            //paso 3: espesifica el valor a mostrar al usuario
            cmb.DisplayMember = "uso";
            // uso 

            //Paso 4:  Definimos la clave primaria
            cmb.ValueMember = "id_uso";
            //id_uso

        }

    }
}
