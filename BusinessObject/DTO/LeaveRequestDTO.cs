using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.DTO
{
    public class LeaveRequestDTO
    {
        public int LeaveRequestId { get; set; }
        public int StaffId { get; set; }
        public DateTime RequestDate { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public string Reason { get; set; }
        public string? LinkReason { get; set; }
        public string Status { get; set; } 
    }
}
