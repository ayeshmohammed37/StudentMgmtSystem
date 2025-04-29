using StudentMgmtSystem.Models.CourseOfferingModel;

namespace StudentMgmtSystem.Models.SemesterModel
{
    public class Semester
    {
        //Primary Key
        public int Id { get; set; }


        // Semester Information
        public string Name { get; set; } // "Fall 2023", "Spring 2024",...
        public string Code { get; set; } // "FA23", SP24", "SU25", ....
        public string AcademicYear { get; set; } // "2018-2017"
        public SemesterTerm SemesterTerm { get; set; } // First, Second, Summer
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // Navigation Properties
        public List<CourseOffering> CourseOfferings { get; set; }
    }
}
