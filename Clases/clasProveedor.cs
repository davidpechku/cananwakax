using AccesoADatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Ganadero.Clases
{
    class clasProveedor
    {
        public string buscar { get; set; }
        public string nombre { get; set; }

        public string telefono { get; set; }

        public string direccion { get; set; }

        public string rfc { get; set; }

        public string codigo_postal { get; set; }

        public string ciudad { get; set; }

        public string correo_electronico { get; set; }

        public void agregarProveedor()
        {
            string sql = string.Format("INSERT INTO proveedores(nombre, telefono, direccion, rfc, codigo_postal, ciudad, correo_electronico) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                nombre, telefono, direccion, rfc, codigo_postal, ciudad, correo_electronico);
            FrameBD.SQLIDU(sql);
        }

        public void editarProveedor(int idProveedor, string nombre, string telefono, string direccion, string rfc, string codigo_postal, string ciudad, string correo_electronico)
        {
            string sql = string.Format("UPDATE proveedores SET nombre='{1}', telefono='{2}', direccion='{3}', rfc='{4}' , codigo_postal='{5}', ciudad='{6}', correo_electronico='{7}' WHERE id_proveedor={0};",
                                        idProveedor, nombre, telefono, direccion, rfc, codigo_postal, ciudad, correo_electronico);
            FrameBD.SQLIDU(sql);
        }

        public void BuscarProveedor(DataGridView dgv)
        {
            string sql = string.Format("SELECT id_proveedor as 'Clave', nombre as 'Empresa', telefono as 'Telefono', direccion as 'Direccion', rfc as 'RFC', codigo_postal as 'Codigo Postal', ciudad as 'Ciudad', correo_electronico as 'Correo Electronico' FROM proveedores WHERE nombre like'{0}%';", buscar);
            dgv.DataSource = FrameBD.SQLSEL(sql);
            dgv.DataMember = "datos";
        }

        public void EliminarProveedor(int id)
        {
            string sql = string.Format("DELETE FROM proveedores WHERE id_proveedor={0};", id);
            FrameBD.SQLIDU(sql);
        }
    }
}
