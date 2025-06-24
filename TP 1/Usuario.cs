using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_1
{
    public class Usuario
    {
        public string Username { get; set; }
        public string Contraseña { get; set; }
        public string Rol { get; set; } // "Administrador" o "Usuario"
    }
}
