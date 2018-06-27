namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DetalleMovimiento")]
    public partial class DetalleMovimiento
    {
        [Key]
        public int IdDetalleMovimiento { get; set; }

        public int IdMovimiento { get; set; }

        public int? IdTipoMovimiento { get; set; }

        [StringLength(1000)]
        public string Descripcion { get; set; }

        [StringLength(1000)]
        public string Logros { get; set; }

        [StringLength(5)]
        public string Estado { get; set; }

        public virtual Movimiento Movimiento { get; set; }

        public virtual TipoMovimiento TipoMovimiento { get; set; }
    }
}
