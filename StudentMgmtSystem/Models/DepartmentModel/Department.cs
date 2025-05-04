using StudentMgmtSystem.Models.AcademicProgramModel;
using StudentMgmtSystem.Models.CourseModel;
using StudentMgmtSystem.Models.InstructorModel;

namespace StudentMgmtSystem.Models.DepartmentModel
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Code { get; set; } = null!; // e.g., "CS"
        public string? OfficeLocation { get; set; }

        // Navigation Properties
        public ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();
        public ICollection<Course> Courses { get; set; } = new HashSet<Course>();
        public ICollection<AcademicProgram> AcademicPrograms { get; set; } = new HashSet<AcademicProgram>();

    }
}
