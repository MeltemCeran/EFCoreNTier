using OYS.BLL.Managers.Abstract;
using OYS.BLL.Managers.Models;
using OYS.DAL.Entities.Concrete;
using OYS.DAL.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OYS.BLL.Managers.Concrete
{
    public class TeacherManager : Manager<TeacherModel, Teacher, TeacherRepository> //??? burayı sor.
    {
        #region Old TeacherManager Codes
        //private readonly TeacherRepository _teacherRepository;
        //public TeacherManager()
        //{
        //    _teacherRepository = new TeacherRepository();
        //}

        //public void AddTeacher(TeacherModel model)
        //{

        //    Teacher teacher = new Teacher();
        //    teacher.Name = model.Name;
        //    teacher.Surname = model.Surname;
        //    teacher.TeacherNumber = Math.Floor(new Random().NextDouble() * 10000000).ToString();
        //    teacher.Email = model.Email;
        //    teacher.BirthDate = model.BirthDate;

        //    _teacherRepository.Add(teacher);

        //} 
        #endregion
    }
}
