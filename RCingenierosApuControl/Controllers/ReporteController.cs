using Services;
using System;
using System.Web.Mvc;
using static RCingenierosApuControl.Tags.AutenticadoAtrribute;

namespace RCingenierosApuControl.Controllers
{

    [AutenticadoAttribute]
    public class ReporteController : Controller
    {

        ReporteService objReporteService = new ReporteService();
        public ActionResult Reportes()
        {
            return View();
        }

        public ActionResult ReporteMovimiento()
        {
            return View();
        }

        public ActionResult ReporteClientes()
        {
            return View();
        }


        public ActionResult ReporteSeguimiento()
        {
            return View();
        }




        [HttpGet]
        public JsonResult ListarDetallesMovimientoPorEmpleado(DateTime FechaInicio, DateTime FechaFinal, string Estado)
        {
            try
            {
                var data = objReporteService.ListarClienteSeguimientoActivoPorFechas(FechaInicio,FechaFinal,Estado);
                return Json(new{data= data} , JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);

            }

        }

        

      [HttpGet]
        public JsonResult ListarCantidaMovimientosPorTipoFechas(DateTime FechaInicio, DateTime FechaFinal)
        {
            try
            {
                var data = objReporteService.ListarCantidaMovimientosPorTipoFechas(FechaInicio, FechaFinal);
                return Json(new { data = data }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }



        [HttpGet]
        public JsonResult ListarCantidaMovimientosClientesEmpleado(string Estado ,DateTime FechaInicio, DateTime FechaFinal )
        {
            try
            {
                var data = objReporteService.ListarCantidaMovimientosClientesEmpleado(Estado, FechaInicio, FechaFinal);
                return Json(new { data = data }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);

            }

        }
















        /// <summary>
        /// 
        /// </summary>
        /// <param name="FechaInicio"></param>
        /// <param name="FechaFinal"></param>
        /// <returns></returns>

        [HttpGet]
        public JsonResult ListarClistesActivoReporte()
        {
            try
            {
                var data = objReporteService.ListarClistesActivoReporte();
                return Json(new { data = data }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }



        [HttpGet]
        public JsonResult ListarDetalleMovimientos(int IdCliente, DateTime FechaInicio, DateTime FechaFinal)
        {
            try
            {
                var data = objReporteService.ListarDetalleMovimientos(IdCliente, FechaInicio, FechaFinal);
                return Json(new { data = data }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);

            }

        }





    }
}