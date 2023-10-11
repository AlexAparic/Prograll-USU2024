using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuarios
    {
        public int IdUsuario { get; set; }
        public string NombreCompleto { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public TipoDeUsuario otipoDeUsuario { get; set; }
        public string FechaDeCreacion { get; set; }
    }
}
