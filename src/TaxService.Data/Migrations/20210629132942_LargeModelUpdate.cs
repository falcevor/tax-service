using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace TaxService.Data.Migrations
{
    public partial class LargeModelUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Taxpayers");

            migrationBuilder.DropColumn(
                name: "PlaceType",
                table: "Taxpayers");

            migrationBuilder.DropColumn(
                name: "TaxType",
                table: "Taxpayers");

            migrationBuilder.AddColumn<int>(
                name: "AreaId",
                table: "Taxpayers",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Taxpayers",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlaceTypeId",
                table: "Taxpayers",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TaxTypeId",
                table: "Taxpayers",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TaxpayerId",
                table: "Payments",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TaxpayerId",
                table: "Incomes",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "InspectorDto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Login = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InspectorDto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlaceTypeDto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaceTypeDto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaxpayerCategoryDto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxpayerCategoryDto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaxTypeDto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxTypeDto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AreaDto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    InspectorId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaDto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AreaDto_InspectorDto_InspectorId",
                        column: x => x.InspectorId,
                        principalTable: "InspectorDto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Taxpayers_AreaId",
                table: "Taxpayers",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Taxpayers_CategoryId",
                table: "Taxpayers",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Taxpayers_PlaceTypeId",
                table: "Taxpayers",
                column: "PlaceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Taxpayers_TaxTypeId",
                table: "Taxpayers",
                column: "TaxTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_TaxpayerId",
                table: "Payments",
                column: "TaxpayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Incomes_TaxpayerId",
                table: "Incomes",
                column: "TaxpayerId");

            migrationBuilder.CreateIndex(
                name: "IX_AreaDto_InspectorId",
                table: "AreaDto",
                column: "InspectorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Incomes_Taxpayers_TaxpayerId",
                table: "Incomes",
                column: "TaxpayerId",
                principalTable: "Taxpayers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Taxpayers_TaxpayerId",
                table: "Payments",
                column: "TaxpayerId",
                principalTable: "Taxpayers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Taxpayers_AreaDto_AreaId",
                table: "Taxpayers",
                column: "AreaId",
                principalTable: "AreaDto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Taxpayers_PlaceTypeDto_PlaceTypeId",
                table: "Taxpayers",
                column: "PlaceTypeId",
                principalTable: "PlaceTypeDto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Taxpayers_TaxpayerCategoryDto_CategoryId",
                table: "Taxpayers",
                column: "CategoryId",
                principalTable: "TaxpayerCategoryDto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Taxpayers_TaxTypeDto_TaxTypeId",
                table: "Taxpayers",
                column: "TaxTypeId",
                principalTable: "TaxTypeDto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Incomes_Taxpayers_TaxpayerId",
                table: "Incomes");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Taxpayers_TaxpayerId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Taxpayers_AreaDto_AreaId",
                table: "Taxpayers");

            migrationBuilder.DropForeignKey(
                name: "FK_Taxpayers_PlaceTypeDto_PlaceTypeId",
                table: "Taxpayers");

            migrationBuilder.DropForeignKey(
                name: "FK_Taxpayers_TaxpayerCategoryDto_CategoryId",
                table: "Taxpayers");

            migrationBuilder.DropForeignKey(
                name: "FK_Taxpayers_TaxTypeDto_TaxTypeId",
                table: "Taxpayers");

            migrationBuilder.DropTable(
                name: "AreaDto");

            migrationBuilder.DropTable(
                name: "PlaceTypeDto");

            migrationBuilder.DropTable(
                name: "TaxpayerCategoryDto");

            migrationBuilder.DropTable(
                name: "TaxTypeDto");

            migrationBuilder.DropTable(
                name: "InspectorDto");

            migrationBuilder.DropIndex(
                name: "IX_Taxpayers_AreaId",
                table: "Taxpayers");

            migrationBuilder.DropIndex(
                name: "IX_Taxpayers_CategoryId",
                table: "Taxpayers");

            migrationBuilder.DropIndex(
                name: "IX_Taxpayers_PlaceTypeId",
                table: "Taxpayers");

            migrationBuilder.DropIndex(
                name: "IX_Taxpayers_TaxTypeId",
                table: "Taxpayers");

            migrationBuilder.DropIndex(
                name: "IX_Payments_TaxpayerId",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Incomes_TaxpayerId",
                table: "Incomes");

            migrationBuilder.DropColumn(
                name: "AreaId",
                table: "Taxpayers");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Taxpayers");

            migrationBuilder.DropColumn(
                name: "PlaceTypeId",
                table: "Taxpayers");

            migrationBuilder.DropColumn(
                name: "TaxTypeId",
                table: "Taxpayers");

            migrationBuilder.DropColumn(
                name: "TaxpayerId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "TaxpayerId",
                table: "Incomes");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Taxpayers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PlaceType",
                table: "Taxpayers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TaxType",
                table: "Taxpayers",
                type: "text",
                nullable: true);
        }
    }
}
