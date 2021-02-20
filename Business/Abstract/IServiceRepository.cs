using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface IServiceRepository  <T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        List<T> Get(Expression<Func<T, bool>> filter = null);
        List<T> GetCarsByBrandId(int id);
        List<T> GetCarsByColorId(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
