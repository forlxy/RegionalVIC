using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RegionalVIC.Models.DB
{
    public partial class RegionalVICContext : DbContext
    {
        public RegionalVICContext()
      
        {
        }

        public RegionalVICContext(DbContextOptions<RegionalVICContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cmmtbl> Cmmtbl { get; set; }
        public virtual DbSet<Cobmas> Cobmas { get; set; }
        public virtual DbSet<Cobtbl> Cobtbl { get; set; }
        public virtual DbSet<Critbl> Critbl { get; set; }
        public virtual DbSet<Idsmas> Idsmas { get; set; }
        public virtual DbSet<Inctbl> Inctbl { get; set; }
        public virtual DbSet<Lgamas> Lgamas { get; set; }
        public virtual DbSet<Lgatbl> Lgatbl { get; set; }
        public virtual DbSet<Lggmas> Lggmas { get; set; }
        public virtual DbSet<Lggtbl> Lggtbl { get; set; }
        public virtual DbSet<Nbitbl> Nbitbl { get; set; }
        public virtual DbSet<Poetbl> Poetbl { get; set; }
        public virtual DbSet<Ppltbl> Ppltbl { get; set; }
        public virtual DbSet<Regmas> Regmas { get; set; }
        public virtual DbSet<Rtrtbl> Rtrtbl { get; set; }
        public virtual DbSet<Sbbmas> Sbbmas { get; set; }
        public virtual DbSet<Sttmas> Sttmas { get; set; }
        public virtual DbSet<Ueptbl> Ueptbl { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
             //  optionsBuilder.UseSqlServer("Server=tcp:regionalvic.database.windows.net,1433;Initial Catalog=regionalVIC;Persist Security Info=False;User ID=vic_web;Password=b@55m0rp12E;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
           //    optionsBuilder.UseSqlServer("Server=tcp:regionaldb.ccpxedmwa2fo.ap-southeast-2.rds.amazonaws.com,2912;Initial Catalog=regionaldb;Persist Security Info=False;User ID=admin;Password=11111111;Connection Timeout=30");

                optionsBuilder.UseSqlServer("Server=regionaldb.ccpxedmwa2fo.ap-southeast-2.rds.amazonaws.com,2912;Initial Catalog=regionaldb;Persist Security Info=False;User ID=admin;Password=11111111;Connection Timeout=30");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cmmtbl>(entity =>
            {
                entity.HasKey(e => new { e.Yr, e.LgaCode, e.CobCode });

                entity.Property(e => e.Suburbs).IsUnicode(false);

                entity.HasOne(d => d.CobCodeNavigation)
                    .WithMany(p => p.Cmmtbl)
                    .HasForeignKey(d => d.CobCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMMTBL_COBMAS");

                entity.HasOne(d => d.LgaCodeNavigation)
                    .WithMany(p => p.Cmmtbl)
                    .HasForeignKey(d => d.LgaCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMMTBL_LGAMAS");
            });

            modelBuilder.Entity<Cobmas>(entity =>
            {
                entity.Property(e => e.Cob).IsUnicode(false);
            });

            modelBuilder.Entity<Cobtbl>(entity =>
            {
                entity.HasKey(e => new { e.Yr, e.LgaCode, e.Cob });

                entity.HasOne(d => d.CobNavigation)
                    .WithMany(p => p.Cobtbl)
                    .HasForeignKey(d => d.Cob)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COBTBL_COBMAS");

                entity.HasOne(d => d.LgaCodeNavigation)
                    .WithMany(p => p.Cobtbl)
                    .HasForeignKey(d => d.LgaCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COBTBL_LGAMAS");
            });

            modelBuilder.Entity<Critbl>(entity =>
            {
                entity.HasKey(e => new { e.LgaCode, e.YrEnd });

                entity.Property(e => e.PolRegion).IsUnicode(false);

                entity.HasOne(d => d.LgaCodeNavigation)
                    .WithMany(p => p.Critbl)
                    .HasForeignKey(d => d.LgaCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CRITBL_LGAMAS");
            });

            modelBuilder.Entity<Idsmas>(entity =>
            {
                entity.Property(e => e.IdsCode).ValueGeneratedNever();

                entity.Property(e => e.IdsName).IsUnicode(false);
            });

            modelBuilder.Entity<Inctbl>(entity =>
            {
                entity.HasKey(e => new { e.Yr, e.LgaCode });

                entity.HasOne(d => d.LgaCodeNavigation)
                    .WithMany(p => p.Inctbl)
                    .HasForeignKey(d => d.LgaCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INCTBL_LGAMAS");
            });

            modelBuilder.Entity<Lgamas>(entity =>
            {
                entity.Property(e => e.LgaCode).ValueGeneratedNever();

                entity.Property(e => e.LgaBdesc).IsUnicode(false);

                entity.Property(e => e.LgaDesc).IsUnicode(false);

                entity.Property(e => e.LgaImage).IsUnicode(false);

                entity.Property(e => e.LgaName).IsUnicode(false);

                entity.Property(e => e.LgaRef).IsUnicode(false);

                entity.Property(e => e.LgaVideo).IsUnicode(false);

                entity.HasOne(d => d.StateNavigation)
                    .WithMany(p => p.Lgamas)
                    .HasForeignKey(d => d.State)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LGAMAS_STTMAS");
            });

            modelBuilder.Entity<Lgatbl>(entity =>
            {
                entity.Property(e => e.LgaCode).ValueGeneratedNever();

                entity.Property(e => e.LgaName).IsUnicode(false);

                entity.Property(e => e.NameCrime).IsUnicode(false);

                entity.Property(e => e.NameRent).IsUnicode(false);

                entity.Property(e => e.Region).IsUnicode(false);

                entity.HasOne(d => d.LgaCodeNavigation)
                    .WithOne(p => p.Lgatbl)
                    .HasForeignKey<Lgatbl>(d => d.LgaCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LGATBL_LGAMAS");
            });

            modelBuilder.Entity<Lggmas>(entity =>
            {
                entity.Property(e => e.Language).IsUnicode(false);
            });

            modelBuilder.Entity<Lggtbl>(entity =>
            {
                entity.HasKey(e => new { e.Yr, e.LgaCode, e.LangCode });

                entity.HasOne(d => d.LangCodeNavigation)
                    .WithMany(p => p.Lggtbl)
                    .HasForeignKey(d => d.LangCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LGGTBL_LGGMAS");

                entity.HasOne(d => d.LgaCodeNavigation)
                    .WithMany(p => p.Lggtbl)
                    .HasForeignKey(d => d.LgaCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LGGTBL_LGAMAS");
            });

            modelBuilder.Entity<Nbitbl>(entity =>
            {
                entity.HasKey(e => new { e.Yr, e.LgaCode, e.IdsCode });

                entity.HasOne(d => d.IdsCodeNavigation)
                    .WithMany(p => p.Nbitbl)
                    .HasForeignKey(d => d.IdsCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NBITBL_IDSMAS");

                entity.HasOne(d => d.LgaCodeNavigation)
                    .WithMany(p => p.Nbitbl)
                    .HasForeignKey(d => d.LgaCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NBITBL_LGAMAS");
            });

            modelBuilder.Entity<Poetbl>(entity =>
            {
                entity.HasKey(e => new { e.Yr, e.LgaCode, e.IdsCode });

                entity.HasOne(d => d.IdsCodeNavigation)
                    .WithMany(p => p.Poetbl)
                    .HasForeignKey(d => d.IdsCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_POETBL_IDSMAS");

                entity.HasOne(d => d.LgaCodeNavigation)
                    .WithMany(p => p.Poetbl)
                    .HasForeignKey(d => d.LgaCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_POETBL_LGAMAS");
            });

            modelBuilder.Entity<Ppltbl>(entity =>
            {
                entity.HasKey(e => new { e.Yr, e.LgaCode });

                entity.HasOne(d => d.LgaCodeNavigation)
                    .WithMany(p => p.Ppltbl)
                    .HasForeignKey(d => d.LgaCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PPLTBL_LGAMAS");
            });

            modelBuilder.Entity<Regmas>(entity =>
            {
                entity.Property(e => e.RegAlt1).IsUnicode(false);

                entity.Property(e => e.RegName).IsUnicode(false);

                entity.HasOne(d => d.StateNavigation)
                    .WithMany(p => p.Regmas)
                    .HasForeignKey(d => d.State)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_REGMAS_STTMAS");
            });

            modelBuilder.Entity<Rtrtbl>(entity =>
            {
                entity.Property(e => e.Region).IsUnicode(false);

                entity.Property(e => e.Typ).IsUnicode(false);

                entity.HasOne(d => d.LgaCodeNavigation)
                    .WithMany(p => p.Rtrtbl)
                    .HasForeignKey(d => d.LgaCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RTRTBL_LGAMAS");
            });

            modelBuilder.Entity<Sbbmas>(entity =>
            {
                entity.Property(e => e.Area).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.HasOne(d => d.StateNavigation)
                    .WithMany(p => p.Sbbmas)
                    .HasForeignKey(d => d.State)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SBBMAS_STTMAS");
            });

            modelBuilder.Entity<Sttmas>(entity =>
            {
                entity.Property(e => e.StateCode).ValueGeneratedNever();

                entity.Property(e => e.StateName).IsUnicode(false);
            });

            modelBuilder.Entity<Ueptbl>(entity =>
            {
                entity.HasKey(e => new { e.Yr, e.LgaCode });

                entity.HasOne(d => d.LgaCodeNavigation)
                    .WithMany(p => p.Ueptbl)
                    .HasForeignKey(d => d.LgaCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UEPTBL_LGAMAS");
            });
        }
    }
}
