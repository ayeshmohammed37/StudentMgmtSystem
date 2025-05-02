using StudentMgmtSystem.Models.AssignmentModel;
using StudentMgmtSystem.Models.CourseOfferingModel;
using StudentMgmtSystem.Models.DepartmentModel;
using StudentMgmtSystem.Models.ExamModel;
using StudentMgmtSystem.Models.TeachingModel;

namespace StudentMgmtSystem.Models.CourseModel
{
    public class Course
    {
        // Primery Key
        public int Id { get; set; }

        // Course Information
        public string Code { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; } //3,4,2,..
        public string Description { get; set; }
        public string LearningOutcomes { get; set; }
        public CourseStatus CourseStatus { get; set; }
        public int DepartmentId { get; set; } // Foreign Key for the Department's Course


        // Navigation Properties
        public Department Department { get; set; }
        public List<Teaching> Teachings { get; set; }
        //public List<CourseOffering> CourseOfferings { get; set; }
        public List<Assignment> Assignments { get; set; }
        public List<Exam> Exams { get; set; }
    }
}
