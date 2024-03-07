﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskManagement.Infra.Data.Context;

#nullable disable

namespace TaskManagement.Infra.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TaskManagement.Domain.Entities.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("TaskComment")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(1000)");

                    b.Property<int>("TaskProjectId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TaskProjectId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("TaskManagement.Domain.Entities.LogTaskProject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<string>("TaskComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TaskProjectId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("LogTaskProjects");
                });

            modelBuilder.Entity("TaskManagement.Domain.Entities.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateAt = new DateTime(2024, 3, 7, 16, 14, 44, 293, DateTimeKind.Utc).AddTicks(1601),
                            ProjectName = "Projeto do Banco Master",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreateAt = new DateTime(2024, 3, 7, 16, 14, 44, 293, DateTimeKind.Utc).AddTicks(1625),
                            ProjectName = "Projeto Grupo Rede D’or",
                            UserId = 1
                        });
                });

            modelBuilder.Entity("TaskManagement.Domain.Entities.TaskProject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(1000)");

                    b.Property<DateTime?>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Priority")
                        .HasColumnType("int");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("TaskProjects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateAt = new DateTime(2024, 3, 7, 16, 14, 44, 293, DateTimeKind.Utc).AddTicks(4382),
                            Description = "Detalhar cada ponto importante do projeto",
                            DueDate = new DateTime(2024, 3, 7, 13, 14, 44, 293, DateTimeKind.Local).AddTicks(4356),
                            ProjectId = 1,
                            Title = "Levantamento de Requisitos"
                        },
                        new
                        {
                            Id = 2,
                            CreateAt = new DateTime(2024, 3, 7, 16, 14, 44, 293, DateTimeKind.Utc).AddTicks(4398),
                            Description = "Detalhar cada ponto importante do projeto",
                            DueDate = new DateTime(2024, 3, 7, 13, 14, 44, 293, DateTimeKind.Local).AddTicks(4397),
                            ProjectId = 2,
                            Title = "Levantamento de Requisitos"
                        });
                });

            modelBuilder.Entity("TaskManagement.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Profile")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateAt = new DateTime(2024, 3, 7, 16, 14, 44, 293, DateTimeKind.Utc).AddTicks(6663),
                            Email = "admin@gmail.com",
                            Name = "Admin",
                            Profile = 1
                        },
                        new
                        {
                            Id = 2,
                            CreateAt = new DateTime(2024, 3, 7, 16, 14, 44, 293, DateTimeKind.Utc).AddTicks(6685),
                            Email = "lucas@gmail.com",
                            Name = "Lucas",
                            Profile = 1
                        },
                        new
                        {
                            Id = 3,
                            CreateAt = new DateTime(2024, 3, 7, 16, 14, 44, 293, DateTimeKind.Utc).AddTicks(6690),
                            Email = "jhonnydscosta@gmail.com",
                            Name = "Jhonny Costa",
                            Profile = 0
                        });
                });

            modelBuilder.Entity("TaskManagement.Domain.Entities.Comment", b =>
                {
                    b.HasOne("TaskManagement.Domain.Entities.TaskProject", "TaskProject")
                        .WithMany("Comments")
                        .HasForeignKey("TaskProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TaskProject");
                });

            modelBuilder.Entity("TaskManagement.Domain.Entities.Project", b =>
                {
                    b.HasOne("TaskManagement.Domain.Entities.User", null)
                        .WithMany("Projects")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("TaskManagement.Domain.Entities.TaskProject", b =>
                {
                    b.HasOne("TaskManagement.Domain.Entities.Project", "Project")
                        .WithMany("TaskProject")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");
                });

            modelBuilder.Entity("TaskManagement.Domain.Entities.Project", b =>
                {
                    b.Navigation("TaskProject");
                });

            modelBuilder.Entity("TaskManagement.Domain.Entities.TaskProject", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("TaskManagement.Domain.Entities.User", b =>
                {
                    b.Navigation("Projects");
                });
#pragma warning restore 612, 618
        }
    }
}