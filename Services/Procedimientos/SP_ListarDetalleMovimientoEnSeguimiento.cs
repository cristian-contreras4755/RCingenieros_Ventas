using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Procedimientos
{
   public class SP_ListarDetalleMovimientoEnSeguimiento
    {
        public int IdDetalleMovimiento { get; set; }

        public string Descripcion { get; set; }
        public string Logros { get; set; }
        public DateTime FechaMovimiento { get; set; }
        public string NombreMovimiento { get; set; }
    }
}
