using System.Collections.Generic;
using System.Linq;
using Zextia.DTOs;
using Zextia.Entities;

namespace Zextia.Extensions
{
    public static class ProductSupplementMappingExtensions
    {
        public static ProductSupplementDto ToDto(this ProductSupplement supplement)
        {
            if (supplement == null)
                return null;

            return new ProductSupplementDto
            {
                Id = supplement.Id,
                ProductId = supplement.ProductId,
                Batches = supplement.Batches,
                CreatedAt = supplement.CreatedAt
            };
        }

        public static ProductSupplement ToEntity(this ProductSupplementDto dto)
        {
            if (dto == null)
                return null;

            return new ProductSupplement
            {
                Id = dto.Id,
                ProductId = dto.ProductId,
                Batches = dto.Batches,
                CreatedAt = dto.CreatedAt
            };
        }
    }
}
