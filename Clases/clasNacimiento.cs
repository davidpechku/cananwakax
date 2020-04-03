using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoADatos;
using System.Windows.Forms;


namespace Sistema_Ganadero.Clases
{
    
    public class clasNacimiento
    {
        public int numero { get; set; }

        public string fecha_nacimiento { get; set; }

        public int numero_crias { get; set; }

        public clasNacimiento() {
        }

        public void BuscarCategorias(string cat, DataGridView dgv)
        {
            string sql = "SELECT nacimientos.id_nacimiento AS 'Clave', animales.alias AS 'Alias' , nacimientos.fecha_nacimiento AS 'Fecha de Nacimiento' , nacimientos.numero_crias AS 'Numero de Crias' FROM nacimientos INNER JOIN animales ON nacimientos.numero = animales.numero WHERE id_nacimiento LIKE'" + cat + "%' ORDER BY nacimientos.id_nacimiento";

            dgv.DataSource = FrameBD.SQLSEL(sql);
            dgv.DataMember = "datos";
        }

       

        public void guardar() {

            string sql = string.Format("INSERT INTO nacimientos(numero, fecha_nacimiento, numero_crias)VALUES({0},'{1}',{2})",
                          numero, fecha_nacimiento, numero_crias);
            FrameBD.SQLIDU(sql);
        }



        public void Eliminar(string pk)

        {
            string sql = string.Format("DELETE FROM nacimientos WHERE id_nacimiento='{0}';", pk);
            //MessageBox.Show(sql);
            FrameBD.SQLIDU(sql);
        }




        public void getnumeros(ComboBox cmb)
        {
            // definimos los datos  que llenaran al combobox
            string consulta = "SELECT numero,alias FROM animales";

            // paso 2:  Vinculamos los  datps al dataspurse del como			
            cmb.DataSource = FrameBD.SQLCOMBO(consulta);

            //paso 3: espesifica el valor a mostrar al usuario
            cmb.DisplayMember = "alias";

            //Paso 4:  Definimos la clave primaria
            cmb.ValueMember = "numero";

        }

        public void update(string pk, int num, int n_crias, string fecha)
        {
            //METODO PARA ACTUALIZAR UNA CATEGORIA
            string sql = string.Format("UPDATE nacimientos SET numero='{1}', numero_crias={2} , fecha_nacimiento='{3}' WHERE id_nacimiento='{0}';", pk, num, n_crias, fecha, n_crias);
            FrameBD.SQLIDU(sql);
        }
    }
}
