namespace Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBModelContext : DbContext
    {
        public DBModelContext()
            : base("name=DBModelContext")
        {
        }

        public virtual DbSet<Comprobante> Comprobante { get; set; }
        public virtual DbSet<DetalleProvicion> DetalleProvicion { get; set; }
        public virtual DbSet<Grupo> Grupo { get; set; }
        public virtual DbSet<Moneda> Moneda { get; set; }
        public virtual DbSet<OrdenCobro> OrdenCobro { get; set; }
        public virtual DbSet<ProvicionMensual> ProvicionMensual { get; set; }
        public virtual DbSet<PuntoVenta> PuntoVenta { get; set; }
        public virtual DbSet<Servicio> Servicio { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comprobante>()
                .Property(e => e.NombreComprobante)
                .IsUnicode(false);

            modelBuilder.Entity<Comprobante>()
                .Property(e => e.Estado)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Comprobante>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleProvicion>()
                .Property(e => e.Estado)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Grupo>()
                .Property(e => e.NombreGrupo)
                .IsUnicode(false);

            modelBuilder.Entity<Grupo>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Grupo>()
                .Property(e => e.TipoDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<Grupo>()
                .Property(e => e.NroDocumento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Grupo>()
                .Property(e => e.Estado)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Moneda>()
                .Property(e => e.NombreMoneda)
                .IsUnicode(false);

            modelBuilder.Entity<Moneda>()
                .Property(e => e.Simbolo)
                .IsUnicode(false);

            modelBuilder.Entity<Moneda>()
                .Property(e => e.Estado)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Moneda>()
                .HasMany(e => e.OrdenCobro)
                .WithRequired(e => e.Moneda)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrdenCobro>()
                .Property(e => e.DescuentoPorcentaje)
                .HasPrecision(3, 3);

            modelBuilder.Entity<OrdenCobro>()
                .Property(e => e.TipoDescuento)
                .IsUnicode(false);

            modelBuilder.Entity<OrdenCobro>()
                .Property(e => e.TipoCobro)
                .IsUnicode(false);

            modelBuilder.Entity<OrdenCobro>()
                .Property(e => e.Estado)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ProvicionMensual>()
                .Property(e => e.Estado)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ProvicionMensual>()
                .HasMany(e => e.DetalleProvicion)
                .WithRequired(e => e.ProvicionMensual)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PuntoVenta>()
                .Property(e => e.NombrePuntoVenta)
                .IsUnicode(false);

            modelBuilder.Entity<PuntoVenta>()
                .Property(e => e.RazonSocial)
                .IsUnicode(false);

            modelBuilder.Entity<PuntoVenta>()
                .Property(e => e.NombreComercial)
                .IsUnicode(false);

            modelBuilder.Entity<PuntoVenta>()
                .Property(e => e.TipoDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<PuntoVenta>()
                .Property(e => e.NroDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<PuntoVenta>()
                .Property(e => e.TipoNegocio)
                .IsUnicode(false);

            modelBuilder.Entity<PuntoVenta>()
                .Property(e => e.Departamento)
                .IsUnicode(false);

            modelBuilder.Entity<PuntoVenta>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<PuntoVenta>()
                .Property(e => e.Estado)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PuntoVenta>()
                .HasMany(e => e.ProvicionMensual)
                .WithRequired(e => e.PuntoVenta)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Servicio>()
                .Property(e => e.NombreServicio)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Servicio>()
                .Property(e => e.TipoServicio)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Servicio>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<Servicio>()
                .HasMany(e => e.OrdenCobro)
                .WithRequired(e => e.Servicio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.NombreUsuario)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Password)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.OrdenCobro)
                .WithRequired(e => e.Usuario)
                .WillCascadeOnDelete(false);
        }
    }
}
