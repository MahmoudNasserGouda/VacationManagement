using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VacationManagement.Models.Entities;
using VacationManagement.Models.EntitiesConfigurations;
using WebApplication1.Models.EntitiesConfiguration;
using VacationManagement.ViewModels;

namespace VacationManagement.Data
{
    public class VacationDbContext : IdentityDbContext<IdentityUser>
    {
        public VacationDbContext() { }

        public VacationDbContext(DbContextOptions<VacationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new DepartmentConfiguration());
            builder.ApplyConfiguration(new VacationRequestConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new UserRoleConfiguration());

            base.OnModelCreating(builder);
        }

        public virtual DbSet<VacationRequest> VacationRequests { get; set;}
        public virtual DbSet<Department> Departments { get; set;}
        public DbSet<VacationManagement.ViewModels.ListVacationRequestsVM>? ListVacationRequestsVM { get; set; }
        public DbSet<VacationManagement.ViewModels.CreateVacationRequestVM>? CreateVacationRequestVM { get; set; }
    }
}
