namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TipoMovimiento")]
    public partial class TipoMovimiento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoMovimiento()
        {
            DetalleMovimiento = new HashSet<DetalleMovimiento>();
        }

        [Key]
        public int IdTipoMovimiento { get; set; }

        [StringLength(200)]
        public string NombreMovimiento { get; set; }

        [StringLength(1000)]
        public string DescripcionMovimiento { get; set; }

        [StringLength(1)]
        public string Estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleMovimiento> DetalleMovimiento { get; set; }
    }
}
