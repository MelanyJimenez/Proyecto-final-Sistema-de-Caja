using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Sistema_de_caja
{
    public class ValidarUsuario
    {
        public Usuario ValidarLogin(string nombre_us, string password)
        {
            string hash = CalcularHash(password);

            using (MySqlConnection conexion = Conexion.ObtenerConexion())
            {
                conexion.Open();
                const string sql = @"SELECT id, nombre_us, email, nombre_tienda
                                                  FROM usuarios
                                                  WHERE nombre_us = @login
                                                    AND `password` = @hash";

                using (var comando = new MySqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@login", nombre_us);
                    comando.Parameters.AddWithValue("@hash", hash);

                    using (MySqlDataReader lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            
                            {
                                return new Usuario(
                                lector.GetInt32("id"),
                                lector.GetString("nombre_us"),
                                lector.GetString("email"),
                                lector.GetString("nombre_tienda")

                                );
                            };
                        }
                    }
                }
            }
            return null;
        }


        public bool YaExisteNombreUs(string nombreUs)
        {
            return Contar("SELECT COUNT(*) FROM usuarios WHERE nombre_us = @valor", nombreUs) > 0;
        }

        public bool YaExisteEmail(string email)
        {
            return Contar("SELECT COUNT(*) FROM usuarios WHERE email = @valor", email) > 0;
        }


        private long Contar(string sql, string valor)
        {
            using (MySqlConnection conexion = Conexion.ObtenerConexion())
            {
                conexion.Open();
                using (var comando = new MySqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@valor", valor);
                    return Convert.ToInt64(comando.ExecuteScalar());
                }
            }
        }
        public string CalcularHash(string input)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder();
                foreach (byte b in bytes)
                    sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }

        public void registrarse(string nombreUs, string email, string password, string nombreTienda)
        {
            email= email.Trim().ToLowerInvariant();

            if (YaExisteNombreUs(nombreUs))
            {
                throw new InvalidOperationException("Ese nombre de usuario ya esxiste");
            }
            if (YaExisteEmail(email))
            {
                throw new InvalidOperationException("Ya existe una cuenta con ese email");
            }

            using (MySqlConnection conexion = Conexion.ObtenerConexion())
            {
                conexion.Open();

                const string sql = @"INSERT INTO usuarios (nombre_us, email, password, nombre_tienda)
                                      VALUES (@nombreUs, @email, @hash, @tienda)";

                using (var comando = new MySqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@nombreUs", nombreUs);
                    comando.Parameters.AddWithValue("@email", email);
                    comando.Parameters.AddWithValue("@hash", CalcularHash(password));
                    comando.Parameters.AddWithValue("@tienda", nombreTienda);
                    comando.ExecuteNonQuery();
                }
            }

        }
    }
}