using Microsoft.AspNetCore.Mvc;
using MyBlog.Services.Abstract;
using MyBlog.Shared.Utilities.Results.ComplexTypes;
using MyBlog.Mvc.Areas.Admin.Models;
using AutoMapper;
using MyBlog.Entities.ComplexTypes;
using MyBlog.Entities.Dtos;
using MyBlog.Mvc.Halpers.Abstract;
using Microsoft.AspNetCore.Identity;
using MyBlog.Entities.Concrete;
using System.Text.Json.Serialization;
using System.Text.Json;
using NToastNotify;
using Microsoft.AspNetCore.Authorization;
using System.Data;
using MyBlog.Entities.Dtos.CustomerReferanceDtos;
using MyBlog.Entities.Dtos.EmployeeTypeDtos;
using MyBlog.Shared.Utilities.Extensions;
using MyBlog.Mvc.Consts;
using Microsoft.AspNetCore.Routing;
using MyBlog.Services.Utilities;
using MyBlog.Shared.Utilities.Results.Concrete;
using MyBlog.Entities.Dtos.EmployeeDtos;
using MyBlog.Shared.Utilities.Results;

namespace MyBlog.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "SuperAdmin, Editor")]

    public class EmployeeTypeController : BaseController
    {
        private readonly IEmployeeTypeService _employeeTypeService;
        private readonly IToastNotification _toastNotification;

        public EmployeeTypeController(IEmployeeTypeService employeeTypeService, IEmployeeTypeService ermployeeTypeService, UserManager<User> userManager,
            IMapper mapper, IImageHelper imageHelper, IToastNotification toastNotification) : base(userManager, mapper, imageHelper)
        {
            _employeeTypeService = employeeTypeService;
            _toastNotification = toastNotification;
        }

        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.EmployeeTypeRead}")]
        [HttpGet]
        public async Task<IActionResult> Index(string tableType)
        {
            ViewBag.TableType =  tableType;
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var result = await _employeeTypeService.GetAllByNonDeletedAndActiveAsync();
                if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _employeeTypeService.GetAllByDeletedAsync();
                if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            }
            _toastNotification.AddErrorToastMessage("Bir Hata ile KArşılaşıldı", new ToastrOptions
            {
                Title = "Başarısız İşlem!"
            });
            return View();
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.EmployeeTypeRead}")]
        [HttpGet]
        public async Task<JsonResult> GetAllEmployeeTypes(string tableType)
        {
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var employeeTypes = await _employeeTypeService.GetAllByNonDeletedAndActiveAsync();
                var employeeTypeResult = JsonSerializer.Serialize(employeeTypes, new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.Preserve
                });
                return Json(employeeTypeResult);
            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _employeeTypeService.GetAllByDeletedAsync();
                var rmployeeTypes = JsonSerializer.Serialize(result, new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.Preserve
                });
                return Json(rmployeeTypes);
            }
            _toastNotification.AddErrorToastMessage("Bir Hata ile KArşılaşıldı", new ToastrOptions
            {
                Title = "Başarısız İşlem!"
            });
            return Json(null);
  
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.EmployeeTypeCreate}")]
        [HttpGet]
        public IActionResult Add()
        {
            return PartialView("_EmployeeTypeAddPartial");
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.EmployeeTypeCreate}")]
        [HttpPost]
        public async Task<IActionResult> Add(EmployeeTypeAddDto employeeTypeAddDto)
        {
            if (ModelState.IsValid)
            {
                var result = await _employeeTypeService.AddAsync(employeeTypeAddDto, LoggedInUser.UserName);

                if (result.ResultStatus == ResultStatus.Success)
                {
                    var ermployeeTypeAddAjaxModel = JsonSerializer.Serialize(new EmployeeTypeAddAjaxViewModel
                    {
                        EmployeeTypeDto = result.Data,
                        EmployeeTypeAddPartial = await this.RenderViewToStringAsync("_EmployeeTypeAddPartial", employeeTypeAddDto)
                    });
                    return Json(ermployeeTypeAddAjaxModel);
                }
            }
            var ermployeeTypeAddAjaxErrorModel = JsonSerializer.Serialize(new EmployeeTypeAddAjaxViewModel
            {
                EmployeeTypeAddPartial = await this.RenderViewToStringAsync("_EmployeeTypeAddPartial", employeeTypeAddDto)
            });
            return Json(ermployeeTypeAddAjaxErrorModel);

        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.EmployeeTypeUpdate}")]
        [HttpGet]
        public async Task<IActionResult> Update(int employeeTypeId, string tableType)
        {   
            ViewBag.TableType = tableType;
            var result = await _employeeTypeService.GetEmployeeTypeUpdateDtoAsync(employeeTypeId);
            if (result.ResultStatus == ResultStatus.Success)
            {
                ViewData["tableType"] = tableType;
                return PartialView("_EmployeeTypeUpdatePartial", result.Data);
            }
            return NotFound();
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.EmployeeTypeUpdate}")]
        [HttpPost]
        public async Task<IActionResult> Update(EmployeeTypeUpdateDto ermployeeTypeUpdateDto, string tableType)
        {
            ViewBag.tableType = tableType;
            if (ModelState.IsValid)
            {
                var result = await _employeeTypeService.UpdateAsync(ermployeeTypeUpdateDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    var ermployeeTypeUpdateAjaxModel = JsonSerializer.Serialize(new EmployeeTypeUpdateAjaxViewModel
                    {
                        EmployeeTypeDto = result.Data,
                        EmployeeTypeUpdatePartial = await this.RenderViewToStringAsync("_EmployeeTypeUpdatePartial", ermployeeTypeUpdateDto)
                    });
                    return Json(ermployeeTypeUpdateAjaxModel);
                }
            }
            var ermployeeTypeUpdateAjaxErrorModel = JsonSerializer.Serialize(new EmployeeTypeUpdateAjaxViewModel
            {
                EmployeeTypeUpdatePartial = await this.RenderViewToStringAsync("_EmployeeTypeUpdatePartial", ermployeeTypeUpdateDto)
            });
            return Json(ermployeeTypeUpdateAjaxErrorModel);

        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.EmployeeTypeDelete}")]
        [HttpPost]
        public async Task<JsonResult> Delete(int employeeTypeId, string tableType)
        {
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var result = await _employeeTypeService.DeleteAsync(employeeTypeId, LoggedInUser.UserName);
                var deletedEmployeeType = JsonSerializer.Serialize(result.Data);
                return Json(deletedEmployeeType);
            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _employeeTypeService.HardDeleteAsync(employeeTypeId);
                var hardDeletedEmployeeResult = JsonSerializer.Serialize(result);
                return Json(hardDeletedEmployeeResult);
            }
            else
            {
                // Hatalı silme türü parametresi durumunda hata döndürme
                return Json("Hatalı silme türü parametresi!");
            }
        }

        //[Authorize(Roles = "SuperAdmin, EmployeeType.Read")]
        //[HttpGet]
        //public async Task<IActionResult> DeletedEmployeeTypes()
        //{
        //    var result = await _employeeTypeService.GetAllByDeletedAsync();
        //    return View(result.Data);

        //}
        //// bu kullanılmayabilir eğer işlemlerimiz başarılı olursa
        //[Authorize(Roles = "SuperAdmin, EmployeeType.Read")]
        //[HttpGet]
        //public async Task<JsonResult> GetAllDeletedEmployeeTypes()
        //{
        //    var result = await _employeeTypeService.GetAllByDeletedAsync();
        //    var rmployeeTypes = JsonSerializer.Serialize(result.Data, new JsonSerializerOptions
        //    {
        //        ReferenceHandler = ReferenceHandler.Preserve
        //    });
        //    return Json(rmployeeTypes);
        //}
        [HttpPost]
        [Authorize(Roles = "SuperAdmin, EmployeeType.Update")]
        public async Task<JsonResult> UndoDelete(int ermployeeTypeId)
        {
            var result = await _employeeTypeService.UndoDeleteAsync(ermployeeTypeId, LoggedInUser.UserName);
            var undoDeletedEmployeeType = JsonSerializer.Serialize(result.Data);
            return Json(undoDeletedEmployeeType);
        }
        [Authorize(Roles = "SuperAdmin, EmployeeType.Update")]
        [HttpGet]
        public async Task<IActionResult> HardDelete(int ermployeeTypeId)
        {
            var result = await _employeeTypeService.HardDeleteAsync(ermployeeTypeId);
            var deletedEmployeeType = JsonSerializer.Serialize(result);
            return View(deletedEmployeeType);

        }
    }
}