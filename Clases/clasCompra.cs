using AccesoADatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Ganadero.Clases
{
    class clasCompra
    {
        public string buscar { get; set; }
        public DateTime fecha { get; set; }


        public void agregarCompra()
        {

            fecha = DateTime.Now;
            string sql = string.Format("INSERT INTO compras(fecha) VALUES ('{0}')",fecha);
            FrameBD.SQLIDU(sql);
        }

        public void BuscarCompra(DataGridView dgv)
        {
            string sql = string.Format("SELECT idcompra as 'Clave', nombres as 'Nombres', apellidos as 'Apellidos', nombreUsuario as 'Nombre de Usuario', telefono as 'Telefono', direccion as 'Direccion',  idRol as 'Clave Rol' FROM empleados WHERE nombres like'{0}%' or apellidos like'{0}%';", buscar);
            dgv.DataSource = FrameBD.SQLSEL(sql);
            dgv.DataMember = "datos";
        }

    }
}
