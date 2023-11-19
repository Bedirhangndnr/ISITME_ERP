﻿using MyBlog.Entities.Dtos;
using MyBlog.Shared.Utilities.Results.Abstract;
using MyBlog.Shared.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.SaleDtos;
using MyBlog.Entities.Dtos.SaleDtos;

namespace MyBlog.Services.Abstract
{
    public interface ISaleService : IGenericService<Sale>
    {
        Task<IDataResult<SaleDto>> GetAsync(int SaleId);
        Task<IDataResult<SaleUpdateDto>> GetSaleUpdateDtoAsync(int SaleId);
        Task<IDataResult<SaleListDto>> GetAllAsync();
        Task<IDataResult<SaleListDto>> GetAllByNonDeletedAndActiveAsync(bool isSuperAdmin);
        Task<IDataResult<SaleListDto>> GetAllByNonDeletedAndActiveByCustomerIdAsync(bool isSuperAdmin, int customerId);
        Task<IDataResult<SaleListDto>> GetAllByDeletedAsync(bool isSuperAdmin);
        Task<IDataResult<SaleListDto>> GetAllByNonDeletedAsync();
        Task<IResult> AddAsync(SaleAddDto SaleAddDto, string createdByName, int userId);
        Task<IResult> UpdateAsync(SaleUpdateDto SaleUpdateDto, string modifiedByName);


        Task<IDataResult<SaleDto>> DeleteAsync(int SaleId, string modifiedByName);
        Task<IDataResult<SaleDto>> UndoDeleteAsync(int SaleId, string modifiedByName);
        Task<IResult> HardDeleteAsync(int SaleId);
        Task<IDataResult<int>> CountAsync(bool isRestOfTheMonth);
        Task<IDataResult<int>> CountByNonDeletedAsync(bool isRestOfTheMonth);
    }
}