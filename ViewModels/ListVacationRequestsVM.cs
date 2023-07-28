using VacationManagement.Models.Entities;

namespace VacationManagement.ViewModels
{
    public class ListVacationRequestsVM
    {
        public Guid Id { get; set; }
        public DateTime SubmissionDate { get; set; }
        public string EmployeeName { get; set; }
        public string Department { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
    }
}
