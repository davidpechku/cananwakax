using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoADatos;

namespace Sistema_Ganadero.Clases
{
    class clasCliente
    {
        public string buscar { get; set; }
        public string nombreCliente { get; set; }
        public string apellidoCliente{ get; set; }
        public string direccionCliente { get; set; }
        public string correoCliente{ get; set; }
        public string telefonoCliente { get; set; }


        public void BuscarCliente(string id, DataGridView dgv)
        {
            string sql = "SELECT id_cliente AS ID ,nombre AS NOMBRES , apellido AS APELLIDOS, direccion AS DIRECCION, email AS CORREO, telefono AS TELEFONO" +
                " FROM clientes";
             //   "WHERE nombre LIKE'" + id + "%';";
            dgv.DataSource = FrameBD.SQLSEL(sql);
           // dgv.Columns[1].Width = 50;
            dgv.DataMember = "datos";
        }


        public void AgregarCliente()
        {
            string sql = string.Format("INSERT INTO clientes(nombre, apellido, direccion, email, telefono) VALUES ('{0}','{1}','{2}','{3}','{4}')",
                nombreCliente, apellidoCliente, direccionCliente, correoCliente, telefonoCliente);
            FrameBD.SQLIDU(sql);
        }


        public void EditarCliente(int id, string nombres, string apellidos, string direc, string email, string telefono)
        {
            string sql = string.Format("UPDATE clientes SET nombre='{1}', apellido='{2}', direccion='{3}', email='{4}', telefono='{5}' WHERE id_cliente={0};",
                                        id, nombres, apellidos, direc, email, telefono);
            FrameBD.SQLIDU(sql);
        }


        public void EliminarCliente(int idCliente)
        {
            string sql = string.Format("DELETE FROM clientes WHERE id_cliente={0};", idCliente);
            FrameBD.SQLIDU(sql);
        }
    }
}
