namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Grupo")]
    public partial class Grupo
    {
        [Key]
        public int IdGrupo { get; set; }

        [StringLength(100)]
        public string NombreGrupo { get; set; }

        [StringLength(200)]
        public string Descripcion { get; set; }

        [StringLength(50)]
        public string TipoDocumento { get; set; }

        [StringLength(20)]
        public string NroDocumento { get; set; }

        [StringLength(1)]
        public string Estado { get; set; }
    }
}
