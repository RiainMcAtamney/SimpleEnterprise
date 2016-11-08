using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MySample.Data.Infrastructure
{
    public interface IRepository<T> where T : class
    {
        
        void Add(T entity);
        
        void Update(T entity);
        
        void Delete(T entity);

        void Delete(Expression<Func<T, bool>> where);

        // Get an entity by int id
        T GetById(int id);

        // Get an entity using delegate
        T Get(Expression<Func<T, bool>> where);

        // Gets all entities of type T
        IEnumerable<T> GetAll();

        // Gets entities using delegate
        IEnumerable<T> GetMany(Expression<Func<T, bool>> where);

        void Save();
    }
}
