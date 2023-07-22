﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyBlog.Entities.Concrete;

namespace MyBlog.Data.Concrete.EntityFramework.Mappings
{
    public class PaymentTypeMap:IEntityTypeConfiguration<PaymentType>
    {
        public void Configure(EntityTypeBuilder<PaymentType> builder)
        {
            builder.ToTable("PaymentTypes");

            builder.HasData(
                new PaymentType
                {
                    Id = 1,
                    Title = "KK | POS",
                    Description = "Point of Sale"
                },
                new PaymentType
                {
                    Id = 2,
                    Title = "Mail Order",
                    Description = "Mail Order Payment"
                },
                new PaymentType
                {
                    Id = 3,
                    Title = "Peşin",
                    Description = "Point of Sale"
                }
           );
        }
    }
}
