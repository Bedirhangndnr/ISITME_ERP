using MyBlog.Entities.Concrete;
using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Dtos.AppointmentDtos
{
    public class AppointmentListWithRelatedTable: DtoGetBase
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public int CustomerId { get; set; }
        public string EmployeeName { get; set; }
        public int EmployeeId { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? AppointmentTypeTitle { get; set; }
        public int? AppointmentTypeId { get; set; }
        public bool IsMade { get; set; }

    }
}
