
using Services.CommonServices;
using System.Web.Mvc;
using System.Web.Routing;

namespace RCingenierosApuControl.Tags
{
    public class PermisoAttribute:ActionFilterAttribute
    {
            public RolesPermisos Permiso { get; set; }
            public override void OnActionExecuting(ActionExecutingContext filterContext)
            {
                base.OnActionExecuting(filterContext);

                if (!FrontUser.TienePermiso(this.Permiso))
                {
                    filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new
                    {
                        controller = "Home",
                        action = "Index"
                    }));
                }
            }
     
    }
}