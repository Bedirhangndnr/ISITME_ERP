using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Concrete
{
    public class Program : EntityBase, IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Module Module{ get; set; }
        public int ModuleId { get; set; }
        public ICollection<SubProgram> SubPrograms { get; set; }

    }
}
