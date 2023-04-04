using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Concrete
{
    public class Appointment : EntityBase, IEntity
    {

        public Customer? Customer { get; set; }
        public int? CustomerId { get; set; }
        public Employee? Employee { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime Date { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public AppointmentType? AppointmentType { get; set; }
        public int? AppointmentTypeId { get; set; }
        public bool IsMade { get; set; }


    }
}
