﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using api.Data.Context;

namespace api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210211080927_mig_InitialProduct")]
    partial class mig_InitialProduct
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("api.Models.Product.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTimeOffset(new DateTime(2021, 2, 11, 11, 39, 26, 629, DateTimeKind.Unspecified).AddTicks(4593), new TimeSpan(0, 3, 30, 0, 0)),
                            Description = "laptop the best",
                            Name = "Laptop",
                            Price = 192.0m,
                            UpdatedAt = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTimeOffset(new DateTime(2021, 2, 11, 11, 40, 26, 634, DateTimeKind.Unspecified).AddTicks(7206), new TimeSpan(0, 3, 30, 0, 0)),
                            Description = "pc the better than laptop",
                            Name = "Pc",
                            Price = 400.0m,
                            UpdatedAt = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTimeOffset(new DateTime(2021, 2, 11, 11, 41, 26, 634, DateTimeKind.Unspecified).AddTicks(7354), new TimeSpan(0, 3, 30, 0, 0)),
                            Description = "glass is good",
                            Name = "glass",
                            Price = 0m,
                            UpdatedAt = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTimeOffset(new DateTime(2021, 2, 11, 11, 42, 26, 634, DateTimeKind.Unspecified).AddTicks(7440), new TimeSpan(0, 3, 30, 0, 0)),
                            Description = "ball for footbal game and another...",
                            Name = "ball",
                            Price = 0m,
                            UpdatedAt = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTimeOffset(new DateTime(2021, 2, 11, 11, 43, 26, 634, DateTimeKind.Unspecified).AddTicks(7448), new TimeSpan(0, 3, 30, 0, 0)),
                            Description = "dress for man",
                            Name = "dress",
                            Price = 0m,
                            UpdatedAt = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
