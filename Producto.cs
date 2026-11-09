using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Sistema_de_caja
{
    public class Producto
    {
        private int id;
        private string codBarras;
        private string descripcion;
        private double precio;
        private int stock;
        private string categoria;

        public Producto(int Id, string CodBarras, string Descripcion, double Precio, int Stock, string Categoria) 
        {
            id = Id;
            codBarras = CodBarras;
            descripcion = Descripcion;
            precio = Precio;
            stock = Stock;
            categoria = Categoria;
        }

        public int ObtenerId() 
        { 
            return id; 
        }
        public string CodigoB(string codBarras)
        {
            if (string.IsNullOrWhiteSpace(codBarras))
            {
                throw new ArgumentException("El código de barras es obligatorio");
            }
            return codBarras.Trim();
        }

        public string Descripcion(string Descripcion)
        {
            if (string.IsNullOrWhiteSpace(Descripcion))
            {
                throw new ArgumentException("La decripcion es abligatoria");
            }
            return Descripcion.Trim();
        }

        public string Precio(string precio)
        {
            if (string.IsNullOrWhiteSpace(precio))
            {
                throw new ArgumentException("El precio es obligatorio");
            }
            return precio.Trim();
        }

        public string Stock(string stock)
        {
            if (string.IsNullOrWhiteSpace(stock))
            {
                throw new ArgumentException("Es obligatorio ingresar");
            }
            return stock.Trim();
        }
    }
}
