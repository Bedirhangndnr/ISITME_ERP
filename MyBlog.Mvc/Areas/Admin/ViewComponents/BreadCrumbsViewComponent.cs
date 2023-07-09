using Microsoft.AspNetCore.Mvc;
using MyBlog.Mvc.Areas.Admin.Models.SingleModels;

namespace MyBlog.Mvc.Areas.Admin.ViewComponents
{
    public class BreadCrumbsViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(BreadCrumbsViewModel breadCrumbsViewModel)
        {
            return View(breadCrumbsViewModel);
        }
    }
}