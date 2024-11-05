using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Product
    {
        public Product()
        {
            InventoryTransactions = new HashSet<InventoryTransaction>();
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public string? Description { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int SupplierId { get; set; }
        public int BranchId { get; set; }
        public int CategoryId { get; set; }
        public string? ImageUrl { get; set; }
        public int StockQuantity { get; set; }
        public bool? IsActive { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual Branch Branch { get; set; } = null!;
        public virtual Category Category { get; set; } = null!;
        public virtual Supplier Supplier { get; set; } = null!;
        public virtual ICollection<InventoryTransaction> InventoryTransactions { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
