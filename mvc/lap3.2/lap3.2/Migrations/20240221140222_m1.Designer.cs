﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using lap3._2.Models;

#nullable disable

namespace lap3._2.Migrations
{
    [DbContext(typeof(ITIContext))]
    [Migration("20240221140222_m1")]
    partial class m1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("lap3._2.Models.Department", b =>
                {
                    b.Property<int>("DeptId")
                        .HasColumnType("int");

                    b.Property<string>("DeptName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DeptId");

                    b.ToTable("departments");
                });

            modelBuilder.Entity("lap3._2.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentDeptId")
                        .HasColumnType("int");

                    b.Property<int>("DeptNo")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentDeptId");

                    b.ToTable("students");
                });

            modelBuilder.Entity("lap3._2.Models.Student", b =>
                {
                    b.HasOne("lap3._2.Models.Department", "Department")
                        .WithMany("students")
                        .HasForeignKey("DepartmentDeptId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("lap3._2.Models.Department", b =>
                {
                    b.Navigation("students");
                });
#pragma warning restore 612, 618
        }
    }
}