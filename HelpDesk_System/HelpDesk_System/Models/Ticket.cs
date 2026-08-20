using HelpDesk_System.Models;
using Microsoft.EntityFrameworkCore;
using System.Net.Sockets;

namespace HelpDesk_System.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Department> Departments => Set<Department>();
        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<Team> Teams => Set<Team>();
        public DbSet<TeamMember> TeamMembers => Set<TeamMember>();
        public DbSet<Customer> Customers => Set<Customer>();
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<Ticket> Tickets => Set<Ticket>(); // Inayos mula 'Tickets' papuntang 'Ticket'
        public DbSet<TicketAssignment> TicketAssignments => Set<TicketAssignment>();
        public DbSet<TicketComment> TicketComments => Set<TicketComment>();
        public DbSet<TicketHistory> TicketHistories => Set<TicketHistory>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Table Mappings
            modelBuilder.Entity<Department>().ToTable("Departments");
            modelBuilder.Entity<Employee>().ToTable("Employees");
            modelBuilder.Entity<Team>().ToTable("Teams");
            modelBuilder.Entity<TeamMember>().ToTable("TeamMembers").HasKey(tm => new { tm.TeamId, tm.EmployeeId });
            modelBuilder.Entity<Customer>().ToTable("Customers");
            modelBuilder.Entity<Category>().ToTable("Categories");
            modelBuilder.Entity<Ticket>().ToTable("Tickets");
            modelBuilder.Entity<TicketAssignment>().ToTable("TicketAssignments");
            modelBuilder.Entity<TicketComment>().ToTable("TicketComments");
            modelBuilder.Entity<TicketHistory>().ToTable("TicketHistory");

            // Relationships / Foreign Keys Configuration
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Department)
                .WithMany(d => d.Employees)
                .HasForeignKey(e => e.DepartmentId);

            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.Customer)
                .WithMany()
                .HasForeignKey(t => t.CustomerId);

            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.Category)
                .WithMany()
                .HasForeignKey(t => t.CategoryId);

            modelBuilder.Entity<TicketAssignment>()
                .HasOne(ta => ta.Ticket)
                .WithMany()
                .HasForeignKey(ta => ta.TicketId);

            modelBuilder.Entity<TicketAssignment>()
                .HasOne(ta => ta.AssignedEmployee)
                .WithMany()
                .HasForeignKey(ta => ta.AssignedToEmployeeId);

            modelBuilder.Entity<TicketComment>()
                .HasOne(tc => tc.Ticket)
                .WithMany()
                .HasForeignKey(tc => tc.TicketId);

            modelBuilder.Entity<TicketComment>()
                .HasOne(tc => tc.Author)
                .WithMany()
                .HasForeignKey(tc => tc.AuthorEmployeeId);
        }
    }
}