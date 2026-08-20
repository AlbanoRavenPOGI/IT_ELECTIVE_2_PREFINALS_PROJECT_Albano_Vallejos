using System.Net.Sockets;

namespace HelpDesk_System.Models
{
    public class TicketAssignment
    {
        public int Id { get; set; }
        public int TicketId { get; set; }
        public int AssignedToEmployeeId { get; set; }
        public string AssignedAt { get; set; } = string.Empty;

        public Tickets? Ticket { get; set; }
        public Employee? AssignedEmployee { get; set; }
    }
}