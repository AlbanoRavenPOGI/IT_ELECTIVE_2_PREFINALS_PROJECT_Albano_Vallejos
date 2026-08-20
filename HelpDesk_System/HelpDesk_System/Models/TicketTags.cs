using System.ComponentModel.DataAnnotations.Schema;

namespace HelpDesk_System.Models
{
    [Table("TicketTags")]
    public class TicketTags
    {
        [Column("TicketTagId")]
        public int Id { get; set; }

        public int TicketId { get; set; }
        public int TagId { get; set; }


        public Ticket? Ticket { get; set; }
        public Tags? Tags { get; set; }
    }
}