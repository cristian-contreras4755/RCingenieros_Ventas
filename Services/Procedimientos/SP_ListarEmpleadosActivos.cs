using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Procedimientos
{
   public class SP_ListarEmpleadosActivos
    {
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string NombreArea { get; set; }
        public string NombreCargo { get; set; }
        public string Documento { get; set; }
        public string EmailCorporativo { get; set; }
        public string EmailPersonal { get; set; }
        public string NroTelfPersonal { get; set; }
        public string NroTelfCorporativo { get; set; }
        public string Estado { get; set; }



    }
}
