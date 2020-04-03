 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoADatos;

namespace Sistema_Ganadero.Clases
{
    class clasEmpleado
    {
        public string buscar { get; set; }
        public string nombresEmpleado { get; set; }
        public string apellidosEmpleado { get; set; }
        public string nombreUsuario { get; set; }
        public string telefonoEmpleado { get; set; }
        public string direccionEmpleado { get; set; }
        public string contraseniaEmpleado { get; set; }
        public string idRol { get; set; }
        public void AgregarEmpleado()
        {
            string sql = string.Format("INSERT INTO empleados(nombre, apellido, user, telefono, direccion, contrasenia,id_rol) VALUES ('{0}','{1}','{2}','{3}','{4}', '{5}',{6})",
                nombresEmpleado, apellidosEmpleado, nombreUsuario, telefonoEmpleado, direccionEmpleado, contraseniaEmpleado, idRol);
            FrameBD.SQLIDU(sql);
        }
        public void EditarEmpleado(int idEmpleado, string nombres, string apellidos, string usuario, string telefono, string direccion, string contrasenia, int idRol)
        {
            string sql = string.Format("UPDATE empleados SET nombre='{1}', apellido='{2}', user='{3}', telefono='{4}', direccion='{5}', contrasenia='{6}', id_rol={7} WHERE id_empleado={0};",
                                        idEmpleado, nombres, apellidos, usuario, telefono, direccion, contrasenia, idRol);
            FrameBD.SQLIDU(sql);
        }
        public void EliminarEmpleado(int idEmpleado)
        {
            string sql = string.Format("DELETE FROM empleados WHERE id_empleado={0};", idEmpleado);
            FrameBD.SQLIDU(sql);
        }
        public void BuscarEmpleado(string claveId, DataGridView dgv)
        {
            string sql = "SELECT empleados.id_empleado AS ID ,empleados.nombre AS NOMBRES ,empleados.apellido AS APELLIDOS,empleados.user AS USUARIO,empleados.telefono AS TELEFONO,empleados.direccion AS DIRECCION" +
                " FROM empleados INNER JOIN roles ON  roles.id_rol=empleados.id_rol" +
                " WHERE empleados.id_rol LIKE'" + claveId + "%';";
            dgv.DataSource = FrameBD.SQLSEL(sql);
            dgv.DataMember = "datos";
        }
        public void GetRoles(ComboBox cmb)
        {
            string consultar = "SELECT id_rol,rol FROM roles";
            cmb.DataSource = FrameBD.SQLCOMBO(consultar);
            cmb.DisplayMember = "rol";
            cmb.ValueMember = "id_rol";
        }

        //public void Usuario(TextBox txt)
        //{
        //    string sql = "SELECT empleados.nombre, empleados.apellido FROM empleados";
        //}
        //public void FiltrarUsuarios(string claveId, DataGridView dgv)
        //{
        //    string sql = "SELECT empleados.idEmpleado,empleados.contrasenia,roles.idRol" +
        //        " FROM empleados INNER JOIN roles ON  roles.idRol=empleados.idRol" +
        //        " WHERE empleados.idRol LIKE'" + claveId + "%';";
        //    dgv.DataSource = FrameBD.SQLSEL(sql);
        //    dgv.DataMember = "datos";
        //}
    }
}
