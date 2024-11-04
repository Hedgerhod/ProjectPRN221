using DataAccess.DAO;
using DataAccess.IRepository;
using DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly UserDAO _userDao;

        public UserRepository(ProjectPRN221Context context)
        {
            _userDao = new UserDAO(context);
        }

        public async Task AddUserAsync(User user)
        {
            await _userDao.CreateAsync(user);
        }

        public async Task UpdateUserAsync(User user)
        {
            await _userDao.UpdateAsync(user);
        }

        public async Task RemoveUserAsync(int userId)
        {
            await _userDao.DeleteUserAsync(userId);
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            return await _userDao.GetAllAsync();
        }

        public async Task<User> GetUserByIdAsync(int userId)
        {
            return await _userDao.GetByIdAsync(userId);
        }
    }
}
