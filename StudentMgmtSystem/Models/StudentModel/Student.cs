using StudentMgmtSystem.Models.AdminModel;
using StudentMgmtSystem.Models.DepartmentModel;
using StudentMgmtSystem.Models.EnrollmentModel;
using StudentMgmtSystem.Models.InstructorModel;
using StudentMgmtSystem.Models.NotificationModel;
using StudentMgmtSystem.Models.TakedExamModel;

namespace StudentMgmtSystem.Models.StudentModel
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
        public string Password { get; set; }

        //public string PasswordHash { get; set; }
        //public string PasswordSalt { get; set; }


        // Academic Information
        public double CGPA { get; set; }
        public int DepartmentId { get; set; } // Foreign Key to Department
        public int InstructorId { get; set; } // Advisor
        public int AdminId { get; set; } // the Admin who'manage student
        public DateTime EnrollmentDate { get; set; } // joining institution or College
        public DateTime? GraduationDate { get; set; }
        public ClassStanding ClassStanding { get; set; } // Freshman, Sophomore, Junior, Senior
        public EnrollmentStatus EnrollmentStatus { get; set; } // Active, OnLeave, Graduated, Withdrawn, Suspended


        // Navigation Properties
        public Department Department { get; set; }
        public List<Enrollment> Enrollments { get; set; }
        public Instructor Instructor { get; set; }
        public List<TakedExam> TakedExams { get; set; }
        public Admin Admin { get; set; }
        public List<Notification> Notifications { get; set; }

    }
}
