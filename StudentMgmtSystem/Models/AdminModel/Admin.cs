using StudentMgmtSystem.Models.NotificationModel;
using StudentMgmtSystem.Models.StudentModel;

namespace StudentMgmtSystem.Models.AdminModel
{
    public class Admin
    {
        // Primary Key
        public int Id { get; set; }

        // Identification
        public string EmployeeId { get; set; } // Institutional ID "ADM-1001"
        public string NationalId { get; set; }

        // Personal Information
        public string FullName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime HireDate { get; set; }


        // Authentication
        //public string UserName { get; set; }
        //public string Password { get; set; }
        //public string PasswordHash { get; set; }  
        //public string PasswordSalt { get; set; }

        // Navigation Properties
        public List<Student> Students { get; set; }
        public List<Notification> Notifications { get; set; }
    }

}
