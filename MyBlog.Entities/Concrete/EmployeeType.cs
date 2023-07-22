using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using MyBlog.Shared.Entities.Abstract;

namespace MyBlog.Entities.Concrete
{
    public class EmployeeType: EntityBase, IEntity
    {
        public ICollection<Employee> Employees { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
    }
}
