using EventBookingManagementSystem_Backend.DB.Entities;
using EventBookingManagementSystem_Backend.DTOs.RequestModels;
using EventBookingManagementSystem_Backend.DTOs.ResponseModels;
using EventBookingManagementSystem_Backend.Repositories.Interfaces;
using EventBookingManagementSystem_Backend.Services.Interfaces;

namespace EventBookingManagementSystem_Backend.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<UserResponse>> GetAllUsersAsync()
        {
            var users = await _repository.GetAllAsync();
            return users.Select(u => new UserResponse
            {
                UserId = u.UserId,
                FirstName = u.FirstName,
                LastName = u.LastName,
                Email = u.Email,
                Phone = u.Phone,
                Address = u.Address,

            });
        }

        public async Task<UserResponse> GetUserByIdAsync(Guid id)
        {
            var u = await _repository.GetByIdAsync(id);
            if (u == null) return null;

            return new UserResponse
            {
                UserId = u.UserId,
                FirstName = u.FirstName,
                LastName = u.LastName,
                Email = u.Email,
                Phone = u.Phone,
                Address = u.Address,

            };
        }

        public async Task<UserResponse> CreateUserAsync(UserRequest dto)
        {
            var user = new User
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Email = dto.Email,
                Phone = dto.Phone,
                Address = dto.Address,
                UserId = new Guid()

            };

            var created = await _repository.CreateAsync(user);

            return new UserResponse
            {
                UserId = created.UserId,
                FirstName = created.FirstName,
                LastName = created.LastName,
                Email = created.Email,
                Phone = created.Phone,
                Address = created.Address,

            };
        }

        public async Task<User?> UpdateUserAsync(Guid id, UserRequest dto)
        {

            var data = await _repository.GetByIdAsync(id);

            if (data != null)
            {
                var user = new User
                {
                    UserId = id,
                    FirstName = dto.FirstName,
                    LastName = dto.LastName,
                    Email = dto.Email,
                    Phone = dto.Phone,
                    Address = dto.Address,

                };

                var updatedData = await _repository.UpdateAsync(user);
                return updatedData;

            }
            else
            {
                return null;
            }
        }

        public async Task<bool> DeleteUserAsync(int id)
        {
            await _repository.DeleteAsync(id);
            return true;
        }

        public Task<UserResponse> GetUserByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
