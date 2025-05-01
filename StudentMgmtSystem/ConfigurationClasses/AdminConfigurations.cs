using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentMgmtSystem.Models.AdminModel;

namespace StudentMgmtSystem.ConfigurationClasses
{
    public class AdminConfigurations : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {

            // Admin-Student 
            builder.HasMany(a => a.Students)
                .WithOne(s => s.Admin)
                .HasForeignKey(s => s.AdminId)
                .OnDelete(DeleteBehavior.Restrict);



            // Admin-Notification 
            builder.HasMany(a => a.Notifications)
                .WithOne(n => n.Admin)
                .HasForeignKey(n => n.SenderId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
