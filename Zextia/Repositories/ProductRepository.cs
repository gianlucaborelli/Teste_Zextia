using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Zextia.Data;
using Zextia.Entities;

namespace Zextia.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
        }

        public IEnumerable<Product> Find(Expression<Func<Product, bool>> predicate)
        {            
            return _dbSet.Where(predicate)
                    .Include(p => p.Detail)
                    .Include(p => p.Supplements)
                    .ToList();
        }

        public Product GetByIdWithSupplements(Guid id)
        {
            return _dbSet
                .Include(p => p.Detail)
                .Include(p => p.Supplements)
                .FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Product> GetAllWithSupplements()
        {
            return _dbSet
                .AsNoTracking()
                .Include(p => p.Detail)
                .Include(p => p.Supplements)
                .OrderBy(p => p.CreatedAt)
                .ToList();
        }

        public void RemoveSupplement(ProductSupplement supplement)
        {
            _context.Set<ProductSupplement>().Remove(supplement);
        }
    }
}
