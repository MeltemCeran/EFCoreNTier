using OYS.DAL.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OYS.DAL.Entities.Concrete
{
    public class City : BaseEntity
    {
        public string Name { get; set; }
        public string NumberPlate { get; set; }
        public virtual List<Faculty> FacultyList { get; set; }
        public virtual List<University> UniversityList { get; set; }
    }
}
