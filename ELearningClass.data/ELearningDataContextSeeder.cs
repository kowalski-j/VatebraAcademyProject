using ELearningClass.data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ELearningClass.data
{
    public static class ELearningDataContextSeeder
    {
        public static void seedCourseData(this ModelBuilder builder)
        {
            builder.Entity<Course>().HasData(
                new Course[]
                {
                new Course { Id = 1, CourseTitle = "Learning HTML", CourseCode = "CSC 001", CourseDescription = "This course teaches HTML", DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
                new Course { Id = 2, CourseTitle = "Learning Ef", CourseCode = "CSC 002", CourseDescription = "", DateCreated = DateTime.Now, DateUpdated = DateTime.Now }
                }
                );
        }
        public static void seedStudentData(this ModelBuilder builder)
        {
            builder.Entity<Student>().HasData(
                new Student[]
                {
                    new Student{ Id = 1, FirstName = "Anthonia", LastName = "Ebhoaye", MatricNumber = "1234567890", DateCreated = DateTime.Now, DateUpdated = DateTime.Now},
                    new Student{ Id = 2, FirstName = "Lucky", LastName = "Moye", MatricNumber = "756449675", DateCreated = DateTime.Now, DateUpdated = DateTime.Now}
                }
                );
        }

        public static void seedEnrollmentData(this ModelBuilder builder)
        {
            builder.Entity<Enrollment>().HasData(
                new Enrollment[]
                {
                new Enrollment { Id = 1, CourseId = 1, StudentId = 1,  DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
                new Enrollment { Id = 2, CourseId = 2, StudentId = 2,  DateCreated = DateTime.Now, DateUpdated = DateTime.Now }
                }
                );
        }
    }
}
