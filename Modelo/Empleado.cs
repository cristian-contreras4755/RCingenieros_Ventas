namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Empleado")]
    public partial class Empleado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empleado()
        {
            Cliente = new HashSet<Cliente>();
            Usuario = new HashSet<Usuario>();
        }

        [Key]
        public int IdEmpleado { get; set; }

        public int IdArea { get; set; }

        public int IdCargo { get; set; }

        [Required]
        [StringLength(250)]
        public string NombreEmpleado { get; set; }

        [StringLength(50)]
        public string ApellidoP { get; set; }

        [StringLength(50)]
        public string ApellidoM { get; set; }

        [Required]
        [StringLength(50)]
        public string TipoDocumento { get; set; }

        [Required]
        [StringLength(20)]
        public string NroDocumento { get; set; }

        [StringLength(50)]
        public string EmailCorporativo { get; set; }

        [StringLength(50)]
        public string EmailPersonal { get; set; }

        [StringLength(20)]
        public string NroTelfPersonal { get; set; }

        [StringLength(20)]
        public string NroTelfCorporativo { get; set; }

        [Required]
        [StringLength(1)]
        public string Estado { get; set; }

        public virtual Area Area { get; set; }

        public virtual Cargo Cargo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cliente> Cliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
