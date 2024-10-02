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
    public class StudentOperation
    {
        private readonly StudentRepository _studentRepository;
        public StudentOperation()
        {
            _studentRepository = new StudentRepository();
        }

        public void AddStudent(StudentModel model)
        {

            Student student = new Student();
            student.Name = model.Name;
            student.Surname = model.Surname;
            student.StudentNumber = (Math.Floor(new Random().NextDouble() * 10000000)).ToString();
            student.Email = model.Email;
            student.BirthDate = model.BirthDate;

            _studentRepository.Add(student);
            

        }
    }
}
