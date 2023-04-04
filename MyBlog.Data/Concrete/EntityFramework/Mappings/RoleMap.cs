using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyBlog.Entities.Concrete;
using MyBlog.Mvc.Consts;
using MyBlog.Mvc.Enums;

namespace MyBlog.Data.Concrete.EntityFramework.Mappings
{
    public class RoleMap : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            // Primary key
            builder.HasKey(r => r.Id);

            // Index for "normalized" role name to allow efficient lookups
            builder.HasIndex(r => r.NormalizedName).HasDatabaseName("RoleNameIndex").IsUnique();

            // Maps to the AspNetRoles table
            builder.ToTable("Roles");

            // A concurrency token for use with the optimistic concurrency checking
            builder.Property(r => r.ConcurrencyStamp).IsConcurrencyToken();

            // Limit the size of columns to use efficient database types
            builder.Property(u => u.Name).HasMaxLength(100);
            builder.Property(u => u.NormalizedName).HasMaxLength(100);

            // The relationships between Role and other entity types
            // Note that these relationships are configured with no navigation properties

            // Each Role can have many entries in the UserRole join table
            builder.HasMany<UserRole>().WithOne().HasForeignKey(ur => ur.RoleId).IsRequired();

            // Each Role can have many associated RoleClaims
            builder.HasMany<RoleClaim>().WithOne().HasForeignKey(rc => rc.RoleId).IsRequired();
            int id = 0;

