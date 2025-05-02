using StudentMgmtSystem.Models.CourseModel;
using StudentMgmtSystem.Models.InstructorModel;

namespace StudentMgmtSystem.Models.AssignmentModel
{
    public class Assignment
    {
        // Primery Key
        public int Id { get; set; }

        // Assignment Details
        public string Title { get; set; }
        public string Description { get; set; }
        public double Points { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime Deadline { get; set; }
        public DateTime? ExtendedDueDate { get; set; } // Optional not nessecary
        public AssignmantType AssignmantType { get; set; }
        //public int InstructorId { get; set; }
        public int CourseId { get; set; }


        // Navigation Properties
        //public Instructor Instructor { get; set; }
        public Course Course { get; set; }
    }
}
