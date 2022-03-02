using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Reloading.Services.EF.Migrations
{
    public partial class EntityCaliberService : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
