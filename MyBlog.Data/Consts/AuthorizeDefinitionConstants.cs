using MyBlog.Entities.Concrete;

namespace MyBlog.Mvc.Consts
{
    static public class AuthorizeDefinitionConstants
    {
        // SUBPROGRAMS // SUBPROGRAMS // SUBPROGRAMS
        public const string Sales = "Sales";
        public const string Customer = "Customer";
        public const string InstitutionalRead = "Institutional.Read";
        public const string SuperAdmin= "SuperAdmin";

        // Employee
        public const string EmployeeCreate = "Employee.Create";
        public const string EmployeeRead = "Employee.Read";
        public const string EmployeeUpdate = "Employee.Update";
        public const string EmployeeDelete = "Employee.Delete";

        // Expense
        public const string ExpenseCreate = "Expense.Create";
        public const string ExpenseRead = "Expense.Read";
        public const string ExpenseUpdate = "Expense.Update";
        public const string ExpenseDelete = "Expense.Delete";

        // Payment
        public const string PaymentCreate = "Payment.Create";
        public const string PaymentRead = "Payment.Read";
        public const string PaymentUpdate = "Payment.Update";
        public const string PaymentDelete = "Payment.Delete";

        // PaymentType
        public const string PaymentTypeCreate = "PaymentType.Create";
        public const string PaymentTypeRead = "PaymentType.Read";
        public const string PaymentTypeUpdate = "PaymentType.Update";
        public const string PaymentTypeDelete = "PaymentType.Delete";

        // EmployeeType
        public const string EmployeeTypeCreate = "EmployeeType.Create";
        public const string EmployeeTypeRead = "EmployeeType.Read";
        public const string EmployeeTypeUpdate = "EmployeeType.Update";
        public const string EmployeeTypeDelete = "EmployeeType.Delete";

        // CustomerReference
        public const string CustomerReferenceCreate = "CustomerReference.Create";
        public const string CustomerReferenceRead = "CustomerReference.Read";
        public const string CustomerReferenceUpdate = "CustomerReference.Update";
        public const string CustomerReferenceDelete = "CustomerReference.Delete";

        // Customer
        public const string CustomerCreate = "Customer.Create";
        public const string CustomerRead = "Customer.Read";
        public const string CustomerUpdate = "Customer.Update";
        public const string CustomerDelete = "Customer.Delete";

        // CustomerType
        public const string CustomerTypeCreate = "CustomerType.Create";
        public const string CustomerTypeRead = "CustomerType.Read";
        public const string CustomerTypeUpdate = "CustomerType.Update";
        public const string CustomerTypeDelete = "CustomerType.Delete";

        // Notification
        public const string NotificationCreate = "Notification.Create";
        public const string NotificationRead = "Notification.Read";
        public const string NotificationUpdate = "Notification.Update";
        public const string NotificationDelete = "Notification.Delete";

        // Brand
        public const string BrandCreate = "Brand.Create";
        public const string BrandRead = "Brand.Read";
        public const string BrandUpdate = "Brand.Update";
        public const string BrandDelete = "Brand.Delete";

        // SaleStatus
        public const string SaleStatusCreate = "SaleStatus.Create";
        public const string SaleStatusRead = "SaleStatus.Read";
        public const string SaleStatusUpdate = "SaleStatus.Update";
        public const string SaleStatusDelete = "SaleStatus.Delete";

        // SaleType
        public const string SaleTypeCreate = "SaleType.Create";
        public const string SaleTypeRead = "SaleType.Read";
        public const string SaleTypeUpdate = "SaleType.Update";
        public const string SaleTypeDelete = "SaleType.Delete";
        
        // Sale
        public const string SaleCreate = "Sale.Create";
        public const string SaleRead = "Sale.Read";
        public const string SaleUpdate = "Sale.Update";
        public const string SaleDelete = "Sale.Delete";

        // ProductGroup
        public const string ProductGroupCreate = "ProductGroup.Create";
        public const string ProductGroupRead = "ProductGroup.Read";
        public const string ProductGroupUpdate = "ProductGroup.Update";
        public const string ProductGroupDelete = "ProductGroup.Delete";

