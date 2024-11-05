using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class LeaveRequestDAO
    {
        private readonly ProjectPRN221Context _context;

        public LeaveRequestDAO(ProjectPRN221Context context)
        {
            _context = context;
        }

        public async Task CreateAsync(LeaveRequest leaveRequest)
        {
            await _context.LeaveRequests.AddAsync(leaveRequest);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(LeaveRequest leaveRequest)
        {
            _context.Entry(leaveRequest).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteLeaveRequestAsync(int requestId)
        {
            var leaveRequest = await _context.LeaveRequests.FindAsync(requestId);
            if (leaveRequest != null)
            {
                _context.LeaveRequests.Remove(leaveRequest);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<LeaveRequest>> GetAllAsync()
        {
            return await _context.LeaveRequests.ToListAsync();
        }

        public async Task<LeaveRequest> GetByIdAsync(int requestId)
        {
            return await _context.LeaveRequests.FindAsync(requestId);
        }
    }
}
