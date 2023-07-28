using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VacationManagement.Models.EntitiesConfigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<IdentityUser>
    {
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            builder.HasData(new List<IdentityUser>(){
                new IdentityUser() {
                    Id = "f6a0c649-5e88-4e33-a5b9-3a7b9911a21e",
                    UserName="Manager",
                    Email="Manager@Email.com",
                    NormalizedEmail="MANAGER@EMAIL.COM",
                    NormalizedUserName="MANAGER",
                    PasswordHash = "AQAAAAIAAYagAAAAEM6bztfW4lSrkXqVBXPaXhBGUIAznEuiidOvk5ojWngU0HnGQVxaZOPVaZGMdzhvIg=="
                },
                new IdentityUser() {
                    Id = Guid.NewGuid().ToString(),
                    UserName="Employee",
                    Email="Employee@gmail.com",
                    NormalizedEmail="EMPLOYEE@GMAIL.COM",
                    NormalizedUserName="EMPLOYEE",
                    PasswordHash = "AQAAAAIAAYagAAAAEM6bztfW4lSrkXqVBXPaXhBGUIAznEuiidOvk5ojWngU0HnGQVxaZOPVaZGMdzhvIg=="
                }
            });
        }
    }
}
