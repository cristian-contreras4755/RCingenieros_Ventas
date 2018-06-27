using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Procedimientos
{
    public class SP_ObtenerClientePorId
    {

        public int Idcliente { get; set; }
        public string NombreComercial { get; set; }
        public string RazonSocial { get; set; }
        public string Ruc { get; set; }
        public string departamento { get; set; }
        public string Provincia { get; set; }
        public string Distrito { get; set; }
        public string Direccion { get; set; }
        public int IdTipoCliente { get; set; }
        public string NombreTipo { get; set; }

        public string NombreContacto1 { get; set; }
        public string NombreContacto2 { get; set; }
        public string NombreContacto3 { get; set; }
        public string NroContacto1 { get; set; }
        public string NroContacto2 { get; set; }
        public string NroContacto3 { get; set; }
        public string EmailContacto1 { get; set; }
        public string EmailContacto2 { get; set; }
        public string EmailContacto3 { get; set; }

        public int IdEmpleado { get; set; }
        public string NombreEmpleado { get; set; }
        public DateTime FechaSunat { get; set; }
        public int IdGrupo { get; set; }
        public string NombreGrupo { get; set; }
        public string Estado { get; set; }
      
    }
}
