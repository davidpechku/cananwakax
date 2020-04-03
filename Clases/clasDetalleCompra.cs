using AccesoADatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Ganadero.Clases
{
    class clasDetalleCompra
    {

        public string buscar { get; set; }
        public int id_detalle_compra { get; set; }

        public int id_empresa { get; set; }

        public int id_empleado { get; set; }

        public int id_compra { get; set; }

        public decimal total_compra { get; set; }

        public int cantidad { get; set; }


        public void AgregarDetalleCompra()
        {
            string sql = string.Format("INSERT INTO detallecompras(idempleado, idempresa, idcompra, totalcompra, cantidad) VALUES ('{0}','{1}','{2}','{3}','{4}')",
                id_empleado, id_empresa, id_compra, total_compra, cantidad);
            FrameBD.SQLIDU(sql);
        }

          public void transaccion()
        {
            string sql = string.Format("INSERT INTO detallecompras(idempleado, idempresa, idcompra, totalcompra, cantidad) VALUES ('{0}','{1}','{2}','{3}','{4}')",
               id_empleado, id_empresa, id_compra, total_compra, cantidad);
            FrameBD.tran(sql);
        }


    }
}
