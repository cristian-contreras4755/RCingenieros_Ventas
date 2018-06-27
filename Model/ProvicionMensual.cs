namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProvicionMensual")]
    public partial class ProvicionMensual
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProvicionMensual()
        {
            DetalleProvicion = new HashSet<DetalleProvicion>();
        }

        [Key]
        public int IdRegistroMensual { get; set; }

        public int? MesProvicion { get; set; }

        public int IdPuntoVenta { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FechaRegistro { get; set; }

        public int? TotalComprobantes { get; set; }

        [StringLength(1)]
        public string Estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleProvicion> DetalleProvicion { get; set; }

        public virtual PuntoVenta PuntoVenta { get; set; }
    }
}
