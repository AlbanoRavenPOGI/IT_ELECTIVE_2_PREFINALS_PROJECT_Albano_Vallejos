using System.Net.Sockets;

namespace HelpDesk_System.Models
{
    public class TicketHistory
    {
        public int Id { get; set; }
        public int TicketId { get; set; }
        public string Action { get; set; } = string.Empty;
        public string ChangedAt { get; set; } = string.Empty;

        public Tickets? Ticket { get; set; }
    }
}