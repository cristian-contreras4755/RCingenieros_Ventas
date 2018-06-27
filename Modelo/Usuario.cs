namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Usuario")]
    public partial class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }

        public int IdEmpleado { get; set; }

        [Required]
        [StringLength(100)]
        public string UsuarioLogin { get; set; }

        [Required]
        [StringLength(100)]
        public string Password { get; set; }

        public bool Bloqueado { get; set; }

        public int? IdRol { get; set; }

        public virtual Empleado Empleado { get; set; }

        public virtual Rol Rol { get; set; }
    }
}
