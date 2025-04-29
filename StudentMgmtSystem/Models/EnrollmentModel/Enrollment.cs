using StudentMgmtSystem.Models.CourseOfferingModel;
using StudentMgmtSystem.Models.StudentModel;

namespace StudentMgmtSystem.Models.EnrollmentModel
{
    public class Enrollment
    {
        // Primary Key
        public int Id { get; set; }

        //Foreign Key
        public int StudentId { get; set; }
        public int CoursOfferingId { get; set; }

        // Enrollment Details Details
        public string Grade { get; set; } // "A", "B", ..., "FR", "AB"
        public DateTime EnrollmentDate { get; set; }

        // Navigation Properties
        public Student Student { get; set; }
        public CourseOffering CourseOffering { get; set; }
    }
}
