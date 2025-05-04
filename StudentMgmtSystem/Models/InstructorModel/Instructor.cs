using StudentMgmtSystem.Models.CourseOfferingModel;
using StudentMgmtSystem.Models.DepartmentModel;

namespace StudentMgmtSystem.Models.InstructorModel
{
    public class Instructor
    {
        public int Id { get; set; }
        public string InstructorId { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? OfficeLocation { get; set; }
        public string? OfficeHours { get; set; }

        // Navigation Properties
        public int DepartmentId { get; set; }
        public Department Department { get; set; } = null!;

        public ICollection<CourseOffering> CourseOfferings { get; set; } = new HashSet<CourseOffering>();
    }
}
