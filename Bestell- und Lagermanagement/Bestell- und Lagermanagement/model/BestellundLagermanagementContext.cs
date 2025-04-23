using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Bestell__und_Lagermanagement.model
{
    public partial class BestellundLagermanagementContext : DbContext
    {
        public BestellundLagermanagementContext()
        {
        }

        public BestellundLagermanagementContext(DbContextOptions<BestellundLagermanagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bestellung> Bestellung { get; set; } = null!;
        public virtual DbSet<Lieferanten> Lieferanten { get; set; } = null!;
        public virtual DbSet<Materiallager> Materiallager { get; set; } = null!;
        public virtual DbSet<Mitarbeiterprofil> Mitarbeiterprofil { get; set; } = null!;
        public virtual DbSet<Verzeichnis> Verzeichnis { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP\\MYSQLSERVER;Initial Catalog=BestellundLagermanagement;Integrated Security=SSPI");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bestellung>(entity =>
            {
                entity.HasKey(e => e.Bestellnummer)
                    .HasName("PK__Bestellu__661AA2E3C62B1A3E");

                entity.Property(e => e.Bestellnummer).ValueGeneratedNever();

                entity.Property(e => e.BestellStatus).HasMaxLength(100);

                entity.Property(e => e.Bestelldatum).HasMaxLength(100);

                entity.Property(e => e.BestellungBezeichung).HasMaxLength(100);

                entity.Property(e => e.Lagerort).HasMaxLength(100);
            });

            modelBuilder.Entity<Lieferanten>(entity =>
            {
                entity.HasKey(e => e.Lieferantennummer)
                    .HasName("PK__Lieferan__BB5D23C8CC8C9B21");

                entity.Property(e => e.Lieferantennummer).ValueGeneratedNever();

                entity.Property(e => e.FirmenSitze).HasMaxLength(100);

                entity.Property(e => e.FrimenName).HasMaxLength(100);

                entity.Property(e => e.Lieferzeit).HasMaxLength(100);

                entity.Property(e => e.Preis).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.WelcheWarensindverfuegbar).HasMaxLength(100);
            });

            modelBuilder.Entity<Materiallager>(entity =>
            {
                entity.HasKey(e => e.Lagernummer)
                    .HasName("PK__Material__C0D28206B9504440");

                entity.Property(e => e.Lagernummer).ValueGeneratedNever();

                entity.Property(e => e.Breite).HasMaxLength(100);

                entity.Property(e => e.Hoehe).HasMaxLength(100);

                entity.Property(e => e.Laenge).HasMaxLength(100);

                entity.Property(e => e.Lagerort).HasMaxLength(100);

                entity.Property(e => e.MaterialWarenbezeichnung).HasMaxLength(100);
            });

            modelBuilder.Entity<Mitarbeiterprofil>(entity =>
            {
                entity.HasKey(e => e.Mitarbeiternummer)
                    .HasName("PK__Mitarbei__AAE5BB5B5826C6B1");

                entity.Property(e => e.Mitarbeiternummer).ValueGeneratedNever();

                entity.Property(e => e.Benutzername).HasMaxLength(100);

                entity.Property(e => e.Diensthandy).HasMaxLength(100);

                entity.Property(e => e.EMail)
                    .HasMaxLength(100)
                    .HasColumnName("E_Mail");

                entity.Property(e => e.Nachname).HasMaxLength(100);

                entity.Property(e => e.Passwort).HasMaxLength(500);

                entity.Property(e => e.Telefon).HasMaxLength(100);

                entity.Property(e => e.Vorname).HasMaxLength(100);
            });

            modelBuilder.Entity<Verzeichnis>(entity =>
            {
                entity.HasKey(e => new { e.VerzeichnisId, e.Verwaltungsnummrer })
                    .HasName("pk_VerzeichnisID");

                entity.Property(e => e.VerzeichnisId).HasColumnName("VerzeichnisID");

                entity.Property(e => e.Verwaltungsnummrer).HasColumnName("verwaltungsnummrer");

                entity.Property(e => e.Lagerort).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
