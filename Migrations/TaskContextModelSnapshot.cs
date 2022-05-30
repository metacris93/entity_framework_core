﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using entity_framework.src.Classes;

#nullable disable

namespace entity_framework.Migrations
{
    [DbContext(typeof(TaskContext))]
    partial class TaskContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("entity_framework.src.Models.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("Level")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.HasKey("Id");

                    b.ToTable("Category", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("879fde45-be65-46b0-8822-5f367041b717"),
                            Level = 20,
                            Name = "Actividades pendientes"
                        },
                        new
                        {
                            Id = new Guid("879fde45-be65-46b0-8822-5f367041b710"),
                            Level = 10,
                            Name = "Actividades personales"
                        });
                });

            modelBuilder.Entity("entity_framework.src.Models.Task_", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValue(new DateTime(2022, 5, 29, 22, 9, 7, 515, DateTimeKind.Local).AddTicks(3350));

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("TaskPriority")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Task", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("879fde45-be65-46b0-8822-5f367041b711"),
                            CategoryId = new Guid("879fde45-be65-46b0-8822-5f367041b717"),
                            CreatedAt = new DateTime(2022, 5, 29, 22, 9, 7, 515, DateTimeKind.Local).AddTicks(1960),
                            TaskPriority = 1,
                            Title = "Pago de servicios publicos"
                        },
                        new
                        {
                            Id = new Guid("879fde45-be65-46b0-8822-5f367041b709"),
                            CategoryId = new Guid("879fde45-be65-46b0-8822-5f367041b710"),
                            CreatedAt = new DateTime(2022, 5, 29, 22, 9, 7, 515, DateTimeKind.Local).AddTicks(1980),
                            TaskPriority = 0,
                            Title = "Ver pelicula en Netflix"
                        });
                });

            modelBuilder.Entity("entity_framework.src.Models.Task_", b =>
                {
                    b.HasOne("entity_framework.src.Models.Category", "Category")
                        .WithMany("Tasks")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("entity_framework.src.Models.Category", b =>
                {
                    b.Navigation("Tasks");
                });
#pragma warning restore 612, 618
        }
    }
}
