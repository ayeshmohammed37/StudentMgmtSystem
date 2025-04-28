namespace StudentMgmtSystem.Models
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
        //public int? DepartmentMgrId { get; set; }
        //public string? DepartmentMgrName { get; set; }

        //Navigation Properties
        // Student Enrolled in this Department
        public List<Student> Students { get; set; }
        public List<Instructor> Instructors { get; set; }


    }
}
