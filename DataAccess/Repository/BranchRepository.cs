using DataAccess.DAO;
using DataAccess.IRepository;
using DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class BranchRepository : IBranchRepository
    {
        private readonly BranchDAO _branchDao;

        public BranchRepository(ProjectPRN221Context context)
        {
            _branchDao = new BranchDAO(context);
        }

        public async Task AddBranchAsync(Branch branch)
        {
            await _branchDao.CreateAsync(branch);
        }

        public async Task UpdateBranchAsync(Branch branch)
        {
            await _branchDao.UpdateAsync(branch);
        }

        public async Task RemoveBranchAsync(int branchId)
        {
            await _branchDao.DeleteBranchAsync(branchId);
        }

        public async Task<List<Branch>> GetAllBranchesAsync()
        {
            return await _branchDao.GetAllAsync();
        }

        public async Task<Branch> GetBranchByIdAsync(int branchId)
        {
            return await _branchDao.GetByIdAsync(branchId);
        }
    }
}
