using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentMgmtSystem.Models.DepartmentModel;

namespace StudentMgmtSystem.ConfigurationClasses
{
    public class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasOne(d => d.Supervisor)
                .WithOne(i => i.SupervisedDepartment)
                .HasForeignKey<Department>(d => d.SupervisorId)
                .OnDelete(DeleteBehavior.SetNull); new NotImplementedException();
        }
    }
}
