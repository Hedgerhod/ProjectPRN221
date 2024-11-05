using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class User
    {
        public User()
        {
            LeaveRequests = new HashSet<LeaveRequest>();
            Orders = new HashSet<Order>();
            StaffSchedules = new HashSet<StaffSchedule>();
        }

        public int UserId { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Role { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public DateTime? LastLogin { get; set; }

        public virtual ICollection<LeaveRequest> LeaveRequests { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<StaffSchedule> StaffSchedules { get; set; }
    }
}
