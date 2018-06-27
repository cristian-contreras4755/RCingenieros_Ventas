using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Procedimientos
{
  public  class SP_ListarTipoClienteTotal
    {
        public int IdTipoCliente { get; set; }
        public string NombreTipo { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
    }
}
