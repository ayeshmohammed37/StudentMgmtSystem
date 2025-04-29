using StudentMgmtSystem.Models.CourseModel;
using StudentMgmtSystem.Models.EnrollmentModel;
using StudentMgmtSystem.Models.InstructorModel;
using StudentMgmtSystem.Models.SemesterModel;

namespace StudentMgmtSystem.Models.CourseOfferingModel
{
    public class CourseOffering
    {
        // Primery Key
        public int Id { get; set; }

        // Foreign Keys
        public int SemesterId { get; set; }
        public int CourseId { get; set; }
        public int InstructorId { get; set; }

        // Details
        public int Capacity { get; set; }
        public int Enrolled { get; set; }
        public string Location { get; set; } // "Building A. Room 101"
        public string Schedule { get; set; } // "Mon,Sat 10:00-11:30"


        // Navigation Properties
        public Semester Semester { get; set; }
        public Course Course { get; set; }
        public Instructor Instructor { get; set; }
        public List<Enrollment> Enrollments { get; set; }

    }
}
