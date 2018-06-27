namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cliente")]
    public partial class Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cliente()
        {
            Movimiento = new HashSet<Movimiento>();
        }

        [Key]
        public int Idcliente { get; set; }

        [StringLength(200)]
        public string NombreComercial { get; set; }

        [StringLength(200)]
        public string RazonSocial { get; set; }

        public string Ruc { get; set; }

        [Required]
        [StringLength(50)]
        public string departamento { get; set; }

        [Required]
        [StringLength(50)]
        public string Provincia { get; set; }

        [Required]
        [StringLength(50)]
        public string Distrito { get; set; }

        [Required]
        [StringLength(200)]
        public string Direccion { get; set; }

        public int? IdTipoCliente { get; set; }

        public int? IdGrupo { get; set; }




        [StringLength(100)]
        public string NombreContacto1 { get; set; }
        [StringLength(100)]
        public string NombreContacto2 { get; set; }
        [StringLength(100)]
        public string NombreContacto3 { get; set; }
        [StringLength(100)]
        public string NroContacto1 { get; set; }
        [StringLength(100)]
        public string NroContacto2 { get; set; }
        [StringLength(100)]
        public string NroContacto3 { get; set; }
        [StringLength(100)]
        public string EmailContacto1 { get; set; }
        [StringLength(100)]
        public string EmailContacto2 { get; set; }
        [StringLength(100)]
        public string EmailContacto3 { get; set; }
        public int IdEmpleado { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FechaSunat { get; set; }

        [StringLength(1)]
        public string Estado { get; set; }

        public virtual Empleado Empleado { get; set; }

        public virtual Grupo Grupo { get; set; }

        public virtual TipoCliente TipoCliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Movimiento> Movimiento { get; set; }
    }
}
