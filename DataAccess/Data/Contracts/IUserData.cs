using DataAccess.Models;

namespace DataAccess.Data.Contracts;

public interface IUserData
{
    Task DeleteUserAsync(int id);
    Task<UserModel?> GetUserAsync(int id);
    Task<IEnumerable<UserModel>> GetUsersAsync();
    Task InsertUserAsync(UserModel user);
    Task UpdateUserAsync(UserModel user);
}