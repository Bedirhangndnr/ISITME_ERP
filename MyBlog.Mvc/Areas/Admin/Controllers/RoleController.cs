using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.RoleDtos;
using MyBlog.Entities.Dtos.UserDtos;
using MyBlog.Mvc.Areas.Admin.Models;
using MyBlog.Mvc.Areas.Admin.Models.UserModels;
using MyBlog.Mvc.Consts;
using MyBlog.Mvc.Halpers.Abstract;
using MyBlog.Services.Abstract;
using MyBlog.Services.Utilities;
using MyBlog.Shared.Utilities.Extensions;
using MyBlog.Shared.Utilities.Messages.NotificationMessages;
using MyBlog.Shared.Utilities.Results.ComplexTypes;
using MyBlog.Shared.Utilities.Results.Concrete;
using System.Text.Json;

namespace MyBlog.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RoleController : BaseController
    {
        private readonly IModuleService _moduleService;
        private readonly IProgramService _programService;
        private readonly ISubProgramService _subProgramService;
        private readonly INotificationService _notificationService;


        private readonly RoleManager<Role> _roleManager;

        public RoleController(IModuleService moduleService,
                        INotificationService notificationService,
IProgramService programService, ISubProgramService subProgramService,
            RoleManager<Role> roleManager, UserManager<User> userManager, IMapper mapper, IImageHelper imageHelper) :
            base(userManager, mapper, imageHelper)
        {
            _notificationService = notificationService;
            _moduleService = moduleService;
            _programService = programService;
            _subProgramService = subProgramService;
            _roleManager = roleManager;
        }

        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.RoleRead}")]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var roles = await _roleManager.Roles.ToListAsync();
            return View(new RoleListDto
            {
                Roles = roles
            });
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.RoleRead}")]
        [HttpGet]
        public async Task<IActionResult> GetAllRoles()
        {
            var roles = await _roleManager.Roles.ToListAsync();
            var roleListDto = JsonSerializer.Serialize(new RoleListDto
            {
                Roles = roles
            });
            return Json(roleListDto);
        }

        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.RoleUpdate}")]
        [HttpGet]
        public async Task<IActionResult> Assign(int userId)
        {
            var user = await UserManager.Users.SingleOrDefaultAsync(u => u.Id == userId);
            var roles = await _roleManager.Roles.ToListAsync();
            var userRoles = await UserManager.GetRolesAsync(user);
            //var modules = await _moduleService.GetAllByNonDeletedAndActiveAsync();
            //var programs = await _programService.GetAllByNonDeletedAndActiveAsync();
            //var subPrograms = await _subProgramService.GetAllByNonDeletedAndActiveAsync();
            UserRoleAssignDto userRoleAssignDto = new UserRoleAssignDto
            {
                //Modules = modules.Data.Modules,
                //Programs = programs.Data.Programs,
                //SubPrograms = subPrograms.Data.SubPrograms,
                UserId = user.Id,
                UserName = user.UserName
            };
            foreach (var role in roles)
            {
                RoleAssignDto rolesAssignDto = new RoleAssignDto
                {
                    RoleId = role.Id,
                    RoleName = role.Name,
                    RoleDefinition = role.Definition,
                    AccessLevel = role.AccessLevel,
                    HasRole = userRoles.Contains(role.Name)
                };
                userRoleAssignDto.RoleAssignDtos.Add(rolesAssignDto);
            }

            return PartialView("_RoleAssignPartial", userRoleAssignDto);
        }

        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.RoleUpdate}")]
        [HttpPost]
        public async Task<IActionResult> Assign(UserRoleAssignDto userRoleAssignDto)
        {
            if (ModelState.IsValid)
            {
                var user = await UserManager.Users.SingleOrDefaultAsync(u => u.Id == userRoleAssignDto.UserId);
                foreach (var roleAssignDto in userRoleAssignDto.RoleAssignDtos)
                {
                    if (roleAssignDto.HasRole)
                        await UserManager.AddToRoleAsync(user, roleAssignDto.RoleName);
                    else
                    {
                        await UserManager.RemoveFromRoleAsync(user, roleAssignDto.RoleName);
                    }
                }

                await UserManager.UpdateSecurityStampAsync(user);
                var userRoleAssignAjaxViewModel = JsonSerializer.Serialize(new UserRoleAssignAjaxViewModel
                {
                    UserDto = new UserDto
                    {
                        User = user,
                        Message = $"{user.UserName} kullanıcısına ait rol atama işlemi başarıyla tamamlanmıştır.",
                        ResultStatus = ResultStatus.Success
                    },
                    RoleAssignPartial = await this.RenderViewToStringAsync("_RoleAssignPartial", userRoleAssignDto)
                });
                await _notificationService.AddAsync(NotificationMessageService.GetMessage(
                   NotificationMessageTypes.Updated,
                   TableNamesConstants.AppointmentTypes,
                   LoggedInUser.UserName),
                   NotificationMessageService.GetTitle(NotificationMessageTypes.Updated), userId: LoggedInUser.Id
                   );
                return Json(userRoleAssignAjaxViewModel);

            }
            else
            {
                var userRoleAssignAjaxErrorModel = JsonSerializer.Serialize(new UserRoleAssignAjaxViewModel
                {
                    RoleAssignPartial = await this.RenderViewToStringAsync("_RoleAssignPartial", userRoleAssignDto),
                    UserRoleAssignDto = userRoleAssignDto
                });
                return Json(userRoleAssignAjaxErrorModel);
            }

            //public async Task<IActionResult> Assign(UserRoleAssignDto userRoleAssignDto)
            //{
            //    if (ModelState.IsValid)
            //    {
            //        var user = await UserManager.Users.SingleOrDefaultAsync(u => u.Id == userRoleAssignDto.UserId);
            //        foreach (var roleAssignDto in userRoleAssignDto.RoleAssignDtos)
            //        {
            //            if (roleAssignDto.HasRole)
            //                await UserManager.AddToRoleAsync(user, roleAssignDto.RoleName);
            //            else
            //            {
            //                await UserManager.RemoveFromRoleAsync(user, roleAssignDto.RoleName);
            //            }
            //        }
            //        // kullanıcıların bilgilerini 30 dk ierisinde kontrol edip bir değişiklik varsa oturumdan atacak
            //        await UserManager.UpdateSecurityStampAsync(user);
            //        var userRoleAssignAjaxViewModel = JsonSerializer.Serialize(new UserRoleAssignAjaxViewModel
            //        {
            //            UserDto = new UserDto
            //            {
            //                User = user,
            //                Message = $"{user.UserName} kullanıcısına ait rol atama işlemi başarıyla tamamlanmıştır.",
            //                ResultStatus = ResultStatus.Success
            //            },
            //            RoleAssignPartial = await this.RenderViewToStringAsync("_RoleAssignPartial", userRoleAssignDto)
            //        });
            //        return Json(userRoleAssignAjaxViewModel);
            //    }
            //    else
            //    {
            //        var userRoleAssignAjaxErrorModel = JsonSerializer.Serialize(new UserRoleAssignAjaxViewModel
            //        {
            //            RoleAssignPartial = await this.RenderViewToStringAsync("_RoleAssignPartial", userRoleAssignDto),
            //            UserRoleAssignDto = userRoleAssignDto
            //        });
            //        return Json(userRoleAssignAjaxErrorModel);
            //    }
        }
    }
}
