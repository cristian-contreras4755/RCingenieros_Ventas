using Modelo;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static RCingenierosApuControl.Tags.AutenticadoAtrribute;

namespace RCingenierosApuControl.Controllers
{

    [AutenticadoAttribute]
    public class MovimientosController : Controller
    {

        ClienteService objClienteService = new ClienteService();
        TipoMovimientoService objTipoMovimientoService = new TipoMovimientoService();
        MovimientoService objMovimientoService = new MovimientoService();
        public ActionResult Index()
        {
            return View();
        }





        [HttpGet]
        public JsonResult ListarClientesPorEmpleado(int IdEmpleado)
        {
            try
            {
                var data = objClienteService.ListarClientesPorEmpleado(IdEmpleado);
                return Json(new { data = data }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {
                throw;
            }
        }


        [HttpGet]
        public JsonResult ListarTipoMovimientoTotal()
        {
            try
            {
                var data = objTipoMovimientoService.ListarTipoMovimientoTotal();
                return Json(new { data = data }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {
                throw;
            }
        }





        [HttpPost]
        public JsonResult RegistrarMovimientos(Movimiento movimiento)
        {
            string status;
            status = objMovimientoService.RegistrarMovimientos(movimiento);

            return Json( status , JsonRequestBehavior.AllowGet);
        }


   






    }
}