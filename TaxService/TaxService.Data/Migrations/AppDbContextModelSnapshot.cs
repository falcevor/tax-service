﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TaxService.Data.DataContext;

namespace TaxService.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("TaxService.Data.Model.DocumentDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<byte[]>("File")
                        .HasColumnType("bytea");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int?>("TaxpayerDtoId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("TaxpayerDtoId");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("TaxService.Data.Model.IncomeDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("TaxService.Data.Model.PaymentDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Incomes");
                });

            modelBuilder.Entity("TaxService.Data.Model.ReportTemplateDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<byte[]>("File")
                        .HasColumnType("bytea");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ReportTemplates");
                });

            modelBuilder.Entity("TaxService.Data.Model.ReportTemplateParameterDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("DefaultValue")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int?>("ReportTemplateDtoId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ReportTemplateDtoId");

                    b.ToTable("ReportTemplateParameterDto");
                });

            modelBuilder.Entity("TaxService.Data.Model.TaxpayerDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("AdditionalInfo")
                        .HasColumnType("text");

                    b.Property<DateTime>("BeginDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Category")
                        .HasColumnType("text");

                    b.Property<string>("Inn")
                        .HasColumnType("text");

                    b.Property<string>("Kpp")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("Percent")
                        .HasColumnType("integer");

                    b.Property<string>("PlaceAddress")
                        .HasColumnType("text");

                    b.Property<string>("PlaceType")
                        .HasColumnType("text");

                    b.Property<string>("TaxType")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Taxpayers");
                });

            modelBuilder.Entity("TaxService.Data.Model.DocumentDto", b =>
                {
                    b.HasOne("TaxService.Data.Model.TaxpayerDto", null)
                        .WithMany("Documents")
                        .HasForeignKey("TaxpayerDtoId");
                });

            modelBuilder.Entity("TaxService.Data.Model.ReportTemplateParameterDto", b =>
                {
                    b.HasOne("TaxService.Data.Model.ReportTemplateDto", null)
                        .WithMany("Parameters")
                        .HasForeignKey("ReportTemplateDtoId");
                });

            modelBuilder.Entity("TaxService.Data.Model.ReportTemplateDto", b =>
                {
                    b.Navigation("Parameters");
                });

            modelBuilder.Entity("TaxService.Data.Model.TaxpayerDto", b =>
                {
                    b.Navigation("Documents");
                });
#pragma warning restore 612, 618
        }
    }
}
