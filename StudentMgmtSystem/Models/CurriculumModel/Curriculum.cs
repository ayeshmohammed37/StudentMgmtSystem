using StudentMgmtSystem.Models.AcademicProgramModel;
using StudentMgmtSystem.Models.CourseModel;

namespace StudentMgmtSystem.Models.CurriculumModel
{
    public class Curriculum
    {
        public int Id { get; set; }
        public bool IsCoreRequirement { get; set; } = true;
        public int RecommendedSemester { get; set; } = 1;

        // Navigation Properties
        public int AcademicProgramId { get; set; }
        public AcademicProgram AcademicProgram { get; set; } = null!;

        public int CourseId { get; set; }
        public Course Course { get; set; } = null!;
    }
}
