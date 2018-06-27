namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PuntoVenta")]
    public partial class PuntoVenta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PuntoVenta()
        {
            ProvicionMensual = new HashSet<ProvicionMensual>();
        }

        [Key]
        public int IdPuntoVenta { get; set; }

        [StringLength(200)]
        public string NombrePuntoVenta { get; set; }

        [StringLength(200)]
        public string RazonSocial { get; set; }

        [StringLength(200)]
        public string NombreComercial { get; set; }

        public int? IdGrupo { get; set; }

        [StringLength(20)]
        public string TipoDocumento { get; set; }

        [StringLength(20)]
        public string NroDocumento { get; set; }

        [StringLength(20)]
        public string TipoNegocio { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FechaRegistro { get; set; }

        public bool? FacturacionIndividual { get; set; }

        public bool? FacturacionGrupal { get; set; }

        [StringLength(100)]
        public string Departamento { get; set; }

        [StringLength(200)]
        public string Direccion { get; set; }

        [StringLength(1)]
        public string Estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProvicionMensual> ProvicionMensual { get; set; }
    }
}
