using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Reloading.Services.EF.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Diameter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Value = table.Column<double>(type: "double precision", nullable: false),
                    UnitType = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diameter", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mass",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Value = table.Column<double>(type: "double precision", nullable: false),
                    UnitType = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mass", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bullets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    MassId = table.Column<Guid>(type: "uuid", nullable: true),
                    DiameterId = table.Column<Guid>(type: "uuid", nullable: true),
                    ManufacturerId = table.Column<Guid>(type: "uuid", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bullets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bullets_Diameter_DiameterId",
                        column: x => x.DiameterId,
                        principalTable: "Diameter",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bullets_Manufacturers_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bullets_Mass_MassId",
                        column: x => x.MassId,
                        principalTable: "Mass",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bullets_DiameterId",
                table: "Bullets",
                column: "DiameterId");

            migrationBuilder.CreateIndex(
                name: "IX_Bullets_ManufacturerId",
                table: "Bullets",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Bullets_MassId",
                table: "Bullets",
                column: "MassId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bullets");

            migrationBuilder.DropTable(
                name: "Diameter");

            migrationBuilder.DropTable(
                name: "Manufacturers");

            migrationBuilder.DropTable(
                name: "Mass");
        }
    }
}
