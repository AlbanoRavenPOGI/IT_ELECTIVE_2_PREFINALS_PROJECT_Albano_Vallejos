namespace HelpDesk_System.Models
{
    public class Tickets
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
    }
}