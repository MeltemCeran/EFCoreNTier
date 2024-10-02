using OYS.DAL.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OYS.DAL.Entities.Concrete
{
    public class Faculty : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Adress { get; set; }
        public virtual City City { get; set; }
        public virtual List<Department> Departments { get; set; } = new List<Department>();
        
    }
}
