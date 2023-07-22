using Microsoft.AspNetCore.Mvc;
using MyBlog.Mvc.Areas.Admin.Models.SingleModels;

namespace MyBlog.Mvc.Areas.Admin.ViewComponents
{
    public class UpdatePageButtonsViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(UpdatePageButtonsModel updatePageButtonsModel)
        {
            return View(updatePageButtonsModel);
        }
    }
}