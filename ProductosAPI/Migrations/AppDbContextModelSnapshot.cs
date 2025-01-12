﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductosAPI.Data;

#nullable disable

namespace ProductosAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("ProductosAPI.Models.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CantidadEnStock")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaDeCreacion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Precio")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Productos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CantidadEnStock = 100,
                            Descripcion = "Laptop Inspirion Dell 3535",
                            FechaDeCreacion = new DateTime(2025, 1, 11, 19, 6, 46, 773, DateTimeKind.Local).AddTicks(3603),
                            Nombre = "Lapatop",
                            Precio = 25000.99m
                        },
                        new
                        {
                            Id = 2,
                            CantidadEnStock = 200,
                            Descripcion = "",
                            FechaDeCreacion = new DateTime(2025, 1, 11, 19, 6, 46, 775, DateTimeKind.Local).AddTicks(8324),
                            Nombre = "Teclado",
                            Precio = 300m
                        },
                        new
                        {
                            Id = 3,
                            CantidadEnStock = 200,
                            Descripcion = "Ergonomico color negro.",
                            FechaDeCreacion = new DateTime(2025, 1, 11, 19, 6, 46, 775, DateTimeKind.Local).AddTicks(8348),
                            Nombre = "Mouse",
                            Precio = 200.55m
                        },
                        new
                        {
                            Id = 4,
                            CantidadEnStock = 200,
                            Descripcion = "",
                            FechaDeCreacion = new DateTime(2025, 1, 11, 19, 6, 46, 775, DateTimeKind.Local).AddTicks(8350),
                            Nombre = "Cargador",
                            Precio = 500m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
