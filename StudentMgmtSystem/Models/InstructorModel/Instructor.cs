using StudentMgmtSystem.Models.AssignmentModel;
using StudentMgmtSystem.Models.CourseOfferingModel;
using StudentMgmtSystem.Models.DepartmentModel;
using StudentMgmtSystem.Models.StudentModel;
using StudentMgmtSystem.Models.TeachingModel;

namespace StudentMgmtSystem.Models.InstructorModel
{
    public class Instructor
    {
        // Primery Key
        public int Id { get; set; }

        // Identification
        public string InstructorId { get; set; }
        public string NationalId { get; set; }

        //personal Information
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public string Nationality { get; set; }
        public string Email { get; set; }
        public string PhoneNmber { get; set; }
        public string Governorate { get; set; }
        public string Address { get; set; }

        // Professional/Employee  Information
        public DateTime HireDate { get; set; }
        public DateTime? EndDate { get; set; } // For former instructors
        public string Title { get; set; } // Professor, Associate Professor, Assistant Professor, etc.
        public string HighestDegree { get; set; }  // Ph.D., Masters, etc
        public decimal Salary { get; set; }
        public string Biography { get; set; }
        public string OfficeHours { get; set; }
        public Status Status { get; set; }  // FullTime, PartTime, Adjunct
        public int DepartmentId { get; set; } // Foreign Key For Departmen's  belong to


        // Authentication
        public string UserName { get; set; }
        public string Password { get; set; }
        //public string PasswordHash { get; set; }
        //public string PasswordSalt { get; set; }


        // Navigation Properties
        public Department Department { get; set; }
        public List<Teaching> Teachings { get; set; }
        //public List<CourseOffering> CourseOfferings { get; set; }
        public List<Student> Students { get; set; } //Academic advisor for students
        //public Department? SupervisedDepartment { get; set; }  // Supervisor role
        //public List<Assignment> Assignments { get; set; }

    }
}
