namespace HelpDesk_System.Models
{
    public class Team
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }

        public Department? Department { get; set; }
    }
}