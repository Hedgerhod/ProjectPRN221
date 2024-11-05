using BusinessObject.DTO;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.IService
{
    public interface IUserService
    {
        Task AddUserAsync(UserDTO user);
        Task UpdateUserAsync(UserDTO user);
        Task RemoveUserAsync(int userId);
        Task<List<UserDTO>> GetAllUsersAsync();
        Task<UserDTO> GetUserByIdAsync(int userId);
        Task<UserDTO> Login(string username, string password);
    }
}
