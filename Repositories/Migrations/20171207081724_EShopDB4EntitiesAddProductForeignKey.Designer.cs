﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Repositories.Context;
using System;

namespace Repositories.Migrations
{
    [DbContext(typeof(EShopContext))]
    [Migration("20171207081724_EShopDB4EntitiesAddProductForeignKey")]
    partial class EShopDB4EntitiesAddProductForeignKey
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Repositories.Entities.Customer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Repositories.Entities.Order", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CustomerId");

                    b.Property<string>("DeliveryAddress")
                        .IsRequired();

                    b.Property<string>("OrderDate");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Repositories.Entities.OrderDetail", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("OrderId");

                    b.Property<long>("ProductId");

                    b.Property<int>("Quantity");

                    b.Property<decimal>("Total");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("Repositories.Entities.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Available");

                    b.Property<string>("ImageUri");

                    b.Property<string>("Label");

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Repositories.Entities.Order", b =>
                {
                    b.HasOne("Repositories.Entities.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Repositories.Entities.OrderDetail", b =>
                {
                    b.HasOne("Repositories.Entities.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Repositories.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
