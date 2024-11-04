using DataAccess.DAO;
using DataAccess.IRepository;
using DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class InventoryTransactionRepository : IInventoryTransactionRepository
    {
        private readonly InventoryTransactionDAO _transactionDao;

        public InventoryTransactionRepository(ProjectPRN221Context context)
        {
            _transactionDao = new InventoryTransactionDAO(context);
        }

        public async Task AddTransactionAsync(InventoryTransaction transaction)
        {
            await _transactionDao.CreateAsync(transaction);
        }

        public async Task UpdateTransactionAsync(InventoryTransaction transaction)
        {
            await _transactionDao.UpdateAsync(transaction);
        }

        public async Task RemoveTransactionAsync(int transactionId)
        {
            await _transactionDao.DeleteTransactionAsync(transactionId);
        }

        public async Task<List<InventoryTransaction>> GetAllTransactionsAsync()
        {
            return await _transactionDao.GetAllAsync();
        }

        public async Task<InventoryTransaction> GetTransactionByIdAsync(int transactionId)
        {
            return await _transactionDao.GetByIdAsync(transactionId);
        }
    }
}
