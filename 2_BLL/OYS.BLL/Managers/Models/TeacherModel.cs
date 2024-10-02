using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OYS.BLL.Managers.Models
{
    public class TeacherModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? Email { get; set; }
        public DateOnly BirthDate { get; set; }
    }
}
