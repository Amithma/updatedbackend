﻿// <auto-generated />
using System;
using AuthDemo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AuthDemo.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20210521081823_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AuthDemo.Models.AsComponent", b =>
                {
                    b.Property<int>("AsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ascomponent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LOID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Marks")
                        .HasColumnType("int");

                    b.Property<string>("ModuleId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("POID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("lid")
                        .HasColumnType("int");

                    b.HasKey("AsID");

                    b.HasIndex("ModuleId");

                    b.HasIndex("POID");

                    b.ToTable("AsComponents");
                });

            modelBuilder.Entity("AuthDemo.Models.LO", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LOID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Lmarks")
                        .HasColumnType("int");

                    b.Property<string>("ModuleId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ModuleId");

                    b.ToTable("LOs");
                });

            modelBuilder.Entity("AuthDemo.Models.Module", b =>
                {
                    b.Property<string>("ModuleId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Credits")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ModuleId");

                    b.ToTable("Modules");
                });

            modelBuilder.Entity("AuthDemo.Models.PO", b =>
                {
                    b.Property<string>("POID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ID")
                        .HasColumnType("int");

                    b.Property<string>("LOID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("POName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("POID");

                    b.HasIndex("ID");

                    b.ToTable("POs");
                });

            modelBuilder.Entity("AuthDemo.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AuthDemo.Models.WeatherForecast", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TemperatureC")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("WeatherForecasts");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("IdentityRole");

                    b.HasData(
                        new
                        {
                            Id = "b081fddb-c2d4-45ca-87c4-820be0b532c6",
                            ConcurrencyStamp = "82ec5a23-a59e-421e-a0b9-7fd6564c5ec5",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "72265c5d-d3d8-4c52-bf62-b6357fb78ff7",
                            ConcurrencyStamp = "6e9d6847-bb15-4ce5-9f0d-71a40a76a932",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "a1b13364-4495-447a-ac26-fbf441552f46",
                            ConcurrencyStamp = "4e5f17f8-f290-46e0-be71-9722abb9ab0f",
                            Name = "Lecturer",
                            NormalizedName = "LECTURER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("IdentityUserRole<string>");
                });

            modelBuilder.Entity("AuthDemo.Models.AsComponent", b =>
                {
                    b.HasOne("AuthDemo.Models.Module", "Module")
                        .WithMany("AsComponents")
                        .HasForeignKey("ModuleId");

                    b.HasOne("AuthDemo.Models.PO", null)
                        .WithMany("AsComponents")
                        .HasForeignKey("POID");

                    b.Navigation("Module");
                });

            modelBuilder.Entity("AuthDemo.Models.LO", b =>
                {
                    b.HasOne("AuthDemo.Models.Module", "Module")
                        .WithMany("LOs")
                        .HasForeignKey("ModuleId");

                    b.Navigation("Module");
                });

            modelBuilder.Entity("AuthDemo.Models.PO", b =>
                {
                    b.HasOne("AuthDemo.Models.LO", "LO")
                        .WithMany("POs")
                        .HasForeignKey("ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LO");
                });

            modelBuilder.Entity("AuthDemo.Models.LO", b =>
                {
                    b.Navigation("POs");
                });

            modelBuilder.Entity("AuthDemo.Models.Module", b =>
                {
                    b.Navigation("AsComponents");

                    b.Navigation("LOs");
                });

            modelBuilder.Entity("AuthDemo.Models.PO", b =>
                {
                    b.Navigation("AsComponents");
                });
#pragma warning restore 612, 618
        }
    }
}
