using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper;
using Modelo;
using Services.Procedimientos;

namespace Services.CommonServices
{
  public  class FrontUser
    {

        public static bool TienePermiso(RolesPermisos valor)
        {
            var usuario = FrontUser.Get();
            return !usuario.Rol.Permiso.Where(x => x.IdPermiso.Equals(valor)).Any();
        }


        public static Usuario Get()
        {
            return new UsuarioService().ObtenerUsuario(SessionHelper.GetUser());
        }


        public static SP_ObtenerDatosUsuarioLogin obtenerDatosUsuarioLogueado()
        {

            return new UsuarioService().ObtenerDatosDeUsuario(SessionHelper.GetUser());
        }


    }
}
