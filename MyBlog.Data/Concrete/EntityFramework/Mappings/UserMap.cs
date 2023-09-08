using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyBlog.Entities.Concrete;
using MyBlog.Mvc.Consts;

namespace MyBlog.Data.Concrete.EntityFramework.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(u => u.Picture).IsRequired();
            builder.Property(u => u.Picture).HasMaxLength(250);
            // Social Media Links
            builder.Property(u => u.Link).HasMaxLength(250).IsRequired(false);
            // About
            builder.Property(u => u.FirstName).HasMaxLength(30);
            builder.Property(u => u.LastName).HasMaxLength(30);
            builder.Property(u => u.About).HasMaxLength(1000);

            // Primary key
            builder.HasKey(u => u.Id);

            // Indexes for "normalized" username and email, to allow efficient lookups
            builder.HasIndex(u => u.NormalizedUserName).HasDatabaseName("UserNameIndex").IsUnique();
            builder.HasIndex(u => u.NormalizedEmail).HasDatabaseName("EmailIndex");

            // Maps to the AspNetUsers table
            builder.ToTable("Users");

            // A concurrency token for use with the optimistic concurrency checking
            builder.Property(u => u.ConcurrencyStamp).IsConcurrencyToken();

            // Limit the size of columns to use efficient database types
            builder.Property(u => u.UserName).HasMaxLength(50);
            builder.Property(u => u.NormalizedUserName).HasMaxLength(50);
            builder.Property(u => u.Email).HasMaxLength(100);
            builder.Property(u => u.NormalizedEmail).HasMaxLength(100);

            // The relationships between User and other entity types
            // Note that these relationships are configured with no navigation properties

            // Each User can have many UserClaims
            builder.HasMany<UserClaim>().WithOne().HasForeignKey(uc => uc.UserId).IsRequired();

            // Each User can have many UserLogins
            builder.HasMany<UserLogin>().WithOne().HasForeignKey(ul => ul.UserId).IsRequired();

            // Each User can have many UserTokens
            builder.HasMany<UserToken>().WithOne().HasForeignKey(ut => ut.UserId).IsRequired();

            // Each User can have many entries in the UserRole join table
            builder.HasMany<UserRole>().WithOne().HasForeignKey(ur => ur.UserId).IsRequired();
            #region FOCUS_USERS
           

            var bilal = new User
            {
                Id = 1,
                UserName = "bilalAdmin",
                NormalizedUserName = "BILALADMIN",
                Email = "bilalAdmin@gmail.com",
                NormalizedEmail = "BILALADMIN@GMAIL.COM",
                PhoneNumber = "+905537314131",
                Picture = "/userImages/defaultUser.png",
                FirstName = "Bilal",
                LastName = "Meto",
                About = "Admin | Bilal",
                Link = "-",
                Institution = InstitutionConstants.Fokus,

                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString()
            };
            bilal.PasswordHash = CreatePasswordHash(bilal, "bilPaswX_.");
            var nazli = new User
            {
                Id = 2,
                UserName = "nazliAdmin",
                NormalizedUserName = "NAZLIADMIN",
                Email = "nazliAdmin@gmail.com",
                NormalizedEmail = "NAZLIADMIN@GMAIL.COM",
                PhoneNumber = "+905398815246",
                Picture = "/userImages/defaultUser.png",
                FirstName = "Nazlı",
                LastName = "-",
                About = "Admin | Nazlı",
                Link = "-",
                Institution = InstitutionConstants.Fokus,
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString()
            };
            nazli.PasswordHash = CreatePasswordHash(nazli, "nazPaswX_n");
            var sema = new User
            {
                Id = 3,
                UserName = "sema",
                NormalizedUserName = "SEMA",
                Email = "sema@gmail.com",
                NormalizedEmail = "SEMA@GMAIL.COM",
                PhoneNumber = "+905071273567",
                Picture = "/userImages/defaultUser.png",
                FirstName = "Sema",
                LastName = "-",
                About = "-",
                Institution = InstitutionConstants.Fokus,
                Link = "https://twitter.com/adminuser",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString()
            };
            sema.PasswordHash = CreatePasswordHash(sema, "XSemaP");
            var dev = new User
            {
                Id = 4,
                UserName = "dev",
                NormalizedUserName = "DEV",
                Email = "x@gmail.com",
                NormalizedEmail = "X@GMAIL.COM",
                PhoneNumber = "+905050102249",
                Picture = "/userImages/defaultUser.png",
                FirstName = "Bedirhan",
                LastName = "Gündöner",
                About = "Geliştirici",
                Link = "-",
                Institution = InstitutionConstants.Dev,
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString()
            };
            dev.PasswordHash = CreatePasswordHash(dev, "xxx");
            var berra = new User
            {
                Id = 5,
                UserName = "berra",
                NormalizedUserName = "BERRA",
                Email = "berra@gmail.com",
                NormalizedEmail = "BERRA@GMAIL.COM",
                PhoneNumber = "+905050102249",
                Picture = "/userImages/defaultUser.png",
                FirstName = "Berra",
                LastName = "-",
                About = "-",
                Link = "-",
                Institution = InstitutionConstants.Ases,
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString()
            };
            berra.PasswordHash = CreatePasswordHash(berra, "XBerraP");
            var elif = new User
            {
                Id = 6,
                UserName = "Elif",
                NormalizedUserName = "ELIF",
                Email = "Elif@gmail.com",
                NormalizedEmail = "ELIF@GMAIL.COM",
                PhoneNumber = "+905050102249",
                Picture = "/userImages/defaultUser.png",
                FirstName = "Elif",
                LastName = "-",
                About = "-",
                Link = "-",
                Institution = InstitutionConstants.Ases,
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString()
            };
            elif.PasswordHash = CreatePasswordHash(elif, "XElifP");

            #endregion

            #region ASES_USERS


            var esma = new User
            {
                Id = 7,
                UserName = "esmaAdmin",
                NormalizedUserName = "ESMAADMIN",
                Email = "esmaAdmin@gmail.com",
                NormalizedEmail = "ESMAADMIN@GMAIL.COM",
                PhoneNumber = "+905537314131",
                Picture = "/userImages/defaultUser.png",
                FirstName = "Bilal",
                LastName = "Meto",
                About = "Admin | Bilal",
                Link = "-",
                Institution = InstitutionConstants.Ases,
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString()
            };
            esma.PasswordHash = CreatePasswordHash(esma, "esmaPWX_");
            var asiye = new User
            {
                Id = 8,
                UserName = "asiyeAdmin",
                NormalizedUserName = "ASIYEADMIN",
                Email = "asiyeAdmin@gmail.com",
                NormalizedEmail = "ASIYEADMIN@GMAIL.COM",
                PhoneNumber = "+905398815246",
                Picture = "/userImages/defaultUser.png",
                FirstName = "Nazlı",
                LastName = "-",
                About = "Admin | Nazlı",
                Link = "-",
                Institution = InstitutionConstants.Ases,
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString()
            };
            asiye.PasswordHash = CreatePasswordHash(asiye, "asiyePWX_");
            var gulistan = new User
            {
                Id = 9,
                UserName = "gulistan",
                NormalizedUserName = "GULISTAN",
                Email = "gulistan@gmail.com",
                NormalizedEmail = "GULISTAN@GMAIL.COM",
                PhoneNumber = "+905071273567",
                Picture = "/userImages/defaultUser.png",
                FirstName = "Sema",
                LastName = "-",
                About = "-",
                Institution = InstitutionConstants.Ases,
                Link = "https://twitter.com/adminuser",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString()
            };
            gulistan.PasswordHash = CreatePasswordHash(gulistan, "GulistanPsw_");

            //var user2 = new User
            //{
            //    Id = 5,
            //    UserName = "berra",
            //    NormalizedUserName = "BERRA",
            //    Email = "berra@gmail.com",
            //    NormalizedEmail = "BERRA@GMAIL.COM",
            //    PhoneNumber = "+905050102249",
            //    Picture = "/userImages/defaultUser.png",
            //    FirstName = "Berra",
            //    LastName = "-",
            //    About = "-",
            //    Link = "-",
            //    EmailConfirmed = true,
            //    PhoneNumberConfirmed = true,
            //    SecurityStamp = Guid.NewGuid().ToString()
            //};
            //berra.PasswordHash = CreatePasswordHash(berra, "XBerraP");
            //var user3 = new User
            //{
            //    Id = 6,
            //    UserName = "Elif",
            //    NormalizedUserName = "ELIF",
            //    Email = "Elif@gmail.com",
            //    NormalizedEmail = "ELIF@GMAIL.COM",
            //    PhoneNumber = "+905050102249",
            //    Picture = "/userImages/defaultUser.png",
            //    FirstName = "Elif",
            //    LastName = "-",
            //    About = "-",
            //    Link = "-",
            //    EmailConfirmed = true,
            //    PhoneNumberConfirmed = true,
            //    SecurityStamp = Guid.NewGuid().ToString()
            //};
            //elif.PasswordHash = CreatePasswordHash(elif, "XElifP");
            builder.HasData(bilal, nazli, sema, dev, berra, elif, esma, asiye, gulistan);
        }
        #endregion

        private string CreatePasswordHash(User user, string password)
        {
            var passwordHasher = new PasswordHasher<User>();
            return passwordHasher.HashPassword(user, password);
        }
    }
}
