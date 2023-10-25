using MyBlog.Entities.Concrete;
using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Dtos.ProductSubGroupDtos
{
    public class ProductSubGroupListDto:DtoGetBase
    {
        public IList<ProductSubGroup> ProductSubGroups{ get; set; }
        public IList<ProductSubGroupListWithRelatedTable> ProductSubGroupListWithRelatedTables { get; set; }
    }
}
