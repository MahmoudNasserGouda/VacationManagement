namespace VacationManagement.Models.Entities
{
    public class VacationRequest
    {
        public Guid Id { get; set; }
        public DateTime SubmissionDate { get; set; }
        public string EmployeeName { get; set; }
        public string Title { get; set; }
        public Guid DepartmentId { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public DateTime Returning { get; set; }
        public int TotalNumberOfDays { get; set; }
        public string? Notes { get; set; }
        public virtual Department Department { get; set; }
    }
}
