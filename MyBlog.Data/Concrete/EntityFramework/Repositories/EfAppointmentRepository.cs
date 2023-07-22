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
            List<AppointmentListWithRelatedTable> Appointments = await query
                .Include(s => s.Customer)
                .Include(s => s.Employee)
                .Select(s => new AppointmentListWithRelatedTable
                {
                    Id = s.Id,
                    CustomerId = s.Customer.Id,
                    EmployeeId = s.Employee.Id,
                    AppointmentTypeId = s.AppointmentTypeId,
                    CustomerName = s.Customer != null ? (s.Customer.FirstName + " " + s.Customer.LastName) : "Belirtilmemiş Ya Da Silinmiş.",
                    EmployeeName = s.Employee != null ? (s.Employee.FirstName + " " + s.Employee.LastName) : "Belirtilmemiş Ya Da Silinmiş.",
                    AppointmentTypeTitle = s.AppointmentType != null ? s.AppointmentType.Title : "Belirtilmemiş Ya Da Silinmiş.",
                    Description = s.Description != null ? s.Description : "Belirtilmemiş Ya Da Silinmiş.",
                    Date=s.Date,
                    Title = s.Title,
                    IsMade = s.IsMade
                }).ToListAsync();

            return Appointments;
        }
    }
}
