using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Sistema_de_caja
{
    public class Usuario
    {
        private int id;
        private readonly string nombreUs;
        private string email; 
        private string nombreTienda;


        public Usuario(int Id, string NombreUs, string Email, string NombreTienda) 
        {
            id = Id;
            nombreUs = NombreUs.Trim();
            email = Email.Trim().ToLowerInvariant();
            nombreTienda = NombreTienda.Trim();
        }
        public int ObtenerId()
        {
            return id; 
        }
        public string ObtenerNombreUs()
        {
            return nombreUs;
        }

    }
}
