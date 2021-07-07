using Microsoft.EntityFrameworkCore.Migrations;

namespace TaxService.Data.Migrations
{
    public partial class UpdatedTaxpayersIdsToNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Taxpayers_Area_AreaId",
                table: "Taxpayers");

            migrationBuilder.DropForeignKey(
                name: "FK_Taxpayers_PlaceType_PlaceTypeId",
                table: "Taxpayers");

            migrationBuilder.DropForeignKey(
                name: "FK_Taxpayers_TaxpayerCategory_CategoryId",
                table: "Taxpayers");

            migrationBuilder.DropForeignKey(
                name: "FK_Taxpayers_TaxType_TaxTypeId",
                table: "Taxpayers");

            migrationBuilder.AlterColumn<int>(
                name: "TaxTypeId",
                table: "Taxpayers",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "PlaceTypeId",
                table: "Taxpayers",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Taxpayers",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "AreaId",
                table: "Taxpayers",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Taxpayers_Area_AreaId",
                table: "Taxpayers",
                column: "AreaId",
                principalTable: "Area",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Taxpayers_PlaceType_PlaceTypeId",
                table: "Taxpayers",
                column: "PlaceTypeId",
                principalTable: "PlaceType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Taxpayers_TaxpayerCategory_CategoryId",
                table: "Taxpayers",
                column: "CategoryId",
                principalTable: "TaxpayerCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Taxpayers_TaxType_TaxTypeId",
                table: "Taxpayers",
                column: "TaxTypeId",
                principalTable: "TaxType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Taxpayers_Area_AreaId",
                table: "Taxpayers");

            migrationBuilder.DropForeignKey(
                name: "FK_Taxpayers_PlaceType_PlaceTypeId",
                table: "Taxpayers");

            migrationBuilder.DropForeignKey(
                name: "FK_Taxpayers_TaxpayerCategory_CategoryId",
                table: "Taxpayers");

            migrationBuilder.DropForeignKey(
                name: "FK_Taxpayers_TaxType_TaxTypeId",
                table: "Taxpayers");

            migrationBuilder.AlterColumn<int>(
                name: "TaxTypeId",
                table: "Taxpayers",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PlaceTypeId",
                table: "Taxpayers",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Taxpayers",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AreaId",
                table: "Taxpayers",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Taxpayers_Area_AreaId",
                table: "Taxpayers",
                column: "AreaId",
                principalTable: "Area",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Taxpayers_PlaceType_PlaceTypeId",
                table: "Taxpayers",
                column: "PlaceTypeId",
                principalTable: "PlaceType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Taxpayers_TaxpayerCategory_CategoryId",
                table: "Taxpayers",
                column: "CategoryId",
                principalTable: "TaxpayerCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Taxpayers_TaxType_TaxTypeId",
                table: "Taxpayers",
                column: "TaxTypeId",
                principalTable: "TaxType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
