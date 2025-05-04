using StudentMgmtSystem.Models.CourseModel;
using StudentMgmtSystem.Models.EnrollmentModel;
using StudentMgmtSystem.Models.InstructorModel;
using StudentMgmtSystem.Models.SemesterModel;

namespace StudentMgmtSystem.Models.CourseOfferingModel
{
    public class CourseOffering
    {
        public int Id { get; set; }
        public string Section { get; set; } = null!; // e.g., "01"
        public int Capacity { get; set; } = 30;
        public string? Schedule { get; set; } // e.g., "MWF 10:00-10:50"
        public string? Location { get; set; }

        // Navigation Properties
        public int CourseId { get; set; }
        public Course Course { get; set; } = null!;

        public int SemesterId { get; set; }
        public Semester Semester { get; set; } = null!;

        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; } = null!;

        public ICollection<Enrollment> Enrollments { get; set; } = new HashSet<Enrollment>();
    }
}
