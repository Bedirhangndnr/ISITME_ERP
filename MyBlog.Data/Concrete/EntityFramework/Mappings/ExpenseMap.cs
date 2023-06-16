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

            builder.HasData(
                new Expense
                {
                    Id=1,
                   Amount = 1,
                   IsDaily = true,
                   IsIncome = true,
                   IsActive = true,
                   IsDeleted = false,
                   CreatedByName = "InitialCreate",
                   CreatedDate = DateTime.Now,
                   ModifiedByName = "InitialCreate",
                   ModifiedDate = DateTime.Now,
                   Note = "TEST",
                },
                new Expense
                {
                    Id = 2,
                    Amount = 1,
                    IsDaily = true,
                    IsIncome = true,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "TEST",
                },
                new Expense
                {
                    Id = 3,
                    Amount = 1,
                    IsDaily = true,
                    IsIncome = true,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "TEST",

                },
                new Expense
                {
                    Id= 4,
                    Amount = 1,
                    IsDaily = false,
                    IsIncome = true,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "TEST",

                },
                new Expense
                {
                    Id = 5,
                    Amount = 22,
                    IsDaily = false,
                    IsIncome = false,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "TEST",

                }
            );
        }
    }
}
