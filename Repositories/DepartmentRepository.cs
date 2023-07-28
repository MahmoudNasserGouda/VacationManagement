using Microsoft.EntityFrameworkCore;
using VacationManagement.Data;
using VacationManagement.Models.Entities;

namespace VacationManagement.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly VacationDbContext _context;
        public DepartmentRepository(VacationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> GetDepartments()
        {
            return await _context.Departments.ToListAsync();
        }
    }
}
