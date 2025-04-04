﻿// <auto-generated />
using EFCore.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCore.DataAccess.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250403065705_aa")]
    partial class aa
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFCore.Models.MelissaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("College")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MmModel");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 33,
                            College = "Completed",
                            Name = "Melisa"
                        },
                        new
                        {
                            Id = 2,
                            Age = 34,
                            College = "Compleft00ed",
                            Name = "Melisa"
                        });
                });

            modelBuilder.Entity("EFCore.Models.Models.OurModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OurMM");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AuthorName = "Author1",
                            Title = "Title1"
                        },
                        new
                        {
                            Id = "2",
                            AuthorName = "Author2",
                            Title = "Title2"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
