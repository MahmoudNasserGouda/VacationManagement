using VacationManagement.Models.Entities;
using VacationManagement.ViewModels;

namespace VacationManagement.Repositories
{
    public interface IDepartmentRepository
    {
        Task<List<Department>> GetDepartments();
    }
}
