using Helper;
using Modelo;
using RCingenierosApuControl.ViewModels;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static RCingenierosApuControl.Tags.AutenticadoAtrribute;

namespace RCingenierosApuControl.Controllers
{
 
    public class SeguridadController : Controller
    {

        private UsuarioService ObjUsuarioService = new UsuarioService();
        private Usuario   ObjUsuario = new Usuario();

        // GET: Seguridad
        [NoLoginAttribute]
        public ActionResult Login()
        {
            return View();
        }

        [NoLoginAttribute]
        [HttpPost]
        public JsonResult AutenticacionUsuario(LoginViewModel model)
        {
            var Estado = "";
            var ValidaLogin = "";

            ValidaLogin = ObjUsuarioService.AutenticacionPersonalizada(model.UsuarioLogin, model.Password);
                if (ValidaLogin == "OK")
                {
                Estado = "OK";

                 }   
                else
                {
               Estado = "Error Usuario Contraseña invalida!";
                   
                }

            return Json(Estado);
        }



        [AutenticadoAttribute]
        public ActionResult CerrarSession() {
            SessionHelper.DestroyUserSession();
            return Redirect("~/Seguridad/Login");
        }
    }
}