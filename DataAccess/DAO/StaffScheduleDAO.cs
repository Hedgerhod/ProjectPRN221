using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class StaffScheduleDAO
    {
        private readonly ProjectPRN221Context _context;

        public StaffScheduleDAO(ProjectPRN221Context context)
        {
            _context = context;
        }

        public async Task CreateAsync(StaffSchedule staffSchedule)
        {
            await _context.StaffSchedules.AddAsync(staffSchedule);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(StaffSchedule staffSchedule)
        {
            _context.Entry(staffSchedule).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteStaffScheduleAsync(int scheduleId)
        {
            var staffSchedule = await _context.StaffSchedules.FindAsync(scheduleId);
            if (staffSchedule != null)
            {
                _context.StaffSchedules.Remove(staffSchedule);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<StaffSchedule>> GetAllAsync()
        {
            return await _context.StaffSchedules.ToListAsync();
        }

        public async Task<StaffSchedule> GetByIdAsync(int scheduleId)
        {
            return await _context.StaffSchedules.FindAsync(scheduleId);
        }
    }
}
