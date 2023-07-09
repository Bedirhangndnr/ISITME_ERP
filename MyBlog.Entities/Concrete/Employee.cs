using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using MyBlog.Shared.Entities.Abstract;

namespace MyBlog.Entities.Concrete
{
    public class Employee: EntityBase, IEntity
    {
        public string Picture { get; set; }
        public ICollection<Sale> Sales { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
        public ICollection<Customer> Customers{ get; set; }
        public ICollection<OutPaymentDetail> outPaymentDetails{ get; set; }
        public ICollection<Notification> Notifications{ get; set; }
        public ICollection<Payment> Payments{ get; set; }
        public EmployeeType? EmployeeType { get; set; }
        public int? EmployeeTypeId { get; set; }
        public string? About { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string TC { get; set; }
    }
}
