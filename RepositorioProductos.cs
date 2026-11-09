using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_caja
{
    internal class RepositorioProductos
    {
        private string Columna = "id_producto, codigo_barra, descripcion, precio, stock, categoria";
        
        public Producto BuscarCodigo(int id, int codigoBarra)
        {
            using (MySqlConnection conexion = Conexion.ObtenerConexion())
            {
                conexion.Open();
                string sql = "SELECT " + Columna + " FROM productos WHERE id_usuario = @usuario AND codigo_barra = @codigo";
                using ( var comando =new MySqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@usuario", id);
                    comando.Parameters.AddWithValue("@codigo", codigoBarra);

                    using(MySqlDataReader lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            return Mapear(lector);
                        }
                    }
                }
            }
            return null;
        }
        
        public int Agregar(int id, Producto producto)
        {
            using (MySqlConnection conexion = Conexion.ObtenerConexion())
            {
                conexion.Open();
                string sql = @"INSERT INTO productos (id_usuario, codigo_barra, descripcion, precio, stock, categoria)
                                    VALUES (@usuario, @codigo, @descripcion, @precio, @stock, @categoria)";
                using (var comando =new MySqlCommand( sql, conexion))
                {
                    comando.Parameters.AddWithValue("@usuario", id);
                    comando.Parameters.AddWithValue("@codigo", producto.CodigoB);
                    comando.Parameters.AddWithValue("@descripcion", producto.Descripcion);
                    comando.Parameters.AddWithValue("@precio", producto.Precio);

                    try
                    {
                        comando.ExecuteNonQuery();
                        return (int)comando.LastInsertedId;
                    }
                    catch (MySqlException Ex) when (Ex.Number == 1062)
                    {
                        throw new InvalidOperationException("Ya hayun producto con este codigo de barras");
                    }
                }
            }
        }
        private Producto Mapear(MySqlDataReader lector)
        {
            return new Producto(
                lector.GetInt32("id_producto"),
                lector.GetString("codigo_barra"),
                lector.GetString("descripcion"),
                lector.GetDouble("precio"),
                lector.GetInt32("stock"),
                lector.GetString("categoria")
                );
        }
    }
}
