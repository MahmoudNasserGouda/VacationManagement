using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication1.Models.EntitiesConfiguration
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(new List<IdentityRole>(){
                new IdentityRole()
                {
                    Id = "8FB4E1AB-7B7E-4A8C-AF5F-CE2D2D5E9188",
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                }
            });
        }
    }
}
