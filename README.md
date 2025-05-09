# Student Information System (SIS) - ASP.NET MVC

A web-based Student Information System (SIS) built using **ASP.NET MVC**, **Entity Framework**, and **SQL Server**. This system allows administrators and faculty to manage student records, courses, grades, and other academic information efficiently.

## 📌 Features

- 🧑‍🎓 Student Registration and Management
- 📚 Course Management
- 🧾 Grades and Transcripts Management
- 👥 Role-Based Authentication (Admin, Teacher, Student)
- 🔍 Search and Filtering
- 📊 Dashboard with Academic Statistics
- 📅 Attendance Tracking (Optional)
- 📁 File Upload (Profile images, documents, etc.)
- 🔒 Secure login and password hashing

## 🛠️ Technologies Used

- ASP.NET MVC 5
- Entity Framework 6 (Code First)
- SQL Server
- HTML5, CSS3, JavaScript, Bootstrap
- Identity Framework for Authentication

## 📂 Project Structure

SIS/
│
├── Controllers/
├── Models/
├── Views/
│ ├── Shared/
│ ├── Student/
│ ├── Course/
│ └── Account/
├── Migrations/
├── Scripts/
├── Content/
├── App_Start/
└── Web.config


## 🚀 Getting Started

### Prerequisites

- Visual Studio 2019 or later
- SQL Server or SQL Server Express
- .NET Framework 4.7.2 or later

### Setup Instructions

1. **Clone the repository**
   ```bash
   git clone https://github.com/your-username/student-information-system.git
   cd student-information-system
2. Open in Visual Studio

3. Restore NuGet Packages
   Visual Studio should automatically restore the packages on build.

4. Configure Database Connection
   Update the Web.config file with your SQL Server connection string.

5. Apply Migrations (if using Code First)
   Open the Package Manager Console:
   Update-Database
6. Run the Application
   Press F5 or click on the green "Start" button in Visual Studio.

👤 User Roles
| Role    | Permissions                       |
| ------- | --------------------------------- |
| Admin   | Full access to all features       |
| Teacher | Manage students and grades        |
| Student | View grades, profile, and courses |

✅ Future Enhancements
   Email Notifications
   Export to PDF/Excel
   Real-time Chat/Announcements
   Mobile Responsive Enhancements
🧑‍💻 Authors
   
