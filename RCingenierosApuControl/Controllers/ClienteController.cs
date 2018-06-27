
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
    public class ClienteController : Controller
    {
        ClienteService objClienteService = new ClienteService();
        EmpleadoService objEmpleadoService = new EmpleadoService();
        TipoClienteService objTipoCliente = new TipoClienteService();
        GrupoService objGrupoService = new GrupoService();


        // GET: Cliente
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public JsonResult ListarClientes()
        {
            try
            {
                var data = objClienteService.ListarTotalDeClientes();
                return Json(new { data = data }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }






        [HttpGet]
        public JsonResult ListarEmpleadosActivos()
        {
            try
            {
                var data = objEmpleadoService.ListarEmpleadosActivos();
                return Json(new { data = data }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {
                throw;
            }
        }



        [HttpGet]
        public JsonResult ListarTipoClienteTotal()
        {
            try
            {
                var data = objTipoCliente.ListarTipoClienteTotal();
                return Json(new { data = data }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {
                throw;
            }
        }



        [HttpGet]
        public JsonResult ListarGrupo()
        {
            try
            {
                var data = objGrupoService.ListarGrupo();
                return Json(new { data = data }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }









        [HttpPost]
        public JsonResult RegistroCliente(Cliente cliente)
        {
        var data = objClienteService.RegistrarCliente(cliente);

            if (data == "OK")
            {

                return Json(data,JsonRequestBehavior.AllowGet);
            }
            else {


                return Json(data="Error",JsonRequestBehavior.AllowGet);
            }
        }




        [HttpPost]
        public JsonResult ObtenerClientePorId(int Id)
        {
            var data = objClienteService.ObtenerClientePorId(Id);
            if (data != null) {
                return Json(data );
            }
            else
            {
                return Json(data =null);
            }
           
        }





        [HttpPost]
        public JsonResult ActualizaPuntoVenta(Cliente cliente)
        {

          var data= objClienteService.EditarCliente(cliente);

            if (data == "OK")
            {

                return Json(data);
            }
            else { 
            return Json(data="ERROR");
            }


        }




        [HttpPost]
        public JsonResult EliminarCliente(int Id)
        {
            var data = objClienteService.EliminarCliente(Id);
            if (data == "OK") {

                return Json(data);
            }
            else {

                return Json(data="ERROR");

            }
         

        }

    }
}