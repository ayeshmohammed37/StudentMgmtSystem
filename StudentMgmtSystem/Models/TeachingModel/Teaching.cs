using StudentMgmtSystem.Models.CourseModel;
using StudentMgmtSystem.Models.InstructorModel;

namespace StudentMgmtSystem.Models.TeachingModel
{
    public class Teaching
    {
        // Primary Key
        public int Id { get; set; }
        // Relation between Instructor and Course Many to Many

        public int CourseId { get; set; }
        public int InstructorId { get; set; }

        public Course Course { get; set; }
        public Instructor Instructor { get; set; }
    }
}
