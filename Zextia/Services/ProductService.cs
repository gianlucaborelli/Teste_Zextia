using System;
using System.Collections.Generic;
using System.Linq;
using Zextia.DTOs;
using Zextia.Extensions;
using Zextia.Repositories;

namespace Zextia.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public ServiceResult<ProductDto> GetById(Guid id)
        {
            try
            {
                var product = _productRepository.GetByIdWithSupplements(id);
                if (product == null)
                    return ServiceResult<ProductDto>.Fail("Produto não encontrado");

                return ServiceResult<ProductDto>.Ok(product.ToDto());
            }
            catch (Exception ex)
            {
                return ServiceResult<ProductDto>.Fail($"Erro ao buscar produto com suplementos: {ex.Message}");
            }
        }

        public ServiceResult<IEnumerable<ProductDto>> Find(string query)
        {
            try
            {
                IEnumerable<Entities.Product> products;

                if (string.IsNullOrWhiteSpace(query))
                {
                    products = _productRepository.GetAllWithSupplements();
                }
                else
                {
                    query = query.ToLower();
                    products = _productRepository.Find(p =>
                        p.Name.ToLower().Contains(query) ||
                        p.Code.ToLower().Contains(query) ||
                        (p.Detail != null && p.Detail.Description.ToLower().Contains(query))
                    );
                }

                return ServiceResult<IEnumerable<ProductDto>>.Ok(products.ToDto());
            }
            catch (Exception ex)
            {
                return ServiceResult<IEnumerable<ProductDto>>.Fail($"Erro ao buscar produtos: {ex.Message}");
            }
        }

        public ServiceResult<IEnumerable<ProductDto>> GetAll()
        {
            try
            {
                var products = _productRepository.GetAllWithSupplements();
                return ServiceResult<IEnumerable<ProductDto>>.Ok(products.ToDto());
            }
            catch (Exception ex)
            {
                return ServiceResult<IEnumerable<ProductDto>>.Fail($"Erro ao buscar produtos com suplementos: {ex.Message}");
            }
        }

        public ServiceResult CreateProduct(ProductDto productDto)
        {
            if (productDto == null)
                return ServiceResult.Fail("Produto não pode ser nulo");

            if (string.IsNullOrWhiteSpace(productDto.Name))
                return ServiceResult.Fail("Nome do produto é obrigatório");

            try
            {
                var product = productDto.ToEntity();
                _productRepository.Add(product);
                _productRepository.SaveChanges();
                return ServiceResult.Ok("Produto criado com sucesso");
            }
            catch (Exception ex)
            {
                return ServiceResult.Fail($"Erro ao criar produto: {ex.Message}");
            }
        }

        public ServiceResult UpdateProduct(ProductDto productDto)
        {
            if (productDto == null)
                return ServiceResult.Fail("Produto não pode ser nulo");

            if (string.IsNullOrWhiteSpace(productDto.Name))
                return ServiceResult.Fail("Nome do produto é obrigatório");

            try
            {
                var product = _productRepository.GetById(productDto.Id);
                if (product == null)
                    return ServiceResult.Fail("Produto não encontrado");

                product.UpdateFromDto(productDto);
                _productRepository.SaveChanges();
                return ServiceResult.Ok("Produto atualizado com sucesso");
            }
            catch (Exception ex)
            {
                return ServiceResult.Fail($"Erro ao atualizar produto: {ex.Message}");
            }
        }

        public ServiceResult DeleteProduct(Guid id)
        {
            try
            {
                var product = _productRepository.GetById(id);
                if (product == null)
                    return ServiceResult.Fail("Produto não encontrado");

                _productRepository.Remove(product);
                _productRepository.SaveChanges();
                return ServiceResult.Ok("Produto excluído com sucesso");
            }
            catch (Exception ex)
            {
                return ServiceResult.Fail($"Erro ao excluir produto: {ex.Message}");
            }
        }

        public ServiceResult AddSupplementToProduct(Guid productId, ProductSupplementDto supplementDto)
        {
            if (supplementDto == null)
                return ServiceResult.Fail("Suplemento não pode ser nulo");

            try
            {
                var product = _productRepository.GetById(productId);
                if (product == null)
                    return ServiceResult.Fail("Produto não encontrado");

                var supplement = supplementDto.ToEntity();
                supplement.ProductId = productId;
                product.Supplements.Add(supplement);
                _productRepository.SaveChanges();
                return ServiceResult.Ok("Suplemento adicionado com sucesso");
            }
            catch (Exception ex)
            {
                return ServiceResult.Fail($"Erro ao adicionar suplemento: {ex.Message}");
            }
        }

        public ServiceResult UpdateSupplement(Guid productId, ProductSupplementDto supplementDto)
        {
            if (supplementDto == null)
                return ServiceResult.Fail("Suplemento não pode ser nulo");

            try
            {
                var product = _productRepository.GetByIdWithSupplements(productId);
                if (product == null)
                    return ServiceResult.Fail("Produto não encontrado");

                var supplement = product.Supplements.FirstOrDefault(s => s.Id == supplementDto.Id);
                if (supplement == null)
                    return ServiceResult.Fail("Suplemento não encontrado");

                supplement.Batches = supplementDto.Batches;

                _productRepository.SaveChanges();
                return ServiceResult.Ok("Suplemento atualizado com sucesso");
            }
            catch (Exception ex)
            {
                return ServiceResult.Fail($"Erro ao atualizar suplemento: {ex.Message}");
            }
        }

        public ServiceResult DeleteSupplement(Guid productId, Guid supplementId)
        {
            try
            {
                var product = _productRepository.GetByIdWithSupplements(productId);
                if (product == null)
                    return ServiceResult.Fail("Produto não encontrado");

                var supplement = product.Supplements.FirstOrDefault(s => s.Id == supplementId);
                if (supplement == null)
                    return ServiceResult.Fail("Suplemento não encontrado");

                product.Supplements.Remove(supplement);
                _productRepository.RemoveSupplement(supplement);

                _productRepository.SaveChanges();
                return ServiceResult.Ok("Suplemento excluído com sucesso");
            }
            catch (Exception ex)
            {
                return ServiceResult.Fail($"Erro ao excluir suplemento: {ex.Message}");
            }
        }
    }
}
