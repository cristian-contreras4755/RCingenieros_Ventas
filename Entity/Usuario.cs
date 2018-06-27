namespace Entity
{
    using Helper;
    using System;
    using System.Linq;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;



    [Table("Usuario")]
    public partial class Usuario
    {
        public int id { get; set; }

        public int Rol_id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string Correo { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        public int? IdPersona { get; set; }

        public bool? Estado { get; set; }

        public virtual Rol Rol { get; set; }








        public ResponseModel Autenticarse()
        {
            var rm = new ResponseModel();

            try
            {
                using (var ctx = new DBModelContext())
                {
                    var usuario = ctx.Usuario.Where(x => x.Correo == this.Correo && x.Password == this.Password).SingleOrDefault();
                    if (usuario != null)
                    {
                        SessionHelper.AddUserToSession(usuario.id.ToString());
                        rm.SetResponse(true);
                    }
                    else
                    {
                        rm.SetResponse(false, "Acceso denegado al sistema");
                    }
                }
            }
            catch (Exception e)
            {
                throw;
            }
            return rm;
        }

        public Usuario Obtener(int id)
        {
            var usuario = new Usuario();

            try
            {
                using (var ctx = new DBModelContext())
                {
                    ctx.Configuration.LazyLoadingEnabled = false;

                    usuario = ctx.Usuario.Include("Rol")
                                         .Include("Rol.Permiso")
                                         .Where(x => x.id == id).SingleOrDefault();
                }
            }
            catch (Exception e)
            {
                throw;
            }

            return usuario;
        }


    }
}
