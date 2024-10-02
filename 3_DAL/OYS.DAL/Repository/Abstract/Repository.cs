using Microsoft.EntityFrameworkCore;
using OYS.DAL.Data;
using OYS.DAL.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OYS.DAL.Repository.Abstract
{
    public abstract class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private protected OYSDbContext _dbContext;
        private protected DbSet<T> _entities;

        protected Repository()
        {
            _dbContext = new OYSDbContext();
            _entities = _dbContext.Set<T>();
        }

        public void Add(T entity)
        {
            _entities.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            _entities.Update(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            _entities.Remove(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            T entity = _entities.Where(s => s.Id == id).ToList().SingleOrDefault();

            _entities.Remove(entity);
            _dbContext.SaveChanges();
        }

        public T Get(int id)
        {
            return _entities.Find(id);
        }

        public ICollection<T> GetAll()
        {
            return _entities.ToList();
        }
    }
}
