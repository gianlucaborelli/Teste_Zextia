using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Zextia.Repositories
{
    public interface IRepository<T> where T : class
    {
        T GetById(Guid id);
        IEnumerable<T> GetAll();        
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
        int SaveChanges();
    }
}
