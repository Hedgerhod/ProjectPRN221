using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.DTO
{
    public class InventoryTransactionDTO
    {
        public int TransactionId { get; set; }
        public int ProductId { get; set; }
        public int BranchId { get; set; }
        public string TransactionType { get; set; }
        public int Quantity { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
