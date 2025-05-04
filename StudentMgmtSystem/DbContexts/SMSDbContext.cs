
using Microsoft.EntityFrameworkCore;
using StudentMgmtSystem.Models.AcademicProgramModel;
using StudentMgmtSystem.Models.AdvisorModel;
using StudentMgmtSystem.Models.CourseModel;
using StudentMgmtSystem.Models.CourseOfferingModel;
using StudentMgmtSystem.Models.CurriculumModel;
using StudentMgmtSystem.Models.DepartmentModel;
using StudentMgmtSystem.Models.EnrollmentModel;
using StudentMgmtSystem.Models.InstructorModel;
using StudentMgmtSystem.Models.SemesterModel;
using StudentMgmtSystem.Models.StudentModel;
using StudentMgmtSystem.Models.User;

namespace StudentMgmtSystem.DbContexts
{
    public class SMSDbContext: DbContext
    {

        public SMSDbContext(DbContextOptions<SMSDbContext> options)
        : base(options)
        {
        }

        public SMSDbContext(): base()
        {
            
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Advisor> Advisors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<AcademicProgram> AcademicPrograms { get; set; }
        public DbSet<Curriculum> Curricula { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<CourseOffering> CourseOfferings { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<UserAccount> UserAccounts { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=SMSDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }




    }
}
