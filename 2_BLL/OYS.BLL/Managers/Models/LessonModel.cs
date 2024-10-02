using OYS.DAL.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OYS.BLL.Managers.Models
{
    public class LessonModel
    {
        public string Name { get; set; }
        public virtual Department Department { get; set; }
    }
}
