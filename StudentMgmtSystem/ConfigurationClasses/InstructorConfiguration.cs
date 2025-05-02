using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentMgmtSystem.Models.InstructorModel;

namespace StudentMgmtSystem.ConfigurationClasses
{
    public class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasOne(i => i.Department)
                .WithMany(d => d.Instructors)
                .HasForeignKey(i => i.DepartmentId)
            .OnDelete(DeleteBehavior.Cascade);

            // Instructor-Teaching
            builder.HasMany(i => i.Teachings)
                .WithOne(t => t.Instructor)
                .HasForeignKey(t => t.InstructorId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(i => i.Salary)
                .HasPrecision(18, 2);

        }
    }
}
