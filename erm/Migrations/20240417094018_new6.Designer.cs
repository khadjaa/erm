﻿// <auto-generated />
using System;
using Erm.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace erm.Migrations
{
    [DbContext(typeof(ErmDbContext))]
    [Migration("20240417094018_new6")]
    partial class new6
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Erm.Models.MyTask", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AssignedTo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasDefaultValue("first");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("MyTasks");

                    b.HasData(
                        new
                        {
                            Id = new Guid("87e05d20-0717-4cd7-b471-6c69bbddf9d3"),
                            AssignedTo = "John Doe",
                            EndDate = new DateTime(2015, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "first task",
                            StartDate = new DateTime(2012, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Erm.Models.Person", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasDefaultValue("first");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RefreshToken")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Persons");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Person");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Erm.Models.Project", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AssignedTo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasDefaultValue("first");

                    b.Property<string>("Risks")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sprints")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("projects", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("106aa3c7-e602-48c2-90d6-c57359aac7b8"),
                            AssignedTo = "Scrum",
                            EndDate = new DateTime(2016, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "first Project",
                            Risks = "risks",
                            Sprints = "3",
                            StartDate = new DateTime(2012, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Erm.Models.Risk", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Impact")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Probability")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Risk");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2ceebe71-26b5-4a7a-8c85-dc0ee1431bd9"),
                            Description = "descriptionInContext",
                            Impact = 1,
                            Name = "firstRiskInContext",
                            Probability = 2
                        },
                        new
                        {
                            Id = new Guid("458d712c-7d4f-40b4-9526-b214589eefb1"),
                            Description = "Description of first risk",
                            Impact = 3,
                            Name = "First Risk",
                            Probability = 2
                        },
                        new
                        {
                            Id = new Guid("64c98460-5fe3-414f-9c89-ef94386abc69"),
                            Description = "Description of second risk",
                            Impact = 2,
                            Name = "Second Risk",
                            Probability = 1
                        });
                });

            modelBuilder.Entity("Erm.Models.Sprint", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasDefaultValue("first sprint");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Tasks")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sprints");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d47bc474-e10d-4250-ab0f-7d349953d4e9"),
                            EndDate = new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "first Sprint",
                            StartDate = new DateTime(2023, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Tasks = "tasks for sprint"
                        });
                });

            modelBuilder.Entity("Erm.Models.Worker", b =>
                {
                    b.HasBaseType("Erm.Models.Person");

                    b.Property<string>("Responsibility")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Worker");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5e2ee89e-6e86-4c81-b80b-6daa449bd361"),
                            FirstName = "first",
                            LastName = "last",
                            Password = "123",
                            RefreshToken = "refresh_token_value",
                            Role = "admin",
                            Username = "maga",
                            Responsibility = "some_responsibility"
                        },
                        new
                        {
                            Id = new Guid("5c00823a-b2b0-4b5c-a139-d7e8b6f81e38"),
                            FirstName = "second",
                            LastName = "last1",
                            Password = "222",
                            RefreshToken = "refresh_token_value1",
                            Role = "editor",
                            Username = "baha",
                            Responsibility = "some_responsibility1"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}