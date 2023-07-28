using VacationManagement.Models.Entities;
using VacationManagement.ViewModels;

namespace VacationManagement.Repositories
{
    public interface IVacationRequestRepository
    {
        Task CreateVacationRequest(CreateVacationRequestVM vacationRequestVM);
        Task<VacationRequest> GetVacationRequest(Guid Id);
        Task<List<ListVacationRequestsVM>> ListVacationRequests();
    }
}
