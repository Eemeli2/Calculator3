using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Reloading.Services.EF.Migrations
{
    public partial class ModifyCaliber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Diameters_Diameters_DiameterId",
                table: "Diameters");

            migrationBuilder.DropIndex(
                name: "IX_Diameters_DiameterId",
                table: "Diameters");

            migrationBuilder.DropColumn(
                name: "DiameterId",
                table: "Diameters");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Diameters");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Diameters");

            migrationBuilder.DropColumn(
                name: "PrimerType",
                table: "Diameters");

            migrationBuilder.CreateTable(
                name: "Calibers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PrimerType = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    DiameterId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calibers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Calibers_Diameters_DiameterId",
                        column: x => x.DiameterId,
                        principalTable: "Diameters",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Calibers_DiameterId",
                table: "Calibers",
                column: "DiameterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calibers");

            migrationBuilder.AddColumn<Guid>(
                name: "DiameterId",
                table: "Diameters",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Diameters",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Diameters",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PrimerType",
                table: "Diameters",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Diameters_DiameterId",
                table: "Diameters",
                column: "DiameterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Diameters_Diameters_DiameterId",
                table: "Diameters",
                column: "DiameterId",
                principalTable: "Diameters",
                principalColumn: "Id");
        }
    }
}
