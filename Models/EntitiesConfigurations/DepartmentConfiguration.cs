using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VacationManagement.Models.Entities;

namespace VacationManagement.Models.EntitiesConfigurations
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
            builder.HasData(new List<Department>()
            {
                new Department()
                {
                    Id = Guid.NewGuid(),
                    Name = "SD",
                },
                new Department()
                {
                    Id = Guid.NewGuid(),
                    Name = "Marketing",
                },
                new Department()
                {
                    Id = Guid.NewGuid(),
                    Name = "QC",
                },
                new Department()
                {
                    Id = Guid.NewGuid(),
                    Name = "HR",
                },
                new Department()
                {
                    Id = Guid.NewGuid(),
                    Name = "Sales",
                }
            });
        }
    }
}
