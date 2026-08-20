using System.ComponentModel.DataAnnotations.Schema;

namespace HelpDesk_System.Models
{
    [Table("Tickets")]
    public class Ticket
    {
        public int Id { get; set; } 

        public int CustomerId { get; set; }
        public int CategoryId { get; set; }
        public string TicketNumber { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Priority { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string CreatedAt { get; set; } = string.Empty;
        public string? UpdatedAt { get; set; }


        public Customer? Customer { get; set; }
        public Category? Category { get; set; }

        public ICollection<TicketAssignment> TicketAssignments { get; set; } = new List<TicketAssignment>();
        public ICollection<TicketComment> TicketComments { get; set; } = new List<TicketComment>();
        public ICollection<TicketTags> TicketTags { get; set; } = new List<TicketTags>();
        public ICollection<TicketAttachment> TicketAttachments { get; set; } = new List<TicketAttachment>();
    }
}