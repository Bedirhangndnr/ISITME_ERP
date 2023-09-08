using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyBlog.Entities.Concrete;
using MyBlog.Shared.Entities.Concrete;

namespace MyBlog.Data.Concrete.EntityFramework.Mappings
{
    public class ExpenseMap:IEntityTypeConfiguration<Expense>
    {
        public void Configure(EntityTypeBuilder<Expense> builder)
        {
            builder.ToTable("Expenses");
            int id = 1;
            int i = -30;
            builder.HasData(
                new Expense
                {
                   Id=id++,Amount = 100,
                   IsDaily = true,
                   IsIncome = true,
                   IsActive = true,
                   IsDeleted = false,
                   CreatedByName = "Test Verisi",
                   CreatedDate = DateTime.Now.AddDays(i+1),
                   ModifiedByName = "Test Verisi",
                   ModifiedDate = DateTime.Now,
                   Note = "TEST",
                },
                new Expense
                {
                    Id=id++,Amount = 122,
                    IsDaily = true,
                    IsIncome = true,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "Test Verisi",
                    CreatedDate = DateTime.Now.AddDays(i + 1),
                    ModifiedByName = "Test Verisi",
                    ModifiedDate = DateTime.Now,
                    Note = "TEST",
                },
                new Expense
                {
                    Id=id++,Amount = 21,
                    IsDaily = false,
                    IsIncome = false,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "Test Verisi",
                    CreatedDate = DateTime.Now.AddDays(i + 1),
                    ModifiedByName = "Test Verisi",
                    ModifiedDate = DateTime.Now,
                    Note = "TEST",

                },
                new Expense
                {
                    Id=id++,Amount = 341,
                    IsDaily = false,
                    IsIncome = true,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "Test Verisi",
                    CreatedDate = DateTime.Now.AddDays(i + 1),
                    ModifiedByName = "Test Verisi",
                    ModifiedDate = DateTime.Now,
                    Note = "TEST",

                },
                new Expense
                {
                    Id=id++,Amount = 422,
                    IsDaily = false,
                    IsIncome = false,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "Test Verisi",
                    CreatedDate = DateTime.Now.AddDays(i + 1),
                    ModifiedByName = "Test Verisi",
                    ModifiedDate = DateTime.Now,
                    Note = "TEST",

                },
                new Expense
                {
                    Id=id++,Amount = 122,
                    IsDaily = false,
                    IsIncome = false,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "Test Verisi",
                    CreatedDate = DateTime.Now.AddDays(i + 1),
                    ModifiedByName = "Test Verisi",
                    ModifiedDate = DateTime.Now,
                    Note = "TEST",

                },
                new Expense
                {
                    Id=id++,Amount = 322,
                    IsDaily = true,
                    IsIncome = true,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "Test Verisi",
                    CreatedDate = DateTime.Now.AddDays(i + 1),
                    ModifiedByName = "Test Verisi",
                    ModifiedDate = DateTime.Now,
                    Note = "TEST",

                },
                new Expense
                {
                    Id=id++,Amount = 422,
                    IsDaily = false,
                    IsIncome = false,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "Test Verisi",
                    CreatedDate = DateTime.Now.AddDays(i + 1),
                    ModifiedByName = "Test Verisi",
                    ModifiedDate = DateTime.Now,
                    Note = "TEST",

                },
                new Expense
                {
                    Id=id++,Amount = 522,
                    IsDaily = true,
                    IsIncome = true,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "Test Verisi",
                    CreatedDate = DateTime.Now.AddDays(i + 1),
                    ModifiedByName = "Test Verisi",
                    ModifiedDate = DateTime.Now,
                    Note = "TEST",

                },
                new Expense
                {
                    Id=id++,Amount = 122,
                    IsDaily = false,
                    IsIncome = false,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "Test Verisi",
                    CreatedDate = DateTime.Now.AddDays(i + 1),
                    ModifiedByName = "Test Verisi",
                    ModifiedDate = DateTime.Now,
                    Note = "TEST",

                },
                new Expense
                {
                    Id=id++,Amount = 232,
                    IsDaily = false,
                    IsIncome = false,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "Test Verisi",
                    CreatedDate = DateTime.Now.AddDays(i + 1),
                    ModifiedByName = "Test Verisi",
                    ModifiedDate = DateTime.Now,
                    Note = "TEST",

                },
                new Expense
                {
                    Id=id++,Amount = 122,
                    IsDaily = true,
                    IsIncome = false,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "Test Verisi",
                    CreatedDate = DateTime.Now.AddDays(i + 1),
                    ModifiedByName = "Test Verisi",
                    ModifiedDate = DateTime.Now,
                    Note = "TEST",

                },
                new Expense
                {
                    Id=id++,Amount = 222,
                    IsDaily = false,
                    IsIncome = true,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "Test Verisi",
                    CreatedDate = DateTime.Now.AddDays(i + 1),
                    ModifiedByName = "Test Verisi",
                    ModifiedDate = DateTime.Now,
                    Note = "TEST",

                },
                new Expense
                {
                    Id=id++,Amount = 22,
                    IsDaily = false,
                    IsIncome = true,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "Test Verisi",
                    CreatedDate = DateTime.Now.AddDays(i + 1),
                    ModifiedByName = "Test Verisi",
                    ModifiedDate = DateTime.Now,
                    Note = "TEST",

                },
                new Expense
                {
                    Id=id++,Amount = 22,
                    IsDaily = false,
                    IsIncome = true,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "Test Verisi",
                    CreatedDate = DateTime.Now.AddDays(i + 1),
                    ModifiedByName = "Test Verisi",
                    ModifiedDate = DateTime.Now,
                    Note = "TEST",

                },
                new Expense
                {
                    Id=id++,Amount = 22,
                    IsDaily = false,
                    IsIncome = false,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "Test Verisi",
                    CreatedDate = DateTime.Now.AddDays(i + 1),
                    ModifiedByName = "Test Verisi",
                    ModifiedDate = DateTime.Now,
                    Note = "TEST",

                },
                new Expense
                {
                    Id=id++,Amount = 22,
                    IsDaily = true,
                    IsIncome = true,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "Test Verisi",
                    CreatedDate = DateTime.Now.AddDays(i + 1),
                    ModifiedByName = "Test Verisi",
                    ModifiedDate = DateTime.Now,
                    Note = "TEST",

                },
                new Expense
                {
                    Id=id++,Amount = 22,
                    IsDaily = false,
                    IsIncome = false,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "Test Verisi",
                    CreatedDate = DateTime.Now.AddDays(i + 1),
                    ModifiedByName = "Test Verisi",
                    ModifiedDate = DateTime.Now,
                    Note = "TEST",

                },
                new Expense
                {
                    Id=id++,Amount = 22,
                    IsDaily = false,
                    IsIncome = true,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "Test Verisi",
                    CreatedDate = DateTime.Now.AddDays(i + 1),
                    ModifiedByName = "Test Verisi",
                    ModifiedDate = DateTime.Now,
                    Note = "TEST",

                }
            );
        }
    }
}
