using DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.IRepository
{
    public interface IStaffScheduleRepository
    {
        Task AddStaffScheduleAsync(StaffSchedule staffSchedule);
        Task UpdateStaffScheduleAsync(StaffSchedule staffSchedule);
        Task RemoveStaffScheduleAsync(int scheduleId);
        Task<List<StaffSchedule>> GetAllStaffSchedulesAsync();
        Task<StaffSchedule> GetStaffScheduleByIdAsync(int scheduleId);
    }
}
