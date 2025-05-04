using StudentMgmtSystem.Models.InstructorModel;
using StudentMgmtSystem.Models.StudentModel;

namespace StudentMgmtSystem.Models.AdvisorModel
{
    public class Advisor : Instructor
    {
        public int MaxAdvisees { get; set; } = 20;
        public string? Specialization { get; set; }

        // Navigation Properties
        public ICollection<Student> Advisees { get; set; } = new HashSet<Student>();
    }
}
