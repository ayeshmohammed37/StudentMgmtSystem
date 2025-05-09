
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
            // 1.Configure inheritance(TPT for Advisor)
                modelBuilder.Entity<Advisor>().ToTable("Advisors");

            // 2. Configure composite keys
            modelBuilder.Entity<UserRole>()
                .HasKey(ur => new { ur.UserAccountId, ur.RoleId });

            // 3. Configure Course Prerequisites (many-to-many)
            modelBuilder.Entity<Course>()
                .HasMany(c => c.Prerequisites)
                .WithMany(c => c.IsPrerequisiteFor)
                .UsingEntity<Dictionary<string, object>>(
                    "CoursePrerequisites",
                    j => j.HasOne<Course>().WithMany().HasForeignKey("PrerequisiteId"),
                    j => j.HasOne<Course>().WithMany().HasForeignKey("CourseId"),
                    j => j.HasKey("CourseId", "PrerequisiteId"));


            // 4. Configure Student relationships
            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasIndex(s => s.StudentId).IsUnique();
                entity.HasIndex(s => s.Email).IsUnique();

                entity.HasOne(s => s.AcademicProgram)
                    .WithMany(p => p.Students)
                    .HasForeignKey(s => s.AcademicProgramId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(s => s.Advisor)
                    .WithMany(a => a.Advisees)
                    .HasForeignKey(s => s.AdvisorId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            // 5. Configure Instructor relationships
            modelBuilder.Entity<Instructor>(entity =>
            {
                entity.HasIndex(i => i.InstructorId).IsUnique();
                entity.HasIndex(i => i.Email).IsUnique();

                entity.HasOne(i => i.Department)
                    .WithMany(d => d.Instructors)
                    .HasForeignKey(i => i.DepartmentId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            // 6. Configure Course relationships
            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasIndex(c => c.CourseCode).IsUnique();

                entity.HasOne(c => c.Department)
                    .WithMany(d => d.Courses)
                    .HasForeignKey(c => c.DepartmentId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            // 7. Configure AcademicProgram relationships
            modelBuilder.Entity<AcademicProgram>(entity =>
            {
                entity.HasIndex(p => p.Code).IsUnique();

                entity.HasOne(p => p.Department)
                    .WithMany(d => d.AcademicPrograms)
                    .HasForeignKey(p => p.DepartmentId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            // 8. Configure Curriculum relationships
            modelBuilder.Entity<Curriculum>(entity =>
            {
                entity.HasKey(c => c.Id);

                entity.HasOne(c => c.AcademicProgram)
                    .WithMany(p => p.Curricula)
                    .HasForeignKey(c => c.AcademicProgramId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(c => c.Course)
                    .WithMany(c => c.Curricula)
                    .HasForeignKey(c => c.CourseId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasIndex(c => new { c.AcademicProgramId, c.CourseId }).IsUnique();
            });

            // 9. Configure CourseOffering relationships
            modelBuilder.Entity<CourseOffering>(entity =>
            {
                entity.HasIndex(co => new { co.CourseId, co.SemesterId, co.Section }).IsUnique();

                entity.HasOne(co => co.Course)
                    .WithMany(c => c.Offerings)
                    .HasForeignKey(co => co.CourseId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(co => co.Semester)
                    .WithMany(s => s.CourseOfferings)
                    .HasForeignKey(co => co.SemesterId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(co => co.Instructor)
                    .WithMany(i => i.CourseOfferings)
                    .HasForeignKey(co => co.InstructorId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            // 10. Configure Enrollment relationships
            modelBuilder.Entity<Enrollment>(entity =>
            {
                entity.HasIndex(e => new { e.StudentId, e.CourseOfferingId }).IsUnique();

                entity.HasOne(e => e.Student)
                    .WithMany(s => s.Enrollments)
                    .HasForeignKey(e => e.StudentId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(e => e.CourseOffering)
                    .WithMany(co => co.Enrollments)
                    .HasForeignKey(e => e.CourseOfferingId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            // 11. Configure Department relationships
            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasIndex(d => d.Code).IsUnique();
            });


            // 12. Configure UserAccount relationships
            modelBuilder.Entity<UserAccount>(entity =>
            {
                entity.HasIndex(u => u.Username).IsUnique();
                entity.HasIndex(u => u.Email).IsUnique();
            });

            // 13. Configure Role relationships
            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasIndex(r => r.Name).IsUnique();
            });

            base.OnModelCreating(modelBuilder);
        }




    }
}
