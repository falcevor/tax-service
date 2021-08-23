using Microsoft.EntityFrameworkCore.Migrations;

namespace TaxService.Data.Migrations
{
    public partial class InspectorEntityConfigured : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Area_Inspector_InspectorId",
                table: "Area");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Inspector",
                table: "Inspector");

            migrationBuilder.RenameTable(
                name: "Inspector",
                newName: "Inspectors");

            migrationBuilder.AlterColumn<int>(
                name: "InspectorId",
                table: "Area",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Inspectors",
                table: "Inspectors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Area_Inspectors_InspectorId",
                table: "Area",
                column: "InspectorId",
                principalTable: "Inspectors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Area_Inspectors_InspectorId",
                table: "Area");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Inspectors",
                table: "Inspectors");

            migrationBuilder.RenameTable(
                name: "Inspectors",
                newName: "Inspector");

            migrationBuilder.AlterColumn<int>(
                name: "InspectorId",
                table: "Area",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Inspector",
                table: "Inspector",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Area_Inspector_InspectorId",
                table: "Area",
                column: "InspectorId",
                principalTable: "Inspector",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
