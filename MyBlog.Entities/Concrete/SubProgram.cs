using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Concrete
{
    public class SubProgram : EntityBase, IEntity
    {
        public int Id { get; set; }
        public string? ControllerName { get; set; }
        public string? ActionName { get; set; }
        public string Name { get; set; }
        public Program Program{ get; set; }
        public int ProgramId { get; set; }
        
    }
}
