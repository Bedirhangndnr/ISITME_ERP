using MyBlog.Mvc.Enums;

namespace MyBlog.Mvc.CustomAttributes
{
    public class AuthorizeDefinitionAttribute: Attribute
    {
        public string Menu { get; set; }
        public string Definition { get; set; }
        // hangi action'a karşılık geldiğine dair bir bilgi
        public ActionType ActionType { get; set; }

    }
}
