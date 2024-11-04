using DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.IRepository
{
    public interface IInventoryTransactionRepository
    {
        Task AddTransactionAsync(InventoryTransaction transaction);
        Task UpdateTransactionAsync(InventoryTransaction transaction);
        Task RemoveTransactionAsync(int transactionId);
        Task<List<InventoryTransaction>> GetAllTransactionsAsync();
        Task<InventoryTransaction> GetTransactionByIdAsync(int transactionId);
    }
}
