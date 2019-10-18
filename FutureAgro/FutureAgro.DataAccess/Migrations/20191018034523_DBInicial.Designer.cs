﻿// <auto-generated />
using System;
using FutureAgro.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FutureAgro.DataAccess.Migrations
{
    [DbContext(typeof(FutureAgroIdentityDbContext))]
    [Migration("20191018034523_DBInicial")]
    partial class DBInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FutureAgro.DataAccess.Models.AspNetRoleClaims", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasMaxLength(450);

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("FutureAgro.DataAccess.Models.AspNetRoles", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("FutureAgro.DataAccess.Models.AspNetUserClaims", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasMaxLength(450);

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("FutureAgro.DataAccess.Models.AspNetUserLogins", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasMaxLength(450);

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("FutureAgro.DataAccess.Models.AspNetUserRoles", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("FutureAgro.DataAccess.Models.AspNetUserTokens", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("FutureAgro.DataAccess.Models.AspNetUsers", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("FutureAgro.DataAccess.Models.Boundary", b =>
                {
                    b.Property<int>("BoundaryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MaxDo")
                        .HasColumnName("MaxDO");

                    b.Property<int?>("MaxEc")
                        .HasColumnName("MaxEC");

                    b.Property<int>("MaxLum");

                    b.Property<int?>("MaxOrp")
                        .HasColumnName("MaxORP");

                    b.Property<decimal?>("MaxPh")
                        .HasColumnName("MaxPH")
                        .HasColumnType("decimal(3, 1)");

                    b.Property<int>("MaxTemp");

                    b.Property<int?>("MinDo")
                        .HasColumnName("MinDO");

                    b.Property<int?>("MinEc")
                        .HasColumnName("MinEC");

                    b.Property<int>("MinLum");

                    b.Property<int?>("MinOrp")
                        .HasColumnName("MinORP");

                    b.Property<decimal?>("MinPh")
                        .HasColumnName("MinPH")
                        .HasColumnType("decimal(3, 1)");

                    b.Property<int>("MinTemp");

                    b.Property<int?>("OptDo")
                        .HasColumnName("OptDO");

                    b.Property<int?>("OptEc")
                        .HasColumnName("OptEC");

                    b.Property<int?>("OptOrp")
                        .HasColumnName("OptORP");

                    b.Property<decimal?>("OptPh")
                        .HasColumnName("OptPH")
                        .HasColumnType("decimal(3, 1)");

                    b.Property<int?>("OptTemp");

                    b.Property<int>("PlantTypeId");

                    b.Property<string>("UnitDo")
                        .HasColumnName("UnitDO")
                        .HasMaxLength(5);

                    b.Property<string>("UnitEc")
                        .HasColumnName("UnitEC")
                        .HasMaxLength(5);

                    b.Property<string>("UnitOrp")
                        .HasColumnName("UnitORP")
                        .HasMaxLength(5);

                    b.Property<string>("UnitPh")
                        .HasColumnName("UnitPH")
                        .HasMaxLength(5);

                    b.Property<string>("UnitTemp")
                        .HasMaxLength(5);

                    b.HasKey("BoundaryId");

                    b.HasIndex("PlantTypeId");

                    b.ToTable("Boundary");
                });

            modelBuilder.Entity("FutureAgro.DataAccess.Models.Crop", b =>
                {
                    b.Property<int>("CropId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int>("PlantTypeId");

                    b.HasKey("CropId");

                    b.HasIndex("PlantTypeId");

                    b.ToTable("Crop");
                });

            modelBuilder.Entity("FutureAgro.DataAccess.Models.Growth", b =>
                {
                    b.Property<int>("GrowthId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime");

                    b.Property<double>("Growth1")
                        .HasColumnName("Growth");

                    b.Property<int>("PlantId");

                    b.HasKey("GrowthId");

                    b.HasIndex("PlantId");

                    b.ToTable("Growth");
                });

            modelBuilder.Entity("FutureAgro.DataAccess.Models.Measure", b =>
                {
                    b.Property<int>("MeasureId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime");

                    b.Property<int>("MeasureTypeId");

                    b.Property<int>("TrayId");

                    b.Property<double>("Value");

                    b.HasKey("MeasureId");

                    b.HasIndex("MeasureTypeId");

                    b.HasIndex("TrayId");

                    b.ToTable("Measure");
                });

            modelBuilder.Entity("FutureAgro.DataAccess.Models.MeasureType", b =>
                {
                    b.Property<int>("MeasureTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MeasureName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("MeasureTypeId");

                    b.ToTable("MeasureType");
                });

            modelBuilder.Entity("FutureAgro.DataAccess.Models.Plant", b =>
                {
                    b.Property<int>("PlantId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Growth");

                    b.Property<bool?>("IsAlive")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((1))");

                    b.Property<int>("PlantTypeId");

                    b.Property<int>("TrayId");

                    b.Property<int?>("TrayXcropId")
                        .HasColumnName("TrayXCropId");

                    b.HasKey("PlantId");

                    b.HasIndex("PlantTypeId");

                    b.HasIndex("TrayId");

                    b.HasIndex("TrayXcropId");

                    b.ToTable("Plant");
                });

            modelBuilder.Entity("FutureAgro.DataAccess.Models.PlantType", b =>
                {
                    b.Property<int>("PlantTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("PlantTypeId");

                    b.ToTable("PlantType");
                });

            modelBuilder.Entity("FutureAgro.DataAccess.Models.Tray", b =>
                {
                    b.Property<int>("TrayId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Brightness");

                    b.Property<int>("Capacity");

                    b.Property<int?>("Humidity");

                    b.Property<double?>("Temperature");

                    b.HasKey("TrayId");

                    b.ToTable("Tray");
                });

            modelBuilder.Entity("FutureAgro.DataAccess.Models.TrayXcrop", b =>
                {
                    b.Property<int>("TrayXcropId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("TrayXCropId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("date");

                    b.Property<int>("CropId");

                    b.Property<int>("TrayId");

                    b.HasKey("TrayXcropId");

                    b.HasIndex("CropId");

                    b.HasIndex("TrayId");

                    b.ToTable("TrayXCrop");
                });

            modelBuilder.Entity("FutureAgro.DataAccess.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(120);

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("FutureAgro.DataAccess.Models.AspNetRoleClaims", b =>
                {
                    b.HasOne("FutureAgro.DataAccess.Models.AspNetRoles", "Role")
                        .WithMany("AspNetRoleClaims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FutureAgro.DataAccess.Models.AspNetUserClaims", b =>
                {
                    b.HasOne("FutureAgro.DataAccess.Models.AspNetUsers", "User")
                        .WithMany("AspNetUserClaims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FutureAgro.DataAccess.Models.AspNetUserLogins", b =>
                {
                    b.HasOne("FutureAgro.DataAccess.Models.AspNetUsers", "User")
                        .WithMany("AspNetUserLogins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FutureAgro.DataAccess.Models.AspNetUserRoles", b =>
                {
                    b.HasOne("FutureAgro.DataAccess.Models.AspNetRoles", "Role")
                        .WithMany("AspNetUserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FutureAgro.DataAccess.Models.AspNetUsers", "User")
                        .WithMany("AspNetUserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FutureAgro.DataAccess.Models.AspNetUserTokens", b =>
                {
                    b.HasOne("FutureAgro.DataAccess.Models.AspNetUsers", "User")
                        .WithMany("AspNetUserTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FutureAgro.DataAccess.Models.Boundary", b =>
                {
                    b.HasOne("FutureAgro.DataAccess.Models.PlantType", "PlantType")
                        .WithMany("Boundary")
                        .HasForeignKey("PlantTypeId")
                        .HasConstraintName("FK_Boundary_PlantType");
                });

            modelBuilder.Entity("FutureAgro.DataAccess.Models.Crop", b =>
                {
                    b.HasOne("FutureAgro.DataAccess.Models.PlantType", "PlantType")
                        .WithMany("Crop")
                        .HasForeignKey("PlantTypeId")
                        .HasConstraintName("FK_Crop_PlantType");
                });

            modelBuilder.Entity("FutureAgro.DataAccess.Models.Growth", b =>
                {
                    b.HasOne("FutureAgro.DataAccess.Models.Plant", "Plant")
                        .WithMany("GrowthNavigation")
                        .HasForeignKey("PlantId")
                        .HasConstraintName("FK_Growth_Plant1");
                });

            modelBuilder.Entity("FutureAgro.DataAccess.Models.Measure", b =>
                {
                    b.HasOne("FutureAgro.DataAccess.Models.MeasureType", "MeasureType")
                        .WithMany("Measure")
                        .HasForeignKey("MeasureTypeId")
                        .HasConstraintName("FK_Measure_MeasureType");

                    b.HasOne("FutureAgro.DataAccess.Models.Tray", "Tray")
                        .WithMany("Measure")
                        .HasForeignKey("TrayId")
                        .HasConstraintName("FK_Measure_Tray1");
                });

            modelBuilder.Entity("FutureAgro.DataAccess.Models.Plant", b =>
                {
                    b.HasOne("FutureAgro.DataAccess.Models.PlantType", "PlantType")
                        .WithMany("Plant")
                        .HasForeignKey("PlantTypeId")
                        .HasConstraintName("FK_Plant_PlantType");

                    b.HasOne("FutureAgro.DataAccess.Models.Tray", "Tray")
                        .WithMany("Plant")
                        .HasForeignKey("TrayId")
                        .HasConstraintName("FK_Plant_Tray");

                    b.HasOne("FutureAgro.DataAccess.Models.TrayXcrop", "TrayXcrop")
                        .WithMany("Plant")
                        .HasForeignKey("TrayXcropId")
                        .HasConstraintName("FK_Plant_TrayXCrop");
                });

            modelBuilder.Entity("FutureAgro.DataAccess.Models.TrayXcrop", b =>
                {
                    b.HasOne("FutureAgro.DataAccess.Models.Crop", "Crop")
                        .WithMany("TrayXcrop")
                        .HasForeignKey("CropId")
                        .HasConstraintName("FK_TrayXCrop_Crop");

                    b.HasOne("FutureAgro.DataAccess.Models.Tray", "Tray")
                        .WithMany("TrayXcrop")
                        .HasForeignKey("TrayId")
                        .HasConstraintName("FK_TrayXCrop_Tray");
                });
#pragma warning restore 612, 618
        }
    }
}
