using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Concrete
{
    public class Module : EntityBase, IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Program> Programs { get; set; }

    }
}
