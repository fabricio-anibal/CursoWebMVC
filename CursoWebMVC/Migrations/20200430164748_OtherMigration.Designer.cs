﻿// <auto-generated />
using System;
using CursoWebMVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using CursoWebMVC.Models;

namespace CursoWebMVC.Migrations
{
    [DbContext(typeof(CursoWebMVCContext))]
    [Migration("20200430164748_OtherMigration")]
    partial class OtherMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CursoWebMVC.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("CursoWebMVC.Models.SalesRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Amount");

                    b.Property<DateTime>("Date");

                    b.Property<int?>("SallerId");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("SallerId");

                    b.ToTable("SalesRecord");
                });

            modelBuilder.Entity("CursoWebMVC.Models.Saller", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("BaseSalary");

                    b.Property<DateTime>("BirthDate");

                    b.Property<int?>("DepartmentId");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Saller");
                });

            modelBuilder.Entity("CursoWebMVC.Models.SalesRecord", b =>
                {
                    b.HasOne("CursoWebMVC.Models.Saller", "Saller")
                        .WithMany("Sales")
                        .HasForeignKey("SallerId");
                });

            modelBuilder.Entity("CursoWebMVC.Models.Saller", b =>
                {
                    b.HasOne("CursoWebMVC.Models.Department", "Department")
                        .WithMany("Sallers")
                        .HasForeignKey("DepartmentId");
                });
#pragma warning restore 612, 618
        }
    }
}
