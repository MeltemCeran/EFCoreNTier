using Microsoft.EntityFrameworkCore;
using OYS.DAL.Entities.Concrete;
using OYS.DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OYS.DAL.Repository.Concrete
{
    public class FacultyRepository : Repository<Faculty>
    {
        public List<Department> GetDepartmentsForFacultyById(int id)
        {
            List<Faculty> faculties = _dbContext.Faculties.Where(f=>f.Id == id).Include(f=>f.Departments).ToList();

            return faculties.SelectMany(f => f.Departments).ToList();
        }
    }

}
