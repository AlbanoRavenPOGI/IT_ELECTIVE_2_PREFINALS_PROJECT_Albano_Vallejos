using HelpDesk_System.Models;

namespace HelpDesk_System.Data
{
    public static class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            context.Database.EnsureCreated();

            if (!context.Departments.Any())
            {
                context.Departments.AddRange(
                    new Department { Name = "IT Support", Description = "Technical Helpdesk", IsActive = 1 },
                    new Department { Name = "Customer Service", Description = "Client Enquiries", IsActive = 1 }
                );
                context.SaveChanges();
            }

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(
                    new Category { Name = "Hardware", Description = "Physical devices" },
                    new Category { Name = "Software", Description = "Applications and OS" }
                );
                context.SaveChanges();
            }
        }
    }
}