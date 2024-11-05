using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.DTO
{
    public class UserDTO
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; } 
        public string Role { get; set; } 
        public DateTime CreatedAt { get; set; }
        public DateTime? LastLogin { get; set; }
    }
}
