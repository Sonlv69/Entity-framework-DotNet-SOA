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
        private readonly IDepartmentService _departmentService;
        public StudentController(IStudentServices studentService, IDepartmentService departmentService) {
            _studentService = studentService;
            _departmentService = departmentService;
        }
        public IActionResult Index()
        {
            var students = _studentService.GetStudents();
            // ViewBag.StudentList = students;
            // ViewData["StudentList"] = students;
            return View(students);
        }
        public IActionResult Add() {
            var departments = _departmentService.GetDepartments();
            return View(departments);
        }
        public IActionResult Save(Student student) {
            _studentService.AddStudent(student);
            return RedirectToAction("index");
        }
    }
}