using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_caja
{
    internal class RepositorioVentas
    {
        public int GuardarVenta(Venta venta, List<DetalleVenta> detalles)
        {
            using (MySqlConnection conexion = Conexion.ObtenerConexion())
            {
                conexion.Open();
                using (MySqlTransaction transaccion = conexion.BeginTransaction())
                {
                    try
                    {
                        string sql = @"INSERT INTO ventas (fecha, total, id_usuario) 
                                            VALUES (@fecha, @total, @usuario)";

                        int idVentaGenerada = 0;

                        using (var cmdVenta = new MySqlCommand(sql, conexion, transaccion))
                        {
                            cmdVenta.Parameters.AddWithValue("@fecha", venta.ObtenerFecha());
                            cmdVenta.Parameters.AddWithValue("@total", venta.ObtenerTotal());
                            cmdVenta.Parameters.AddWithValue("@usuario", venta.ObtenerIdUsuario());

                            cmdVenta.ExecuteNonQuery();
                            idVentaGenerada = Convert.ToInt32(cmdVenta.LastInsertedId);
                        }

                        string sqlDetalle = @"INSERT INTO detalle_ventas (id_venta, id_producto, cantidad, precio_unitario) 
                                              VALUES (@idVenta, @idProducto, @cantidad, @precio)";

                        foreach (DetalleVenta item in detalles)
                        {
                            using (var cmdDetalle = new MySqlCommand(sqlDetalle, conexion, transaccion))
                            {
                                cmdDetalle.Parameters.AddWithValue("@idVenta", idVentaGenerada);
                                cmdDetalle.Parameters.AddWithValue("@idProducto", item.ObtenerIdProducto());
                                cmdDetalle.Parameters.AddWithValue("@cantidad", item.ObtenerCantidad());
                                cmdDetalle.Parameters.AddWithValue("@precio", item.ObtenerPrecioUnitario());
                                cmdDetalle.ExecuteNonQuery();
                            }
                        }

                        transaccion.Commit();
                        return idVentaGenerada;
                    }
                    catch (Exception)
                    {
                        transaccion.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}
