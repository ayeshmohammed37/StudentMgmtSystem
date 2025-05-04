using StudentMgmtSystem.Models.CourseOfferingModel;

namespace StudentMgmtSystem.Models.SemesterModel
{
    public class Semester
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!; // e.g., "Fall 2023"
        public string Code { get; set; } = null!; // e.g., "FA23"
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsCurrent { get; set; } = false;

        // Navigation Properties
        public ICollection<CourseOffering> CourseOfferings { get; set; } = new HashSet<CourseOffering>();

    }
}
