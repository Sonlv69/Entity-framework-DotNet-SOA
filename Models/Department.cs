using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp.Mvc.Models
{
    public class Department
    {
        public Department() {
            this.Name = String.Empty;
            Students = new List<Student>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(256)]
        public string Name { get; set; }
        public virtual List<Student> Students { get; set; }
    }
}