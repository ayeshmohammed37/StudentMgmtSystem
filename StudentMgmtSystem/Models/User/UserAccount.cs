namespace StudentMgmtSystem.Models.User
{
    public class UserAccount
    {
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public string Email { get; set; } = null!;
        public bool IsActive { get; set; } = true;
        public DateTime LastLogin { get; set; }

        // Navigation Properties
        public ICollection<UserRole> UserRoles { get; set; } = new HashSet<UserRole>();
    }

    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!; // "Student", "Instructor", "Admin"
        public string? Description { get; set; }

        // Navigation Properties
        public ICollection<UserRole> UserRoles { get; set; } = new HashSet<UserRole>();
    }

    public class UserRole
    {
        public int UserAccountId { get; set; }
        public UserAccount UserAccount { get; set; } = null!;

        public int RoleId { get; set; }
        public Role Role { get; set; } = null!;
    }


}
