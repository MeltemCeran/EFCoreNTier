using OYS.DAL.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace OYS.DAL.Entities.Concrete
{
    public class Student : BaseEntity
    {
        [Column(TypeName = "nvarchar(25)")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(25)")]
        public string Surname { get; set; }

        [Column(TypeName = "varchar(8)")]
        public string StudentNumber { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Email { get; set; }

        public DateOnly BirthDate { get; set; }
    }
}
