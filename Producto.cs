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
        private int idUsuario;

        public Producto(int Id, string CodBarras, string Descripcion, double Precio, int Stock, string Categoria, int idUsuario)
        {
            id = Id;
            codBarras = CodBarras;
            descripcion = Descripcion;
            precio = Precio;
            stock = Stock;
            categoria = Categoria;
            this.idUsuario = idUsuario;
        }
        public int ObtenerIdUsu()
        {
            return idUsuario;
        }
        public int ObtenerId()
        {
            return id;
        }
        public string ObtenerCodBarras()
        {
            return codBarras;
        }
        public string ObtenerDescripcion()
        {
            return descripcion;
        }
        public double ObtenerPrecio()
        {
            return precio;
        }
        public int ObtenerStock()
        {
            return stock;
        }
        public string ObtenerCategoria()
        {
            return categoria;
        }
    }
}
