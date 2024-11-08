using BussinessObject.Models;
using DataAccessLayer;
using Responsitory.dal;

namespace Responsitory.Implementations
{
    public class UserResponsitory : IUser
    {
        public async Task<bool> CheckEmailExistsAsync(string email)
        {
            return await UserDAO.Instance.CheckEmailExistsAsync(email);
        }

        public async Task<bool> CheckUserNameExistsAsync(string username)
        {
            return await UserDAO.Instance.CheckUserNameExistsAsync(username);
        }

        public async Task DeleteUserAsync(int userID) => await UserDAO.Instance.DeleteUserByUserID(userID);

        public async Task<List<User>> GetAllUsersAsync()
        {
            return await UserDAO.Instance.GetUsersAsync();
        }

        public async Task<User> GetUserAsync(string username, string password)
        {
            return await UserDAO.Instance.GetUserAsync(username, password);
        }

        public Task<User> getUserByUserID(int userID)
        {
            return UserDAO.Instance.getUserByUserID(userID);
        }

        public async Task InsertUserAsync(User user)
        {
            await UserDAO.Instance.InsertUserAsync(user);
        }

        public async Task UpdatePasswordAsync(string email, string password)
        {
            await UserDAO.Instance.UpdatePasswordAsync(email, password);
        }
    }
}
