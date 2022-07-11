using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace AZSAPI.Models
{
    public partial class AZS2Context : DbContext
    {
        public AZS2Context()
        {
        }

        public AZS2Context(DbContextOptions<AZS2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Datum> Data { get; set; }
        public virtual DbSet<Refill> Refills { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<Datum>(entity =>
            {
                entity.HasKey(e => e.StationId)
                    .HasName("PK__DATA__55F200EE73F70189");

                entity.ToTable("DATA");

                entity.Property(e => e.StationId).HasColumnName("Station_ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(3, 2)");

                entity.Property(e => e.RefillId).HasColumnName("Refill_ID");
            });

            modelBuilder.Entity<Refill>(entity =>
            {
                entity.HasKey(e => e.IdRefill)
                    .HasName("PK__Refill__4D4802F23671D3CF");

                entity.ToTable("Refill");

                entity.Property(e => e.IdRefill).HasColumnName("ID_Refill");

                entity.Property(e => e.Adress)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
