using MyBlog.Data.Abstract;
using MyBlog.Data.Concrete.EntityFramework.Context;
using MyBlog.Data.Concrete.EntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Data.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyBlogContext _context;
        private EfArticleRepository _articleRepository;
        private EfCategoryRepository _categoryRepository;
        private EfCommentRepository _commentRepository;
        private EfAppointmentRepository _appointmentRepository;
        private EfCustomerReferanceRepository _customerReferanceRepository;
        private EfCustomerRepository _customerRepository;
        private EfProductCategoryRepository _productCategoryRepository;
        private EfProductRepository _productRepository;
        private EfStockRepository _stockRepository;
        private EfCustomerTypeRepository _customerTypeRepository;
        private EfPaymentRepository _paymentRepository;
        private EfPaymentTypeRepository _paymentTypeRepository;
        private EfEmployeeRepository _employeeRepository;
        private EfEmployeeTypeRepository _employeeTypeRepository;
        private EfNotificationRepository _notificationRepository;
        private EfBrandRepository _brandRepository;
        private EfProductGroupRepository _productGroupRepository;
        private EfProductSubGroupRepository _productSubGroupRepository;
        private EfSaleTypeRepository _saleTypeRepository;
        private EfSaleStatusRepository _saleStatusRepository;
        private EfAppointmentTypeRepository _appointmentTypeRepository;
        private EfSaleRepository _saleRepository;
        private EfSubProgramRepository _subProgramRepository;
        private EfProgramRepository _programRepository;
        private EfModuleRepository _moduleRepository;
        public UnitOfWork(MyBlogContext context)
        {
            _context = context;
        }
        // ?? if our value is null than do->
        public IArticleRepository Articles => _articleRepository ?? new EfArticleRepository(_context);
        public ICategoryRepository Categories => _categoryRepository ?? new EfCategoryRepository(_context);
        public ICommentRepository Comments => _commentRepository ?? new EfCommentRepository(_context);
        public ICustomerReferanceRepository CustomerReferances => _customerReferanceRepository ?? new EfCustomerReferanceRepository(_context);
        public ICustomerRepository Customers => _customerRepository ?? new EfCustomerRepository(_context);
        public ICustomerTypeRepository CustomerTypes => _customerTypeRepository ?? new EfCustomerTypeRepository(_context);
        public IProductCategoryRepository ProductCategorys => _productCategoryRepository ?? new EfProductCategoryRepository(_context);
        public IProductRepository Products => _productRepository ?? new EfProductRepository(_context);
        public IStockRepository Stocks => _stockRepository ?? new EfStockRepository(_context);
        public IPaymentRepository Payments => _paymentRepository ?? new EfPaymentRepository(_context);
        public IPaymentTypeRepository PaymentTypes => _paymentTypeRepository ?? new EfPaymentTypeRepository(_context);
        public IAppointmentRepository Appointments => _appointmentRepository ?? new EfAppointmentRepository(_context);
        public IEmployeeRepository Employees => _employeeRepository ?? new EfEmployeeRepository(_context);
        public IEmployeeTypeRepository EmployeeTypes => _employeeTypeRepository ?? new EfEmployeeTypeRepository(_context);
        public INotificationRepository Notifications => _notificationRepository ?? new EfNotificationRepository(_context);
        public IProductGroupRepository ProductGroups=> _productGroupRepository ?? new EfProductGroupRepository(_context);
        public IBrandRepository Brands=> _brandRepository ?? new EfBrandRepository(_context);
        public IProductSubGroupRepository ProductSubGroups=> _productSubGroupRepository ?? new EfProductSubGroupRepository(_context);
        public ISaleStatusRepository SaleStatuses=> _saleStatusRepository ?? new EfSaleStatusRepository(_context);
        public ISaleTypeRepository SaleTypes=> _saleTypeRepository ?? new EfSaleTypeRepository(_context);
        public IAppointmentTypeRepository AppointmentTypes=> _appointmentTypeRepository ?? new EfAppointmentTypeRepository(_context);
        public ISaleRepository Sales=> _saleRepository ?? new EfSaleRepository(_context);
        public IProgramRepository Programs => _programRepository ?? new EfProgramRepository(_context);
        public ISubProgramRepository SubPrograms => _subProgramRepository ?? new EfSubProgramRepository(_context);
        public IModuleRepository Modules => _moduleRepository ?? new EfModuleRepository(_context);

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public async Task<int> SaveAsync()
        {
            try
            {
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var debugInfo = _context.ChangeTracker.DebugView.LongView;
                // Hatanın neden olduğu özelliklerin gerçek değerlerini göstermek için 
                // aşağıdaki satırı kullanın
                Console.WriteLine(debugInfo);
                throw;
            }
        }
    }
}
