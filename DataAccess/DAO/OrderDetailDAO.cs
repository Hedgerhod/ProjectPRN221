using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class OrderDetailDAO
    {
        private readonly ProjectPRN221Context _context;

        public OrderDetailDAO(ProjectPRN221Context context)
        {
            _context = context;
        }

        public async Task CreateAsync(OrderDetail orderDetail)
        {
            await _context.OrderDetails.AddAsync(orderDetail);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(OrderDetail orderDetail)
        {
            _context.Entry(orderDetail).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteOrderDetailAsync(int orderDetailId)
        {
            var orderDetail = await _context.OrderDetails.FindAsync(orderDetailId);
            if (orderDetail != null)
            {
                _context.OrderDetails.Remove(orderDetail);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<OrderDetail>> GetAllAsync()
        {
            return await _context.OrderDetails.ToListAsync();
        }

        public async Task<OrderDetail> GetByIdAsync(int orderDetailId)
        {
            return await _context.OrderDetails.FindAsync(orderDetailId);
        }
    }
}
