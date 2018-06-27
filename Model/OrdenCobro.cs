namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrdenCobro")]
    public partial class OrdenCobro
    {
        public int IdServicio { get; set; }

        [Key]
        public int IdOrdenCobro { get; set; }

        public int IdUsuario { get; set; }

        public decimal? DescuentoPorcentaje { get; set; }

        [StringLength(20)]
        public string TipoDescuento { get; set; }

        [StringLength(50)]
        public string TipoCobro { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FechaGeneracion { get; set; }

        public int IdMoneda { get; set; }

        public int? Mes { get; set; }

        public int? TotalDocEmitido { get; set; }

        [StringLength(1)]
        public string Estado { get; set; }

        public virtual Moneda Moneda { get; set; }

        public virtual Servicio Servicio { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
