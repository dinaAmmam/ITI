﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using lap4.Models;

#nullable disable

namespace lap4.Migrations
{
    [DbContext(typeof(ITIContext))]
    [Migration("20240226190044_status")]
    partial class status
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CourseDepartment", b =>
                {
                    b.Property<int>("DepartmentsDeptId")
                        .HasColumnType("int");

                    b.Property<int>("coursesId")
                        .HasColumnType("int");

                    b.HasKey("DepartmentsDeptId", "coursesId");

                    b.HasIndex("coursesId");

                    b.ToTable("CourseDepartment");
                });

            modelBuilder.Entity("lap4.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Crs_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("courses");
                });

            modelBuilder.Entity("lap4.Models.Department", b =>
                {
                    b.Property<int>("DeptId")
                        .HasColumnType("int");

                    b.Property<string>("DeptName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("DeptId");

                    b.ToTable("departments");
                });

            modelBuilder.Entity("lap4.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int?>("DeptNo")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("DeptNo");

                    b.ToTable("students");
                });

            modelBuilder.Entity("lap4.Models.StudentCourse", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("CrsId")
                        .HasColumnType("int");

                    b.Property<int>("Degree")
                        .HasColumnType("int");

                    b.HasKey("StudentId", "CrsId");

                    b.HasIndex("CrsId");

                    b.ToTable("studentsCourses");
                });

            modelBuilder.Entity("CourseDepartment", b =>
                {
                    b.HasOne("lap4.Models.Department", null)
                        .WithMany()
                        .HasForeignKey("DepartmentsDeptId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("lap4.Models.Course", null)
                        .WithMany()
                        .HasForeignKey("coursesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("lap4.Models.Student", b =>
                {
                    b.HasOne("lap4.Models.Department", "Department")
                        .WithMany("students")
                        .HasForeignKey("DeptNo");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("lap4.Models.StudentCourse", b =>
                {
                    b.HasOne("lap4.Models.Course", "Course")
                        .WithMany("CourseStudents")
                        .HasForeignKey("CrsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("lap4.Models.Student", "Student")
                        .WithMany("StudentCourses")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("lap4.Models.Course", b =>
                {
                    b.Navigation("CourseStudents");
                });

            modelBuilder.Entity("lap4.Models.Department", b =>
                {
                    b.Navigation("students");
                });

            modelBuilder.Entity("lap4.Models.Student", b =>
                {
                    b.Navigation("StudentCourses");
                });
#pragma warning restore 612, 618
        }
    }
}