using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Branch
    {
        public Branch()
        {
            InventoryTransactions = new HashSet<InventoryTransaction>();
            Products = new HashSet<Product>();
        }

        public int BranchId { get; set; }
        public string BranchName { get; set; } = null!;
        public string Location { get; set; } = null!;
        public DateTime CreatedAt { get; set; }

        public virtual ICollection<InventoryTransaction> InventoryTransactions { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
