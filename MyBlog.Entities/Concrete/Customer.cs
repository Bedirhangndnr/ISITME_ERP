using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Concrete
{
    public class Customer : EntityBase, IEntity
    {
        public string? Picture { get; set; }
        public ICollection<Notification> Notifications { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
        public ICollection<Payment> Payments { get; set; }
        public ICollection<Sale> Sales{ get; set; }
        public CustomerReferance? CustomerReferance { get; set; }
        public int? CustomerReferanceId { get; set; }
        public CustomerType? CustomerType{ get; set; }
        public int? CustomerTypeId { get; set; }        
        public Employee? Employee{ get; set; }
        public int? EmployeeId { get; set; }
        public string? About { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string TC { get; set; }
        public string HospitalOfReport { get; set; }
        public DateTime? BirthDate { get; set; }
    }
}
