using StudentApp.Mvc.Models;

namespace StudentApp.Mvc.Services
{
    public class StudentService : IStudentService
    {
        private readonly DataContext _context;
        public StudentService(DataContext context)
        {
            this._context = context;

        }
        public Student AddStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return student;
        }

        public bool DeleteStudent(int studentId)
        {
            try
            {
                var currentStudent = GetStudentById(studentId);
                if (currentStudent == null) return false;
                _context.Students.Remove(currentStudent);
                _context.SaveChanges();
                return true;
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        public Student? GetStudentById(int studentId)
        {
            return _context.Students.FirstOrDefault(s => s.Id == studentId);
        }

        public List<Student> GetStudents()
        {
            return _context.Students.ToList();
        }

        public Student? UpdateStudent(Student student)
        {
            var currentStudent = GetStudentById(student.Id);
            if (currentStudent == null) return null;
            currentStudent.Name = student.Name;
            currentStudent.Age = student.Age;
            currentStudent.Address = student.Address;

            _context.SaveChanges();
            return currentStudent;
        }
    }
}