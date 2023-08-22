using JituCourses.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JituCourses
{
    public class MyDbContext : DbContext
    {
        public DbSet<CoursesDTO> Courses { get; set; }
        public DbSet<TrainerDTO> Trainers { get; set; }

        public DbSet<TraineesDTO> Trainees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=COLLO;Database=JituCourses;Trusted_Connection=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CoursesDTO>().HasData(
                new CoursesDTO() { CourseId = 1, CourseName = "C#", CourseDescription = "C# is a programming language" });

            var JituCourses = new CoursesDTO[]
            {
                new CoursesDTO() { CourseId = 2, CourseName = "ASP.NET", CourseDescription = "ASP.NET is a web development framework"  },
                new CoursesDTO() { CourseId = 3, CourseName = "MVC", CourseDescription = "MVC is a web development framework" },
                new CoursesDTO() { CourseId = 4, CourseName = "SQL Server", CourseDescription = "SQL Server is a database management system" },
                new CoursesDTO() { CourseId = 5, CourseName = "Angular", CourseDescription = "Angular is a web development framework" },
            };
            modelBuilder.Entity<CoursesDTO>().HasData(JituCourses);
        }
    }
}
