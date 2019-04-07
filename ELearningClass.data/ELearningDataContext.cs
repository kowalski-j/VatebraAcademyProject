using ELearningClass.data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ELearningClass.data
{
    public class ELearningDataContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Enrollment> Enrollment { get; set; }
        public ELearningDataContext(DbContextOptions<ELearningDataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.seedCourseData();
            modelBuilder.seedStudentData();
            modelBuilder.seedEnrollmentData();
           // base.OnModelCreating(modelBuilder);
        }

    }
}
