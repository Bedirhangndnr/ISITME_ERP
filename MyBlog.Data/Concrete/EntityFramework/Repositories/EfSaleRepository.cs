﻿using Microsoft.EntityFrameworkCore;
using MyBlog.Data.Abstract;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.AppointmentDtos;
using MyBlog.Entities.Dtos.SaleDtos;
using MyBlog.Shared.Data.Concrete.EntityFramework;
using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Data.Concrete.EntityFramework.Repositories
{
    public class EfSaleRepository : EfEntityRepositoryBase<Sale>, ISaleRepository
    {
        public EfSaleRepository(DbContext dbContext) : base(dbContext)
        {
        }
        public async Task<IList<SaleListWithRelatedTables>> GetAllForProductCareAsync(Expression<Func<Sale, bool>> predicate = null, params Expression<Func<Sale, object>>[] includeProperties)
        {
            IQueryable<Sale> query = _context.Set<Sale>();
            DateTime today = DateTime.Now;
            var Appointments = query
                .Include(x => x.Customer)
                .Where(x =>
                    (x.IsProduct == 1) ||
                    (x.CreatedDate.AddDays(25) == today) ||
                    (x.CreatedDate.AddDays(360) == today) ||
                    (x.CreatedDate.AddDays(175) == today) ||
                    (x.CreatedDate.AddDays(85) == today)
                )
                .Select(x => new SaleListWithRelatedTables
                {
                    Id = x.Id,
                    CustomerFirstName = x.Customer.FirstName + " " + x.Customer.LastName,
                    CreatedDate = x.CreatedDate
                }).OrderBy(x => x.CreatedDate);

            return await Appointments.ToListAsync();
        }

        public async Task<IList<SaleListWithRelatedTables>> GetAllWithNamesAsync(Expression<Func<Sale, bool>> predicate = null, params Expression<Func<Sale, object>>[] includeProperties)
        {
            IQueryable<Sale> query = _context.Set<Sale>();
            if (predicate != null)
            {
                query = query.Where(predicate);
            }
            List<SaleListWithRelatedTables> sales = await query
                .Include(s => s.Customer)
                .Include(s => s.Employee)
                .Include(s => s.SaleType)
                .Include(s => s.SaleStatus)
                .Include(s => s.Product)
                .Select(s => new SaleListWithRelatedTables
                {
                    Id = s.Id,
                    DownPayment = s.DownPayment.Value,
                    IsInvoiceDue = s.IsInvoiceDue,
                    DeliveryDate = s.DeliveryDate.Value,
                    CreatedDate = s.CreatedDate,
                    ModifiedDate = s.ModifiedDate,
                    Amount = s.Amount,
                    AmountOfSgk = s.AmountOfSgk,
                    SgkTypeTitle = s.SgkTypeTitle,
                    CustomerId = s.Customer.Id,
                    CustomerFirstName = s.Customer.FirstName + " " + s.Customer.LastName,
                    EmployeeId = s.Employee.Id,
                    EmployeeFirstName = s.Employee.FirstName + " " + s.Employee.LastName,

                    SaleTypeId = s.SaleTypeId != null ? s.SaleTypeId.Value : -1,
                    SaleTypeName = s.SaleType.Title != null ? s.SaleType.Title : "Satış tipi bulunamadı, silinmiş olabilir.",

                    SaleStatusId = s.SaleStatus.Id,

                    SaleStatusName = s.SaleStatus.Title,
                    ProductId = s.ProductId != null ? s.ProductId.Value : -1,
                    ProductName = s.Product == null ? "Seçili Ürün bulunmuyor" :
    s.Product.IsProduct == false ?
        s.Product.Model.Title ?? string.Empty  // Sadece SubModelTitle
        : (s.Product.SubModel.Title ?? string.Empty) + " | " + (s.Product.SerialNumber ?? string.Empty) +
             (s.Product.Quantity.Value < 3 ? " | " + s.Product.Quantity.Value.ToString() : ""),  // SubModelTitle, SerialNumber ve gerekirse Quantity,  // SubModelTitle ve SerialNumber

                }).ToListAsync();

            return sales;
        }
    }
}
