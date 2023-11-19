using MyBlog.Entities.Concrete;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Dtos.CustomerDtos
{
    public class CustomerListWithRelatedTable
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName{ get; set; }
        public string Phone{ get; set; }
        public string? Email { get; set; }
        public string Note { get; set; }
        public string Address { get; set; }
        public string? Picture { get; set; }
        public string TC { get; set; }
        public int CustomerTypeId { get; set; }
        public string CustomerTypeTitle { get; set; }
        public int? CustomerReferanceId { get; set; }
        public string? CustomerReferanceTitle { get; set; }
        [JsonProperty("Sales")]
        public ICollection<Sale> Sales { get; set; }

    }
}
