using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Helper;
using Services.Procedimientos;
using System.Data.SqlClient;

namespace Services
{
   public class UsuarioService
    {



        public ResponseModel AutenticarUsuario(string usuarioLogin ,string Password) {

            var rm = new ResponseModel();

            try
            {
                using (var ctx=new DBContexto()) {

                    Password = HashHelper.MD5(Password);
                    var usuario = ctx.Usuario.Where(x => x.UsuarioLogin == usuarioLogin).Where(x => x.Password == Password).SingleOrDefault();


                    if (usuario != null)
                    {

                        SessionHelper.AddUserToSession(usuario.IdUsuario.ToString());
                        rm.SetResponse(true);

                    }
                    else {

                        rm.SetResponse(false,"Usuario o Contraseña Invalidos Intentelo nuevamente!");

                    }
                }


            }
            catch (Exception)
            {

                throw;
            }
            return rm;
        }




        public  string  AutenticacionPersonalizada(string usuarioLogin, string Password) {

            var estado = "";
            try
            {

                using ( var ctx=new DBContexto()) {

                    Password = HashHelper.MD5(Password);
                    var usuario = ctx.Usuario.Where(x => x.UsuarioLogin == usuarioLogin).Where(x => x.Password == Password).SingleOrDefault();


                    if (usuario != null)
                    {
                        SessionHelper.AddUserToSession(usuario.IdUsuario.ToString());
                        estado = "OK";
                    }
                    else
                    {
                        estado="Usuario o Contraseña Invalidos Intentelo nuevamente!";
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return estado;

        }













        public Usuario ObtenerUsuario(int id)
        {
            var usuario = new Usuario();

            try
            {
                using (var ctx = new DBContexto())
                {
                    ctx.Configuration.LazyLoadingEnabled = false;
                    usuario = ctx.Usuario.Include("Rol")
                                         .Include("Rol.Permiso")
                                         .Where(x => x.IdUsuario == id).SingleOrDefault();
                }
            }
            catch (Exception e)
            {
                throw;
            }

            return usuario;
        }





        public SP_ObtenerDatosUsuarioLogin ObtenerDatosDeUsuario(int IdUsuario)
        {

           

                using (var ctx = new DBContexto())
                {
                var UsuarioLogin = new SP_ObtenerDatosUsuarioLogin();
                UsuarioLogin = ctx.Database.SqlQuery<SP_ObtenerDatosUsuarioLogin>("SP_ObtenerDatosUsuarioLogin @IdUsuario", new SqlParameter("@IdUsuario", IdUsuario)).First();

                return UsuarioLogin;
            }

        }









    }


}
