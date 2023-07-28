using Microsoft.EntityFrameworkCore;
using VacationManagement.Data;
using VacationManagement.Models.Entities;
using VacationManagement.ViewModels;

namespace VacationManagement.Repositories
{
    public class VacationRequestRepository : IVacationRequestRepository
    {
        private readonly VacationDbContext _context;
        public VacationRequestRepository(VacationDbContext context)
        {
            _context = context;
        }

        public async Task CreateVacationRequest(CreateVacationRequestVM vacationRequestVM)
        {
            VacationRequest vacationRequest = new VacationRequest()
            {
                Id = vacationRequestVM.Id,
                SubmissionDate = DateTime.UtcNow,
                EmployeeName = vacationRequestVM.EmployeeName,
                Title = vacationRequestVM.Title,
                DepartmentId = vacationRequestVM.DepartmentId,
                DateFrom = vacationRequestVM.DateFrom,
                DateTo = vacationRequestVM.DateTo,
                Returning = (vacationRequestVM.DateTo.DayOfWeek < DayOfWeek.Thursday) ? vacationRequestVM.DateTo.AddDays(1) : vacationRequestVM.DateTo.AddDays(1 + (6 - (int)vacationRequestVM.DateTo.DayOfWeek)),
                TotalNumberOfDays = (vacationRequestVM.DateTo.DayOfYear - vacationRequestVM.DateFrom.DayOfYear) + (365 * (vacationRequestVM.DateTo.Year - vacationRequestVM.DateFrom.Year)),
                Notes = vacationRequestVM.Notes,
            };

            await _context.VacationRequests.AddAsync(vacationRequest);
            await _context.SaveChangesAsync();
        }

        public async Task<VacationRequest> GetVacationRequest(Guid Id)
        {
            return await _context.VacationRequests.Include(x => x.Department).Where(x => x.Id.Equals(Id)).FirstAsync();
        }

        public async Task<List<ListVacationRequestsVM>> ListVacationRequests()
        {
            var vacationRequests = await _context.VacationRequests.Include(x => x.Department).ToListAsync();
            List<ListVacationRequestsVM> vacationRequestsVM = new List<ListVacationRequestsVM>();
            foreach (var request in vacationRequests)
            {
                ListVacationRequestsVM requestVM = new ListVacationRequestsVM() 
                {
                    Id = request.Id,
                    SubmissionDate = request.SubmissionDate,
                    EmployeeName = request.EmployeeName,
                    Department = request.Department.Name,
                    DateFrom = request.DateFrom,
                    DateTo = request.DateTo,
                };
                vacationRequestsVM.Add(requestVM);
            }
            return vacationRequestsVM;
        }
    }
}
