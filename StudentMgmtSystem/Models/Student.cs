namespace StudentMgmtSystem.Models
{
    public class Student
    {
        // Primary Key
        public int Id { get; set; }

        // Idendification
        public string StudentId { get; set; } // Institution-assigned ID (e.g., "800453123")
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


        // Authentication
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }


        // Academic Information
        public double CGPA { get; set; }
        public int DepartmentId { get; set; } // Foreign Key to Department
        public DateTime EnrollmentDate { get; set; } // joining institution or College
        public DateTime? GraduationDate { get; set; }
        public ClassStanding ClassStanding { get; set; } // Freshman, Sophomore, Junior, Senior
        public EnrollmentStatus EnrollmentStatus { get; set; } // Active, OnLeave, Graduated, Withdrawn, Suspended


        // Navigation Properties
        public Department Department { get; set; }

    }
}
