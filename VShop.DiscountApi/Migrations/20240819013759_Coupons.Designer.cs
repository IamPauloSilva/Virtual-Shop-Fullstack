﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VShop.DiscountApi.Context;

#nullable disable

namespace VShop.DiscountApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240819013759_Coupons")]
    partial class Coupons
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("VShop.DiscountApi.Models.Coupon", b =>
                {
                    b.Property<int>("CouponId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("CouponId"));

                    b.Property<string>("CouponCode")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("CouponId");

                    b.ToTable("Coupons");

                    b.HasData(
                        new
                        {
                            CouponId = 1,
                            CouponCode = "VSHOP_PROMO_10",
                            Discount = 10m
                        },
                        new
                        {
                            CouponId = 2,
                            CouponCode = "VSHOP_PROMO_20",
                            Discount = 20m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
