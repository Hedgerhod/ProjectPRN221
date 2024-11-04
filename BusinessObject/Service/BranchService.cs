using BusinessObject.DTO;
using BusinessObject.IService;
using DataAccess.IRepository;
using DataAccess.Models;
using DataAccess.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessObject.Service
{
    public class BranchService : IBranchService
    {
        private readonly IBranchRepository _branchRepository;

        public BranchService(IBranchRepository branchRepository)
        {
            _branchRepository = branchRepository;
        }

        public async Task AddBranchAsync(BranchDTO branchDTO)
        {
            var branch = new Branch
            {
                BranchName = branchDTO.BranchName,
                Location = branchDTO.Location,
                CreatedAt = branchDTO.CreatedAt
            };

            await _branchRepository.AddBranchAsync(branch);
        }

        public async Task UpdateBranchAsync(BranchDTO branchDTO)
        {
            var branch = new Branch
            {
                BranchId = branchDTO.BranchId,
                BranchName = branchDTO.BranchName,
                Location = branchDTO.Location,
                CreatedAt = branchDTO.CreatedAt
            };

            await _branchRepository.UpdateBranchAsync(branch);
        }

        public async Task<bool> DeleteBranchAsync(int branchId)
        {
            var branch = await _branchRepository.GetBranchByIdAsync(branchId);
            if (branch == null)
            {
                return false;
            }

            await _branchRepository.RemoveBranchAsync(branchId);
            return true;
        }

        public async Task<BranchDTO> GetBranchByIdAsync(int branchId)
        {
            var branch = await _branchRepository.GetBranchByIdAsync(branchId);
            if (branch == null)
            {
                return null;
            }

            return new BranchDTO
            {
                BranchId = branch.BranchId,
                BranchName = branch.BranchName,
                Location = branch.Location,
                CreatedAt = branch.CreatedAt
            };
        }

        public async Task<IEnumerable<BranchDTO>> GetAllBranchesAsync()
        {
            var branches = await _branchRepository.GetAllBranchesAsync();
            return branches.Select(branch => new BranchDTO
            {
                BranchId = branch.BranchId,
                BranchName = branch.BranchName,
                Location = branch.Location,
                CreatedAt = branch.CreatedAt
            }).ToList();
        }
    }
}
