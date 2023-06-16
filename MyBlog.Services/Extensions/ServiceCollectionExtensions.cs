﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyBlog.Data.Abstract;
using MyBlog.Data.Concrete;
using MyBlog.Data.Concrete.EntityFramework.Context;
using MyBlog.Entities.Concrete;
using MyBlog.Services.Abstract;
using MyBlog.Services.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Services.Extensions
{
    public static class ServiceCollectionExtensions // static, bu sınıfta oluturulan nesnelere sadece direkt bu sınıf üzerinden erişim
                                                    // sağlama kısıtı getirir. -> Class.Write("something"); gibi
    {
        public static IServiceCollection LoadMyServices(this IServiceCollection serviceCollection, string connectionString) {
            serviceCollection.AddDbContext<MyBlogContext>(options=>options.UseSqlServer(connectionString));
            serviceCollection.AddIdentity<User, Role>(options =>
            {
                // email adresi kullanılırak 2. bir kayıt oluşturulabilir mi* şifrede rakam bulunmalı mı gibi kurallar/ ayarlar buradan kontrol edilir 
                //User password options
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 5;
                options.Password.RequiredUniqueChars = 0;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = true;
            }).AddEntityFrameworkStores<MyBlogContext>();
            serviceCollection.Configure<SecurityStampValidatorOptions>(options =>
            {  // giriş yapan kullanıcının bilgilerinin kontrol eidlme aralığı
                options.ValidationInterval = TimeSpan.FromMinutes(15);
            });
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>(); //IUnitOfWork istendiğinde UnitOfWork u ver.
            serviceCollection.AddScoped<ICategoryService, CategoryManager>();
            serviceCollection.AddScoped<IArticleService, ArticleManager>();
            serviceCollection.AddScoped<ICommentService, CommentManager>();
            serviceCollection.AddScoped<IPaymentService, PaymentManager>();
            serviceCollection.AddScoped<IPaymentTypeService, PaymentTypeManager>();
            serviceCollection.AddScoped<IEmployeeService, EmployeeManager>();
            serviceCollection.AddScoped<IEmployeeTypeService, EmployeeTypeManager>();
            serviceCollection.AddScoped<ICustomerReferanceService, CustomerReferanceManager>();
            serviceCollection.AddScoped<ICustomerService, CustomerManager>();
            serviceCollection.AddScoped<ICustomerTypeService, CustomerTypeManager>();
            serviceCollection.AddScoped<INotificationService, NotificationManager>();
            serviceCollection.AddScoped<IBrandService, BrandManager>();
            serviceCollection.AddScoped<ISaleStatusService, SaleStatusManager>();
            serviceCollection.AddScoped<ISaleTypeService, SaleTypeManager>();
            serviceCollection.AddScoped<IProductGroupService, ProductGroupManager>();
            serviceCollection.AddScoped<IProductSubGroupService, ProductSubGroupManager>();
            serviceCollection.AddScoped<IProductService, ProductManager>();
            serviceCollection.AddScoped<IAppointmentTypeService, AppointmentTypeManager>();
            serviceCollection.AddScoped<ISaleService, SaleManager>();
            serviceCollection.AddScoped<IProductService, ProductManager>();
            serviceCollection.AddScoped<IAppointmentService, AppointmentManager>();
            serviceCollection.AddScoped<IProgramService, ProgramManager>();
            serviceCollection.AddScoped<IModuleService, ModuleManager>();
            serviceCollection.AddScoped<ISubProgramService, SubProgramManager>();
            serviceCollection.AddScoped<IPaymentService, PaymentManager>();
            serviceCollection.AddScoped<IAssociatedInstitutionService, AssociatedInstitutionManager>();
            serviceCollection.AddScoped<IExpenseService, ExpenseManager>();
            return serviceCollection;

        }
    }
}

