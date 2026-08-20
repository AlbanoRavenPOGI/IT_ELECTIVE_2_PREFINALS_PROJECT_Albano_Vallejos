using Microsoft.EntityFrameworkCore;
using HelpDesk_System.Models;

namespace HelpDesk_System.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<TicketAssignment> TicketAssignments { get; set; }
        public DbSet<TicketComment> TicketComments { get; set; }
        public DbSet<TicketTags> TicketTags { get; set; }
        public DbSet<Tags> Tags { get; set; }
        public DbSet<TicketAttachment> TicketAttachments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

           
            modelBuilder.Entity<TicketAssignment>(entity =>
            {
                entity.ToTable("TicketAssignments");
                entity.HasKey(t => new { t.TicketId, t.EmployeeId });
            });

          
            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.ToTable("Tickets");
                entity.HasKey(e => e.Id);
            });

           
            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("TicketCategories");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).HasColumnName("CategoryId");
            });

           
            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("Departments");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).HasColumnName("DepartmentId");
            });

           
            modelBuilder.Entity<TicketComment>(entity =>
            {
                entity.ToTable("TicketComments");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).HasColumnName("TicketCommentId");
            });

           
            modelBuilder.Entity<TicketTags>(entity =>
            {
                entity.ToTable("TicketTags");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).HasColumnName("TicketTagId");
            });

            modelBuilder.Entity<Tags>(entity =>
            {
                entity.ToTable("Tags");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).HasColumnName("TagId");
            });

            modelBuilder.Entity<TicketAttachment>(entity =>
            {
                entity.ToTable("TicketAttachments");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).HasColumnName("TicketAttachmentId");
            });
        }
    }
}