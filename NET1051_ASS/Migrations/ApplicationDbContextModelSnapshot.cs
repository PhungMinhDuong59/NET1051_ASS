﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NET1051_ASS.Context;

#nullable disable

namespace NET1051_ASS.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NET1051_ASS.Models.Cart", b =>
                {
                    b.Property<int>("CartID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartID"));

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("CartID");

                    b.HasIndex("UserID")
                        .IsUnique();

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("NET1051_ASS.Models.CartItem", b =>
                {
                    b.Property<int>("CartItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartItemID"));

                    b.Property<int>("CartID")
                        .HasColumnType("int");

                    b.Property<int?>("ComboID")
                        .HasColumnType("int");

                    b.Property<int?>("FoodItemID")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("CartItemID");

                    b.HasIndex("CartID");

                    b.HasIndex("ComboID");

                    b.HasIndex("FoodItemID");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("NET1051_ASS.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("NET1051_ASS.Models.Combo", b =>
                {
                    b.Property<int>("ComboID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ComboID"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ComboID");

                    b.ToTable("Combos");
                });

            modelBuilder.Entity("NET1051_ASS.Models.ComboFoodItem", b =>
                {
                    b.Property<int>("ComboID")
                        .HasColumnType("int");

                    b.Property<int>("FoodItemID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ComboID", "FoodItemID");

                    b.HasIndex("FoodItemID");

                    b.ToTable("ComboFoodItems");
                });

            modelBuilder.Entity("NET1051_ASS.Models.FoodItem", b =>
                {
                    b.Property<int>("FoodItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FoodItemID"));

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("FoodItemID");

                    b.HasIndex("CategoryID");

                    b.ToTable("FoodItems");
                });

            modelBuilder.Entity("NET1051_ASS.Models.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderID"));

                    b.Property<DateTime>("OrderTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("OrderID");

                    b.HasIndex("UserID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("NET1051_ASS.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderDetailID"));

                    b.Property<int?>("ComboID")
                        .HasColumnType("int");

                    b.Property<int?>("FoodItemID")
                        .HasColumnType("int");

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderDetailID");

                    b.HasIndex("ComboID");

                    b.HasIndex("FoodItemID");

                    b.HasIndex("OrderID");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("NET1051_ASS.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("NET1051_ASS.Models.Cart", b =>
                {
                    b.HasOne("NET1051_ASS.Models.User", "User")
                        .WithOne("Cart")
                        .HasForeignKey("NET1051_ASS.Models.Cart", "UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("NET1051_ASS.Models.CartItem", b =>
                {
                    b.HasOne("NET1051_ASS.Models.Cart", "Cart")
                        .WithMany("CartItems")
                        .HasForeignKey("CartID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NET1051_ASS.Models.Combo", "Combo")
                        .WithMany("CartItems")
                        .HasForeignKey("ComboID");

                    b.HasOne("NET1051_ASS.Models.FoodItem", "FoodItem")
                        .WithMany("CartItems")
                        .HasForeignKey("FoodItemID");

                    b.Navigation("Cart");

                    b.Navigation("Combo");

                    b.Navigation("FoodItem");
                });

            modelBuilder.Entity("NET1051_ASS.Models.ComboFoodItem", b =>
                {
                    b.HasOne("NET1051_ASS.Models.Combo", "Combo")
                        .WithMany("ComboFoodItems")
                        .HasForeignKey("ComboID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NET1051_ASS.Models.FoodItem", "FoodItem")
                        .WithMany("ComboFoodItems")
                        .HasForeignKey("FoodItemID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Combo");

                    b.Navigation("FoodItem");
                });

            modelBuilder.Entity("NET1051_ASS.Models.FoodItem", b =>
                {
                    b.HasOne("NET1051_ASS.Models.Category", "Category")
                        .WithMany("FoodItems")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("NET1051_ASS.Models.Order", b =>
                {
                    b.HasOne("NET1051_ASS.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("NET1051_ASS.Models.OrderDetail", b =>
                {
                    b.HasOne("NET1051_ASS.Models.Combo", "Combo")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ComboID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("NET1051_ASS.Models.FoodItem", "FoodItem")
                        .WithMany("OrderDetails")
                        .HasForeignKey("FoodItemID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("NET1051_ASS.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Combo");

                    b.Navigation("FoodItem");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("NET1051_ASS.Models.Cart", b =>
                {
                    b.Navigation("CartItems");
                });

            modelBuilder.Entity("NET1051_ASS.Models.Category", b =>
                {
                    b.Navigation("FoodItems");
                });

            modelBuilder.Entity("NET1051_ASS.Models.Combo", b =>
                {
                    b.Navigation("CartItems");

                    b.Navigation("ComboFoodItems");

                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("NET1051_ASS.Models.FoodItem", b =>
                {
                    b.Navigation("CartItems");

                    b.Navigation("ComboFoodItems");

                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("NET1051_ASS.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("NET1051_ASS.Models.User", b =>
                {
                    b.Navigation("Cart")
                        .IsRequired();

                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
