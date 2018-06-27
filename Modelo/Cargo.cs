namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cargo")]
    public partial class Cargo
    {
     
        public Cargo()
        {
            Empleado = new HashSet<Empleado>();
        }

        [Key]
        public int IdCargo { get; set; }

        [Required]
        [StringLength(100)]
        public string NombreCargo { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(1)]
        public string Estado { get; set; }


        public virtual ICollection<Empleado> Empleado { get; set; }
    }
}
