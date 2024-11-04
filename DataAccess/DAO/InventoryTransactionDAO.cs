using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class InventoryTransactionDAO
    {
        private readonly ProjectPRN221Context _context;

        public InventoryTransactionDAO(ProjectPRN221Context context)
        {
            _context = context;
        }

        public async Task CreateAsync(InventoryTransaction transaction)
        {
            await _context.InventoryTransactions.AddAsync(transaction);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(InventoryTransaction transaction)
        {
            _context.Entry(transaction).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTransactionAsync(int transactionId)
        {
            var transaction = await _context.InventoryTransactions.FindAsync(transactionId);
            if (transaction != null)
            {
                _context.InventoryTransactions.Remove(transaction);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<InventoryTransaction>> GetAllAsync()
        {
            return await _context.InventoryTransactions.ToListAsync();
        }

        public async Task<InventoryTransaction> GetByIdAsync(int transactionId)
        {
            return await _context.InventoryTransactions.FindAsync(transactionId);
        }
    }
}
