﻿// <auto-generated />
using System;
using AuthDemo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AuthDemo.Migrations
{
    [DbContext(typeof(DBContext))]
    partial class DBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Lmarks")
                        .HasColumnType("int");

                    b.Property<string>("ModuleId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("p1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("p10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("p11")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("p12")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("p2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("p3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("p4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("p5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("p6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("p7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("p8")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("p9")
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
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("s1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("s10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("s11")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("s12")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("s2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("s3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("s4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("s5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("s6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("s7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("s8")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("s9")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ModuleId");

                    b.ToTable("Modules");
                });

            modelBuilder.Entity("AuthDemo.Models.PO", b =>
                {
                    b.Property<string>("POID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("POName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("POID");

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
                            Id = "dc066c0a-2a53-4424-a11a-9328c9776387",
                            ConcurrencyStamp = "e5b30df3-9787-41a5-965d-f553e9e2ff57",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "d13df85f-ff06-46cc-b44b-3baf5376fa01",
                            ConcurrencyStamp = "4e3b5523-7d43-4bd9-8e58-7ef2d2f37a34",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "3927cee3-1d1b-4168-86c8-00cbde7834c6",
                            ConcurrencyStamp = "4bde39f5-e744-4ea5-bcd6-d2ba3c91ee63",
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
