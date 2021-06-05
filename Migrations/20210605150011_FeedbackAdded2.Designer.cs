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
    [Migration("20210605150011_FeedbackAdded2")]
    partial class FeedbackAdded2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
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

            modelBuilder.Entity("GroupProject.Models.Feedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ModuleId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Q1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Q10")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Q2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Q3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Q4")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Q5")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Q6")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Q7")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Q8")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Q9")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("feedbacks");
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
                            Id = "4ae243b8-dc2b-4df2-8fbe-4d689f76b615",
                            ConcurrencyStamp = "8b38c6c8-88bf-4c18-83b7-40ace28ccc8c",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "df6b9661-f1e9-4368-b969-dc72355fd41e",
                            ConcurrencyStamp = "09e515ee-d684-48c5-a54a-6dd2b533f8e0",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "9b96604b-5ddb-47e7-afb9-ca8b9ee45dcc",
                            ConcurrencyStamp = "c67f8b93-8ebe-425f-a808-15094c8a78f6",
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
