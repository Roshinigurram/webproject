using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using project1.Data;

namespace project1.Controllers
{
    public class DefaultController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DefaultController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

        ViewData["City"] = "Hyderabad";
        ViewBag.name = "roshini";
            TempData["name"] = "rakesh";
            var emp = _context.Employee.ToList();
            var dep = _context.Department.ToList();
            ViewBag.emp1 = emp;
           
            return View(dep);
        }
        public IActionResult component()
        {
            return View();
        }
    }
}
