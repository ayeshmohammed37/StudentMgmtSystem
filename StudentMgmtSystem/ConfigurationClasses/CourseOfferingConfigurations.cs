using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentMgmtSystem.Models.CourseOfferingModel;

namespace StudentMgmtSystem.ConfigurationClasses
{
    public class CourseOfferingConfigurations : IEntityTypeConfiguration<CourseOffering>
    {
        public void Configure(EntityTypeBuilder<CourseOffering> builder)
        {
            // Course-CourseOffering
            builder.HasOne(co => co.Course)
                .WithMany(c => c.CourseOfferings)
                .HasForeignKey(co => co.CourseId)
                .OnDelete(DeleteBehavior.Restrict);



            // CourseOffering-Instructor 
            builder.HasOne(co => co.Instructor)
                .WithMany(i => i.CourseOfferings)
                .HasForeignKey(co => co.InstructorId)
                .OnDelete(DeleteBehavior.Restrict);

            // CourseOffering-Semester
            builder.HasOne(co => co.Semester)
                .WithMany(s => s.CourseOfferings)
                .HasForeignKey(co => co.SemesterId)
                .OnDelete(DeleteBehavior.Restrict);

            // CourseOffering-Enrollment
            builder.HasMany(co => co.Enrollments)
                .WithOne(e => e.CourseOffering)
                .HasForeignKey(e => e.CourseOfferingId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
