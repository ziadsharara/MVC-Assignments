using Assignment2MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Assignment2MVC.Controllers
{
    public class InstructorController : Controller
    {
        MVCEntities context = new MVCEntities();
        public IActionResult Index()
        {
            List<Instructor> instructorsModels = context.Instructor.ToList();
            return View("Index", instructorsModels);
        }

        public IActionResult Details(int id)
        {
            Instructor instructorModel = context.Instructor.FirstOrDefault(i => i.Id == id);
            return View("Details", instructorModel);
        }
    }
}
