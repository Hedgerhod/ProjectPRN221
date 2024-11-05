using DataAccess.DAO;
using DataAccess.IRepository;
using DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDAO _productDao;

        public ProductRepository(ProjectPRN221Context context)
        {
            _productDao = new ProductDAO(context);
        }

        public async Task AddProductAsync(Product product)
        {
            await _productDao.CreateAsync(product);
        }

        public async Task UpdateProductAsync(Product product)
        {
            await _productDao.UpdateAsync(product);
        }

        public async Task RemoveProductAsync(int productId)
        {
            await _productDao.DeleteProductAsync(productId);
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await _productDao.GetAllAsync();
        }

        public async Task<Product> GetProductByIdAsync(int productId)
        {
            return await _productDao.GetByIdAsync(productId);
        }
    }
}
