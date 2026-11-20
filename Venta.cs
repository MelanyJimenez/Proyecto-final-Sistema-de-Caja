using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_caja
{
    internal class Venta
    {
        private int id_venta;
        private DateTime fecha;
        private double total;
        private int idUsuario;

        public Venta(int id_venta, DateTime fecha, double total, int idUsuario)
        {
            this.id_venta = id_venta;
            this.fecha = fecha;
            this.total = total;
            this.idUsuario = idUsuario;
        }

        public int ObtenerIdVenta()
        {
            return id_venta;
        }

        public DateTime ObtenerFecha()
        {
            return fecha;
        }

        public double ObtenerTotal()
        {
            return total;
        }

        public int ObtenerIdUsuario()
        {
            return idUsuario;
        }
    }
}
