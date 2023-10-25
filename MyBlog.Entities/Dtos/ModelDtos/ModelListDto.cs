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
    public class ModelListDto:DtoGetBase
    {
        public IList<Model> Models{ get; set; }
        public IList<ModelListWithRelatedTable> ModelListWithRelatedTables { get; set; }

    }
}
