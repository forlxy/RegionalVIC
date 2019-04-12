using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RegionalVIC.Models.DB
{
    public partial class regionalVICContext : DbContext
    {
        public regionalVICContext()
        {
        }

        public regionalVICContext(DbContextOptions<regionalVICContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Critbl> Critbl { get; set; }
        public virtual DbSet<Lgamas> Lgamas { get; set; }
        public virtual DbSet<Lgatbl> Lgatbl { get; set; }
        public virtual DbSet<Ppltbl> Ppltbl { get; set; }
        public virtual DbSet<Regmas> Regmas { get; set; }
        public virtual DbSet<Rtrtbl> Rtrtbl { get; set; }
        public virtual DbSet<Sbbmas> Sbbmas { get; set; }
        public virtual DbSet<Sttmas> Sttmas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:regionalvic.database.windows.net,1433;Initial Catalog=regionalVIC;Persist Security Info=False;User ID=vic_web;Password=b@55m0rp12E;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Critbl>(entity =>
            {
                entity.HasKey(e => new { e.LgaCode, e.YrEnd });

                entity.ToTable("CRITBL");

                entity.Property(e => e.LgaCode)
                    .HasColumnName("LGA_code")
                    .HasMaxLength(5);

                entity.Property(e => e.YrEnd).HasColumnName("yr_end");

                entity.Property(e => e.IncdRcd).HasColumnName("incd_rcd");

                entity.Property(e => e.PolRegion)
                    .HasColumnName("pol_region")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rate)
                    .HasColumnName("rate")
                    .HasColumnType("decimal(18, 9)");

                entity.Property(e => e.RatePerPpl)
                    .HasColumnName("rate_per_ppl")
                    .HasColumnType("decimal(18, 6)");

                entity.HasOne(d => d.LgaCodeNavigation)
                    .WithMany(p => p.Critbl)
                    .HasForeignKey(d => d.LgaCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CRITBL_LGAMAS");
            });

            modelBuilder.Entity<Lgamas>(entity =>
            {
                entity.HasKey(e => e.LgaCode);

                entity.ToTable("LGAMAS");

                entity.Property(e => e.LgaCode)
                    .HasColumnName("LGA_code")
                    .HasMaxLength(5)
                    .ValueGeneratedNever();

                entity.Property(e => e.LgaArea)
                    .HasColumnName("LGA_area")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.LgaBdesc)
                    .HasColumnName("LGA_bdesc")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LgaDesc)
                    .HasColumnName("LGA_desc")
                    .HasColumnType("varchar(MAX)")
                    //.HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LgaName)
                    .HasColumnName("LGA_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnName("state")
                    .HasMaxLength(3)
                    .HasDefaultValueSql("('XXX')");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('A')");
            });

            modelBuilder.Entity<Lgatbl>(entity =>
            {
                entity.HasKey(e => e.LgaCode);

                entity.ToTable("LGATBL");

                entity.Property(e => e.LgaCode)
                    .HasColumnName("LGA_code")
                    .HasMaxLength(5)
                    .ValueGeneratedNever();

                entity.Property(e => e.LgaName)
                    .HasColumnName("LGA_name")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NameCrime)
                    .HasColumnName("name_crime")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NameRent)
                    .HasColumnName("name_rent")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Region)
                    .HasColumnName("region")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('A')");
            });

            modelBuilder.Entity<Ppltbl>(entity =>
            {
                entity.HasKey(e => new { e.Yr, e.LgaCode });

                entity.ToTable("PPLTBL");

                entity.Property(e => e.Yr).HasColumnName("yr");

                entity.Property(e => e.LgaCode)
                    .HasColumnName("LGA_code")
                    .HasMaxLength(5)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Density)
                    .HasColumnName("density")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Popul).HasColumnName("popul");
            });

            modelBuilder.Entity<Regmas>(entity =>
            {
                entity.HasKey(e => e.Seq);

                entity.ToTable("REGMAS");

                entity.Property(e => e.Seq).HasColumnName("seq");

                entity.Property(e => e.Lvl).HasColumnName("lvl");

                entity.Property(e => e.Parent).HasColumnName("parent");

                entity.Property(e => e.RegAlt1)
                    .HasColumnName("reg_alt_1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegName)
                    .HasColumnName("reg_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnName("state")
                    .HasMaxLength(3)
                    .HasDefaultValueSql("(N'XXX')");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('A')");
            });

            modelBuilder.Entity<Rtrtbl>(entity =>
            {
                entity.HasKey(e => e.Seq);

                entity.ToTable("RTRTBL");

                entity.Property(e => e.Seq).HasColumnName("seq");

                entity.Property(e => e.Count)
                    .HasColumnName("count")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LgaCode)
                    .IsRequired()
                    .HasColumnName("LGA_code")
                    .HasMaxLength(5)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Median)
                    .HasColumnName("median")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Mth)
                    .IsRequired()
                    .HasColumnName("mth")
                    .HasMaxLength(3)
                    .HasDefaultValueSql("(N'XXX')");

                entity.Property(e => e.NoOfBedrm)
                    .HasColumnName("no_of_bedrm")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Quarter).HasColumnName("quarter");

                entity.Property(e => e.Region)
                    .HasColumnName("region")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Typ)
                    .HasColumnName("typ")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Yr).HasColumnName("yr");
            });

            modelBuilder.Entity<Sbbmas>(entity =>
            {
                entity.HasKey(e => e.Seq);

                entity.ToTable("SBBMAS");

                entity.Property(e => e.Seq).HasColumnName("seq");

                entity.Property(e => e.Area)
                    .HasColumnName("area")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostCode)
                    .IsRequired()
                    .HasColumnName("post_code")
                    .HasMaxLength(4);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnName("state")
                    .HasMaxLength(3)
                    .HasDefaultValueSql("(N'VIC')");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<Sttmas>(entity =>
            {
                entity.HasKey(e => e.StateCode);

                entity.ToTable("STTMAS");

                entity.Property(e => e.StateCode)
                    .HasColumnName("state_code")
                    .HasMaxLength(3)
                    .ValueGeneratedNever();

                entity.Property(e => e.AreaCode)
                    .HasColumnName("area_code")
                    .HasMaxLength(2);

                entity.Property(e => e.Capital)
                    .HasColumnName("capital")
                    .HasMaxLength(50);

                entity.Property(e => e.StateName)
                    .HasColumnName("state_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('A')");
            });
        }
    }
}
