namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Moneda")]
    public partial class Moneda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Moneda()
        {
            OrdenCobro = new HashSet<OrdenCobro>();
        }

        [Key]
        public int IdMoneda { get; set; }

        [StringLength(50)]
        public string NombreMoneda { get; set; }

        [StringLength(20)]
        public string Simbolo { get; set; }

        [StringLength(1)]
        public string Estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdenCobro> OrdenCobro { get; set; }
    }
}
