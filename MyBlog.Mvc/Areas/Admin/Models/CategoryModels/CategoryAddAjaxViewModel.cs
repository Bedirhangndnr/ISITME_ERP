using MyBlog.Entities.Dtos.CategoryDtos;
using MyBlog.Shared.Entities.Abstract;

namespace MyBlog.Mvc.Areas.Admin.Models.CategoryModels
{
    public class CategoryAddAjaxViewModel
    {
        public CategoryAddDto CategoryAddDto { get; set; }
        //ajax ile post işlemi yaptığımızda dönecek model.
        public string CategoryAddPartial { get; set; }
        public CategoryDto CategoryDto { get; set; }
    }
}
