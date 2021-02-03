using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using Entities.Abstract;

namespace DataAccess.Abstract
{
    //generic constraint 
    //calss : referans tip
    // IEntity : IEntity Olabilir  veya IEntity implemente eden bir nesne olabilir.
    //new() : new' lenebilir olmalı.
    public interface IEntityRepository<T> where T:class, IEntity
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        List<T> GetAllByCategory(int categoryId);
    }
}
