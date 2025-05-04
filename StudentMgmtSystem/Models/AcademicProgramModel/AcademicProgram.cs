using StudentMgmtSystem.Models.CurriculumModel;
using StudentMgmtSystem.Models.DepartmentModel;
using StudentMgmtSystem.Models.StudentModel;


namespace StudentMgmtSystem.Models.AcademicProgramModel
{
    public class AcademicProgram
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Code { get; set; } = null!; // e.g., "BSCS"
        public string DegreeType { get; set; } = "Bachelor";
        public int TotalCreditsRequired { get; set; } = 120;

        // Navigation Properties
        public int DepartmentId { get; set; }
        public Department Department { get; set; } = null!;

        public ICollection<Student> Students { get; set; } = new HashSet<Student>();
        public ICollection<Curriculum> Curricula { get; set; } = new HashSet<Curriculum>();
    }
}
