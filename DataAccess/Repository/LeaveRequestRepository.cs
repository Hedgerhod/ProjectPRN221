using DataAccess.DAO;
using DataAccess.IRepository;
using DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class LeaveRequestRepository : ILeaveRequestRepository
    {
        private readonly LeaveRequestDAO _leaveRequestDao;

        public LeaveRequestRepository(ProjectPRN221Context context)
        {
            _leaveRequestDao = new LeaveRequestDAO(context);
        }

        public async Task AddLeaveRequestAsync(LeaveRequest leaveRequest)
        {
            await _leaveRequestDao.CreateAsync(leaveRequest);
        }

        public async Task UpdateLeaveRequestAsync(LeaveRequest leaveRequest)
        {
            await _leaveRequestDao.UpdateAsync(leaveRequest);
        }

        public async Task RemoveLeaveRequestAsync(int requestId)
        {
            await _leaveRequestDao.DeleteLeaveRequestAsync(requestId);
        }

        public async Task<List<LeaveRequest>> GetAllLeaveRequestsAsync()
        {
            return await _leaveRequestDao.GetAllAsync();
        }

        public async Task<LeaveRequest> GetLeaveRequestByIdAsync(int requestId)
        {
            return await _leaveRequestDao.GetByIdAsync(requestId);
        }
    }
}
