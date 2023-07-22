using Microsoft.AspNetCore.Mvc;
using MyBlog.Mvc.Areas.Admin.Models.SingleModels;

namespace MyBlog.Mvc.Areas.Admin.ViewComponents
{
    public class ModifiedDetailsInfoViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(ModifiedDetailsInfoModel modifiedDetailsInfoModel)
        {
            return View(modifiedDetailsInfoModel);
        }
    }
}