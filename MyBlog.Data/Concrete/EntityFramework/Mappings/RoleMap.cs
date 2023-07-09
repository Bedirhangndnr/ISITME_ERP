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
                      Name = AuthorizeDefinitionConstants.SuperAdmin,
                      NormalizedName = AuthorizeDefinitionConstants.SuperAdmin.ToUpperInvariant(),
                      Definition = "SüperAdmin Yetkisi",
                      ConcurrencyStamp = Guid.NewGuid().ToString(),
                      AccessLevel = 1
                  },
                new Role
                {
                    Id = id = id + 1,
                    Name = AuthorizeDefinitionConstants.UserCreate,
                    NormalizedName = AuthorizeDefinitionConstants.UserCreate.ToUpperInvariant(),
                    Definition = "Kullanıcı Ekleme Yetkisi",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    AccessLevel = 3
                }
                ,
                new Role
                {
                    Id = id = id + 1,
                    Name = AuthorizeDefinitionConstants.UserRead,
                    NormalizedName = AuthorizeDefinitionConstants.UserRead.ToUpperInvariant(),
                    Definition = "Kullanıcı Görüntüleme Yetkisi",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    AccessLevel = 3
                },
                new Role
                {
                    Id = id = id + 1,
                    Name = AuthorizeDefinitionConstants.UserUpdate,
                    NormalizedName = AuthorizeDefinitionConstants.UserUpdate.ToUpperInvariant(),
                    Definition = "Kullanıcı Güncelleme Yetkisi",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    AccessLevel = 3
                }
                ,
                new Role
                {
                    Id = id = id + 1,
                    Name = AuthorizeDefinitionConstants.UserDelete,
                    NormalizedName = AuthorizeDefinitionConstants.UserDelete.ToUpperInvariant(),
                    Definition = "Kullanıcı Silme Yetkisi",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    AccessLevel = 3
                }
                ,
                new Role
                {
                    Id = id = id + 1,
                    Name = AuthorizeDefinitionConstants.RoleRead,
                    NormalizedName = AuthorizeDefinitionConstants.RoleRead.ToUpperInvariant(),
                    Definition = "Rol Görüntüleme Yetkisi",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    AccessLevel = 3
                },
                new Role
                {
                    Id = id = id + 1,
                    Name = AuthorizeDefinitionConstants.RoleUpdate,
                    NormalizedName = AuthorizeDefinitionConstants.RoleUpdate.ToUpperInvariant(),
                    Definition = "Rol Güncelleme Yetkisi",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    AccessLevel = 3
                }
                ,
                new Role
                {
                    Id = id = id + 1,
                    Name = AuthorizeDefinitionConstants.RoleDelete,
                    NormalizedName = AuthorizeDefinitionConstants.RoleDelete.ToUpperInvariant(),
                    Definition = "Rol Silme Yetkisi",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    AccessLevel = 3
                }
                ,
                new Role
                {
                    Id = id = id + 1,
                    Name = AuthorizeDefinitionConstants.RoleCreate,
                    NormalizedName = AuthorizeDefinitionConstants.RoleCreate.ToUpperInvariant(),
                    Definition = "Rol Ekleme Yetkisi",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    AccessLevel = 3
                },


                 // Payment
                 new Role
                 {
                     Id = id = id + 1,
                     Name = AuthorizeDefinitionConstants.PaymentCreate,
                     NormalizedName = AuthorizeDefinitionConstants.PaymentCreate.ToUpperInvariant(),
                     Definition = "Ödeme Ekleme Yetkisi",
                     ConcurrencyStamp = Guid.NewGuid().ToString(),
                     AccessLevel = 3
                 },
                 new Role
                 {
                     Id = id = id + 1,
                     Name = AuthorizeDefinitionConstants.PaymentRead,
                     NormalizedName = AuthorizeDefinitionConstants.PaymentRead.ToUpperInvariant(),
                     Definition = "Ödeme Görüntüleme Yetkisi",
                     ConcurrencyStamp = Guid.NewGuid().ToString(),
                     AccessLevel = 3
                 },
                 new Role
                 {
                     Id = id = id + 1,
                     Name = AuthorizeDefinitionConstants.PaymentUpdate,
                     NormalizedName = AuthorizeDefinitionConstants.PaymentUpdate.ToUpperInvariant(),
                     Definition = "Ödeme Güncelleme Yetkisi",
                     ConcurrencyStamp = Guid.NewGuid().ToString(),
                     AccessLevel = 3
                 },
                 new Role
                 {
                     Id = id = id + 1,
                     Name = AuthorizeDefinitionConstants.PaymentDelete,
                     NormalizedName = AuthorizeDefinitionConstants.PaymentDelete.ToUpperInvariant(),
                     Definition = "Ödeme Silme Yetkisi",
                     ConcurrencyStamp = Guid.NewGuid().ToString(),
                     AccessLevel = 3
                 },

             // PaymentType
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.PaymentTypeCreate,
                 NormalizedName = AuthorizeDefinitionConstants.PaymentTypeCreate.ToUpperInvariant(),
                 Definition = "Ödeme Türü Ekleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.PaymentTypeRead,
                 NormalizedName = AuthorizeDefinitionConstants.PaymentTypeRead.ToUpperInvariant(),
                 Definition = "Ödeme Türü Görüntüleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.PaymentTypeUpdate,
                 NormalizedName = AuthorizeDefinitionConstants.PaymentTypeUpdate.ToUpperInvariant(),
                 Definition = "Ödeme Türü Güncelleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.PaymentTypeDelete,
                 NormalizedName = AuthorizeDefinitionConstants.PaymentTypeDelete.ToUpperInvariant(),
                 Definition = "Ödeme Türü Silme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },


             // Employee
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.EmployeeCreate,
                 NormalizedName = AuthorizeDefinitionConstants.EmployeeCreate.ToUpperInvariant(),
                 Definition = "Çalışan Ekleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.EmployeeRead,
                 NormalizedName = AuthorizeDefinitionConstants.EmployeeRead.ToUpperInvariant(),
                 Definition = "Çalışan Görüntüleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.EmployeeUpdate,
                 NormalizedName = AuthorizeDefinitionConstants.EmployeeUpdate.ToUpperInvariant(),
                 Definition = "Çalışan Güncelleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.EmployeeDelete,
                 NormalizedName = AuthorizeDefinitionConstants.EmployeeDelete.ToUpperInvariant(),
                 Definition = "Çalışan Silme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },



             // EmployeeType
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.EmployeeTypeCreate,
                 NormalizedName = AuthorizeDefinitionConstants.EmployeeTypeCreate.ToUpperInvariant(),
                 Definition = "Çalışan Türü Ekleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.EmployeeTypeRead,
                 NormalizedName = AuthorizeDefinitionConstants.EmployeeTypeRead.ToUpperInvariant(),
                 Definition = "Çalışan Türü Görüntüleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.EmployeeTypeUpdate,
                 NormalizedName = AuthorizeDefinitionConstants.EmployeeTypeUpdate.ToUpperInvariant(),
                 Definition = "Çalışan Türü Güncelleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.EmployeeTypeDelete,
                 NormalizedName = AuthorizeDefinitionConstants.EmployeeTypeDelete.ToUpperInvariant(),
                 Definition = "Çalışan Türü Silme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },

             // Customer
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.CustomerCreate,
                 NormalizedName = AuthorizeDefinitionConstants.CustomerCreate.ToUpperInvariant(),
                 Definition = "Müşteri Ekleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.CustomerRead,
                 NormalizedName = AuthorizeDefinitionConstants.CustomerRead.ToUpperInvariant(),
                 Definition = "Müşteri Görüntüleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.CustomerUpdate,
                 NormalizedName = AuthorizeDefinitionConstants.CustomerUpdate.ToUpperInvariant(),
                 Definition = "Müşteri Güncelleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.CustomerDelete,
                 NormalizedName = AuthorizeDefinitionConstants.CustomerDelete.ToUpperInvariant(),
                 Definition = "Müşteri Silme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },

             // CustomerType
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.CustomerTypeCreate,
                 NormalizedName = AuthorizeDefinitionConstants.CustomerTypeCreate.ToUpperInvariant(),
                 Definition = "Müşteri Tipi Ekleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.CustomerTypeRead,
                 NormalizedName = AuthorizeDefinitionConstants.CustomerTypeRead.ToUpperInvariant(),
                 Definition = "Müşteri Tipi Görüntüleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.CustomerTypeUpdate,
                 NormalizedName = AuthorizeDefinitionConstants.CustomerTypeUpdate.ToUpperInvariant(),
                 Definition = "Müşteri Tipi Güncelleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.CustomerTypeDelete,
                 NormalizedName = AuthorizeDefinitionConstants.CustomerTypeDelete.ToUpperInvariant(),
                 Definition = "Müşteri Tipi Silme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },

             // Notification
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.NotificationCreate,
                 NormalizedName = AuthorizeDefinitionConstants.NotificationCreate.ToUpperInvariant(),
                 Definition = "Bildirim Ekleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.NotificationRead,
                 NormalizedName = AuthorizeDefinitionConstants.NotificationRead.ToUpperInvariant(),
                 Definition = "Bildirim Görüntüleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.NotificationUpdate,
                 NormalizedName = AuthorizeDefinitionConstants.NotificationUpdate.ToUpperInvariant(),
                 Definition = "Bildirim Güncelleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.NotificationDelete,
                 NormalizedName = AuthorizeDefinitionConstants.NotificationDelete.ToUpperInvariant(),
                 Definition = "Bildirim Silme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             // Brand
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.BrandCreate,
                 NormalizedName = AuthorizeDefinitionConstants.BrandCreate.ToUpperInvariant(),
                 Definition = "Marka Ekleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.BrandRead,
                 NormalizedName = AuthorizeDefinitionConstants.BrandRead.ToUpperInvariant(),
                 Definition = "Marka Görüntüleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.BrandUpdate,
                 NormalizedName = AuthorizeDefinitionConstants.BrandUpdate.ToUpperInvariant(),
                 Definition = "Marka Güncelleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.BrandDelete,
                 NormalizedName = AuthorizeDefinitionConstants.BrandDelete.ToUpperInvariant(),
                 Definition = "Marka Silme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },

             // SaleStatus
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.SaleStatusCreate,
                 NormalizedName = AuthorizeDefinitionConstants.SaleStatusCreate.ToUpperInvariant(),
                 Definition = "Satış Durumu Ekleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.SaleStatusRead,
                 NormalizedName = AuthorizeDefinitionConstants.SaleStatusRead.ToUpperInvariant(),
                 Definition = "Satış Durumu Görüntüleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.SaleStatusUpdate,
                 NormalizedName = AuthorizeDefinitionConstants.SaleStatusUpdate.ToUpperInvariant(),
                 Definition = "Satış Durumu Güncelleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.SaleStatusDelete,
                 NormalizedName = AuthorizeDefinitionConstants.SaleStatusDelete.ToUpperInvariant(),
                 Definition = "Satış Durumu Silme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             // SaleType
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.SaleTypeCreate,
                 NormalizedName = AuthorizeDefinitionConstants.SaleTypeCreate.ToUpperInvariant(),
                 Definition = "Satış Türü Ekleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.SaleTypeRead,
                 NormalizedName = AuthorizeDefinitionConstants.SaleTypeRead.ToUpperInvariant(),
                 Definition = "Satış Türü Görüntüleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.SaleTypeUpdate,
                 NormalizedName = AuthorizeDefinitionConstants.SaleTypeUpdate.ToUpperInvariant(),
                 Definition = "Satış Türü Güncelleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.SaleTypeDelete,
                 NormalizedName = AuthorizeDefinitionConstants.SaleTypeDelete.ToUpperInvariant(),
                 Definition = "Satış Türü Silme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },

             // ProductGroup
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.ProductGroupCreate,
                 NormalizedName = AuthorizeDefinitionConstants.ProductGroupCreate.ToUpperInvariant(),
                 Definition = "Ürün Grubu Ekleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.ProductGroupRead,
                 NormalizedName = AuthorizeDefinitionConstants.ProductGroupRead.ToUpperInvariant(),
                 Definition = "Ürün Grubu Görüntüleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.ProductGroupUpdate,
                 NormalizedName = AuthorizeDefinitionConstants.ProductGroupUpdate.ToUpperInvariant(),
                 Definition = "Ürün Grubu Güncelleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.ProductGroupDelete,
                 NormalizedName = AuthorizeDefinitionConstants.ProductGroupDelete.ToUpperInvariant(),
                 Definition = "Ürün Grubu Silme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },

             // ProductSubGroup
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.ProductSubGroupCreate,
                 NormalizedName = AuthorizeDefinitionConstants.ProductSubGroupCreate.ToUpperInvariant(),
                 Definition = "Ürün Alt Grubu Ekleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.ProductSubGroupRead,
                 NormalizedName = AuthorizeDefinitionConstants.ProductSubGroupRead.ToUpperInvariant(),
                 Definition = "Ürün Alt Grubu Görüntüleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.ProductSubGroupUpdate,
                 NormalizedName = AuthorizeDefinitionConstants.ProductSubGroupUpdate.ToUpperInvariant(),
                 Definition = "Ürün Alt Grubu Güncelleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.ProductSubGroupDelete,
                 NormalizedName = AuthorizeDefinitionConstants.ProductSubGroupDelete.ToUpperInvariant(),
                 Definition = "Ürün Silme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },


             // AppointmentType
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.AppointmentTypeCreate,
                 NormalizedName = AuthorizeDefinitionConstants.AppointmentTypeCreate.ToUpperInvariant(),
                 Definition = "Randevu Türü Ekleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.AppointmentTypeRead,
                 NormalizedName = AuthorizeDefinitionConstants.AppointmentTypeRead.ToUpperInvariant(),
                 Definition = "Randevu Türü Görüntüleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.AppointmentTypeUpdate,
                 NormalizedName = AuthorizeDefinitionConstants.AppointmentTypeUpdate.ToUpperInvariant(),
                 Definition = "Randevu Türü Güncelleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.AppointmentTypeDelete,
                 NormalizedName = AuthorizeDefinitionConstants.AppointmentTypeDelete.ToUpperInvariant(),
                 Definition = "Randevu Türü Silme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },

             // Sale
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.SaleCreate,
                 NormalizedName = AuthorizeDefinitionConstants.SaleCreate.ToUpperInvariant(),
                 Definition = "Satış Oluşturma Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.SaleRead,
                 NormalizedName = AuthorizeDefinitionConstants.SaleRead.ToUpperInvariant(),
                 Definition = "Satış Görüntüleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.SaleUpdate,
                 NormalizedName = AuthorizeDefinitionConstants.SaleUpdate.ToUpperInvariant(),
                 Definition = "Satış Güncelleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.SaleDelete,
                 NormalizedName = AuthorizeDefinitionConstants.SaleDelete.ToUpperInvariant(),
                 Definition = "Satış Silme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },

             // Product
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.ProductCreate,
                 NormalizedName = AuthorizeDefinitionConstants.ProductCreate.ToUpperInvariant(),
                 Definition = "Ürün Ekleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.ProductRead,
                 NormalizedName = AuthorizeDefinitionConstants.ProductRead.ToUpperInvariant(),
                 Definition = "Ürün Görüntüleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.ProductUpdate,
                 NormalizedName = AuthorizeDefinitionConstants.ProductUpdate.ToUpperInvariant(),
                 Definition = "Ürün Güncelleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.ProductDelete,
                 NormalizedName = AuthorizeDefinitionConstants.ProductDelete.ToUpperInvariant(),
                 Definition = "Ürün Silme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },


              // Appointment
              new Role
              {
                  Id = id = id + 1,
                  Name = AuthorizeDefinitionConstants.AppointmentCreate,
                  NormalizedName = AuthorizeDefinitionConstants.AppointmentCreate.ToUpperInvariant(),
                  Definition = "Randevu Oluşturma Yetkisi",
                  ConcurrencyStamp = Guid.NewGuid().ToString(),
                  AccessLevel = 3
              },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.AppointmentRead,
                 NormalizedName = AuthorizeDefinitionConstants.AppointmentRead.ToUpperInvariant(),
                 Definition = "Randevu Görüntüleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.AppointmentUpdate,
                 NormalizedName = AuthorizeDefinitionConstants.AppointmentUpdate.ToUpperInvariant(),
                 Definition = "Randevu Güncelleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.AppointmentDelete,
                 NormalizedName = AuthorizeDefinitionConstants.AppointmentDelete.ToUpperInvariant(),
                 Definition = "Randevu Silme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },

              // OutPayment
              new Role
              {
                  Id = id = id + 1,
                  Name = AuthorizeDefinitionConstants.OutPaymentCreate,
                  NormalizedName = AuthorizeDefinitionConstants.OutPaymentCreate.ToUpperInvariant(),
                  Definition = "Randevu Oluşturma Yetkisi",
                  ConcurrencyStamp = Guid.NewGuid().ToString(),
                  AccessLevel = 3
              },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.OutPaymentRead,
                 NormalizedName = AuthorizeDefinitionConstants.OutPaymentRead.ToUpperInvariant(),
                 Definition = "Randevu Görüntüleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.OutPaymentUpdate,
                 NormalizedName = AuthorizeDefinitionConstants.OutPaymentUpdate.ToUpperInvariant(),
                 Definition = "Randevu Güncelleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.OutPaymentDelete,
                 NormalizedName = AuthorizeDefinitionConstants.OutPaymentDelete.ToUpperInvariant(),
                 Definition = "Randevu Silme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
              // OutPaymentDetail
              new Role
              {
                  Id = id = id + 1,
                  Name = AuthorizeDefinitionConstants.OutPaymentDetailCreate,
                  NormalizedName = AuthorizeDefinitionConstants.OutPaymentDetailCreate.ToUpperInvariant(),
                  Definition = "Dış Ödeme Detayı Oluşturma Yetkisi",
                  ConcurrencyStamp = Guid.NewGuid().ToString(),
                  AccessLevel = 3
              },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.OutPaymentDetailRead,
                 NormalizedName = AuthorizeDefinitionConstants.OutPaymentDetailRead.ToUpperInvariant(),
                 Definition = "Dış Ödeme Detayı Görüntüleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.OutPaymentDetailUpdate,
                 NormalizedName = AuthorizeDefinitionConstants.OutPaymentDetailUpdate.ToUpperInvariant(),
                 Definition = "Dış Ödeme Detayı Güncelleme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },
             new Role
             {
                 Id = id = id + 1,
                 Name = AuthorizeDefinitionConstants.OutPaymentDetailDelete,
                 NormalizedName = AuthorizeDefinitionConstants.OutPaymentDetailDelete.ToUpperInvariant(),
                 Definition = "Dış Ödeme Detayı Silme Yetkisi",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
                 AccessLevel = 3
             },

                          // PORGRAM ATAMALARI        

                          new Role
                          {
                              Id = id = id + 1,
                              Name = AuthorizeDefinitionConstants.EmployeeProgramRead,
                              NormalizedName = AuthorizeDefinitionConstants.EmployeeProgramRead.ToUpperInvariant(),
                              Definition = "Markalar Programı Görüntüleme",
                              ConcurrencyStamp = Guid.NewGuid().ToString(),
                              AccessLevel = 2
                          }, new Role
                          {
                              Id = id = id + 1,
                              Name = AuthorizeDefinitionConstants.InstitutionalProgramRead,
                              NormalizedName = AuthorizeDefinitionConstants.InstitutionalProgramRead.ToUpperInvariant(),
                              Definition = "Randevular Programı Görüntüleme",
                              ConcurrencyStamp = Guid.NewGuid().ToString(),
                              AccessLevel = 2
                          }, new Role
                          {
                              Id = id = id + 1,
                              Name = AuthorizeDefinitionConstants.CustomerProgramRead,
                              NormalizedName = AuthorizeDefinitionConstants.CustomerProgramRead.ToUpperInvariant(),
                              Definition = "Hastalar Programı Görüntüleme",
                              ConcurrencyStamp = Guid.NewGuid().ToString(),
                              AccessLevel = 2
                          }, new Role
                          {
                              Id =id=id+1,
                              Name = AuthorizeDefinitionConstants.PaymentProgramRead,
                              NormalizedName = AuthorizeDefinitionConstants.PaymentProgramRead.ToUpperInvariant(),
                              Definition = "Referanslar Programı Görüntüleme",
                              ConcurrencyStamp = Guid.NewGuid().ToString(),
                              AccessLevel = 2
                          }, 
                          new Role
                          {
                              Id =id=id+1,
                              Name = AuthorizeDefinitionConstants.ProductProgramRead,
                              NormalizedName = AuthorizeDefinitionConstants.ProductProgramRead.ToUpperInvariant(),
                              Definition = "Ürünler Programı Görüntüleme",
                              ConcurrencyStamp = Guid.NewGuid().ToString(),
                              AccessLevel = 2
                          }, new Role
                          {
                              Id =id=id+1,
                              Name = AuthorizeDefinitionConstants.MarketingProgramRead,
                              NormalizedName = AuthorizeDefinitionConstants.MarketingProgramRead.ToUpperInvariant(),
                              Definition = "Roller Programı Görüntüleme",
                              ConcurrencyStamp = Guid.NewGuid().ToString(),
                              AccessLevel = 2
                          }, new Role
                          {
                              Id =id=id+1,
                              Name = AuthorizeDefinitionConstants.AgendaProgramRead,
                              NormalizedName = AuthorizeDefinitionConstants.AgendaProgramRead.ToUpperInvariant(),
                              Definition = "Satışlar Programı Görüntüleme",
                              ConcurrencyStamp = Guid.NewGuid().ToString(),
                              AccessLevel = 2
                          }, new Role
                          {
                              Id =id=id+1,
                              Name = AuthorizeDefinitionConstants.FinanceProgramRead,
                              NormalizedName = AuthorizeDefinitionConstants.FinanceProgramRead.ToUpperInvariant(),
                              Definition = "Stok Programı Görüntüleme",
                              ConcurrencyStamp = Guid.NewGuid().ToString(),
                              AccessLevel = 2
                          },
                                new Role
                                {
                                    Id = id = id + 1,
                                    Name = AuthorizeDefinitionConstants.HomeProgramRead,
                                    NormalizedName = AuthorizeDefinitionConstants.HomeProgramRead.ToUpperInvariant(),
                                    Definition = "Anasayfa Görüntüleme Yetkisi",
                                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                                    AccessLevel = 1
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
                Name = AuthorizeDefinitionConstants.EmployeeTypeModuleRead,
                NormalizedName = AuthorizeDefinitionConstants.EmployeeTypeModuleRead.ToUpperInvariant(),
                Definition = "Personel Tipleri Modülü Görüntüleme",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                AccessLevel = 1
            },
            new Role
            {
                Id =id=id+1,
                Name = AuthorizeDefinitionConstants.EmployeeModuleRead,
                NormalizedName = AuthorizeDefinitionConstants.EmployeeModuleRead.ToUpperInvariant(),
                Definition = "Personeller Modülü Görüntüleme",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                AccessLevel = 1
            },
            new Role
            {
                Id =id=id+1,
                Name = AuthorizeDefinitionConstants.UserModuleRead,
                NormalizedName = AuthorizeDefinitionConstants.UserModuleRead.ToUpperInvariant(),
                Definition = "Kullanıcılar Modülü Görüntüleme",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                AccessLevel = 1
            },
            new Role
            {
                Id =id=id+1,
                Name = AuthorizeDefinitionConstants.CustomerModuleRead,
                NormalizedName = AuthorizeDefinitionConstants.CustomerModuleRead.ToUpperInvariant(),
                Definition = "Hastalar Modülü Görüntüleme",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                AccessLevel = 1
            },
            new Role
            {
                Id =id=id+1,
                Name = AuthorizeDefinitionConstants.CustomerTypeModuleRead,
                NormalizedName = AuthorizeDefinitionConstants.CustomerTypeModuleRead.ToUpperInvariant(),
                Definition = "HAsta Tipleri Modülü Görüntüleme",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                AccessLevel = 1
            },
            new Role
            {
                Id =id=id+1,
                Name = AuthorizeDefinitionConstants.ProductModuleRead,
                NormalizedName = AuthorizeDefinitionConstants.ProductModuleRead.ToUpperInvariant(),
                Definition = "Ürünler Modülü Yetkisi",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                AccessLevel = 1
            },
            new Role
            {
                Id =id=id+1,
                Name = AuthorizeDefinitionConstants.ProductGroupModuleRead,
                NormalizedName = AuthorizeDefinitionConstants.ProductGroupModuleRead.ToUpperInvariant(),
                Definition = "Ürün Grupları Modülü Yetkisi",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                AccessLevel = 1
            },
            new Role
            {
                Id =id=id+1,
                Name = AuthorizeDefinitionConstants.ProductSubGroupModuleRead,
                NormalizedName = AuthorizeDefinitionConstants.ProductSubGroupModuleRead.ToUpperInvariant(),
                Definition = "Ürün Alt Grupları Modülü Yetkisi",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                AccessLevel = 1
            },
            new Role
            {
                Id =id=id+1,
                Name = AuthorizeDefinitionConstants.BrandModuleRead,
                NormalizedName = AuthorizeDefinitionConstants.BrandModuleRead.ToUpperInvariant(),
                Definition = "Markalar Modülü Yetkisi",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                AccessLevel = 1
            },
            new Role
            {
                Id =id=id+1,
                Name = AuthorizeDefinitionConstants.CustomerReferanceModuleRead,
                NormalizedName = AuthorizeDefinitionConstants.CustomerReferanceModuleRead.ToUpperInvariant(),
                Definition = "Hasta Referanları Modülü Yetkisi",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                AccessLevel = 1
            },
            new Role
            {
                Id =id=id+1,
                Name = AuthorizeDefinitionConstants.AppointmentModuleRead,
                NormalizedName = AuthorizeDefinitionConstants.AppointmentModuleRead.ToUpperInvariant(),
                Definition = "Randevular Modülü Yetkisi",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                AccessLevel = 1
            },
            new Role
            {
                Id =id=id+1,
                Name = AuthorizeDefinitionConstants.NotificationModuleRead,
                NormalizedName = AuthorizeDefinitionConstants.NotificationModuleRead.ToUpperInvariant(),
                Definition = "Bildirimler Modülü Yetkisi",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                AccessLevel = 1
            },
            new Role
            {
                Id =id=id+1,
                Name = AuthorizeDefinitionConstants.OutPaymentModuleRead,
                NormalizedName = AuthorizeDefinitionConstants.OutPaymentModuleRead.ToUpperInvariant(),
                Definition = "Dış Ödemeler Modülü Yetkisi",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                AccessLevel = 1
            },
            new Role
            {
                Id =id=id+1,
                Name = AuthorizeDefinitionConstants.SaleModuleRead,
                NormalizedName = AuthorizeDefinitionConstants.SaleModuleRead.ToUpperInvariant(),
                Definition = "Satışlar Modülü Yetkisi",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                AccessLevel = 1
            },
            new Role
            {
                Id =id=id+1,
                Name = AuthorizeDefinitionConstants.PaymentModuleRead,
                NormalizedName = AuthorizeDefinitionConstants.PaymentModuleRead.ToUpperInvariant(),
                Definition = "Gelen Ödemeler Modülü Yetkisi",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                AccessLevel = 1
            },
            new Role
            {
                Id =id=id+1,
                Name = AuthorizeDefinitionConstants.ExpenseModuleRead,
                NormalizedName = AuthorizeDefinitionConstants.ExpenseModuleRead.ToUpperInvariant(),
                Definition = "Gelir Giderler Modülü Yetkisi",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                AccessLevel = 1
            },
            new Role
            {
                Id =id=id+1,
                Name = AuthorizeDefinitionConstants.RoleModuleRead,
                NormalizedName = AuthorizeDefinitionConstants.RoleModuleRead.ToUpperInvariant(),
                Definition = "Roller Modülü Yetkisi",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                AccessLevel = 1
            }
            );
        }
    }
}
