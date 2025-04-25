using EventBookingManagementSystem_Backend.DB.Entities;
using EventBookingManagementSystem_Backend.DTOs.RequestModels;
using EventBookingManagementSystem_Backend.DTOs.ResponseModels;

namespace EventBookingManagementSystem_Backend.Services.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<UserResponse>> GetAllUsersAsync();
        Task<UserResponse> GetUserByIdAsync(Guid id);
        Task<UserResponse> CreateUserAsync(UserRequest dto);
        Task<bool> DeleteUserAsync(Guid id);

        Task<User?> UpdateUserAsync(Guid id, UserRequest dto);
    }
}
