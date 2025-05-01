using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentMgmtSystem.Models.ExamModel;

namespace StudentMgmtSystem.ConfigurationClasses
{
    public class ExamConfiguration : IEntityTypeConfiguration<Exam>
    {
        public void Configure(EntityTypeBuilder<Exam> builder)
        {

            // Exam-TakedExam
            builder.HasMany(e => e.TakedExams)
               .WithOne(te => te.Exam)
               .HasForeignKey(te => te.ExamId)
               .OnDelete(DeleteBehavior.Restrict);


            // Course-Exam 
            builder.HasOne(e => e.Course)
                .WithMany(c => c.Exams)
                .HasForeignKey(e => e.CourseId)
                .OnDelete(DeleteBehavior.Restrict);


            builder.Property(e => e.TotalMarks)
                .HasPrecision(18, 2);

            builder.Property(e => e.PassingMarks)
                .HasPrecision(18, 2);
        }
    }
}
