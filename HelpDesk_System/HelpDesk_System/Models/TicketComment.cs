using System.Net.Sockets;

namespace HelpDesk_System.Models
{
    public class TicketComment
    {
        public int Id { get; set; }
        public int TicketId { get; set; }
        public int AuthorEmployeeId { get; set; }
        public string CommentText { get; set; } = string.Empty;
        public string CreatedAt { get; set; } = string.Empty;

        public Ticket? Ticket { get; set; }
        public Employee? Author { get; set; }
    }
}