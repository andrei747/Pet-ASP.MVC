using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HelloWorld.Models;
using HelloWorld.Controllers;

namespace HelloWorld.Controllers
{
    public class PetController : Controller
    {
        public IActionResult Index()  
        {


            return View(); 
        }
        public IActionResult GetPetById (int Id)
        {
            var pets = new PetViewModel();

            if(Id == 1)
            {
                pets.Name = "Azorel";
                pets.Race = "Dog";
                pets.Age = 15;

            } else if(Id == 2)
            {
                pets.Name = "Snowball";
                pets.Race = "Cat";
                pets.Age = 0.5;
            }


            return View(pets);
        }

        public IActionResult AddPet(PetViewModel petViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
           

            return View();
        }

       
    }
}