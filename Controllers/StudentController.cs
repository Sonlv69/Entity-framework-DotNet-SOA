using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentApp.Mvc.Services;

namespace StudentApp.Mvc.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            this._studentService = studentService;
        }
        public IActionResult Index()
        {
            var students = _studentService.GetStudents();
            // ViewBag.StudentList = students;
            // ViewData["StudentList"] = students;
     
            return View(students);
        }

        public IActionResult Add()
        {
            return View();
        }
    }
}