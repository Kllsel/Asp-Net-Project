﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OLX_AspNet.Data;

#nullable disable

namespace OLX_AspNet.Migrations
{
    [DbContext(typeof(OLXDbContext))]
    [Migration("20240207153750_CreateCategory")]
    partial class CreateCategory
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OLX_AspNet.Data.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Electronics"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Sport"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Fashion"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Home & Garden"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Transport"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Toys & Hobbies"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Musical Instruments"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Art"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Other"
                        });
                });

            modelBuilder.Entity("OLX_AspNet.Data.Entities.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Rivne",
                            CategoryId = 1,
                            Description = "Something",
                            Image = "https://applecity.com.ua/image/cache/catalog/0iphone/ipohnex/iphone-x-black-1000x1000.png",
                            Price = 650m,
                            Time = new DateTime(2010, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "iPhone X"
                        });
                });

            modelBuilder.Entity("OLX_AspNet.Data.Entities.Item", b =>
                {
                    b.HasOne("OLX_AspNet.Data.Entities.Category", "Category")
                        .WithMany("Items")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("OLX_AspNet.Data.Entities.Category", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}