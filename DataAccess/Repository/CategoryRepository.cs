using DataAccess.DAO;
using DataAccess.IRepository;
using DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly CategoryDAO _categoryDao;

        public CategoryRepository(ProjectPRN221Context context)
        {
            _categoryDao = new CategoryDAO(context);
        }

        public async Task AddCategoryAsync(Category category)
        {
            await _categoryDao.CreateAsync(category);
        }

        public async Task UpdateCategoryAsync(Category category)
        {
            await _categoryDao.UpdateAsync(category);
        }

        public async Task RemoveCategoryAsync(int categoryId)
        {
            await _categoryDao.DeleteCategoryAsync(categoryId);
        }

        public async Task<List<Category>> GetAllCategoriesAsync()
        {
            return await _categoryDao.GetAllAsync();
        }

        public async Task<Category> GetCategoryByIdAsync(int categoryId)
        {
            return await _categoryDao.GetByIdAsync(categoryId);
        }
    }
}
