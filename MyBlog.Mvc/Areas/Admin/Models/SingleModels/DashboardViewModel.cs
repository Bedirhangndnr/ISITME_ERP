using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.ArticleDtos;

namespace MyBlog.Mvc.Areas.Admin.Models.SingleModels
{
    public class DashboardViewModel
    {
        public int CategoriesCount { get; set; }
        public int ArticlesCount { get; set; }
        public int CommentsCount { get; set; }
        public int UsersCount { get; set; }
        public ArticleListDto Articles { get; set; }
    }
}
