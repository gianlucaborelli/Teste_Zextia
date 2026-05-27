using System.Collections.Generic;

namespace Zextia.Entities
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public virtual ProductDetail Detail { get; set; }
        public virtual ICollection<ProductSupplement> Supplements { get; set; }

        public Product()
        {
            Supplements = new List<ProductSupplement>();
        }
    }
}
