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
    public class GrupoController : Controller
    {

        GrupoService objGrupoService = new GrupoService();
        // GET: Grupo
        public ActionResult Index()
        {
            return View();
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
        public JsonResult RegistrarGrupo(Grupo grupo)
        {
            var data = objGrupoService.RegistrarGrupo(grupo);

            if (data == "OK")
            {

                return Json(data, JsonRequestBehavior.AllowGet);
            }
            else
            {


                return Json(data = "Error", JsonRequestBehavior.AllowGet);
            }
        }








        [HttpPost]
        public JsonResult ActualizaGrupo(Grupo grupo)
        {

            var data = objGrupoService.EditarGrupo(grupo);

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
        public JsonResult EliminarGrupo(int Id)
        {
            var data = objGrupoService.EliminarGrupo(Id);
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