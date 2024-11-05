using DataAccess.IRepository;
using DataAccess.Models;
using BusinessObject.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.IService;
using DataAccess.DAO;

namespace BusinessObject.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task AddUserAsync(UserDTO userDto)
        {
            var user = new User
            {
                Username = userDto.Username,
                Password = userDto.Password,
                Role = userDto.Role,
                CreatedAt = userDto.CreatedAt,
                LastLogin = userDto.LastLogin
            };

            await _userRepository.AddUserAsync(user);
        }

        public async Task<List<UserDTO>> GetAllUsersAsync()
        {
            var users = await _userRepository.GetAllUsersAsync();
            return users.Select(u => new UserDTO
            {
                UserId = u.UserId,
                Username = u.Username,
                Password = u.Password,
                Role = u.Role,
                CreatedAt = u.CreatedAt,
                LastLogin = u.LastLogin
            }).ToList();
        }

        public async Task<UserDTO> GetUserByIdAsync(int userId)
        {
            var user = await _userRepository.GetUserByIdAsync(userId);
            if (user != null)
            {
                return new UserDTO
                {
                    UserId = user.UserId,
                    Username = user.Username,
                    Password = user.Password,
                    Role = user.Role,
                    CreatedAt = user.CreatedAt,
                    LastLogin = user.LastLogin
                };
            }
            return null;
        }

        public async Task<UserDTO> Login(string username, string password)
        {
            var user = await _userRepository.Login(username, password);
            if (user != null)
            {
                return new UserDTO
                {
                    UserId = user.UserId,
                    Username = user.Username,
                    Password = user.Password,
                    Role = user.Role,
                    CreatedAt = user.CreatedAt,
                    LastLogin = user.LastLogin
                };
            }
            return null;
        }

        public async Task RemoveUserAsync(int userId)
        {
            await _userRepository.RemoveUserAsync(userId);
        }

        public async Task UpdateUserAsync(UserDTO userDto)
        {
            var user = new User
            {
                UserId = userDto.UserId,
                Username = userDto.Username,
                Password = userDto.Password,
                Role = userDto.Role,
                CreatedAt = userDto.CreatedAt,
                LastLogin = userDto.LastLogin
            };

            await _userRepository.UpdateUserAsync(user);
        }
    }
}
