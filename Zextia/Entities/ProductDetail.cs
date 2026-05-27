using System;

namespace Zextia.Entities
{
    public class ProductDetail : Entity
    {
        public Guid ProductId { get; set; }
        public string Description { get; set; }
        public virtual Product Product { get; set; }
    }
}
