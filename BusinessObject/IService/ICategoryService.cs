using BusinessObject.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessObject.IService
{
    public interface ICategoryService
    {
        Task AddCategoryAsync(CategoryDTO categoryDTO);
        Task UpdateCategoryAsync(CategoryDTO categoryDTO);
        Task<bool> DeleteCategoryAsync(int categoryId);
        Task<CategoryDTO> GetCategoryByIdAsync(int categoryId);
        Task<List<CategoryDTO>> GetAllCategoriesAsync();
    }
}
