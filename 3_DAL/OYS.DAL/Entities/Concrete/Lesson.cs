using OYS.DAL.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OYS.DAL.Entities.Concrete
{
    public class Lesson : BaseEntity
    {
        public string Name { get; set; }
        public virtual Department Department { get; set; }
    }
}
