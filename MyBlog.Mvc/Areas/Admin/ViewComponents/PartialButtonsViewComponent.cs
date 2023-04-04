using Microsoft.AspNetCore.Mvc;
using MyBlog.Mvc.Areas.Admin.Models.SingleModels;

namespace MyBlog.Mvc.Areas.Admin.ViewComponents
{
    public class PartialButtonsViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(PartialButtonsModel partialButtonsModel)
        {
            return View(partialButtonsModel);
        }
    }
}