﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Models;

#nullable disable

namespace WebApplication1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231028042319_seedCategoryTable")]
    partial class seedCategoryTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApplication1.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Comments = "Sample Comment 1",
                            Description = "Sample Description 1",
                            Name = "Sample Product 1",
                            Type = "Sample type 1"
                        },
                        new
                        {
                            ProductId = 2,
                            Comments = "Sample Comment 2",
                            Description = "Sample Description 2",
                            Name = "Sample Product 2",
                            Type = "Sample type 2"
                        },
                        new
                        {
                            ProductId = 3,
                            Comments = "Sample Comment 3",
                            Description = "Sample Description 3",
                            Name = "Sample Product 3",
                            Type = "Sample type 3"
                        },
                        new
                        {
                            ProductId = 4,
                            Comments = "Sample Comment 4",
                            Description = "Sample Description 4",
                            Name = "Sample Product 4",
                            Type = "Sample type 4"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
