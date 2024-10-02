using OYS.DAL.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OYS.BLL.Managers.Models
{
    public class DepartmentModel
    {
        public string Name { get; set; }
        public virtual Faculty Faculty { get; set; }
        public virtual List<Lesson> Lessons { get; set; } = new List<Lesson>();
    }
}