        // ProductSubGroup
        public const string ProductSubGroupCreate = "ProductSubGroup.Create";
        public const string ProductSubGroupRead = "ProductSubGroup.Read";
        public const string ProductSubGroupUpdate = "ProductSubGroup.Update";
        public const string ProductSubGroupDelete = "ProductSubGroup.Delete";

        // Product
        public const string ProductCreate = "Product.Create";
        public const string ProductRead = "Product.Read";
        public const string ProductUpdate = "Product.Update";
        public const string ProductDelete = "Product.Delete";

        // Appointment
        public const string AppointmentCreate = "Appointment.Create";
        public const string AppointmentRead = "Appointment.Read";
        public const string AppointmentUpdate = "Appointment.Update";
        public const string AppointmentDelete = "Appointment.Delete";

        // AppointmentType
        public const string AppointmentTypeCreate = "AppointmentType.Create";
        public const string AppointmentTypeRead = "AppointmentType.Read";
        public const string AppointmentTypeUpdate = "AppointmentType.Update";
        public const string AppointmentTypeDelete = "AppointmentType.Delete";

        // Stock 
        public const string StockCreate = "Stock.Create";
        public const string StockRead = "Stock.Read";
        public const string StockUpdate = "Stock.Update";
        public const string StockDelete = "Stock.Delete";

        // Role
        public const string RoleCreate = "Role.Create";
        public const string RoleRead = "Role.Read";
        public const string RoleUpdate = "Role.Update";
        public const string RoleDelete = "Role.Delete";
        
        
        // User
        public const string UserCreate = "User.Create";
        public const string UserRead = "User.Read";
        public const string UserUpdate = "User.Update";
        public const string UserDelete = "User.Delete";
        
        // Payment
        public const string OutPaymentCreate = "OutPayment.Create";
        public const string OutPaymentRead = "OutPayment.Read";
        public const string OutPaymentUpdate = "OutPayment.Update";
        public const string OutPaymentDelete = "OutPayment.Delete";
        // Payment
        public const string OutPaymentDetailCreate = "OutPaymentDetail.Create";
        public const string OutPaymentDetailRead = "OutPaymentDetail.Read";
        public const string OutPaymentDetailUpdate = "OutPaymentDetail.Update";
        public const string OutPaymentDetailDelete = "OutPaymentDetail.Delete";

        // PROGRAMS // PROGRAMS // PROGRAMS
        // SUBPROGRAMS // SUBPROGRAMS // SUBPROGRAMS
        public const string EmployeeProgramRead = "EmployeeProgram.Read";
        public const string InstitutionalProgramRead = "InstitutionalProgram.Read";
        public const string PaymentProgramRead = "PaymentProgram.Read";
        public const string CustomerProgramRead = "CustomerProgram.Read";
        public const string ProductProgramRead = "ProductProgram.Read";
        public const string MarketingProgramRead = "MarketingProgram.Read";
        public const string AgendaProgramRead = "AgendaProgram.Read";
        public const string FinanceProgramRead = "FinanceProgram.Read";
        public const string HomeProgramRead= "HomeProgram.Read";



        // MODULES MODULES MODULES MODULES
        public const string EmployeeTypeModuleRead = "EmployeeTypeModule.Read";

        public const string EmployeeModuleRead = "EmployeeModule.Read";

        public const string UserModuleRead = "UserModule.Read";

        public const string CustomerModuleRead = "CustomerModule.Read";

        public const string CustomerTypeModuleRead = "CustomerTypeModule.Read";


        public const string ProductModuleRead = "ProductModule.Read";

        public const string ProductGroupModuleRead = "ProductGroupModule.Read";

        public const string ProductSubGroupModuleRead = "ProductSubGroupModule.Read";

        public const string BrandModuleRead = "BrandModule.Read";

        public const string CustomerReferanceModuleRead = "CustomerReferanceModule.Read";

        public const string AppointmentModuleRead = "AppointmentModule.Read";

        public const string NotificationModuleRead = "NotificationModule.Read";


        public const string OutPaymentModuleRead = "OutPaymentModule.Read";

        public const string SaleModuleRead = "SaleModule.Read";

        public const string PaymentModuleRead = "PaymentModule.Read";

        public const string ExpenseModuleRead = "ExpenseModule.Read";

        public const string StockModuleRead = "StockModule.Read";

        public const string RoleModuleRead = "RoleModule.Read";

    }
}

