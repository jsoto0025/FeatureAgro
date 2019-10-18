using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FutureAgro.DataAccess.Migrations
{
    public partial class DBInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MeasureType",
                columns: table => new
                {
                    MeasureTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MeasureName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeasureType", x => x.MeasureTypeId);
                });

            migrationBuilder.CreateTable(
                name: "PlantType",
                columns: table => new
                {
                    PlantTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlantType", x => x.PlantTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Tray",
                columns: table => new
                {
                    TrayId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Capacity = table.Column<int>(nullable: false),
                    Temperature = table.Column<double>(nullable: true),
                    Humidity = table.Column<int>(nullable: true),
                    Brightness = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tray", x => x.TrayId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(maxLength: 120, nullable: false),
                    Password = table.Column<string>(maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(maxLength: 450, nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(maxLength: 450, nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(maxLength: 450, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Boundary",
                columns: table => new
                {
                    BoundaryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PlantTypeId = table.Column<int>(nullable: false),
                    MinDO = table.Column<int>(nullable: true),
                    MaxDO = table.Column<int>(nullable: true),
                    OptDO = table.Column<int>(nullable: true),
                    UnitDO = table.Column<string>(maxLength: 5, nullable: true),
                    MinPH = table.Column<decimal>(type: "decimal(3, 1)", nullable: true),
                    MaxPH = table.Column<decimal>(type: "decimal(3, 1)", nullable: true),
                    OptPH = table.Column<decimal>(type: "decimal(3, 1)", nullable: true),
                    UnitPH = table.Column<string>(maxLength: 5, nullable: true),
                    MinEC = table.Column<int>(nullable: true),
                    MaxEC = table.Column<int>(nullable: true),
                    OptEC = table.Column<int>(nullable: true),
                    UnitEC = table.Column<string>(maxLength: 5, nullable: true),
                    MinORP = table.Column<int>(nullable: true),
                    MaxORP = table.Column<int>(nullable: true),
                    OptORP = table.Column<int>(nullable: true),
                    UnitORP = table.Column<string>(maxLength: 5, nullable: true),
                    MinTemp = table.Column<int>(nullable: false),
                    MaxTemp = table.Column<int>(nullable: false),
                    OptTemp = table.Column<int>(nullable: true),
                    UnitTemp = table.Column<string>(maxLength: 5, nullable: true),
                    MinLum = table.Column<int>(nullable: false),
                    MaxLum = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boundary", x => x.BoundaryId);
                    table.ForeignKey(
                        name: "FK_Boundary_PlantType",
                        column: x => x.PlantTypeId,
                        principalTable: "PlantType",
                        principalColumn: "PlantTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Crop",
                columns: table => new
                {
                    CropId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(maxLength: 20, nullable: false),
                    PlantTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crop", x => x.CropId);
                    table.ForeignKey(
                        name: "FK_Crop_PlantType",
                        column: x => x.PlantTypeId,
                        principalTable: "PlantType",
                        principalColumn: "PlantTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Measure",
                columns: table => new
                {
                    MeasureId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TrayId = table.Column<int>(nullable: false),
                    MeasureTypeId = table.Column<int>(nullable: false),
                    Value = table.Column<double>(nullable: false),
                    Date = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Measure", x => x.MeasureId);
                    table.ForeignKey(
                        name: "FK_Measure_MeasureType",
                        column: x => x.MeasureTypeId,
                        principalTable: "MeasureType",
                        principalColumn: "MeasureTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Measure_Tray1",
                        column: x => x.TrayId,
                        principalTable: "Tray",
                        principalColumn: "TrayId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TrayXCrop",
                columns: table => new
                {
                    TrayXCropId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CropId = table.Column<int>(nullable: false),
                    TrayId = table.Column<int>(nullable: false),
                    CreationDate = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrayXCrop", x => x.TrayXCropId);
                    table.ForeignKey(
                        name: "FK_TrayXCrop_Crop",
                        column: x => x.CropId,
                        principalTable: "Crop",
                        principalColumn: "CropId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TrayXCrop_Tray",
                        column: x => x.TrayId,
                        principalTable: "Tray",
                        principalColumn: "TrayId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Plant",
                columns: table => new
                {
                    PlantId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TrayXCropId = table.Column<int>(nullable: true),
                    PlantTypeId = table.Column<int>(nullable: false),
                    IsAlive = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    Growth = table.Column<int>(nullable: false),
                    TrayId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plant", x => x.PlantId);
                    table.ForeignKey(
                        name: "FK_Plant_PlantType",
                        column: x => x.PlantTypeId,
                        principalTable: "PlantType",
                        principalColumn: "PlantTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Plant_Tray",
                        column: x => x.TrayId,
                        principalTable: "Tray",
                        principalColumn: "TrayId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Plant_TrayXCrop",
                        column: x => x.TrayXCropId,
                        principalTable: "TrayXCrop",
                        principalColumn: "TrayXCropId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Growth",
                columns: table => new
                {
                    GrowthId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PlantId = table.Column<int>(nullable: false),
                    Growth = table.Column<double>(nullable: false),
                    Date = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Growth", x => x.GrowthId);
                    table.ForeignKey(
                        name: "FK_Growth_Plant1",
                        column: x => x.PlantId,
                        principalTable: "Plant",
                        principalColumn: "PlantId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Boundary_PlantTypeId",
                table: "Boundary",
                column: "PlantTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Crop_PlantTypeId",
                table: "Crop",
                column: "PlantTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Growth_PlantId",
                table: "Growth",
                column: "PlantId");

            migrationBuilder.CreateIndex(
                name: "IX_Measure_MeasureTypeId",
                table: "Measure",
                column: "MeasureTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Measure_TrayId",
                table: "Measure",
                column: "TrayId");

            migrationBuilder.CreateIndex(
                name: "IX_Plant_PlantTypeId",
                table: "Plant",
                column: "PlantTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Plant_TrayId",
                table: "Plant",
                column: "TrayId");

            migrationBuilder.CreateIndex(
                name: "IX_Plant_TrayXCropId",
                table: "Plant",
                column: "TrayXCropId");

            migrationBuilder.CreateIndex(
                name: "IX_TrayXCrop_CropId",
                table: "TrayXCrop",
                column: "CropId");

            migrationBuilder.CreateIndex(
                name: "IX_TrayXCrop_TrayId",
                table: "TrayXCrop",
                column: "TrayId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Boundary");

            migrationBuilder.DropTable(
                name: "Growth");

            migrationBuilder.DropTable(
                name: "Measure");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Plant");

            migrationBuilder.DropTable(
                name: "MeasureType");

            migrationBuilder.DropTable(
                name: "TrayXCrop");

            migrationBuilder.DropTable(
                name: "Crop");

            migrationBuilder.DropTable(
                name: "Tray");

            migrationBuilder.DropTable(
                name: "PlantType");
        }
    }
}
