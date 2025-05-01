using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentMgmtSystem.Models.TeachingModel;

namespace StudentMgmtSystem.ConfigurationClasses
{
    public class TeachingConfiguration : IEntityTypeConfiguration<Teaching>
    {
        public void Configure(EntityTypeBuilder<Teaching> builder)
        {
            // Teaching (Instructor-Course)
            builder.HasOne(t => t.Course)
               .WithMany(c => c.Teachings)
               .HasForeignKey(t => t.CourseId)
               .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(t => t.Instructor)
               .WithMany(i => i.Teachings)
               .HasForeignKey(t => t.InstructorId)
               .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
