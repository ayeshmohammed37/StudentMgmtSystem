using StudentMgmtSystem.Models.CourseModel;
using StudentMgmtSystem.Models.TakedExamModel;

namespace StudentMgmtSystem.Models.ExamModel
{
    public class Exam
    {
        // Primery Key
        public int Id { get; set; }


        // Exam Details
        public string Name { get; set; }
        public string Code { get; set; }    // "MID-01", "FINAL-CS101"
        public string Description { get; set; }
        public ExamType ExamType { get; set; } // Final, MidTerm
        public ExamFormat ExamFormat { get; set; }
        public int CourseId { get; set; }
        public DateTime ScheduledDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan Duration { get; set; }
        public decimal TotalMarks { get; set; }
        public decimal PassingMarks { get; set; }


        // Navigation Properties
        public Course Course { get; set; }
        public List<TakedExam> TakedExams { get; set; }
    }
}
