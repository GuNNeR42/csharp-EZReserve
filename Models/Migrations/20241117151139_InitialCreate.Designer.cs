﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using csharp_EZReserve.Data;

#nullable disable

namespace csharp_EZReserve.Models.Migrations
{
    [DbContext(typeof(SQLiteDbContext))]
    [Migration("20241117151139_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("csharp_EZReserve.Models.Entities.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("city");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("last_name");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("postal_code");

                    b.Property<string>("StreetAddress")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("street_address");

                    b.HasKey("CustomerId");

                    b.ToTable("customers", (string)null);
                });

            modelBuilder.Entity("csharp_EZReserve.Models.Entities.Reservation", b =>
                {
                    b.Property<int>("ReservationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<int>("CustomerId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("customer_id");

                    b.Property<DateTime>("From")
                        .HasColumnType("datetime")
                        .HasColumnName("from");

                    b.Property<string>("Room")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("room");

                    b.Property<DateTime>("To")
                        .HasColumnType("datetime")
                        .HasColumnName("to");

                    b.HasKey("ReservationId");

                    b.HasIndex("CustomerId");

                    b.ToTable("reservations", (string)null);
                });

            modelBuilder.Entity("csharp_EZReserve.Models.Entities.Reservation", b =>
                {
                    b.HasOne("csharp_EZReserve.Models.Entities.Customer", "Customer")
                        .WithMany("Reservations")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("csharp_EZReserve.Models.Entities.Customer", b =>
                {
                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}
