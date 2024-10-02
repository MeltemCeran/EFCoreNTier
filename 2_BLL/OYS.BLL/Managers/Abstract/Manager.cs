using AutoMapper;
using OYS.DAL.Entities.Abstract;
using OYS.DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OYS.BLL.Managers.Abstract
{
    public abstract class Manager<TModel, TEntity, TRepository> : IManager<TModel, TEntity, TRepository>
        where TModel : class
        where TEntity : BaseEntity
        where TRepository : Repository<TEntity>, new()
    {

        private readonly TRepository _repository;
        private readonly MapperConfiguration _config;
        private readonly IMapper _mapper;

        protected Manager()
        {
            _repository = new TRepository();
            _config = new MapperConfiguration(cfg => cfg.CreateMap<TEntity, TModel>().ReverseMap());
            _mapper = new Mapper(_config);
        }

        public void Add(TModel model)
        {
            TEntity entity = _mapper.Map<TEntity>(model);
            _repository.Add(entity);
        }

        public void Delete(TModel model)
        {
            TEntity entity = _mapper.Map<TEntity>(model);
            _repository.Delete(entity);
        }

        public ICollection<TModel> GetAll()
        {
            ICollection<TEntity> entities = _repository.GetAll();
            ICollection<TModel> models = _mapper.Map<ICollection<TModel>>(entities);

            return models;
        }

        public TModel GetById(int id)
        {
            TEntity entity = _repository.Get(id);
            TModel model = _mapper.Map<TModel>(entity);

            return model;
        }

        public void Update(TModel model)
        {
            TEntity entity = _mapper.Map<TEntity>(model);
            _repository.Update(entity);
        }
    }

    #region Ank 18 in kendi Auto Mapping Sınıfı
    //public static class Mapping<TOut, TIn> 
    //    where TOut : class, new()
    //    where TIn : class
    //{
    //    public static TOut Map(TIn model)
    //    {
    //        TOut outObject = new TOut();

    //        //PropertyInfo[] properties = outObject.GetType().GetProperties();
    //        PropertyInfo[] properties = model.GetType().GetProperties();

    //        foreach (PropertyInfo property in properties) 
    //        {
    //            outObject.GetType().GetProperty(property.Name).SetValue(outObject, property.GetValue(model));

    //            //property.SetValue(outObject, model.GetType().GetProperty(property.Name).GetValue(model));
    //        }

    //        return outObject;
    //    }
    //} 
    #endregion
}
