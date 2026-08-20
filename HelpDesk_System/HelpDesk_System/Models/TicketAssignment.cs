using System.ComponentModel.DataAnnotations.Schema;

namespace HelpDesk_System.Models
{
    [Table("TicketAssignments")]
    public class TicketAssignment
    {
        public int TicketId { get; set; }
        public int EmployeeId { get; set; }
        public string AssignedAt { get; set; } = string.Empty;
        public string? UnassignedAt { get; set; }
        public int IsPrimary { get; set; }
        public Ticket? Ticket { get; set; }
        public Employee? Employee { get; set; }
    }
}