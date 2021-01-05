using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using project1.di;

namespace project1.Controllers
{
    public class DependencyController : Controller
    {
        private readonly IExample example1;

        public DependencyController(IExample example)
        {
            example1 = example;
        }
        public IActionResult Index()
        {
            return View();
        }
    }

}