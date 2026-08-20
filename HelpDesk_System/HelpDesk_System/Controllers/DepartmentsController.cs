using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HelpDesk_System.Data;

namespace HelpDesk_System.Controllers
{
    public class DepartmentsController : Controller
    {
        private readonly AppDbContext _context;
        public DepartmentsController(AppDbContext context) => _context = context;

        public async Task<IActionResult> Index()
        {
            return View(await _context.Departments.ToListAsync());
        }
    }
}