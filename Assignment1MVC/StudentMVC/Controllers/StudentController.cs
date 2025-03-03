using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using StudentMVC.Models;

namespace StudentMVC.Controllers
{
    public class StudentController : Controller
    {
        // GET
        public IActionResult Index()
        {
            StudentList studentBL = new StudentList();
            List<Student> studentList = studentBL.GetAll();
            return View("DisplayAllStudent", studentList);
        }

        public IActionResult Details(int id)
        {
            StudentList studentBL = new StudentList();
            Student studentModel = studentBL.GetById(id);
            return View("Details", studentModel);
        }
    }
}