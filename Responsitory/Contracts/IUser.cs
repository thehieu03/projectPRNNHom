using BussinessObject.Models;

namespace Responsitory.dal
{
    public interface IUser
    {
        Task<User> GetUserAsync(string username, string password);
        Task InsertUserAsync(User user);
        Task<bool> CheckUserNameExistsAsync(string username);
        Task<bool> CheckEmailExistsAsync(string email);
        Task UpdatePasswordAsync(string email, string password);
        Task<List<User>> GetAllUsersAsync();
        Task DeleteUserAsync(int userID);
        Task<User> getUserByUserID(int userID);
    }
}
