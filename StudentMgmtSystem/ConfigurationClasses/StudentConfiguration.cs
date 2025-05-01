using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentMgmtSystem.Models.StudentModel;

namespace StudentMgmtSystem.ConfigurationClasses
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            // Student-Notification
            builder.HasMany(s => s.Notifications)
                .WithOne(n => n.Student)
                .HasForeignKey(n => n.StudentId)
                .OnDelete(DeleteBehavior.Restrict);

            // Student-Department 
           builder.HasOne(s => s.Department)
                .WithMany(d => d.Students)
                .HasForeignKey(s => s.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);

            // Student-Enrollment 
           builder.HasMany(s => s.Enrollments)
                .WithOne(e => e.Student)
                .HasForeignKey(e => e.StudentId)
                .OnDelete(DeleteBehavior.Restrict);

            // Student-Instructor (Advisor) 
           builder.HasOne(s => s.Instructor)
                .WithMany(i => i.Students)
                .HasForeignKey(s => s.InstructorId)
                .OnDelete(DeleteBehavior.SetNull);

            // Student-TakedExam 
           builder.HasMany(s => s.TakedExams)
                .WithOne(te => te.Student)
                .HasForeignKey(te => te.StudentId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
