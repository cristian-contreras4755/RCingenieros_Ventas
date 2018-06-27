using Modelo;
using Services.Procedimientos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
   public class TipoMovimientoService
    {

        public IEnumerable<SP_ListarTipoMovimientoTotal> ListarTipoMovimientoTotal()
        {
            try
            {
                using (var ctx = new DBContexto())
                {
                    var query = ctx.Database.SqlQuery<SP_ListarTipoMovimientoTotal>("SP_ListarTipoMovimientoTotal").ToList();
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
