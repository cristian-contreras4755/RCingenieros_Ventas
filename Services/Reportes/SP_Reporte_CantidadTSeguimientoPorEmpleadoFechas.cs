using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Reportes
{
  public  class SP_Reporte_CantidadTSeguimientoPorEmpleadoFechas
    {
        public string NombreMovimiento { get; set; }
        public string Empleado { get; set; }
        public int CantidadTareas { get; set; }
    }
}
