using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentApp.Mvc.Models;

namespace StudentApp.Mvc.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly DataContext _context;
        public DepartmentService(DataContext context)
        {
            _context = context;
        }

        public Department? GetDepartmentNyId(int id)
        {
            return _context.Department.FirstOrDefault(x => x.Id == id);
        }

        public List<Department> GetDepartments()
        {
            return _context.Department.ToList();
        }
    }
}