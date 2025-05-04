using StudentMgmtSystem.Models.CourseOfferingModel;
using StudentMgmtSystem.Models.StudentModel;

namespace StudentMgmtSystem.Models.EnrollmentModel
{
    public class Enrollment
    {
        public int Id { get; set; }
        public DateTime EnrollmentDate { get; set; } = DateTime.UtcNow;
        public string? Grade { get; set; } // e.g., "A", "B+"
        public bool IsAudit { get; set; } = false;

        // Navigation Properties
        public int StudentId { get; set; }
        public Student Student { get; set; } = null!;

        public int CourseOfferingId { get; set; }
        public CourseOffering CourseOffering { get; set; } = null!;

    }
}
