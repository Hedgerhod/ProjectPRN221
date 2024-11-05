using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class BranchDAO
    {
        private readonly ProjectPRN221Context _context;

        public BranchDAO(ProjectPRN221Context context)
        {
            _context = context;
        }

        public async Task CreateAsync(Branch branch)
        {
            await _context.Branches.AddAsync(branch);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Branch branch)
        {
            _context.Entry(branch).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteBranchAsync(int branchId)
        {
            var branch = await _context.Branches.FindAsync(branchId);
            if (branch != null)
            {
                _context.Branches.Remove(branch);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Branch>> GetAllAsync()
        {
            return await _context.Branches.ToListAsync();
        }

        public async Task<Branch> GetByIdAsync(int branchId)
        {
            return await _context.Branches.FindAsync(branchId);
        }
    }
}
