using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Procedimientos
{
 public   class SP_ListarDetalleMovimientoPorEmpleadoYCliente
    {
        public int IdDetalleMovimiento { get; set; }
        public int IdMovimiento { get; set; }
        public int IdTipoMovimiento { get; set; }
        public int Idcliente { get; set; }
        public int IdEmpleado { get; set; }
        public string NombreComercial { get; set; }
        public DateTime FechaMovimiento { get; set; }
        public string NombreMovimiento { get; set; }
        public string Descripcion { get; set; }
        public string Logros { get; set; }
        public string Estado { get; set; }
    }
}
