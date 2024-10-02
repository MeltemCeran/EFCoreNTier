using Microsoft.EntityFrameworkCore;
using OYS.DAL.Data;
using OYS.DAL.Entities.Concrete;
using OYS.DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OYS.DAL.Repository.Concrete
{
    public class StudentRepository : Repository<Student>
    {
        //private OYSDbContext _dbContext;
        //private DbSet<Student> _students;
        //public StudentRepository() 
        //{
        //    _dbContext = new OYSDbContext();
        //    _students = _dbContext.Students;
        //}
        //public void Add(Student student) 
        //{
        //    _students.Add(student);
        //    _dbContext.SaveChanges();
        //}
        //public void Update(Student student) 
        //{
        //    _students.Update(student);
        //    _dbContext.SaveChanges();
        //}
        //public void Delete(int id) 
        //{
        //    Student student = _students.Where(s => s.Id == id).ToList().SingleOrDefault();

        //    _students.Remove(student);
        //    _dbContext.SaveChanges();
        //}

        //public void Delete(Student student)
        //{
        //    _students.Remove(student);
        //    _dbContext.SaveChanges();
        //}

        //public List<Student> GetAll() 
        //{
        //    return _students.ToList();
        //}
        //public Student Get(int id) 
        //{
        //    //Student student = _students.Where(s => s.Id == id).ToList().SingleOrDefault();
        //    Student student = _students.Find(id);

        //    return student;
        //}
        public List<Student> GetActive()
        {
            return _entities.Where(s => s.IsActive == true).ToList();
        }

        public List<Student> GetActiveByBirthDateYear(int year)
        {
            return _entities.Where(s => s.IsActive == true && s.BirthDate.Year == year).ToList();
        }
    }
}
