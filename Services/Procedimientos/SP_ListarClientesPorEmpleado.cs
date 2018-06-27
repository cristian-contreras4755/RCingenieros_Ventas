using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Procedimientos
{
  public  class SP_ListarClientesPorEmpleado
    {
        public int Idcliente { get; set; }
        public string NombreComercial { get; set; }
        public string RazonSocial { get; set; }
        public string Ruc { get; set; }
        public string Zona { get; set; }
        public string NombreTipo { get; set; }
        public DateTime FechaSunat { get; set; }
        public string NombreEmpleado { get; set; }
    }
}
