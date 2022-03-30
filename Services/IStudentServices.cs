using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentApp.Mvc.Models;

namespace StudentApp.Mvc.Services
{
    public interface IStudentServices
    {
        List<Student> GetStudents();
        Student GetStudentById(int id);
        Student AddStudent(Student student);
        Student UpdateStudent(Student student);
        bool DeleteStudent(int id);
    }
}