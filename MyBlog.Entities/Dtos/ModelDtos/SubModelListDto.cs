using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.ModelDtos;
using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Dtos.ModelDtos
{
    public class SubModelListDto:DtoGetBase
    {
        public IList<SubModel> SubModels{ get; set; }
        public IList<SubModelListWithRelatedTable> SubModelListWithRelatedTables { get; set; }

    }
}
