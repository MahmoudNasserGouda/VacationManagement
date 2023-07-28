using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VacationManagement.Models.Entities;

namespace VacationManagement.Models.EntitiesConfigurations
{
    public class VacationRequestConfiguration : IEntityTypeConfiguration<VacationRequest>
    {
        public void Configure(EntityTypeBuilder<VacationRequest> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.SubmissionDate).IsRequired().HasDefaultValueSql("GETUTCDATE()");
            builder.Property(x => x.EmployeeName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Title).IsRequired();
            builder.Property(x => x.DateFrom).IsRequired();
            builder.Property(x => x.DateTo).IsRequired();
            builder.Property(x => x.Returning).IsRequired();
            builder.Property(x => x.TotalNumberOfDays).IsRequired();
            builder.Property(x => x.Notes).IsRequired(false).HasMaxLength(1000);
            builder.HasOne(x => x.Department).WithMany();
        }
    }
}
