using DataAccess.DAO;
using DataAccess.IRepository;
using DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly OrderDAO _orderDao;

        public OrderRepository(ProjectPRN221Context context)
        {
            _orderDao = new OrderDAO(context);
        }

        public async Task AddOrderAsync(Order order)
        {
            await _orderDao.CreateAsync(order);
        }

        public async Task UpdateOrderAsync(Order order)
        {
            await _orderDao.UpdateAsync(order);
        }

        public async Task RemoveOrderAsync(int orderId)
        {
            await _orderDao.DeleteOrderAsync(orderId);
        }

        public async Task<List<Order>> GetAllOrdersAsync()
        {
            return await _orderDao.GetAllAsync();
        }

        public async Task<Order> GetOrderByIdAsync(int orderId)
        {
            return await _orderDao.GetByIdAsync(orderId);
        }
    }
}
