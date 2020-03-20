using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HelloWorld.Models;

namespace HelloWorld.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            
           

            return View();
        }
        public IActionResult GetStudentById(int id)
        {
            var student = new StudentViewModel();
            switch (id)
            {
                case 1:
                    student.FirstName = "John";
                    student.LastName = "Doe";
                    break;
                case 2:
                    student.FirstName = "Jane";
                    student.LastName = "Eyre";
                    break;

            }

            return View("Index",student);
        }
        public IActionResult CreateStudent(StudentViewModel student)
        {
            if (!ModelState.IsValid)
            {
                
            }
            return View("Index");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
