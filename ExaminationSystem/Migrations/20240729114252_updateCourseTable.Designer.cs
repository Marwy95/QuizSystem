﻿// <auto-generated />
using System;
using ExaminationSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ExaminationSystem.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240729114252_updateCourseTable")]
    partial class updateCourseTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ExaminationSystem.Models.Choice", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<bool>("IsRight")
                        .HasColumnType("bit");

                    b.Property<int>("QuestionID")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("QuestionID");

                    b.ToTable("Choices");
                });

            modelBuilder.Entity("ExaminationSystem.Models.Course", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CreditHours")
                        .HasColumnType("int");

                    b.Property<int>("InstructorID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("InstructorID");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("ExaminationSystem.Models.Exam", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<int>("InstructorID")
                        .HasColumnType("int");

                    b.Property<int>("QuestionsNumber")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CourseID");

                    b.HasIndex("InstructorID");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("ExaminationSystem.Models.ExamQuestion", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("ExamID")
                        .HasColumnType("int");

                    b.Property<int>("QuestionID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ExamID");

                    b.HasIndex("QuestionID");

                    b.ToTable("ExamQuestions");
                });

            modelBuilder.Entity("ExaminationSystem.Models.Instructor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("ExaminationSystem.Models.Question", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("ExaminationSystem.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("ExaminationSystem.Models.StudentCourse", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CourseID");

                    b.HasIndex("StudentID");

                    b.ToTable("StudentCourses");
                });

            modelBuilder.Entity("ExaminationSystem.Models.StudentExam", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("ExamID")
                        .HasColumnType("int");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ExamID");

                    b.HasIndex("StudentID");

                    b.ToTable("StudentExams");
                });

            modelBuilder.Entity("ExaminationSystem.Models.Choice", b =>
                {
                    b.HasOne("ExaminationSystem.Models.Question", "Question")
                        .WithMany("choices")
                        .HasForeignKey("QuestionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("ExaminationSystem.Models.Course", b =>
                {
                    b.HasOne("ExaminationSystem.Models.Instructor", "Instructor")
                        .WithMany("Courses")
                        .HasForeignKey("InstructorID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("ExaminationSystem.Models.Exam", b =>
                {
                    b.HasOne("ExaminationSystem.Models.Course", "Course")
                        .WithMany("Exams")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExaminationSystem.Models.Instructor", "Instructor")
                        .WithMany("Exams")
                        .HasForeignKey("InstructorID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("ExaminationSystem.Models.ExamQuestion", b =>
                {
                    b.HasOne("ExaminationSystem.Models.Exam", "Exam")
                        .WithMany("ExamQuestions")
                        .HasForeignKey("ExamID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExaminationSystem.Models.Question", "Question")
                        .WithMany("ExamQuestions")
                        .HasForeignKey("QuestionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exam");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("ExaminationSystem.Models.StudentCourse", b =>
                {
                    b.HasOne("ExaminationSystem.Models.Course", "Course")
                        .WithMany("StudentCourses")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExaminationSystem.Models.Student", "Student")
                        .WithMany("StudentCourses")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("ExaminationSystem.Models.StudentExam", b =>
                {
                    b.HasOne("ExaminationSystem.Models.Exam", "Exam")
                        .WithMany("StudentExams")
                        .HasForeignKey("ExamID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExaminationSystem.Models.Student", "Student")
                        .WithMany("StudentExams")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exam");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("ExaminationSystem.Models.Course", b =>
                {
                    b.Navigation("Exams");

                    b.Navigation("StudentCourses");
                });

            modelBuilder.Entity("ExaminationSystem.Models.Exam", b =>
                {
                    b.Navigation("ExamQuestions");

                    b.Navigation("StudentExams");
                });

            modelBuilder.Entity("ExaminationSystem.Models.Instructor", b =>
                {
                    b.Navigation("Courses");

                    b.Navigation("Exams");
                });

            modelBuilder.Entity("ExaminationSystem.Models.Question", b =>
                {
                    b.Navigation("ExamQuestions");

                    b.Navigation("choices");
                });

            modelBuilder.Entity("ExaminationSystem.Models.Student", b =>
                {
                    b.Navigation("StudentCourses");

                    b.Navigation("StudentExams");
                });
#pragma warning restore 612, 618
        }
    }
}
