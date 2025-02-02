﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UserBalanceAPI.Data;

#nullable disable

namespace UserBalanceAPI.Migrations
{
    [DbContext(typeof(UserBalanceContext))]
    [Migration("20240728201642_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("UserBalanceAPI.Models.UserBalance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Balance")
                        .HasPrecision(6, 2)
                        .HasColumnType("decimal(6,2)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserBalances");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Balance = 5000m,
                            Email = "user1@example.com"
                        },
                        new
                        {
                            Id = 2,
                            Balance = 1000m,
                            Email = "user2@example.com"
                        },
                        new
                        {
                            Id = 3,
                            Balance = 2000m,
                            Email = "user3@example.com"
                        },
                        new
                        {
                            Id = 4,
                            Balance = 1500m,
                            Email = "user4@example.com"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
