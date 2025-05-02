using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentMgmtSystem.Models.CourseModel;
using StudentMgmtSystem.Models.CourseOfferingModel;
using StudentMgmtSystem.Models.ExamModel;
using StudentMgmtSystem.Models.TeachingModel;

namespace StudentMgmtSystem.ConfigurationClasses
{
    public class CourseConfigurations : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            // Course-Department 
            builder.HasOne(c => c.Department)
                .WithMany(d => d.Courses)
                .HasForeignKey(c => c.DepartmentId)
                .OnDelete(DeleteBehavior.Cascade);


        }
    }
}
