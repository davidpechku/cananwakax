using AccesoADatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Ganadero.Clases
{
    class clasProducto
    {
        public string buscar { get; set; }

        public string idProducto { get; set; }
        public string nombre { get; set; }
        public int existencia { get; set; }
        public void AgregarProducto()
        {
            string sql = string.Format("INSERT INTO productos(nombre) VALUES ('{0}')",
                 nombre);
            FrameBD.SQLIDU(sql);
        }

        public void editarProducto(int idProducto, string nombre, int existencia)
        {
            string sql = string.Format("UPDATE productos SET nombre='{1}', existencia='{2}' WHERE id_producto={0};",
                                        idProducto, nombre, existencia);
            FrameBD.SQLIDU(sql);
        }

        public void buscarProducto(DataGridView dgv)
        {
            string sql = string.Format("SELECT id_producto as 'Clave', nombre as 'Producto', existencia as 'Existencias' FROM productos WHERE nombre like'{0}%';", buscar);
            dgv.DataSource = FrameBD.SQLSEL(sql);
            dgv.DataMember = "datos";
        }

        public void EliminarProducto(int id)
        {
            string sql = string.Format("DELETE FROM productos WHERE id_producto={0};", id);
            FrameBD.SQLIDU(sql);
        }

      
    }
}
