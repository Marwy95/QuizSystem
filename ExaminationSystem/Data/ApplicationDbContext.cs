﻿using ExaminationSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace ExaminationSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=MSI\\SQLEXPRESS;Initial Catalog=Examination_System;Integrated Security=True;Trust Server Certificate=True");
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Instructor>()
                        .HasMany(i => i.Exams)
                        .WithOne(e => e.Instructor)
                        .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Instructor>()
                        .HasMany(i => i.Courses)
                        .WithOne(c => c.Instructor)
                        .OnDelete(DeleteBehavior.NoAction);
        }
        DbSet<Student> Students { get; set; }
        DbSet<Instructor> Instructors { get; set; }
        DbSet<Choice> Choices { get; set; }
        DbSet<Course> Courses { get; set; }
        DbSet<Exam> Exams { get; set; }
        DbSet<ExamQuestion> ExamQuestions { get; set; }
        DbSet<Question> Questions { get; set; }
        DbSet<StudentCourse> StudentCourses { get; set; }
        DbSet<StudentExam> StudentExams { get; set; }
    }
   
}
/*
 
 namespace ExaminationSystem
{
    public class AutoFacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Context>().InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>)).InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(typeof(IExamService).Assembly).AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(typeof(IExamQuestionService).Assembly).AsImplementedInterfaces().InstancePerLifetimeScope();

        }
    }
}

   builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
            builder.Host.ConfigureContainer<ContainerBuilder>(builder =>
                builder.RegisterModule(new AutoFacModule()));
 
 */