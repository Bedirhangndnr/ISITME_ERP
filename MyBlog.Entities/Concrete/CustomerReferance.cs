    using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Concrete
{
    public class CustomerReferance : EntityBase, IEntity
    {
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public string Phone  { get; set; }
        public string Description  { get; set; }
        public CustomerReferanceTitle? CustomerReferanceTitle { get; set; }
        public int? CustomerReferanceTitleId { get; set; }
        public ICollection<Customer> Customers { get; set; }
    }
}
