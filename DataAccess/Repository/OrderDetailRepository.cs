using DataAccess.DAO;
using DataAccess.IRepository;
using DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private readonly OrderDetailDAO _orderDetailDao;

        public OrderDetailRepository(ProjectPRN221Context context)
        {
            _orderDetailDao = new OrderDetailDAO(context);
        }

        public async Task AddOrderDetailAsync(OrderDetail orderDetail)
        {
            await _orderDetailDao.CreateAsync(orderDetail);
        }

        public async Task UpdateOrderDetailAsync(OrderDetail orderDetail)
        {
            await _orderDetailDao.UpdateAsync(orderDetail);
        }

        public async Task RemoveOrderDetailAsync(int orderDetailId)
        {
            await _orderDetailDao.DeleteOrderDetailAsync(orderDetailId);
        }

        public async Task<List<OrderDetail>> GetAllOrderDetailsAsync()
        {
            return await _orderDetailDao.GetAllAsync();
        }

        public async Task<OrderDetail> GetOrderDetailByIdAsync(int orderDetailId)
        {
            return await _orderDetailDao.GetByIdAsync(orderDetailId);
        }
    }
}
