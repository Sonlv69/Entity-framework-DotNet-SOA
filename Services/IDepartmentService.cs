using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentApp.Mvc.Models;

namespace StudentApp.Mvc.Services
{
    public interface IDepartmentService
    {
        List<Department> GetDepartments();
        Department? GetDepartmentNyId(int id);
    }
}