using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_caja
{
    internal class Conexion
    {
        private static string Servidor = "localhost";
        private static string Puerto = "3307";
        private static string BaseDatos = "BDCaja";
        private static string Usuario = "root";
        private static string Password = "admin16";

        public static MySqlConnection ObtenerConexion()
        {
            string cadena = $"Server={Servidor};Port={Puerto};Database={BaseDatos};" +
                            $"Uid={Usuario};Pwd={Password};";
            return new MySqlConnection(cadena);
        }
    }
}
