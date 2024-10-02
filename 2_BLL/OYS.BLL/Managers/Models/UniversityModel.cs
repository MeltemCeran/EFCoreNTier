using OYS.DAL.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OYS.BLL.Managers.Models
{
    public class UniversityModel
    {
        public string Name { get; set; }
        public virtual City City { get; set; }
    }
}
