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

            builder.HasOne(te => te.Student)
               .WithMany(s => s.TakedExams)
               .HasForeignKey(te => te.StudentId)
               .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(te => te.Exam)
               .WithMany(e => e.TakedExams)
               .HasForeignKey(te => te.ExamId)
               .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
