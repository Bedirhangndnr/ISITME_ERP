using MyBlog.Entities.Dtos.CategoryDtos;

namespace MyBlog.Mvc.Areas.Admin.Models.CategoryModels
{
    public class CategoryUpdateAjaxViewModel
    {
        public CategoryUpdateDto CategoryUpdateDto { get; set; }
        //ajax ile post işlemi yaptığımızda dönecek model.
        public string CategoryUpdatePartial { get; set; }
        public CategoryDto CategoryDto { get; set; }
    }
}
