using Microsoft.EntityFrameworkCore;
using MyBlog.Data.Abstract;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.PaymentDtos;
using MyBlog.Shared.Data.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyBlog.Data.Concrete.EntityFramework.Repositories
{
    public class EfPaymentRepository : EfEntityRepositoryBase<Payment>, IPaymentRepository
    {
        public EfPaymentRepository(DbContext dbContext) : base(dbContext)
        {
           
        }
        public async Task<IList<PaymentListWithRelatedTables>> GetAllWithNamesAsync(Expression<Func<Payment, bool>> predicate = null, params Expression<Func<Payment, object>>[] includeProperties)
        {
            IQueryable<Payment> query = _context.Set<Payment>();

            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            List<PaymentListWithRelatedTables> payments = await query
      .Include(p => p.AssociatedInstitutions)
      .Include(p => p.Customer)
      .Include(p => p.PaymentType)
      .Include(p => p.Employee)
      .Select(p => new PaymentListWithRelatedTables
      {
          
          Id = p.Id,
          AssociatedInstitutionTitle = p.AssociatedInstitutions.Title,
          AssociatedInstitutionId = p.AssociatedInstitutions.Id,
          PaymentTypeTitle= p.PaymentType.Title,
          PaymentTypeId = p.PaymentType.Id,

          AmountPaid = p.AmountPaid,
          Note = p.Note,
          Description = p.Description,
          CustomerName = p.Customer.FirstName,
          CustomerId = p.CustomerId,
          EmployeeName = p.Employee.FirstName,
          Date = p.CreatedDate,
          EmployeeId = p.EmployeeId
      })
      .ToListAsync();

            return payments;
        }
    }
}
