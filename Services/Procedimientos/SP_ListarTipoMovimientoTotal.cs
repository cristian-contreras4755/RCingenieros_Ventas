using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Procedimientos
{
   public class SP_ListarTipoMovimientoTotal
    {

        public int IdTipoMovimiento { get; set; }
        public string NombreMovimiento { get; set; }
        public string DescripcionMovimiento { get; set; }
        public string Estado { get; set; }
    }
}

