using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyBlog.Entities.Concrete;

namespace MyBlog.Data.Concrete.EntityFramework.Mappings
{
    public class UserRoleMap:IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            // Primary key
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("UserRoles");
            //#region FOCUS_ROLEMAP
            // Kodunuzu buraya ekleyin
            // Birden çok satır kod ekleyebilirsiniz

            //builder.HasData(
            //    // Category.Create
            //    //bilal
            //    new UserRole
            //    {
            //        UserId = 1,
            //        RoleId = 1

            //    },
            //    //nazlı
            //    new UserRole
            //    {
            //        UserId = 2,
            //        RoleId = 1

            //    },
            //    // sema
            //    new UserRole
            //    {
            //        UserId = 3,
            //        RoleId = 2//default user

            //    },
            //    //dev
            //    new UserRole
            //    {
            //        UserId = 4,
            //        RoleId = 1

            //    },
            //    //dev
            //    new UserRole
            //    {
            //        UserId = 4,
            //        RoleId = 3

            //    },
            //    //berra
            //    new UserRole
            //    {
            //        UserId = 5,
            //        RoleId = 2//default user

            //    },
            //    //elif
            //    new UserRole
            //    {
            //        UserId = 6,
            //        RoleId = 2//default user

            //    },
            //#endregion
            //#region ASES_ROLEMAP

           
            //     //Category.Create
            //    //esma
            //    new UserRole
            //    {
            //        UserId = 7,
            //        RoleId = 1

            //    },
            //    //asiye
            //    new UserRole
            //    {
            //        UserId = 8,
            //        RoleId = 1

            //    },
            //     //gülistan
            //    new UserRole
            //    {
            //        UserId = 9,
            //        RoleId = 2//default user

            //    }
            //    ////usr2
            //    //new UserRole
            //    //{
            //    //    UserId = 5,
            //    //    RoleId = 2//default user

            //    //},
            //    ////elif
            //    //new UserRole
            //    //{
            //    //    UserId = 6,
            //    //    RoleId = 2//default user

            //    //}
            //    );
            //#endregion

        }
    }
}
