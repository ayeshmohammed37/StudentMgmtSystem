using System.Reflection;
using Microsoft.EntityFrameworkCore;
using StudentMgmtSystem.Models.AdminModel;
using StudentMgmtSystem.Models.AssignmentModel;
using StudentMgmtSystem.Models.CourseModel;
using StudentMgmtSystem.Models.CourseOfferingModel;
using StudentMgmtSystem.Models.DepartmentModel;
using StudentMgmtSystem.Models.EnrollmentModel;
using StudentMgmtSystem.Models.ExamModel;
using StudentMgmtSystem.Models.InstructorModel;
using StudentMgmtSystem.Models.NotificationModel;
using StudentMgmtSystem.Models.SemesterModel;
using StudentMgmtSystem.Models.StudentModel;
using StudentMgmtSystem.Models.TakedExamModel;
using StudentMgmtSystem.Models.TeachingModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StudentMgmtSystem.DbContexts
{
    public class SMSDbContext: DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=SMSDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //foreach (var relation in modelBuilder.Model.GetEntityTypes()
            //    .SelectMany(e => e.GetForeignKeys()))
            //{
                
            //}

            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Admin> Admins { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseOffering> CourseOfferings { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Exam> Exam { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<TakedExam> TakedExams { get; set; }
        public DbSet<Teaching> Teachings { get; set; }

    }
}
