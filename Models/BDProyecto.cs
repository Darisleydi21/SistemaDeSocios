using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CapaPresentacion.Models
{
    public partial class BDProyecto : DbContext
    {
        public BDProyecto()
            : base("name=BDProyecto")
        {
        }

        public virtual DbSet<Socios> Socios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Socios>()
                .Property(e => e.NombreSocio)
                .IsUnicode(false);

            modelBuilder.Entity<Socios>()
                .Property(e => e.CedulaSocio)
                .IsUnicode(false);

            modelBuilder.Entity<Socios>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Socios>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Socios>()
                .Property(e => e.TipoMembresia)
                .IsUnicode(false);

            modelBuilder.Entity<Socios>()
                .Property(e => e.NombreContacto)
                .IsUnicode(false);

            modelBuilder.Entity<Socios>()
                .Property(e => e.TelefonoContacto)
                .IsUnicode(false);
        }
    }
}
