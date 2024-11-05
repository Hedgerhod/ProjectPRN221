using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class LeaveRequest
    {
        public int LeaveRequestId { get; set; }
        public int StaffId { get; set; }
        public DateTime RequestDate { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public string Reason { get; set; } = null!;
        public string? LinkReason { get; set; }
        public string Status { get; set; } = null!;

        public virtual User Staff { get; set; } = null!;
    }
}
