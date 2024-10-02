using OYS.DAL.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OYS.DAL.Entities.Concrete
{
    public class Department : BaseEntity
    {
        public string Name { get; set; }
        public virtual Faculty Faculty { get; set; }
        public virtual List<Lesson> Lessons { get; set; } = new List<Lesson>();
    }
}
