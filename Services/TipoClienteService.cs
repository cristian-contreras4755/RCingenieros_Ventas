using Modelo;
using Services.Procedimientos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
  public  class TipoClienteService
    {



      public IEnumerable<SP_ListarTipoClienteTotal> ListarTipoClienteTotal() {
            try
            {
                using (var ctx = new DBContexto())
                {
                    var query = ctx.Database.SqlQuery<SP_ListarTipoClienteTotal>("SP_ListarTipoClienteTotal").ToList();
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
