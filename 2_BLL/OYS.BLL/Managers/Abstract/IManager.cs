using OYS.DAL.Entities.Abstract;
using OYS.DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OYS.BLL.Managers.Abstract
{
    public interface IManager<TModel, TEntity, TRepository>
         where TModel : class
         where TEntity : BaseEntity
         where TRepository : Repository<TEntity>, new()
    {
        void Add(TModel model);
        void Update(TModel model);
        void Delete(TModel model);
        TModel GetById(int id);
        ICollection<TModel> GetAll();
    }
}
