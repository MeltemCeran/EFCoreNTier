using OYS.DAL.Entities.Concrete;
using OYS.DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OYS.DAL.Repository.Concrete
{
    public class TeacherRepository : Repository<Teacher>
    {
        public List<Teacher> GetActive()
        {
            return _entities.Where(t => t.IsActive == true).ToList();
        }

        public List<Teacher> GetActiveByBirthDateYear(int year)
        {
            return _entities.Where(t => t.IsActive == true && t.BirthDate.Year == year).ToList();
        }
    }
}
