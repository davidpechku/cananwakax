using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoADatos; // Para tener acceso al archivo frameDB
using System.Windows.Forms; // para tener acceso a los componenetes

namespace Sistema_Ganadero.Clases
{
   public class clasApliCria
    {

        public int id_cria { get; set; }
        public int id_vacuna { get; set; }
        public string fecha_aplicacion { get; set; }
        public string proxima_fecha { get; set; }
        public string hora_aplicacion { get; set; }
        public int id_empleado { get; set; }

        public clasApliCria()
        {

        }

        public void BuscarCategorias(string cat, DataGridView dgv)
        {
            string sql = "SELECT aplicaciones_crias.id_aplicacion AS 'Clave', crias.alias AS 'Alias', vacunas.vacuna AS 'Vacuna', aplicaciones_crias.fecha_aplicacion AS 'Fecha de Aplicacion', aplicaciones_crias.hora_aplicacion AS 'Hora de la Aplicacion',aplicaciones_crias.proxima_fecha AS 'Proxima Aplicacion', empleados.nombre AS 'Empleado' FROM aplicaciones_crias INNER JOIN crias ON crias.id_cria = aplicaciones_crias.id_cria INNER JOIN vacunas ON aplicaciones_crias.id_vacuna = vacunas.id_vacuna INNER JOIN empleados ON aplicaciones_crias.id_empleado = empleados.id_empleado WHERE aplicaciones_crias.id_aplicacion  LIKE'" + cat + "%' ORDER BY aplicaciones_crias.id_aplicacion";

            dgv.DataSource = FrameBD.SQLSEL(sql);
            dgv.DataMember = "datos";


        }

        public void store()
        {

            string sql = string.Format("INSERT INTO aplicaciones_crias(id_cria,id_vacuna, fecha_aplicacion, hora_aplicacion, proxima_fecha, id_empleado)VALUES('{0}','{1}','{2}','{3}','{4}','{5}')",
                                      id_cria, id_vacuna, fecha_aplicacion, hora_aplicacion, proxima_fecha, id_empleado);
            FrameBD.SQLIDU(sql);
        }


        public void Eliminar(string pk)

        {
            string sql = string.Format("DELETE FROM aplicaciones_crias WHERE id_aplicacion='{0}';", pk);
            //MessageBox.Show(sql);
            FrameBD.SQLIDU(sql);
        }

        public void update(string pk, int id_cria, int id_vacuna, string fecha, string hora, string proxima, int clave)
        {
            //METODO PARA ACTUALIZAR UNA CATEGORIA
            string sql = string.Format("UPDATE aplicaciones_crias SET id_cria={1}, id_vacuna={2}, fecha_aplicacion='{3}', hora_aplicacion='{4}', proxima_fecha= '{5}', id_empleado={6} WHERE id_aplicacion='{0}';", pk, id_cria, id_vacuna, fecha, hora, proxima, clave);
            FrameBD.SQLIDU(sql);
        }


        public void getCria(ComboBox cmb)
        {
            // definimos los datos  que llenaran al combobox
            string consulta = "SELECT id_cria,alias FROM crias";

            // paso 2:  Vinculamos los  datps al dataspurse del como			
            cmb.DataSource = FrameBD.SQLCOMBO(consulta);

            //paso 3: espesifica el valor a mostrar al usuario
            cmb.DisplayMember = "alias";

            //Paso 4:  Definimos la clave primaria
            cmb.ValueMember = "id_cria";

        }


        public void getVacuna(ComboBox cmb)
        {
            // definimos los datos  que llenaran al combobox
            string consulta = "SELECT id_vacuna,vacuna FROM vacunas";

            // paso 2:  Vinculamos los  datps al dataspurse del como			
            cmb.DataSource = FrameBD.SQLCOMBO(consulta);

            //paso 3: espesifica el valor a mostrar al usuario
            cmb.DisplayMember = "vacuna";

            //Paso 4:  Definimos la clave primaria
            cmb.ValueMember = "id_vacuna";

        }

        public void getEmple(ComboBox cmb)
        {
            // definimos los datos  que llenaran al combobox
            string consulta = "SELECT id_empleado,nombre FROM empleados";

            // paso 2:  Vinculamos los  datps al dataspurse del como			
            cmb.DataSource = FrameBD.SQLCOMBO(consulta);

            //paso 3: espesifica el valor a mostrar al usuario
            cmb.DisplayMember = "nombre";

            //Paso 4:  Definimos la clave primaria
            cmb.ValueMember = "id_empleado";

        }

        public void transaccion()
        {
            string sql = string.Format("INSERT INTO aplicaciones_crias(id_cria,id_vacuna, fecha_aplicacion, hora_aplicacion, proxima_fecha, id_empleado)VALUES('{0}','{1}','{2}','{3}','{4}','{5}')",
                                      id_cria, id_vacuna, fecha_aplicacion, hora_aplicacion, proxima_fecha, id_empleado);
            FrameBD.tran(sql);
        }


    }
}
