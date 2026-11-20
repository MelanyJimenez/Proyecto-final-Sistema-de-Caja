using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_caja
{
    internal class RepositorioReportes
    {
        private string Columna = "id_venta, fecha, total, id_usuario";

        public List<Venta> ObtenerVentas(int idUsuario)
        {
            List<Venta> list = new List<Venta>();
            string sql = "SELECT " + Columna + " FROM ventas WHERE id_usuario = @usuario ORDER BY id_venta DESC";
            using (MySqlConnection conexion = Conexion.ObtenerConexion())
            {
                conexion.Open();
                using (var comando = new MySqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@usuario", idUsuario);
                    using (MySqlDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            list.Add(Mapear(lector));
                        }
                    }
                }
            }

            return list;
        }

        private Venta Mapear(MySqlDataReader lector)
        {
            return new Venta(
                lector.GetInt32("id_venta"),
                lector.GetDateTime("fecha"),
                lector.GetDouble("total"),
                lector.GetInt32("id_usuario")
            );
        }
    }
}
