using MyBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Dtos.EmployeeDtos
{
    public class EmployeeListWithRelatedTable
    {
        public int Id { get; set; }
        public int EmployeeTypeId { get; set; }
        public string EmployeeTypeTitle { get; set; }
        public string? About { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string TC { get; set; }
        public string Picture { get; set; }

    }
}
