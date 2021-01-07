using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//using DefaultMVCCore.Data;
using project1.Data;
using Microsoft.EntityFrameworkCore;

namespace project1.ViewComponents
{
    public class EmployeeViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public EmployeeViewComponent(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var data = await _context.Employee.ToListAsync();
            return View(data);
        }
    }
}
