﻿// <auto-generated />
using MOD.PaymentService.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MOD.PaymentService.Migrations
{
    [DbContext(typeof(PaymentContext))]
    [Migration("20191114101202_PaymentMigration01")]
    partial class PaymentMigration01
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MOD.PaymentService.Models.Payment", b =>
                {
                    b.Property<long>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<double>("MentorAmount")
                        .HasColumnType("float");

                    b.Property<long>("MentorId")
                        .HasColumnType("bigint");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("PaymentId");

                    b.ToTable("Payment");

                    b.HasData(
                        new
                        {
                            PaymentId = 12L,
                            Amount = 4.0,
                            MentorAmount = 3.0,
                            MentorId = 201L,
                            UserId = 101L
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
