using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentApp.Mvc.Models;
using StudentApp.Mvc.Services;

namespace StudentApp.Mvc.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentServices _studentService;
        public StudentController(IStudentServices studentService) {
            _studentService = studentService;
        }
        public IActionResult Index()
        {
            var students = _studentService.GetStudents();
            // ViewBag.StudentList = students;
            // ViewData["StudentList"] = students;
            return View(students);
        }
        public IActionResult Add() {
            return View();
        }
        public IActionResult Save(Student student) {
            _studentService.AddStudent(student);
            return RedirectToAction("index");
        }
    }
}