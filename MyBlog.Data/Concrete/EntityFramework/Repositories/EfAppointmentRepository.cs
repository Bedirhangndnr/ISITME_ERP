using Microsoft.EntityFrameworkCore;
using MyBlog.Data.Abstract;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.AppointmentDtos;
using MyBlog.Shared.Data.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Data.Concrete.EntityFramework.Repositories
{
    public class EfAppointmentRepository : EfEntityRepositoryBase<Appointment>, IAppointmentRepository
    {
        public EfAppointmentRepository(DbContext dbContext) : base(dbContext)
        {
        }
        public async Task<IList<AppointmentListWithRelatedTable>> GetAllWithNamesAsync(Expression<Func<Appointment, bool>> predicate = null, params Expression<Func<Appointment, object>>[] includeProperties)
        {
            IQueryable<Appointment> query = _context.Set<Appointment>();
            if (predicate != null)
            {
                query = query.Where(predicate);
            }
            DateTime today = DateTime.Now;
            List<AppointmentListWithRelatedTable> Appointments = await query
                .Include(s => s.Customer)
                .Include(s => s.Employee)
                .Select(s => new AppointmentListWithRelatedTable
                {
                    Id = s.Id,
                    CustomerId = s.Customer.Id,
                    EmployeeId = s.Employee.Id != null ? s.Employee.Id: 0 ,
                    AppointmentTypeId = s.AppointmentTypeId,
                    CustomerName = s.Customer != null ? (s.Customer.FirstName + " " + s.Customer.LastName) : "Belirtilmemiş.",
                    EmployeeName = s.Employee != null ? (s.Employee.FirstName + " " + s.Employee.LastName) : "Genel",
                    AppointmentTypeTitle = s.AppointmentType != null ? s.AppointmentType.Title : "Belirtilmemiş.",
                    Description = s.Description != null ? s.Description : "Belirtilmemiş.",
                    Date=s.Date,
                    Title = s.Title != null ? s.Title : "Belirtilmemiş.",
                    IsMade = s.IsMade
                }).Where(x=> x.Date > today.AddDays(-7)).ToListAsync();

            return Appointments;
        }
    }
}
