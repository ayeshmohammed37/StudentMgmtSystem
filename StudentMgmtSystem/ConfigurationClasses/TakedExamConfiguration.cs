using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentMgmtSystem.Models.TakedExamModel;

namespace StudentMgmtSystem.ConfigurationClasses
{
    public class TakedExamConfiguration : IEntityTypeConfiguration<TakedExam>
    {
        public void Configure(EntityTypeBuilder<TakedExam> builder)
        {
            builder.Property(te => te.points)
                .HasPrecision(18, 2);
        }
    }
}
