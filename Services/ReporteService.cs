using Modelo;
using Services.Procedimientos;
using Services.Reportes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ReporteService
    {


        public IEnumerable<SP_Reporte_CantidadDeSeguimientosPorEmpleadoFechas> ListarClienteSeguimientoActivoPorFechas(DateTime FechaInicio,DateTime FechaFinal,string Estado )
        {

            using (var ctx = new DBContexto())
            {
                try
                {
                    var Lista = ctx.Database.SqlQuery<SP_Reporte_CantidadDeSeguimientosPorEmpleadoFechas>("SP_Reporte_CantidadDeSeguimientosPorEmpleadoFechas @Estado,@fechaInicial,@fechaFinal", new SqlParameter("@Estado", Estado),new SqlParameter("@fechaInicial", FechaInicio),new SqlParameter("@fechaFinal", FechaFinal)).ToList();
                    return Lista;
                }
                catch (Exception)
                {
                    throw;
                }

            }
        }


        



        public IEnumerable<SP_Reporte_CantidadTSeguimientoPorEmpleadoFechas> ListarCantidaMovimientosPorTipoFechas(DateTime FechaInicio, DateTime FechaFinal)
        {

            using (var ctx = new DBContexto())
            {
                try
                {
                    var Lista = ctx.Database.SqlQuery<SP_Reporte_CantidadTSeguimientoPorEmpleadoFechas>("SP_Reporte_CantidadTSeguimientoPorEmpleadoFechas @fechaInicial,@fechaFinal", new SqlParameter("@fechaInicial", FechaInicio), new SqlParameter("@fechaFinal", FechaFinal)).ToList();
                    return Lista;
                }
                catch (Exception)
                {
                    throw;
                }

            }
        }



        


        public IEnumerable<SP_Reporte_Seguimiento_clientesPorEmpleado> ListarCantidaMovimientosClientesEmpleado(string Estado, DateTime FechaInicio, DateTime FechaFinal)
        {

            using (var ctx = new DBContexto())
            {
                try
                {
                    var Lista = ctx.Database.SqlQuery<SP_Reporte_Seguimiento_clientesPorEmpleado>("SP_Reporte_Seguimiento_clientesPorEmpleado @Estado,@fechaInicial,@fechaFinal", new SqlParameter("@Estado", Estado), new SqlParameter("@fechaInicial", FechaInicio), new SqlParameter("@fechaFinal", FechaFinal)).ToList();
                    return Lista;
                }
                catch (Exception)
                {
                    throw;
                }

            }
        }

        



        //reportes 

        public IEnumerable<SP_Reporte_ListarClienteActivo> ListarClistesActivoReporte()
        {

            using (var ctx = new DBContexto())
            {
                try
                {
                    var Lista = ctx.Database.SqlQuery<SP_Reporte_ListarClienteActivo>("SP_Reporte_ListarClienteActivo").ToList();
                    return Lista;
                }
                catch (Exception)
                {
                    throw;
                }

            }
        }





        public IEnumerable<SP_Reporte_DetalleMovimiento> ListarDetalleMovimientos(int IdCliente, DateTime FechaInicio, DateTime FechaFinal)
        {

            using (var ctx = new DBContexto())
            {
                try
                {
                    var Lista = ctx.Database.SqlQuery<SP_Reporte_DetalleMovimiento>("SP_Reporte_DetalleMovimiento @Idcliente,@FechaInicial,@FechaFinal", new SqlParameter("@Idcliente", IdCliente), new SqlParameter("@FechaInicial", FechaInicio), new SqlParameter("@FechaFinal", FechaFinal)).ToList();
                    return Lista;
                }
                catch (Exception)
                {
                    throw;
                }

            }
        }


    }
}
