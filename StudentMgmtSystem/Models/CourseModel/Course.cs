using StudentMgmtSystem.Models.CourseOfferingModel;
using StudentMgmtSystem.Models.CurriculumModel;
using StudentMgmtSystem.Models.DepartmentModel;

namespace StudentMgmtSystem.Models.CourseModel
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseCode { get; set; } = null!; // e.g., "CS101"
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public int Credits { get; set; } = 3;
        public bool IsActive { get; set; } = true;

        // Navigation Properties
        public int DepartmentId { get; set; }
        public Department Department { get; set; } = null!;

        public ICollection<Curriculum> Curricula { get; set; } = new HashSet<Curriculum>();
        public ICollection<CourseOffering> Offerings { get; set; } = new HashSet<CourseOffering>();
        public ICollection<Course> Prerequisites { get; set; } = new HashSet<Course>();
        public ICollection<Course> IsPrerequisiteFor { get; set; } = new HashSet<Course>();
    }
}
