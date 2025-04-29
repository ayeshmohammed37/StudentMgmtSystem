using StudentMgmtSystem.Models.CourseModel;
using StudentMgmtSystem.Models.InstructorModel;
using StudentMgmtSystem.Models.StudentModel;

namespace StudentMgmtSystem.Models.DepartmentModel
{
    public class Department
    {
        // Primery Key
        public int Id { get; set; }

        // Basic Information
        public string Code { get; set; } // CS, IS, ECE, PME,...
        public string Name { get; set; }
        public string Description { get; set; }


        // Mangment Information
        public int SupervisorId { get; set; } // Foreign Key to Instructor

        //Navigation Properties
        // Student Enrolled in this Department
        public List<Student> Students { get; set; }
        public List<Instructor> Instructors { get; set; }
        public List<Course> Courses { get; set; }
        public Instructor Supervisor { get; set; } //  nav-prop for the instructor who manage department

    }
}
