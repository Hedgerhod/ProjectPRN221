using DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.IRepository
{
    public interface IOrderRepository
    {
        Task AddOrderAsync(Order order);
        Task UpdateOrderAsync(Order order);
        Task RemoveOrderAsync(int orderId);
        Task<List<Order>> GetAllOrdersAsync();
        Task<Order> GetOrderByIdAsync(int orderId);
    }
}
