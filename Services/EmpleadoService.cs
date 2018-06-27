using Modelo;
using Services.Procedimientos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
  public  class EmpleadoService
    {

        public IEnumerable<SP_ListarEmpleadosActivos> ListarEmpleadosActivos()
        {
            try
            {
                using (var ctx = new DBContexto())
                {
                    var query = ctx.Database.SqlQuery<SP_ListarEmpleadosActivos>("SP_ListarEmpleadosActivos").ToList();
                    return query;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
