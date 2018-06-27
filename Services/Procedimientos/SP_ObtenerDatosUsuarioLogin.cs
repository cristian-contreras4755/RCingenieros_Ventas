using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Procedimientos
{
   public class SP_ObtenerDatosUsuarioLogin
    {

        public int IdEmpleado { get; set; }
        public int IdUsuario { get; set; }
        public string NombreEmpleado { get; set; }
        public string UsuarioLogin { get; set; }
        public string NombreRol { get; set; }
    }
}
