namespace HelpDesk_System.Models
{
    public class TeamMember
    {
        public int TeamId { get; set; }
        public int EmployeeId { get; set; }
        public string JoinedAt { get; set; } = string.Empty;

        public Team? Team { get; set; }
        public Employee? Employee { get; set; }
    }
}