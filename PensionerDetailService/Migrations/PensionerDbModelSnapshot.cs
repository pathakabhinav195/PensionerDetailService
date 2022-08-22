﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PensionerDetailService.Model;

namespace PensionerDetailService.Migrations
{
    [DbContext(typeof(PensionerDb))]
    partial class PensionerDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PensionerDetailService.Model.PensionerDetail", b =>
                {
                    b.Property<string>("Aadhar")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AccountNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Allowances")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("BankName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BankType")
                        .HasColumnType("int");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PAN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PensionType")
                        .HasColumnType("int");

                    b.Property<decimal>("SalaryEarned")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Aadhar");

                    b.ToTable("Pensioners");
                });
#pragma warning restore 612, 618
        }
    }
}