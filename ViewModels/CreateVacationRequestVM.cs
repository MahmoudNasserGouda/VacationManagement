using VacationManagement.Models.Entities;

namespace VacationManagement.ViewModels
{
    public class CreateVacationRequestVM
    {
        public Guid Id { get; set; }
        public string EmployeeName { get; set; }
        public string Title { get; set; }
        public Guid DepartmentId { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string? Notes { get; set; }
    }
}
