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
    public class SeguimientoController : Controller
    {
        SeguimientoService objSeguimientoService = new SeguimientoService();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cliente()
        {
            return View();
        }


        public JsonResult ListarDetallesMovimientoPorEmpleado(int IdEmpleado) {
            try
            {
                var data = objSeguimientoService.ListarDetallesMovimientoPorEmpleado(IdEmpleado);
                return Json(new{ data=data},JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
               
            }


        }





        public JsonResult ListarClienteSeguimientoActivo(int IdEmpleado)
        {
            try
            {
                var data = objSeguimientoService.ListarClienteSeguimientoActivo(IdEmpleado);
                return Json(new { data = data }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);

            }


        }



        public JsonResult ListarDetalleMovimientoEnSeguimiento(int Idcliente)
        {
            try
            {
                var data = objSeguimientoService.ListarDetalleMovimientoEnSeguimiento(Idcliente);
                return Json(new { data = data }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);

            }


        }


        [HttpPost]
        public JsonResult CerrarSeguimientoCliente(int Id)
        {
            var data = objSeguimientoService.CerrarSeguimientoFinal(Id);
            if (data == "OK")
            {
                return Json(data);
            }
            else
            {
                return Json(data = "ERROR");
            }
        }



        


        [HttpPost]
        public JsonResult CerrarSeguimientoPosterior(int IdDetalleMovimiento, string Logros)
        {
            var data = objSeguimientoService.CerrarSeguimientoPosterior(IdDetalleMovimiento,Logros);
            if (data == "OK")
            {
                return Json(data);
            }
            else
            {
                return Json(data = "ERROR");
            }
        }




    }
}