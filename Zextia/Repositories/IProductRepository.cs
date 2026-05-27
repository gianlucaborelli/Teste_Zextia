using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Zextia.Entities;

namespace Zextia.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> Find(Expression<Func<Product, bool>> predicate);
        Product GetByIdWithSupplements(Guid id);
        IEnumerable<Product> GetAllWithSupplements();
        void RemoveSupplement(ProductSupplement supplement);
        bool DeleteProduct(Guid productId, out string message);
    }
}
