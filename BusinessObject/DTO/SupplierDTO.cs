using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.DTO
{
    public class SupplierDTO
    {
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string Email { get; set; } 
        public string PhoneNumber { get; set; } 
        public string Address { get; set; } 
        public DateTime CreatedAt { get; set; }
    }
}
