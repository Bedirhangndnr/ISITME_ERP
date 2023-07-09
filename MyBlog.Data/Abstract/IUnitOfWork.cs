using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Data.Abstract
{
    public interface IUnitOfWork:IAsyncDisposable
    {
        IArticleRepository Articles { get; }
        ICategoryRepository Categories { get; }
        ICommentRepository Comments { get; }
        IAppointmentRepository Appointments { get; }
        ICustomerReferanceRepository CustomerReferances { get; }
        ICustomerRepository Customers { get; }
        ICustomerTypeRepository CustomerTypes { get; }
        IStockRepository Stocks { get; }
        IProductCategoryRepository ProductCategorys { get; }
        IProductRepository Products { get; }
        IPaymentRepository Payments { get; }
        IPaymentTypeRepository PaymentTypes { get; }
        IEmployeeRepository Employees{ get; }
        IEmployeeTypeRepository EmployeeTypes { get; }
        INotificationRepository Notifications { get; }
        IBrandRepository Brands{ get; }
        IProductSubGroupRepository ProductSubGroups{ get; }
        IProductGroupRepository ProductGroups{ get; }
        ISaleTypeRepository SaleTypes{ get; }
        ISaleStatusRepository SaleStatuses{ get; }
        IAppointmentTypeRepository AppointmentTypes { get; }
        ISaleRepository Sales { get; }
        IProgramRepository Programs { get; }
        ISubProgramRepository SubPrograms { get; }
        IModuleRepository Modules { get; }
        IExpenseRepository Expenses { get; }
        IAssociatedInstitutionRepository AssociatedInstitutions { get; }
        IOutPaymentRepository OutPayments { get; }
        IOutPaymentDetailRepository OutPaymentDetails { get; }
        Task<int> SaveAsync();
    }
}
