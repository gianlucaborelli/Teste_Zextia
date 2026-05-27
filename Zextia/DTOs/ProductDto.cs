using System;
using System.Collections.Generic;

namespace Zextia.DTOs
{
    public class ProductDto
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Code { get; set; }
        public string DetailDescription { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;        

        public List<ProductSupplementDto> Supplements { get; set; }

        public ProductDto()
        {
            Supplements = new List<ProductSupplementDto>();
        }
    }
}
