using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class StaffSchedule
    {
        public int ScheduleId { get; set; }
        public int StaffId { get; set; }
        public DateTime ShiftDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual User Staff { get; set; } = null!;
    }
}
