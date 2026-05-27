using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Zextia.Data;

namespace Zextia.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        protected readonly ApplicationDbContext _context;
        protected readonly DbSet<T> _dbSet;

        protected Repository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public virtual T GetById(Guid id)
        {
            return _dbSet.Find(id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _dbSet
                .ToList();
        }
        
        public virtual void Add(T entity)
        {
            _dbSet.Add(entity);
        }
                
        public virtual void Update(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Remove(T entity)
        {
            _dbSet.Remove(entity);
        }

        public virtual int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
