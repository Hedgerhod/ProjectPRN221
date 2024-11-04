using BusinessObject.DTO;
using DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessObject.IService
{
    public interface IProductService
    {
        Task AddProductAsync(ProductDTO product);
        Task UpdateProductAsync(ProductDTO product);
        Task RemoveProductAsync(int productId);
        Task<List<ProductDTO>> GetAllProductsAsync();
        Task<ProductDTO> GetProductByIdAsync(int productId);
    }
}
