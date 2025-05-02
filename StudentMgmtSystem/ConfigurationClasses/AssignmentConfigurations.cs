using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentMgmtSystem.Models.AssignmentModel;

namespace StudentMgmtSystem.ConfigurationClasses
{
    public class AssignmentConfigurations : IEntityTypeConfiguration<Assignment>
    {
        public void Configure(EntityTypeBuilder<Assignment> builder)
        {
            // Assignment-Instructor 
            //builder.HasOne(a => a.Instructor)
            //    .WithMany(i => i.Assignments)
            //    .HasForeignKey(a => a.InstructorId)
            //.OnDelete(DeleteBehavior.Cascade);

            // Assignment-Course relationship (many-to-one)
            builder.HasOne(a => a.Course)
                .WithMany(c => c.Assignments)
                .HasForeignKey(a => a.CourseId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
