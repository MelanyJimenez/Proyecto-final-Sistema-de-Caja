using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_caja
{
    internal class DetalleVenta
    {
        private int idProducto;
        private string codigoBarra;
        private int cantidad;
        private double precioUnit;
        private double subTotal;

        public DetalleVenta(int idProducto, string codigoBarra, int cantidad, double precioUnit)
        {
            this.idProducto = idProducto;
            this.codigoBarra = codigoBarra;
            this.cantidad = cantidad;
            this.precioUnit = precioUnit;
            this.subTotal = precioUnit * cantidad;
        }

        public int ObtenerIdProducto()
        {
            return idProducto;
        }

        public string ObtenerCodigoBarra()
        {
            return codigoBarra;
        }
        public int ObtenerCantidad()
        {
            return cantidad;
        }
        public double ObtenerPrecioUnitario()
        {
            return precioUnit;
        }
        public double ObtenerSubtotal()
        {
            return subTotal;
        }
    }
}
