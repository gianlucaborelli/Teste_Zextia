using System.Collections.Generic;
using System.Linq;
using Zextia.DTOs;
using Zextia.Entities;

namespace Zextia.Extensions
{
    public static class ProductMappingExtensions
    {
        public static ProductDto ToDto(this Product product)
        {
            if (product == null)
                return null;

            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Code = product.Code,
                CreatedAt = product.CreatedAt,
                DetailDescription = product.Detail?.Description ?? string.Empty,
                Supplements = product.Supplements?.Select(s => s.ToDto()).ToList() ?? new List<ProductSupplementDto>()
            };
        }

        public static Product ToEntity(this ProductDto dto)
        {
            if (dto == null)
                return null;

            return new Product
            {
                Id = dto.Id,
                Name = dto.Name,
                Code = dto.Code,
                CreatedAt = dto.CreatedAt,
                Detail = new ProductDetail
                {
                    Description = dto.DetailDescription,
                    ProductId = dto.Id
                },
                Supplements = dto.Supplements?.Select(s => s.ToEntity()).ToList() ?? new List<ProductSupplement>()
            };
        }

        public static List<ProductDto> ToDto(this IEnumerable<Product> products)
        {
            if (products == null)
                return new List<ProductDto>();

            return products.Select(p => p.ToDto()).ToList();
        }

        public static void UpdateFromDto(this Product product, ProductDto dto)
        {
            if (product == null || dto == null)
                return;

            product.Name = dto.Name;
            product.Code = dto.Code;

            if (product.Detail == null)
            {
                product.Detail = new ProductDetail
                {
                    ProductId = product.Id
                };
            }

            product.Detail.Description = dto.DetailDescription;
        }
    }
}
