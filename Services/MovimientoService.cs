using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
   public class MovimientoService
    {


        public string RegistrarMovimientos(Movimiento movimiento)
        {
            string status = "";
            try
            {
                using (var ctx = new DBContexto())
                {
                    ctx.Movimiento.Add(movimiento);
                    ctx.SaveChanges();
                    return status = "OK";
                }
            }
            catch (Exception ex)
            {
                return status = "ERROR";
            }
        }








    }
}
