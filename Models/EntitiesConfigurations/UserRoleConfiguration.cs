using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models.EntitiesConfiguration
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(new List<IdentityUserRole<string>>(){
                new IdentityUserRole<string>()
                {
                    RoleId = "8FB4E1AB-7B7E-4A8C-AF5F-CE2D2D5E9188",
                    UserId = "f6a0c649-5e88-4e33-a5b9-3a7b9911a21e",
                }
            });
        }
    }
}
