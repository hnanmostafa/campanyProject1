﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using campany.data.context;

#nullable disable

namespace campany.data.Migrations
{
    [DbContext(typeof(campanyDbContext))]
    partial class campanyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("campany.data.Entity.Department", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 10L, 10);

                    b.Property<string>("code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("creatAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isdeleted")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("id");

                    b.HasIndex("name")
                        .IsUnique();

                    b.ToTable("departments");
                });

            modelBuilder.Entity("campany.data.Entity.Employee", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.Property<DateTime>("creatAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("departmentId")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("hiringdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("imageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isdeleted")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("phoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("salary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("id");

                    b.HasIndex("departmentId");

                    b.ToTable("employees");
                });

            modelBuilder.Entity("campany.data.Entity.Employee", b =>
                {
                    b.HasOne("campany.data.Entity.Department", "department")
                        .WithMany("Employees")
                        .HasForeignKey("departmentId");

                    b.Navigation("department");
                });

            modelBuilder.Entity("campany.data.Entity.Department", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
