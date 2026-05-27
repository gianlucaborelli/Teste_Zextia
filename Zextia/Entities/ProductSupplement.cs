using System;

namespace Zextia.Entities
{
    public class ProductSupplement : Entity
    {
        public Guid ProductId { get; set; }
        public string Batches { get; set; }
        public virtual Product Product { get; set; }
    }
}
