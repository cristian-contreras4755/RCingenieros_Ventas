namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DetalleProvicion")]
    public partial class DetalleProvicion
    {
        [Key]
        public int IdDetalleProvicion { get; set; }

        public int IdRegistroMensual { get; set; }

        public int IdComprobante { get; set; }

        public int? TotalMensual { get; set; }

        [StringLength(1)]
        public string Estado { get; set; }

        public virtual ProvicionMensual ProvicionMensual { get; set; }
    }
}
