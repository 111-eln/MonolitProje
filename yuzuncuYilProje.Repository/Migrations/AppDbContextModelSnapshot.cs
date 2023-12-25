﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using yuzuncuYilProje.Repository;

#nullable disable

namespace yuzuncuYilProje.Repository.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("yuzuncuYilProje.Core.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TeamName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Teams", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 12, 21, 21, 5, 31, 300, DateTimeKind.Local).AddTicks(4077),
                            TeamName = "Development"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 12, 21, 21, 5, 31, 300, DateTimeKind.Local).AddTicks(4088),
                            TeamName = "Sales"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 12, 21, 21, 5, 31, 300, DateTimeKind.Local).AddTicks(4088),
                            TeamName = "Marketing"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2023, 12, 21, 21, 5, 31, 300, DateTimeKind.Local).AddTicks(4089),
                            TeamName = "HR"
                        });
                });

            modelBuilder.Entity("yuzuncuYilProje.Core.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 12, 21, 21, 5, 31, 300, DateTimeKind.Local).AddTicks(4273),
                            Email = "busegizemsezer@gmail.com",
                            Password = "123456",
                            TeamId = 1,
                            UserName = "busegizem"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 12, 21, 21, 5, 31, 300, DateTimeKind.Local).AddTicks(4275),
                            Email = "elnurakkurt@gmail.com",
                            Password = "122332",
                            TeamId = 2,
                            UserName = "elnurak"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 12, 21, 21, 5, 31, 300, DateTimeKind.Local).AddTicks(4276),
                            Email = "seherselintosun@gmail.com",
                            Password = "42342342",
                            TeamId = 3,
                            UserName = "seherselin"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2023, 12, 21, 21, 5, 31, 300, DateTimeKind.Local).AddTicks(4276),
                            Email = "gizemturan@gmail.com",
                            Password = "35345345",
                            TeamId = 4,
                            UserName = "gizemturan"
                        });
                });

            modelBuilder.Entity("yuzuncuYilProje.Core.Models.UserProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("NickName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserProfiles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Buse",
                            LastName = "Sezer",
                            NickName = "bus",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Elnur",
                            LastName = "Akkurt",
                            NickName = "eln",
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Seher",
                            LastName = "Tosun",
                            NickName = "b12",
                            UserId = 3
                        },
                        new
                        {
                            Id = 4,
                            FirstName = "Gizem",
                            LastName = "Turan",
                            NickName = "sherlock",
                            UserId = 4
                        });
                });

            modelBuilder.Entity("yuzuncuYilProje.Core.Models.User", b =>
                {
                    b.HasOne("yuzuncuYilProje.Core.Models.Team", "Team")
                        .WithMany("User")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");
                });

            modelBuilder.Entity("yuzuncuYilProje.Core.Models.UserProfile", b =>
                {
                    b.HasOne("yuzuncuYilProje.Core.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("yuzuncuYilProje.Core.Models.Team", b =>
                {
                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
