using System;
using System.Collections.Generic;
using Zextia.DTOs;

namespace Zextia.Services
{
    public interface IProductService
    {
        ServiceResult<ProductDto> GetById(Guid id);
        ServiceResult<IEnumerable<ProductDto>> Find(string query);
        ServiceResult<IEnumerable<ProductDto>> GetAll();        
        ServiceResult CreateProduct(ProductDto product);
        ServiceResult UpdateProduct(ProductDto product);
        ServiceResult DeleteProduct(Guid id);
        ServiceResult AddSupplementToProduct(Guid productId, ProductSupplementDto supplement);
        ServiceResult UpdateSupplement(Guid productId, ProductSupplementDto supplement);
        ServiceResult DeleteSupplement(Guid productId, Guid supplementId);
    }
}
