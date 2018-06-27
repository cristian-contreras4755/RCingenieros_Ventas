namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Comprobante")]
    public partial class Comprobante
    {
        [Key]
        public int IdComprobante { get; set; }

        [StringLength(50)]
        public string NombreComprobante { get; set; }

        [StringLength(1)]
        public string Estado { get; set; }

        [StringLength(10)]
        public string Codigo { get; set; }
    }
}
