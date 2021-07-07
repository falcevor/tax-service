using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace TaxService.Data.Migrations
{
    public partial class TaxpayerIdsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Taxpayers_TaxpayerDtoId",
                table: "Documents");

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
                name: "ReportTemplateParameterDto");

            migrationBuilder.DropTable(
                name: "TaxpayerCategoryDto");

            migrationBuilder.DropTable(
                name: "TaxTypeDto");

            migrationBuilder.DropTable(
                name: "InspectorDto");

            migrationBuilder.DropIndex(
                name: "IX_Documents_TaxpayerDtoId",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "TaxpayerDtoId",
                table: "Documents");

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

            migrationBuilder.AlterColumn<int>(
                name: "TaxpayerId",
                table: "Payments",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TaxpayerId",
                table: "Incomes",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TaxpayerId",
                table: "Documents",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Inspector",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Login = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inspector", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlaceType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaceType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReportTemplateParameter",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    DefaultValue = table.Column<string>(type: "text", nullable: true),
                    ReportTemplateId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportTemplateParameter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReportTemplateParameter_ReportTemplates_ReportTemplateId",
                        column: x => x.ReportTemplateId,
                        principalTable: "ReportTemplates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TaxpayerCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxpayerCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaxType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Area",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    InspectorId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Area", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Area_Inspector_InspectorId",
                        column: x => x.InspectorId,
                        principalTable: "Inspector",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Documents_TaxpayerId",
                table: "Documents",
                column: "TaxpayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Area_InspectorId",
                table: "Area",
                column: "InspectorId");

            migrationBuilder.CreateIndex(
                name: "IX_ReportTemplateParameter_ReportTemplateId",
                table: "ReportTemplateParameter",
                column: "ReportTemplateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Taxpayers_TaxpayerId",
                table: "Documents",
                column: "TaxpayerId",
                principalTable: "Taxpayers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Incomes_Taxpayers_TaxpayerId",
                table: "Incomes",
                column: "TaxpayerId",
                principalTable: "Taxpayers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Taxpayers_TaxpayerId",
                table: "Payments",
                column: "TaxpayerId",
                principalTable: "Taxpayers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Taxpayers_TaxpayerId",
                table: "Documents");

            migrationBuilder.DropForeignKey(
                name: "FK_Incomes_Taxpayers_TaxpayerId",
                table: "Incomes");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Taxpayers_TaxpayerId",
                table: "Payments");

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

            migrationBuilder.DropTable(
                name: "Area");

            migrationBuilder.DropTable(
                name: "PlaceType");

            migrationBuilder.DropTable(
                name: "ReportTemplateParameter");

            migrationBuilder.DropTable(
                name: "TaxpayerCategory");

            migrationBuilder.DropTable(
                name: "TaxType");

            migrationBuilder.DropTable(
                name: "Inspector");

            migrationBuilder.DropIndex(
                name: "IX_Documents_TaxpayerId",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "TaxpayerId",
                table: "Documents");

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

            migrationBuilder.AlterColumn<int>(
                name: "TaxpayerId",
                table: "Payments",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "TaxpayerId",
                table: "Incomes",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "TaxpayerDtoId",
                table: "Documents",
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
                name: "ReportTemplateParameterDto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DefaultValue = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    ReportTemplateDtoId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportTemplateParameterDto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReportTemplateParameterDto_ReportTemplates_ReportTemplateDt~",
                        column: x => x.ReportTemplateDtoId,
                        principalTable: "ReportTemplates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    InspectorId = table.Column<int>(type: "integer", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true)
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
                name: "IX_Documents_TaxpayerDtoId",
                table: "Documents",
                column: "TaxpayerDtoId");

            migrationBuilder.CreateIndex(
                name: "IX_AreaDto_InspectorId",
                table: "AreaDto",
                column: "InspectorId");

            migrationBuilder.CreateIndex(
                name: "IX_ReportTemplateParameterDto_ReportTemplateDtoId",
                table: "ReportTemplateParameterDto",
                column: "ReportTemplateDtoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Taxpayers_TaxpayerDtoId",
                table: "Documents",
                column: "TaxpayerDtoId",
                principalTable: "Taxpayers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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
    }
}
