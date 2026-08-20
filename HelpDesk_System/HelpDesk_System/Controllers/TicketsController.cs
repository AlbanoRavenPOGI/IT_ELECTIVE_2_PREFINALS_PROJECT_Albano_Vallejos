using HelpDesk_System.Data;
using HelpDesk_System.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HelpDesk_System.Controllers
{
    public class TicketsController : Controller
    {
        private readonly AppDbContext _context;
        public TicketsController(AppDbContext context) => _context = context;

        public async Task<IActionResult> Index()
        {
            var tickets = await _context.Tickets
                .Include(t => t.Customer)
                .Include(t => t.Category)
                .ToListAsync();
            return View(tickets);
        }

        public async Task<IActionResult> Details(int id)
        {
            var ticket = await _context.Tickets
                .Include(t => t.Customer)
                .Include(t => t.Category)
                .FirstOrDefaultAsync(t => t.Id == id);
            if (ticket == null) return NotFound();
            return View(ticket);
        }

        public IActionResult Create()
        {
            ViewBag.Customers = _context.Customers.ToList();
            ViewBag.Categories = _context.Categories.ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Ticket ticket)
        {
            ticket.CreatedAt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            ticket.Status = "Open";
            _context.Add(ticket);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}