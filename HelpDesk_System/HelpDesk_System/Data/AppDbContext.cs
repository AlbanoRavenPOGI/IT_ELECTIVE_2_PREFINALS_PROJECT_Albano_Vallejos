using Microsoft.EntityFrameworkCore;
using HelpDesk_System.Models;

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
        public DbSet<Ticket> Tickets => Set<Ticket>();
        public DbSet<TicketAssignment> TicketAssignments => Set<TicketAssignment>();
        public DbSet<TicketComment> TicketComments => Set<TicketComment>();
        public DbSet<TicketHistory> TicketHistories => Set<TicketHistory>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Department>().ToTable("Departments");
            modelBuilder.Entity<Employee>().ToTable("Employees");
            modelBuilder.Entity<Team>().ToTable("Teams");
            modelBuilder.Entity<TeamMember>().ToTable("TeamMembers").HasKey(tm => new { tm.TeamId, tm.EmployeeId });
            modelBuilder.Entity<Customer>().ToTable("Customers");
            modelBuilder.Entity<Category>().ToTable("Categories");
            modelBuilder.Entity<Ticket>().ToTable("Ticket");
            modelBuilder.Entity<TicketAssignment>().ToTable("TicketAssignments");
            modelBuilder.Entity<TicketComment>().ToTable("TicketComments");
            modelBuilder.Entity<TicketHistory>().ToTable("TicketHistory");
        }
    }
}