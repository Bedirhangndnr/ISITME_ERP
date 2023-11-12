using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyBlog.Data.Concrete.EntityFramework.Mappings;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.ProgramsDtos;
using MyBlog.Shared.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Data.Concrete.EntityFramework.Context
{
    public class MyBlogContext:IdentityDbContext<User, Role, int,UserClaim, UserRole,UserLogin, RoleClaim, UserToken>
    {
        public MyBlogContext(DbContextOptions<MyBlogContext> options): base(options)
        {
            // DbContextOptionsBuilder nesnesi oluştur
            var builder = new DbContextOptionsBuilder<MyBlogContext>(options);

            // Sensitive Data Logging özelliğini etkinleştir
            builder.EnableSensitiveDataLogging();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging(); // Hassas veri günlüğünü etkinleştirme
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArticleMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new CommentMap());
            modelBuilder.ApplyConfiguration(new CustomerMap());
            modelBuilder.ApplyConfiguration(new CustomerReferanceTitleMap());
            modelBuilder.ApplyConfiguration(new CustomerReferanceMap());
            modelBuilder.ApplyConfiguration(new CustomerTypeMap());
            modelBuilder.ApplyConfiguration(new ProductCategoryMap());
            modelBuilder.ApplyConfiguration(new ProductMap());
            modelBuilder.ApplyConfiguration(new StockMap());
            modelBuilder.ApplyConfiguration(new AppointmentMap());
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new RoleMap());
            modelBuilder.ApplyConfiguration(new RoleClaimMap());
            modelBuilder.ApplyConfiguration(new UserClaimMap());
            modelBuilder.ApplyConfiguration(new UserRoleMap());
            modelBuilder.ApplyConfiguration(new UserTokenMap());
            modelBuilder.ApplyConfiguration(new UserLoginMap());
            modelBuilder.ApplyConfiguration(new PaymentMap());
            modelBuilder.ApplyConfiguration(new OutPaymentMap());
            modelBuilder.ApplyConfiguration(new OutPaymentDetailMap());
            modelBuilder.ApplyConfiguration(new PaymentTypeMap());
            modelBuilder.ApplyConfiguration(new EmployeeMap());
            modelBuilder.ApplyConfiguration(new EmployeeTypeMap());
            modelBuilder.ApplyConfiguration(new BrandMap());
            modelBuilder.ApplyConfiguration(new ModelMap());
            modelBuilder.ApplyConfiguration(new AppointmentTypeMap());
            modelBuilder.ApplyConfiguration(new NotificationMap());
            modelBuilder.ApplyConfiguration(new ProductGroupMap());
            modelBuilder.ApplyConfiguration(new ProductSubGroupMap());
            modelBuilder.ApplyConfiguration(new SaleStatusMap());
            modelBuilder.ApplyConfiguration(new SaleMap());
            modelBuilder.ApplyConfiguration(new SaleTypeMap());
            modelBuilder.ApplyConfiguration(new ChangeLogMap());
            modelBuilder.ApplyConfiguration(new ModuleMap());
            modelBuilder.ApplyConfiguration(new SubModelMap());
            modelBuilder.ApplyConfiguration(new ProgramMap());
            modelBuilder.ApplyConfiguration(new SubProgramMap());
            modelBuilder.ApplyConfiguration(new AssociatedInstitutionMap());
            modelBuilder.ApplyConfiguration(new ExpenseMap());
            modelBuilder.ApplyConfiguration(new MessageToDeveloperMap());
        }
        public DbSet<Article> Articles{ get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Comment> Comments{ get; set; }
        public DbSet<Appointment> Appointments{ get; set; }
        public DbSet<Customer> Customers{ get; set; }
        public DbSet<CustomerReferanceTitle> CustomerReferanceTitles { get; set; }
        public DbSet<CustomerReferance> CustomerReferances{ get; set; }
        public DbSet<Product> Products{ get; set; }
        public DbSet<ProductCategory> ProductsCategories{ get; set; }
        public DbSet<Stock> Stocks{ get; set; }
        public DbSet<CustomerType> CustomerTypes{ get; set; }
        public DbSet<Payment> Payments{ get; set; } 
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<Employee> Employees{ get; set; }
        public DbSet<EmployeeType> EmployeeTypes{ get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<SubModel> SubModels { get; set; }
        public DbSet<AppointmentType> AppointmentTypes { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<ProductGroup> ProductGroups { get; set; }
        public DbSet<ProductSubGroup> ProductSubGroups { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleStatus> SaleStatuses { get; set; }
        public DbSet<SaleType> SaleTypes { get; set; }
        public DbSet<ChangeLog> changeLogs{ get; set; }
        public DbSet<Program> Programs{ get; set; }
        public DbSet<SubProgram> SubPrograms { get; set; }
        public DbSet<Module> Modules{ get; set; }
        public DbSet<AssociatedInstitution> AssociatedInstitutions { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<OutPayment> OutPayments { get; set; }
        public DbSet<OutPaymentDetail> OutPaymentDetails { get; set; }
        public DbSet<MessageToDeveloper> MessageToDevelopers{ get; set; }

    }
}

