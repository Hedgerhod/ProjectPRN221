using BusinessObject.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.IService
{
    public interface IBranchService
    {
        Task AddBranchAsync(BranchDTO branchDTO);
        Task UpdateBranchAsync(BranchDTO branchDTO);
        Task<bool> DeleteBranchAsync(int branchId);
        Task<BranchDTO> GetBranchByIdAsync(int branchId);
        Task<IEnumerable<BranchDTO>> GetAllBranchesAsync();
    }
}
