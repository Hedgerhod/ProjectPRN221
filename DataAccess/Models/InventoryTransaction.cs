using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class InventoryTransaction
    {
        public int TransactionId { get; set; }
        public int ProductId { get; set; }
        public int BranchId { get; set; }
        public string TransactionType { get; set; } = null!;
        public int Quantity { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual Branch Branch { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}
