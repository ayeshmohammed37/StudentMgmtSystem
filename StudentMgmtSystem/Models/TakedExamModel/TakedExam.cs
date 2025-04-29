using StudentMgmtSystem.Models.ExamModel;

namespace StudentMgmtSystem.Models.TakedExamModel
{
    public class TakedExam
    {
        // Primery Key
        public int Id { get; set; }


        public decimal points { get; set; }
        public int ExamId { get; set; }
        public int StudentId { get; set; }


        // Navigation Properties
        public Exam Exam { get; set; }
        public Student Student { get; set; }
    }
}
