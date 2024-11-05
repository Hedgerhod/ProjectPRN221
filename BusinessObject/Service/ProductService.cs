using BusinessObject.DTO;
using BusinessObject.IService;
using DataAccess.IRepository;
using DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessObject.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task AddProductAsync(ProductDTO productDto)
        {
            var product = new Product
            {
                ProductName = productDto.ProductName,
                Description = productDto.Description,
                Quantity = productDto.Quantity,
                Price = productDto.Price,
                SupplierId = productDto.SupplierId,
                BranchId = productDto.BranchId,
                CategoryId = productDto.CategoryId,
                ImageUrl = productDto.ImageUrl,
                StockQuantity = productDto.StockQuantity,
                IsActive = productDto.IsActive,
                CreatedAt = productDto.CreatedAt
            };

            await _productRepository.AddProductAsync(product);
        }

        public async Task UpdateProductAsync(ProductDTO productDto)
        {
            var product = new Product
            {
                ProductId = productDto.ProductId,
                ProductName = productDto.ProductName,
                Description = productDto.Description,
                Quantity = productDto.Quantity,
                Price = productDto.Price,
                SupplierId = productDto.SupplierId,
                BranchId = productDto.BranchId,
                CategoryId = productDto.CategoryId,
                ImageUrl = productDto.ImageUrl,
                StockQuantity = productDto.StockQuantity,
                IsActive = productDto.IsActive,
                CreatedAt = productDto.CreatedAt
            };

            await _productRepository.UpdateProductAsync(product);
        }

        public async Task RemoveProductAsync(int productId)
        {
            await _productRepository.RemoveProductAsync(productId);
        }

        public async Task<List<ProductDTO>> GetAllProductsAsync()
        {
            var products = await _productRepository.GetAllProductsAsync();
            var productDtos = new List<ProductDTO>();
            foreach (var product in products)
            {
                productDtos.Add(new ProductDTO
                {
                    ProductId = product.ProductId,
                    ProductName = product.ProductName,
                    Description = product.Description,
                    Quantity = product.Quantity,
                    Price = product.Price,
                    SupplierId = product.SupplierId,
                    BranchId = product.BranchId,
                    CategoryId = product.CategoryId,
                    ImageUrl = product.ImageUrl,
                    StockQuantity = product.StockQuantity,
                    IsActive = product.IsActive,
                    CreatedAt = product.CreatedAt
                });
            }
            return productDtos;
        }

        public async Task<ProductDTO> GetProductByIdAsync(int productId)
        {
            var product = await _productRepository.GetProductByIdAsync(productId);
            if (product == null) return null;
            return new ProductDTO
            {
                ProductId = product.ProductId,
                ProductName = product.ProductName,
                Description = product.Description,
                Quantity = product.Quantity,
                Price = product.Price,
                SupplierId = product.SupplierId,
                BranchId = product.BranchId,
                CategoryId = product.CategoryId,
                ImageUrl = product.ImageUrl,
                StockQuantity = product.StockQuantity,
                IsActive = product.IsActive,
                CreatedAt = product.CreatedAt
            };
        }
    }
}
