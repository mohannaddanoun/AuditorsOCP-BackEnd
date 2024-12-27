﻿// <auto-generated />
using APi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("APi.Models.Domain.OfficeInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CertifiedAccountants")
                        .HasColumnType("int");

                    b.Property<string>("Emails")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Employees")
                        .HasColumnType("int");

                    b.Property<int>("ExpectedBudgets")
                        .HasColumnType("int");

                    b.Property<string>("LicenseNumbers")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LicensedAccountants")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("OfficeName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumbers")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("TaxNumber")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("OfficeInfos");
                });

            modelBuilder.Entity("APi.Models.Domain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}