using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Procedimientos
{
   public class SP_ListarGrupo
    {
        public int IdGrupo { get; set; }
        public string NombreGrupo { get; set; }
        public string TipoDocumento { get; set; }
        public string NroDocumento { get; set; }
        public string Estado { get; set; }
    }
}
