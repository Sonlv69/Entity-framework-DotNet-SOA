using Microsoft.EntityFrameworkCore;
using StudentApp.Mvc.Models;

namespace StudentApp.Mvc.Services
{
    public class StudentService : IStudentServices
    {
        private readonly DataContext? _context;
        public StudentService(DataContext? context)
        {
            _context = context;
        }

        public Student AddStudent(Student student)
        {
            _context?.Student.Add(student);
            _context?.SaveChanges();
            return student;
        }

        public bool DeleteStudent(int id)
        {
            try
            {
                var currentStudent = GetStudentById(id);
                if (currentStudent == null) return false;
                _context?.Student.Remove(currentStudent);
                _context?.SaveChanges();
                return true;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public Student? GetStudentById(int id)
        {
            return _context?.Student.FirstOrDefault(s => s.Id == id);
        }

        public List<Student> GetStudents() => _context?.Student.Include(s => s.Department).ToList();

        public Student? UpdateStudent(Student student)
        {
            var currentStudent = GetStudentById(student.Id);
            if (currentStudent == null) return null;
            currentStudent.Name = student.Name;
            currentStudent.Age = student.Age;
            currentStudent.Address = student.Address;

            _context?.SaveChanges();
            return currentStudent;
        }
    }
}