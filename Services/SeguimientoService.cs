using Modelo;
using Services.Procedimientos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
 public   class SeguimientoService
    {

        public IEnumerable<SP_ListarDetallesMovimientoPorEmpleado> ListarDetallesMovimientoPorEmpleado(int IdEmpleado) {
   
            using (var ctx = new DBContexto()){


                            try
                            {
                                  var   Lista = ctx.Database.SqlQuery<SP_ListarDetallesMovimientoPorEmpleado>("SP_ListarDetallesMovimientoPorEmpleado @IdEmpleado", new SqlParameter("@IdEmpleado", IdEmpleado)).ToList();
                                    return Lista;
                            }
                            catch (Exception)
                            {

                                throw;
                            }

             }

  
        }

        public IEnumerable<SP_ListarClienteSeguimientoActivo> ListarClienteSeguimientoActivo(int IdEmpleado)
        {

            using (var ctx = new DBContexto())
            {


                try
                {
                    var Lista = ctx.Database.SqlQuery<SP_ListarClienteSeguimientoActivo>("SP_ListarClienteSeguimientoActivo @IdEmpleado", new SqlParameter("@IdEmpleado", IdEmpleado)).ToList();
                    return Lista;
                }
                catch (Exception)
                {

                    throw;
                }

            }


        }



        public IEnumerable<SP_ListarDetalleMovimientoEnSeguimiento> ListarDetalleMovimientoEnSeguimiento(int Idcliente)
        {

            using (var ctx = new DBContexto())
            {


                try
                {
                    var Lista = ctx.Database.SqlQuery<SP_ListarDetalleMovimientoEnSeguimiento>("SP_ListarDetalleMovimientoEnSeguimiento @Idcliente", new SqlParameter("@Idcliente", Idcliente)).ToList();
                    return Lista;
                }
                catch (Exception)
                {

                    throw;
                }

            }


        }




        public string CerrarSeguimientoFinal( int Id) {
      
                    var estado = "";
                    var DetalleMovimiento = new DetalleMovimiento{ IdDetalleMovimiento = Id };
                    try
                    {
                        using (var bd = new DBContexto())
                        {

                            bd.DetalleMovimiento.Attach(DetalleMovimiento);
                            DetalleMovimiento.Estado = "C";
                            bd.Configuration.ValidateOnSaveEnabled = false;
                            bd.SaveChanges();
                            estado ="OK";
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(estado = ex.Message);

                    }
                    return estado;
      
        }





        public string CerrarSeguimientoPosterior(int IdDetalleMovimiento, string Logros)
        {
  
            using (var ctx = new DBContexto())
            {
                string result = "";
         

                try
                {
                    var objeto = ctx.Database.SqlQuery<DetalleMovimiento>("SP_CerrarSeguimiento @IdDetalleMovimiento,@Logros", new SqlParameter("@IdDetalleMovimiento", IdDetalleMovimiento), new SqlParameter("@Logros", Logros)).FirstOrDefaultAsync();
                    if (objeto != null)
                    {
                         result = "OK";
                    }
                    else {

                       result = "ERROR";
                    }


                }
                catch (Exception)
                {

                    throw;
                }
                return result;

            }


        }








    }
}
