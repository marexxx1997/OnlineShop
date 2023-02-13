﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineShop.Data;

#nullable disable

namespace OnlineShop.Migrations
{
    [DbContext(typeof(AppDbCContext))]
    [Migration("20221212185806_SecondMigration")]
    partial class SecondMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OnlineShop.Models.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("OnlineShop.Models.Laptop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GraphicCard")
                        .HasColumnType("int");

                    b.Property<string>("HardDisc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Manufacturer")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Processor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePictureUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("RAM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ScreenSize")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Warranty")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Laptops");
                });

            modelBuilder.Entity("OnlineShop.Models.LaptopBrand", b =>
                {
                    b.Property<int>("LaptopId")
                        .HasColumnType("int");

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.HasKey("LaptopId", "BrandId");

                    b.HasIndex("BrandId");

                    b.ToTable("LaptopBrands");
                });

            modelBuilder.Entity("OnlineShop.Models.LaptopBrand", b =>
                {
                    b.HasOne("OnlineShop.Models.Brand", "Brand")
                        .WithMany("LaptopBrands")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineShop.Models.Laptop", "Laptop")
                        .WithMany("LaptopBrands")
                        .HasForeignKey("LaptopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Laptop");
                });

            modelBuilder.Entity("OnlineShop.Models.Brand", b =>
                {
                    b.Navigation("LaptopBrands");
                });

            modelBuilder.Entity("OnlineShop.Models.Laptop", b =>
                {
                    b.Navigation("LaptopBrands");
                });
#pragma warning restore 612, 618
        }
    }
}
