using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.AppointmentDtos;
using MyBlog.Shared.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Data.Abstract
{
    public interface IAppointmentRepository:IEntityRepository<Appointment>
    {
        public Task<IList<AppointmentListWithRelatedTable>> GetAllWithNamesAsync(Expression<Func<Appointment, bool>> predicate = null, params Expression<Func<Appointment, object>>[] includeProperties);
    }
}
