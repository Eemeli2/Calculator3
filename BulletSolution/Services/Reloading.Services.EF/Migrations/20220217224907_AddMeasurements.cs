using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Reloading.Services.EF.Migrations
{
    public partial class AddMeasurements : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bullets_Diameter_DiameterId",
                table: "Bullets");

            migrationBuilder.DropForeignKey(
                name: "FK_Bullets_Mass_MassId",
                table: "Bullets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mass",
                table: "Mass");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Diameter",
                table: "Diameter");

            migrationBuilder.RenameTable(
                name: "Mass",
                newName: "Masses");

            migrationBuilder.RenameTable(
                name: "Diameter",
                newName: "Diameters");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Masses",
                table: "Masses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Diameters",
                table: "Diameters",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bullets_Diameters_DiameterId",
                table: "Bullets",
                column: "DiameterId",
                principalTable: "Diameters",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bullets_Masses_MassId",
                table: "Bullets",
                column: "MassId",
                principalTable: "Masses",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bullets_Diameters_DiameterId",
                table: "Bullets");

            migrationBuilder.DropForeignKey(
                name: "FK_Bullets_Masses_MassId",
                table: "Bullets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Masses",
                table: "Masses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Diameters",
                table: "Diameters");

            migrationBuilder.RenameTable(
                name: "Masses",
                newName: "Mass");

            migrationBuilder.RenameTable(
                name: "Diameters",
                newName: "Diameter");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mass",
                table: "Mass",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Diameter",
                table: "Diameter",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bullets_Diameter_DiameterId",
                table: "Bullets",
                column: "DiameterId",
                principalTable: "Diameter",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bullets_Mass_MassId",
                table: "Bullets",
                column: "MassId",
                principalTable: "Mass",
                principalColumn: "Id");
        }
    }
}
