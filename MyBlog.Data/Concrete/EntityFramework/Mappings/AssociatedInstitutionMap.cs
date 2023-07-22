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
    public class AssociatedInstitutionMap : IEntityTypeConfiguration<AssociatedInstitution>
    {
        public void Configure(EntityTypeBuilder<AssociatedInstitution> builder)
        {
            builder.ToTable("AssociatedInstitutions");

            builder.HasData(

                // POS -------------------------------
 new AssociatedInstitution
 {
     Id = 1,
     Title = "İş Bankası",
     Description = "İş Bankası Description",
     PaymentTypeId = 1
 },
    new AssociatedInstitution
    {
        Id = 2,
        Title = "Garanti Bankası",
        Description = "Garanti Bankası Description",
        PaymentTypeId = 1
    },
    new AssociatedInstitution
    {
        Id = 3,
        Title = "Yapı Kredi",
        Description = "Yapı Kredi Description",
        PaymentTypeId = 1
    },
    new AssociatedInstitution
    {
        Id = 4,
        Title = "Akbank",
        Description = "Akbank Description",
        PaymentTypeId = 1
    },
    // MAİL ORDER -------------------------------

    new AssociatedInstitution
    {   
        Id = 5,
        Title = "Avrupa Ses",
        Description = "Avrupa Ses Description",
        PaymentTypeId = 2
    },
    new AssociatedInstitution
    {
        Id = 6,
        Title = "Sivasot",
        Description = "Sivasot Description",
        PaymentTypeId = 2
    },
    new AssociatedInstitution
    {
        Id = 7,
        Title = "Timtoptan",
        Description = "Timtoptan Description",
        PaymentTypeId = 2
    }
            );
        }
    }
}