            builder.HasData(
                new Role
                {
                    Id = id = id + 1,
                    Name = AuthorizeDefinitionConstants.UserCreate,
                    NormalizedName = AuthorizeDefinitionConstants.UserCreate.ToUpper(),
                    Definition = "Kullanıcı Ekleme Yetkisi",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    AccessLevel = 3
                }
                ,
                new Role
                {
                    Id = id = id + 1,
                    Name = AuthorizeDefinitionConstants.UserRead,
                    NormalizedName = AuthorizeDefinitionConstants.UserRead.ToUpper(),
                    Definition = "Kullanıcı Görüntüleme Yetkisi",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    AccessLevel = 3
                },
                new Role
                {
                    Id = id = id + 1,
                    Name = AuthorizeDefinitionConstants.UserUpdate,
                    NormalizedName = AuthorizeDefinitionConstants.UserUpdate.ToUpper(),
                    Definition = "Kullanıcı Güncelleme Yetkisi",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    AccessLevel = 3
                }
                ,
                new Role
                {
                    Id = id = id + 1,
                    Name = AuthorizeDefinitionConstants.UserDelete,
                    NormalizedName = AuthorizeDefinitionConstants.UserDelete.ToUpper(),
                    Definition = "Kullanıcı Silme Yetkisi",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    AccessLevel = 3
                }
                ,
                new Role
                {
                    Id = id = id + 1,
                    Name = AuthorizeDefinitionConstants.RoleRead,
                    NormalizedName = AuthorizeDefinitionConstants.RoleRead.ToUpper(),
                    Definition = "Rol Görüntüleme Yetkisi",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    AccessLevel = 3
                },
                new Role
                {
                    Id = id = id + 1,
                    Name = AuthorizeDefinitionConstants.RoleUpdate,
                    NormalizedName = AuthorizeDefinitionConstants.RoleUpdate.ToUpper(),
                    Definition = "Rol Güncelleme Yetkisi",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    AccessLevel = 3
                }
                ,
                new Role
                {
                    Id = id = id + 1,
                    Name = AuthorizeDefinitionConstants.RoleDelete,
                    NormalizedName = AuthorizeDefinitionConstants.RoleDelete.ToUpper(),
                    Definition = "Rol Silme Yetkisi",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    AccessLevel = 3
                }
                ,
                new Role
                {
                    Id = id = id + 1,
                    Name = AuthorizeDefinitionConstants.RoleCreate,
                    NormalizedName = AuthorizeDefinitionConstants.RoleCreate.ToUpper(),
                    Definition = "Rol Ekleme Yetkisi",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    AccessLevel = 3
                },


                 // Payment
                 new Role
                 {
                     Id = id = id + 1,
                     Name = AuthorizeDefinitionConstants.PaymentCreate,
                     NormalizedName = AuthorizeDefinitionConstants.PaymentCreate.ToUpper(),
                     Definition = "Ödeme Ekleme Yetkisi",
                     ConcurrencyStamp = Guid.NewGuid().ToString(),
                     AccessLevel = 3
                 },
                 new Role
                 {
                     Id = id = id + 1,
                     Name = AuthorizeDefinitionConstants.PaymentRead,
                     NormalizedName = AuthorizeDefinitionConstants.PaymentRead.ToUpper(),
                     Definition = "Ödeme Görüntüleme Yetkisi",
                     ConcurrencyStamp = Guid.NewGuid().ToString(),
                     AccessLevel = 3
                 },
                 new Role
                 {
                     Id = id = id + 1,
                     Name = AuthorizeDefinitionConstants.PaymentUpdate,
                     NormalizedName = AuthorizeDefinitionConstants.PaymentUpdate.ToUpper(),
                     Definition = "Ödeme Güncelleme Yetkisi",
                     ConcurrencyStamp = Guid.NewGuid().ToString(),
                     AccessLevel = 3
                 },
                 new Role
                 {
                     Id = id = id + 1,
                     Name = AuthorizeDefinitionConstants.PaymentDelete,
                     NormalizedName = AuthorizeDefinitionConstants.PaymentDelete.ToUpper(),
                     Definition = "Ödeme Silme Yetkisi",
                     ConcurrencyStamp = Guid.NewGuid().ToString(),
                     AccessLevel = 3
                 },

             // PaymentType
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.PaymentTypeCreate,
                 NormalizedName = AuthorizeDefinitionConstants.PaymentTypeCreate.ToUpper(),
                 Definition = "Ödeme Türü Ekleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.PaymentTypeRead,
                 NormalizedName = AuthorizeDefinitionConstants.PaymentTypeRead.ToUpper(),
                 Definition = "Ödeme Türü Görüntüleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.PaymentTypeUpdate,
                 NormalizedName = AuthorizeDefinitionConstants.PaymentTypeUpdate.ToUpper(),
                 Definition = "Ödeme Türü Güncelleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.PaymentTypeDelete,
                 NormalizedName = AuthorizeDefinitionConstants.PaymentTypeDelete.ToUpper(),
                 Definition = "Ödeme Türü Silme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },


             // Employee
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.EmployeeCreate,
                 NormalizedName = AuthorizeDefinitionConstants.EmployeeCreate.ToUpper(),
                 Definition = "Çalışan Ekleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.EmployeeRead,
                 NormalizedName = AuthorizeDefinitionConstants.EmployeeRead.ToUpper(),
                 Definition = "Çalışan Görüntüleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.EmployeeUpdate,
                 NormalizedName = AuthorizeDefinitionConstants.EmployeeUpdate.ToUpper(),
                 Definition = "Çalışan Güncelleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.EmployeeDelete,
                 NormalizedName = AuthorizeDefinitionConstants.EmployeeDelete.ToUpper(),
                 Definition = "Çalışan Silme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },



             // EmployeeType
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.EmployeeTypeCreate,
                 NormalizedName = AuthorizeDefinitionConstants.EmployeeTypeCreate.ToUpper(),
                 Definition = "Çalışan Türü Ekleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.EmployeeTypeRead,
                 NormalizedName = AuthorizeDefinitionConstants.EmployeeTypeRead.ToUpper(),
                 Definition = "Çalışan Türü Görüntüleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.EmployeeTypeUpdate,
                 NormalizedName = AuthorizeDefinitionConstants.EmployeeTypeUpdate.ToUpper(),
                 Definition = "Çalışan Türü Güncelleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.EmployeeTypeDelete,
                 NormalizedName = AuthorizeDefinitionConstants.EmployeeTypeDelete.ToUpper(),
                 Definition = "Çalışan Türü Silme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },

             // Customer
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.CustomerCreate,
                 NormalizedName = AuthorizeDefinitionConstants.CustomerCreate.ToUpper(),
                 Definition = "Müşteri Ekleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.CustomerRead,
                 NormalizedName = AuthorizeDefinitionConstants.CustomerRead.ToUpper(),
                 Definition = "Müşteri Görüntüleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.CustomerUpdate,
                 NormalizedName = AuthorizeDefinitionConstants.CustomerUpdate.ToUpper(),
                 Definition = "Müşteri Güncelleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.CustomerDelete,
                 NormalizedName = AuthorizeDefinitionConstants.CustomerDelete.ToUpper(),
                 Definition = "Müşteri Silme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },

             // CustomerType
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.CustomerTypeCreate,
                 NormalizedName = AuthorizeDefinitionConstants.CustomerTypeCreate.ToUpper(),
                 Definition = "Müşteri Tipi Ekleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.CustomerTypeRead,
                 NormalizedName = AuthorizeDefinitionConstants.CustomerTypeRead.ToUpper(),
                 Definition = "Müşteri Tipi Görüntüleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.CustomerTypeUpdate,
                 NormalizedName = AuthorizeDefinitionConstants.CustomerTypeUpdate.ToUpper(),
                 Definition = "Müşteri Tipi Güncelleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.CustomerTypeDelete,
                 NormalizedName = AuthorizeDefinitionConstants.CustomerTypeDelete.ToUpper(),
                 Definition = "Müşteri Tipi Silme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },

             // Notification
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.NotificationCreate,
                 NormalizedName = AuthorizeDefinitionConstants.NotificationCreate.ToUpper(),
                 Definition = "Bildirim Ekleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.NotificationRead,
                 NormalizedName = AuthorizeDefinitionConstants.NotificationRead.ToUpper(),
                 Definition = "Bildirim Görüntüleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.NotificationUpdate,
                 NormalizedName = AuthorizeDefinitionConstants.NotificationUpdate.ToUpper(),
                 Definition = "Bildirim Güncelleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.NotificationDelete,
                 NormalizedName = AuthorizeDefinitionConstants.NotificationDelete.ToUpper(),
                 Definition = "Bildirim Silme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             // Brand
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.BrandCreate,
                 NormalizedName = AuthorizeDefinitionConstants.BrandCreate.ToUpper(),
                 Definition = "Marka Ekleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.BrandRead,
                 NormalizedName = AuthorizeDefinitionConstants.BrandRead.ToUpper(),
                 Definition = "Marka Görüntüleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.BrandUpdate,
                 NormalizedName = AuthorizeDefinitionConstants.BrandUpdate.ToUpper(),
                 Definition = "Marka Güncelleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.BrandDelete,
                 NormalizedName = AuthorizeDefinitionConstants.BrandDelete.ToUpper(),
                 Definition = "Marka Silme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },

             // SaleStatus
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.SaleStatusCreate,
                 NormalizedName = AuthorizeDefinitionConstants.SaleStatusCreate.ToUpper(),
                 Definition = "Satış Durumu Ekleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.SaleStatusRead,
                 NormalizedName = AuthorizeDefinitionConstants.SaleStatusRead.ToUpper(),
                 Definition = "Satış Durumu Görüntüleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.SaleStatusUpdate,
                 NormalizedName = AuthorizeDefinitionConstants.SaleStatusUpdate.ToUpper(),
                 Definition = "Satış Durumu Güncelleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.SaleStatusDelete,
                 NormalizedName = AuthorizeDefinitionConstants.SaleStatusDelete.ToUpper(),
                 Definition = "Satış Durumu Silme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             // SaleType
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.SaleTypeCreate,
                 NormalizedName = AuthorizeDefinitionConstants.SaleTypeCreate.ToUpper(),
                 Definition = "Satış Türü Ekleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.SaleTypeRead,
                 NormalizedName = AuthorizeDefinitionConstants.SaleTypeRead.ToUpper(),
                 Definition = "Satış Türü Görüntüleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.SaleTypeUpdate,
                 NormalizedName = AuthorizeDefinitionConstants.SaleTypeUpdate.ToUpper(),
                 Definition = "Satış Türü Güncelleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.SaleTypeDelete,
                 NormalizedName = AuthorizeDefinitionConstants.SaleTypeDelete.ToUpper(),
                 Definition = "Satış Türü Silme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },

             // ProductGroup
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.ProductGroupCreate,
                 NormalizedName = AuthorizeDefinitionConstants.ProductGroupCreate.ToUpper(),
                 Definition = "Ürün Grubu Ekleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.ProductGroupRead,
                 NormalizedName = AuthorizeDefinitionConstants.ProductGroupRead.ToUpper(),
                 Definition = "Ürün Grubu Görüntüleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.ProductGroupUpdate,
                 NormalizedName = AuthorizeDefinitionConstants.ProductGroupUpdate.ToUpper(),
                 Definition = "Ürün Grubu Güncelleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.ProductGroupDelete,
                 NormalizedName = AuthorizeDefinitionConstants.ProductGroupDelete.ToUpper(),
                 Definition = "Ürün Grubu Silme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },

             // ProductSubGroup
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.ProductSubGroupCreate,
                 NormalizedName = AuthorizeDefinitionConstants.ProductSubGroupCreate.ToUpper(),
                 Definition = "Ürün Alt Grubu Ekleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.ProductSubGroupRead,
                 NormalizedName = AuthorizeDefinitionConstants.ProductSubGroupRead.ToUpper(),
                 Definition = "Ürün Alt Grubu Görüntüleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.ProductSubGroupUpdate,
                 NormalizedName = AuthorizeDefinitionConstants.ProductSubGroupUpdate.ToUpper(),
                 Definition = "Ürün Alt Grubu Güncelleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.ProductSubGroupDelete,
                 NormalizedName = AuthorizeDefinitionConstants.ProductSubGroupDelete.ToUpper(),
                 Definition = "Ürün Silme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },


             // AppointmentType
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.AppointmentTypeCreate,
                 NormalizedName = AuthorizeDefinitionConstants.AppointmentTypeCreate.ToUpper(),
                 Definition = "Randevu Türü Ekleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.AppointmentTypeRead,
                 NormalizedName = AuthorizeDefinitionConstants.AppointmentTypeRead.ToUpper(),
                 Definition = "Randevu Türü Görüntüleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.AppointmentTypeUpdate,
                 NormalizedName = AuthorizeDefinitionConstants.AppointmentTypeUpdate.ToUpper(),
                 Definition = "Randevu Türü Güncelleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.AppointmentTypeDelete,
                 NormalizedName = AuthorizeDefinitionConstants.AppointmentTypeDelete.ToUpper(),
                 Definition = "Randevu Türü Silme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },

             // Sale
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.SaleCreate,
                 NormalizedName = AuthorizeDefinitionConstants.SaleCreate.ToUpper(),
                 Definition = "Satış Oluşturma Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.SaleRead,
                 NormalizedName = AuthorizeDefinitionConstants.SaleRead.ToUpper(),
                 Definition = "Satış Görüntüleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.SaleUpdate,
                 NormalizedName = AuthorizeDefinitionConstants.SaleUpdate.ToUpper(),
                 Definition = "Satış Güncelleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.SaleDelete,
                 NormalizedName = AuthorizeDefinitionConstants.SaleDelete.ToUpper(),
                 Definition = "Satış Silme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },

             // Product
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.ProductCreate,
                 NormalizedName = AuthorizeDefinitionConstants.ProductCreate.ToUpper(),
                 Definition = "Ürün Ekleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.ProductRead,
                 NormalizedName = AuthorizeDefinitionConstants.ProductRead.ToUpper(),
                 Definition = "Ürün Görüntüleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.ProductUpdate,
                 NormalizedName = AuthorizeDefinitionConstants.ProductUpdate.ToUpper(),
                 Definition = "Ürün Güncelleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.ProductDelete,
                 NormalizedName = AuthorizeDefinitionConstants.ProductDelete.ToUpper(),
                 Definition = "Ürün Silme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },


              // Appointment
              new Role
              {
                  Id = id = id + 1,
                  Name = AuthorizeDefinitionConstants.AppointmentCreate,
                  NormalizedName = AuthorizeDefinitionConstants.AppointmentCreate.ToUpper(),
                  Definition = "Randevu Oluşturma Yetkisi",
                  ConcurrencyStamp = Guid.NewGuid().ToString(),
                  AccessLevel = 3
              },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.AppointmentRead,
                 NormalizedName = AuthorizeDefinitionConstants.AppointmentRead.ToUpper(),
                 Definition = "Randevu Görüntüleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.AppointmentUpdate,
                 NormalizedName = AuthorizeDefinitionConstants.AppointmentUpdate.ToUpper(),
                 Definition = "Randevu Güncelleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.AppointmentDelete,
                 NormalizedName = AuthorizeDefinitionConstants.AppointmentDelete.ToUpper(),
                 Definition = "Randevu Silme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },

                          // PORGRAM ATAMALARI        

                          new Role
                          {
                              Id = id = id + 1,
                              Name = AuthorizeDefinitionConstants.BrandProgramRead,
                              NormalizedName = AuthorizeDefinitionConstants.BrandProgramRead.ToUpper(),
                              Definition = "Markalar Programı Görüntüleme",
                              ConcurrencyStamp = Guid.NewGuid().ToString(),
                              AccessLevel = 2
                          }, new Role
                          {
                              Id = id = id + 1,
                              Name = AuthorizeDefinitionConstants.AppointmentProgramRead,
                              NormalizedName = AuthorizeDefinitionConstants.AppointmentProgramRead.ToUpper(),
                              Definition = "Randevular Programı Görüntüleme",
                              ConcurrencyStamp = Guid.NewGuid().ToString(),
                              AccessLevel = 2
                          }, new Role
                          {
                              Id = id = id + 1,
                              Name = AuthorizeDefinitionConstants.CustomerProgramRead,
                              NormalizedName = AuthorizeDefinitionConstants.CustomerProgramRead.ToUpper(),
                              Definition = "Hastalar Programı Görüntüleme",
                              ConcurrencyStamp = Guid.NewGuid().ToString(),
                              AccessLevel = 2
                          }, new Role
                          {
                              Id =id=id+1,
                              Name = AuthorizeDefinitionConstants.CustomerReferenceProgramRead,
                              NormalizedName = AuthorizeDefinitionConstants.CustomerReferenceProgramRead.ToUpper(),
                              Definition = "Referanslar Programı Görüntüleme",
                              ConcurrencyStamp = Guid.NewGuid().ToString(),
                              AccessLevel = 2
                          }, new Role
                          {
                              Id =id=id+1,
                              Name = AuthorizeDefinitionConstants.EmployeeProgramRead,
                              NormalizedName = AuthorizeDefinitionConstants.EmployeeProgramRead.ToUpper(),
                              Definition = "Personeller Programı Görüntüleme",
                              ConcurrencyStamp = Guid.NewGuid().ToString(),
                              AccessLevel = 2
                          }, new Role
                          {
                              Id =id=id+1,
                              Name = AuthorizeDefinitionConstants.NotificationProgramRead,
                              NormalizedName = AuthorizeDefinitionConstants.NotificationProgramRead.ToUpper(),
                              Definition = "Bildirimler Programı Görüntüleme",
                              ConcurrencyStamp = Guid.NewGuid().ToString(),
                              AccessLevel = 2
                          }, new Role
                          {
                              Id =id=id+1,
                              Name = AuthorizeDefinitionConstants.PaymentProgramRead,
                              NormalizedName = AuthorizeDefinitionConstants.PaymentProgramRead.ToUpper(),
                              Definition = "Ödemeler Programı Görüntüleme",
                              ConcurrencyStamp = Guid.NewGuid().ToString(),
                              AccessLevel = 2
                          }, new Role
                          {
                              Id =id=id+1,
                              Name = AuthorizeDefinitionConstants.ProductProgramRead,
                              NormalizedName = AuthorizeDefinitionConstants.ProductProgramRead.ToUpper(),
                              Definition = "Ürünler Programı Görüntüleme",
                              ConcurrencyStamp = Guid.NewGuid().ToString(),
                              AccessLevel = 2
                          }, new Role
                          {
                              Id =id=id+1,
                              Name = AuthorizeDefinitionConstants.RoleProgramRead,
                              NormalizedName = AuthorizeDefinitionConstants.RoleProgramRead.ToUpper(),
                              Definition = "Roller Programı Görüntüleme",
                              ConcurrencyStamp = Guid.NewGuid().ToString(),
                              AccessLevel = 2
                          }, new Role
                          {
                              Id =id=id+1,
                              Name = AuthorizeDefinitionConstants.SalesProgramRead,
                              NormalizedName = AuthorizeDefinitionConstants.SalesProgramRead.ToUpper(),
                              Definition = "Satışlar Programı Görüntüleme",
                              ConcurrencyStamp = Guid.NewGuid().ToString(),
                              AccessLevel = 2
                          }, new Role
                          {
                              Id =id=id+1,
                              Name = AuthorizeDefinitionConstants.StockProgramRead,
                              NormalizedName = AuthorizeDefinitionConstants.StockProgramRead.ToUpper(),
                              Definition = "Stok Programı Görüntüleme",
                              ConcurrencyStamp = Guid.NewGuid().ToString(),
                              AccessLevel = 2
                          },  new Role
                          {
                              Id =id=id+1,
                              Name = AuthorizeDefinitionConstants.UserProgramRead,
                              NormalizedName = AuthorizeDefinitionConstants.UserProgramRead.ToUpper(),
                              Definition = "Kullanıcılar Programı Görüntüleme",
                              ConcurrencyStamp = Guid.NewGuid().ToString(),
                              AccessLevel = 2
                          },

             // MODULE ATAMALARI

             new Role
             {
                 Id =id=id+1,
                 Name = AuthorizeDefinitionConstants.StockModuleRead,
                 NormalizedName = AuthorizeDefinitionConstants.StockModuleRead,
                 Definition = "Stok Modülü Görüntüleme",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 1
             },
            new Role
            {
                Id =id=id+1,
                Name = AuthorizeDefinitionConstants.MarketingModuleRead,
                NormalizedName = AuthorizeDefinitionConstants.MarketingModuleRead.ToUpper(),
                Definition = "MArketing Modülü Görüntüleme",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                AccessLevel = 1
            },
            new Role
            {
                Id =id=id+1,
                Name = AuthorizeDefinitionConstants.AgendaModuleRead,
                NormalizedName = AuthorizeDefinitionConstants.AgendaModuleRead.ToUpper(),
                Definition = "Ajanda Modülü Görüntüleme",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                AccessLevel = 1
            },
            new Role
            {
                Id =id=id+1,
                Name = AuthorizeDefinitionConstants.InstitutionalModuleRead,
                NormalizedName = AuthorizeDefinitionConstants.InstitutionalModuleRead.ToUpper(),
                Definition = "Kurumsal Modülü Görüntüleme",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                AccessLevel = 1
            },
            new Role
            {
                Id =id=id+1,
                Name = AuthorizeDefinitionConstants.CustomerModuleRead,
                NormalizedName = AuthorizeDefinitionConstants.CustomerModuleRead.ToUpper(),
                Definition = "Müşteri Modülü Görüntüleme",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                AccessLevel = 1
            },
            new Role
            {
                Id =id=id+1,
                Name = AuthorizeDefinitionConstants.FinanceModuleRead,
                NormalizedName = AuthorizeDefinitionConstants.FinanceModuleRead.ToUpper(),
                Definition = "Finans Modülü Görüntüleme",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                AccessLevel = 1
            },
                  new Role
            {
                Id =id=id+1,
                Name = AuthorizeDefinitionConstants.HomeModuleRead,
                NormalizedName = AuthorizeDefinitionConstants.HomeModuleRead.ToUpper(),
                Definition = "Anasayfa Görüntüleme Yetkisi",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                      AccessLevel = 1
                  },
            new Role
            {
                Id =id=id+1,
                Name = AuthorizeDefinitionConstants.SuperAdmin,
                NormalizedName = AuthorizeDefinitionConstants.SuperAdmin.ToUpper(),
                Definition = "SüperAdmin Yetkisi",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                AccessLevel = 1
            }
            );
        }
    }
}
