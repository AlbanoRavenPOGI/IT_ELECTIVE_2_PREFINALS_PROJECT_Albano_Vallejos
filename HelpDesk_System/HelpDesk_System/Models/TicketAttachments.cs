using System.ComponentModel.DataAnnotations.Schema;

namespace HelpDesk_System.Models
{
    [Table("TicketAttachments")]
    public class TicketAttachment
    {
        [Column("TicketAttachmentId")]
        public int Id { get; set; }

        public int TicketId { get; set; }
        public string FileName { get; set; } = string.Empty;
        public string FilePath { get; set; } = string.Empty;

        public Ticket? Ticket { get; set; }
    }
}