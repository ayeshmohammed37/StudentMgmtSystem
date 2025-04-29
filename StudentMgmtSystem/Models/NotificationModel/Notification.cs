using StudentMgmtSystem.Models.AdminModel;
using StudentMgmtSystem.Models.StudentModel;

namespace StudentMgmtSystem.Models.NotificationModel
{
    public class Notification
    {
        public int Id { get; set; }


        // Notification Details
        public string Title { get; set; }
        public string Message { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? SendDate { get; set; }
        public bool IsRead { get; set; } = false;
        public DateTime? ReadDate { get; set; }
        public int SenderId { get; set; }   // Foreign Key for Admin
        public int StudentId { get; set; }  // Foreign Key for Student 


        // Navigation Properties
        public Admin Admin { get; set; } // Admin Who send the notification
        public Student Student { get; set; }    // Student Who recived notification
    }
}
