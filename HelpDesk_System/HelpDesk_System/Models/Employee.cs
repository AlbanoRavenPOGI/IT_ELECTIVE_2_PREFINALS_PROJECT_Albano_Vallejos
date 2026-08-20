namespace HelpDesk_System.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string JobTitle { get; set; } = string.Empty;
        public string HireDate { get; set; } = string.Empty;
        public int IsActive { get; set; } = 1;

        public Department? Department { get; set; }
    }
}