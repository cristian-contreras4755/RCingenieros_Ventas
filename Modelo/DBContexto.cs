namespace Modelo
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBContexto : DbContext
    {
        public DBContexto()
            : base("name=DBContexto")
        {
        }

        public virtual DbSet<Area> Area { get; set; }
        public virtual DbSet<Grupo> Grupo { get; set; }
        public virtual DbSet<Cargo> Cargo { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<DetalleMovimiento> DetalleMovimiento { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<Movimiento> Movimiento { get; set; }
        public virtual DbSet<TipoCliente> TipoCliente { get; set; }
        public virtual DbSet<TipoMovimiento> TipoMovimiento { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Permiso> Permiso { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {



            modelBuilder.Entity<Grupo>()
            .HasMany(e => e.Cliente)
            .WithRequired(e => e.Grupo)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<Area>()
                .HasMany(e => e.Empleado)
                .WithRequired(e => e.Area)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cargo>()
                .HasMany(e => e.Empleado)
                .WithRequired(e => e.Cargo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.Movimiento)
                .WithRequired(e => e.Cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empleado>()
                .HasMany(e => e.Cliente)
                .WithRequired(e => e.Empleado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empleado>()
                .HasMany(e => e.Usuario)
                .WithRequired(e => e.Empleado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Movimiento>()
                .HasMany(e => e.DetalleMovimiento)
                .WithRequired(e => e.Movimiento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Permiso>()
                .HasMany(e => e.Rol)
                .WithMany(e => e.Permiso)
                .Map(m => m.ToTable("PermisoDenegadoPorRol").MapLeftKey("IdPermiso").MapRightKey("IdRol"));
        }
    }
}
