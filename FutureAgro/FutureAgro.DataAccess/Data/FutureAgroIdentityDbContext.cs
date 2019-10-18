using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using FutureAgro.DataAccess.Models;

namespace FutureAgro.DataAccess.Data
{
    public partial class FutureAgroIdentityDbContext : DbContext
    {
        public FutureAgroIdentityDbContext()
        {
        }

        public FutureAgroIdentityDbContext(DbContextOptions<FutureAgroIdentityDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<Boundary> Boundary { get; set; }
        public virtual DbSet<Crop> Crop { get; set; }
        public virtual DbSet<Growth> Growth { get; set; }
        public virtual DbSet<Measure> Measure { get; set; }
        public virtual DbSet<MeasureType> MeasureType { get; set; }
        public virtual DbSet<Plant> Plant { get; set; }
        public virtual DbSet<PlantType> PlantType { get; set; }
        public virtual DbSet<Tray> Tray { get; set; }
        public virtual DbSet<TrayXcrop> TrayXcrop { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:futureagrosqlsvr.database.windows.net,1433;Initial Catalog=FutureAgroSQL;Persist Security Info=False;User ID=futureagro;Password=$us3rdb54321;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Boundary>(entity =>
            {
                entity.Property(e => e.MaxDo).HasColumnName("MaxDO");

                entity.Property(e => e.MaxEc).HasColumnName("MaxEC");

                entity.Property(e => e.MaxOrp).HasColumnName("MaxORP");

                entity.Property(e => e.MaxPh)
                    .HasColumnName("MaxPH")
                    .HasColumnType("decimal(3, 1)");

                entity.Property(e => e.MinDo).HasColumnName("MinDO");

                entity.Property(e => e.MinEc).HasColumnName("MinEC");

                entity.Property(e => e.MinOrp).HasColumnName("MinORP");

                entity.Property(e => e.MinPh)
                    .HasColumnName("MinPH")
                    .HasColumnType("decimal(3, 1)");

                entity.Property(e => e.OptDo).HasColumnName("OptDO");

                entity.Property(e => e.OptEc).HasColumnName("OptEC");

                entity.Property(e => e.OptOrp).HasColumnName("OptORP");

                entity.Property(e => e.OptPh)
                    .HasColumnName("OptPH")
                    .HasColumnType("decimal(3, 1)");

                entity.Property(e => e.UnitDo)
                    .HasColumnName("UnitDO")
                    .HasMaxLength(5);

                entity.Property(e => e.UnitEc)
                    .HasColumnName("UnitEC")
                    .HasMaxLength(5);

                entity.Property(e => e.UnitOrp)
                    .HasColumnName("UnitORP")
                    .HasMaxLength(5);

                entity.Property(e => e.UnitPh)
                    .HasColumnName("UnitPH")
                    .HasMaxLength(5);

                entity.Property(e => e.UnitTemp).HasMaxLength(5);

                entity.HasOne(d => d.PlantType)
                    .WithMany(p => p.Boundary)
                    .HasForeignKey(d => d.PlantTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Boundary_PlantType");
            });

            modelBuilder.Entity<Crop>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.PlantType)
                    .WithMany(p => p.Crop)
                    .HasForeignKey(d => d.PlantTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Crop_PlantType");
            });

            modelBuilder.Entity<Growth>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Growth1).HasColumnName("Growth");

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.GrowthNavigation)
                    .HasForeignKey(d => d.PlantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Growth_Plant1");
            });

            modelBuilder.Entity<Measure>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.HasOne(d => d.MeasureType)
                    .WithMany(p => p.Measure)
                    .HasForeignKey(d => d.MeasureTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Measure_MeasureType");

                entity.HasOne(d => d.Tray)
                    .WithMany(p => p.Measure)
                    .HasForeignKey(d => d.TrayId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Measure_Tray1");
            });

            modelBuilder.Entity<MeasureType>(entity =>
            {
                entity.Property(e => e.MeasureName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Plant>(entity =>
            {
                entity.Property(e => e.IsAlive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TrayXcropId).HasColumnName("TrayXCropId");

                entity.HasOne(d => d.PlantType)
                    .WithMany(p => p.Plant)
                    .HasForeignKey(d => d.PlantTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Plant_PlantType");

                entity.HasOne(d => d.Tray)
                    .WithMany(p => p.Plant)
                    .HasForeignKey(d => d.TrayId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Plant_Tray");

                entity.HasOne(d => d.TrayXcrop)
                    .WithMany(p => p.Plant)
                    .HasForeignKey(d => d.TrayXcropId)
                    .HasConstraintName("FK_Plant_TrayXCrop");
            });

            modelBuilder.Entity<PlantType>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TrayXcrop>(entity =>
            {
                entity.ToTable("TrayXCrop");

                entity.Property(e => e.TrayXcropId).HasColumnName("TrayXCropId");

                entity.Property(e => e.CreationDate).HasColumnType("date");

                entity.HasOne(d => d.Crop)
                    .WithMany(p => p.TrayXcrop)
                    .HasForeignKey(d => d.CropId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TrayXCrop_Crop");

                entity.HasOne(d => d.Tray)
                    .WithMany(p => p.TrayXcrop)
                    .HasForeignKey(d => d.TrayId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TrayXCrop_Tray");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(120);
            });
        }
    }
}
