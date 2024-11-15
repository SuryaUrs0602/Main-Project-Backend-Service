﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SalesDashBoardApplication.Models;

#nullable disable

namespace SalesDashBoardApplication.Migrations
{
    [DbContext(typeof(SalesDashBoardDbContext))]
    [Migration("20241017084314_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SalesDashBoardApplication.Models.Inventory", b =>
                {
                    b.Property<int>("InventoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InventoryId"));

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ReorderLevel")
                        .HasColumnType("int");

                    b.Property<int>("StockLevel")
                        .HasColumnType("int");

                    b.HasKey("InventoryId");

                    b.HasIndex("ProductId")
                        .IsUnique()
                        .HasFilter("[ProductId] IS NOT NULL");

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("SalesDashBoardApplication.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<double>("OrderAmount")
                        .HasColumnType("float");

                    b.Property<DateOnly>("OrderDate")
                        .HasColumnType("date");

                    b.Property<string>("TransactionReference")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("OrderDate");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("SalesDashBoardApplication.Models.OrderItem", b =>
                {
                    b.Property<int>("OrderItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderItemId"));

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<double>("UnitPrice")
                        .HasColumnType("float");

                    b.HasKey("OrderItemId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("SalesDashBoardApplication.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("ProductCategory")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("ProductPrice")
                        .HasColumnType("float");

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("SalesDashBoardApplication.Models.Revenue", b =>
                {
                    b.Property<int>("RevenueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RevenueId"));

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<double>("Profit")
                        .HasColumnType("float");

                    b.Property<double>("TotalCost")
                        .HasColumnType("float");

                    b.Property<double>("TotalRevenue")
                        .HasColumnType("float");

                    b.HasKey("RevenueId");

                    b.HasIndex("Date");

                    b.ToTable("Revenues");
                });

            modelBuilder.Entity("SalesDashBoardApplication.Models.SalesPerformance", b =>
                {
                    b.Property<int>("SalesPerformanceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SalesPerformanceId"));

                    b.Property<double>("AverageOrderValue")
                        .HasColumnType("float");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<string>("MostSoldProduct")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalOrders")
                        .HasColumnType("int");

                    b.HasKey("SalesPerformanceId");

                    b.HasIndex("Date");

                    b.ToTable("SalesPerformances");
                });

            modelBuilder.Entity("SalesDashBoardApplication.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserRole")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.HasIndex("UserEmail")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SalesDashBoardApplication.Models.Inventory", b =>
                {
                    b.HasOne("SalesDashBoardApplication.Models.Product", "Product")
                        .WithOne("Inventory")
                        .HasForeignKey("SalesDashBoardApplication.Models.Inventory", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Product");
                });

            modelBuilder.Entity("SalesDashBoardApplication.Models.Order", b =>
                {
                    b.HasOne("SalesDashBoardApplication.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("User");
                });

            modelBuilder.Entity("SalesDashBoardApplication.Models.OrderItem", b =>
                {
                    b.HasOne("SalesDashBoardApplication.Models.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId");

                    b.HasOne("SalesDashBoardApplication.Models.Product", "Product")
                        .WithMany("OrderItems")
                        .HasForeignKey("ProductId");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("SalesDashBoardApplication.Models.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("SalesDashBoardApplication.Models.Product", b =>
                {
                    b.Navigation("Inventory");

                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("SalesDashBoardApplication.Models.User", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
