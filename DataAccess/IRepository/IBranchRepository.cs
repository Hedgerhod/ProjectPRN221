using DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.IRepository
{
    public interface IBranchRepository
    {
        Task AddBranchAsync(Branch branch);
        Task UpdateBranchAsync(Branch branch);
        Task RemoveBranchAsync(int branchId);
        Task<List<Branch>> GetAllBranchesAsync();
        Task<Branch> GetBranchByIdAsync(int branchId);
    }
}
