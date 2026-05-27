using System;

namespace Zextia.DTOs
{
    public class ProductSupplementDto
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public string Batches { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
