using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_caja
{
    internal class RepositorioProductos
    {
        private string Columna = "id_producto, codigo_barra, descripcion, precio, stock, categoria, id_usuario";
        
        public Producto BuscarCodigo(int idUsuario, string codigoBarra)
        {
            using (MySqlConnection conexion = Conexion.ObtenerConexion())
            {
                conexion.Open();
                string sql = "SELECT " + Columna + " FROM productos WHERE id_usuario = @usuario AND codigo_barra = @codigo";
                using ( var comando =new MySqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@usuario", idUsuario);
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
        
        public int Agregar(int idUsuario, Producto producto)
        {
            using (MySqlConnection conexion = Conexion.ObtenerConexion())
            {
                conexion.Open();
                string sql = @"INSERT INTO productos (id_usuario, codigo_barra, descripcion, precio, stock, categoria)
                                    VALUES (@usuario, @codigo, @descripcion, @precio, @stock, @categoria)";
                using (var comando =new MySqlCommand( sql, conexion))
                {
                    comando.Parameters.AddWithValue("@usuario", idUsuario);
                    comando.Parameters.AddWithValue("@codigo", producto.ObtenerCodBarras());
                    comando.Parameters.AddWithValue("@descripcion", producto.ObtenerDescripcion());
                    comando.Parameters.AddWithValue("@precio", producto.ObtenerPrecio());
                    comando.Parameters.AddWithValue("@stock", producto.ObtenerStock());
                    comando.Parameters.AddWithValue("@categoria", producto.ObtenerCategoria());

                    try
                    {
                        comando.ExecuteNonQuery();
                        return Convert.ToInt32(comando.LastInsertedId);
                    }
                    catch (MySqlException Ex) when (Ex.Number == 1062)
                    {
                        throw new InvalidOperationException("Ya hay un producto con este codigo de barras");
                    }
                }
            }
        }

        public List<Producto> ObtenerProductos (int idUsuario)
        {
            List<Producto> lista = new List<Producto>();
            string sql = " SELECT " + Columna + " FROM productos WHERE id_usuario = @usuario";

            using (MySqlConnection conexion = Conexion.ObtenerConexion())
            {
                conexion.Open();
                using (var comando = new MySqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@usuario", idUsuario);
                    using (MySqlDataReader lector = comando.ExecuteReader())
                    {
                        while(lector.Read())
                        {
                            lista.Add(Mapear(lector));
                        }
                        
                    }
                }
            }

            return lista;
        }

        public void EliminarProducto(int idProducto, int idUsuario)
        {
            using (MySqlConnection conexion = Conexion.ObtenerConexion())
            {
                conexion.Open();
                string sql = "DELETE FROM productos WHERE id_producto = @idProducto AND id_usuario = @usuario";

                using (var comando = new MySqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@idProducto", idProducto);
                    comando.Parameters.AddWithValue("@usuario", idUsuario);
                    comando.ExecuteNonQuery();
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
                lector.GetString("categoria"),
                lector.GetInt32("id_usuario")
                );
        }
    }
}
