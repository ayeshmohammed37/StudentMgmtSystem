using StudentMgmtSystem.Models.AcademicProgramModel;
using StudentMgmtSystem.Models.AdvisorModel;
using StudentMgmtSystem.Models.EnrollmentModel;

namespace StudentMgmtSystem.Models.StudentModel
{
    public class Student
    {
        public int Id { get; set; }
        public string StudentId { get; set; } = null!; // University ID
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? PhoneNumber { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string Status { get; set; } = "Active"; // Active, Graduated, Withdrawn

        // Navigation Properties
        public int? AcademicProgramId { get; set; }
        public AcademicProgram? AcademicProgram { get; set; }

        public int? AdvisorId { get; set; }
        public Advisor? Advisor { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; } = new HashSet<Enrollment>();
    }
}
