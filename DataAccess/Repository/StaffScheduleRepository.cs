using DataAccess.DAO;
using DataAccess.IRepository;
using DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class StaffScheduleRepository : IStaffScheduleRepository
    {
        private readonly StaffScheduleDAO _staffScheduleDao;

        public StaffScheduleRepository(ProjectPRN221Context context)
        {
            _staffScheduleDao = new StaffScheduleDAO(context);
        }

        public async Task AddStaffScheduleAsync(StaffSchedule staffSchedule)
        {
            await _staffScheduleDao.CreateAsync(staffSchedule);
        }

        public async Task UpdateStaffScheduleAsync(StaffSchedule staffSchedule)
        {
            await _staffScheduleDao.UpdateAsync(staffSchedule);
        }

        public async Task RemoveStaffScheduleAsync(int scheduleId)
        {
            await _staffScheduleDao.DeleteStaffScheduleAsync(scheduleId);
        }

        public async Task<List<StaffSchedule>> GetAllStaffSchedulesAsync()
        {
            return await _staffScheduleDao.GetAllAsync();
        }

        public async Task<StaffSchedule> GetStaffScheduleByIdAsync(int scheduleId)
        {
            return await _staffScheduleDao.GetByIdAsync(scheduleId);
        }
    }
}
