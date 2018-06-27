namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Movimiento")]
    public partial class Movimiento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Movimiento()
        {
            DetalleMovimiento = new HashSet<DetalleMovimiento>();
        }

        [Key]
        public int IdMovimiento { get; set; }

        public int Idcliente { get; set; }

        public int IdEmpleado { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FechaMovimiento { get; set; }

        [StringLength(1)]
        public string Estado { get; set; }

        public virtual Cliente Cliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleMovimiento> DetalleMovimiento { get; set; }
    }
}
