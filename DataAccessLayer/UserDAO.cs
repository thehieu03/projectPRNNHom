using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer
{
    public class UserDAO : SingletonBase<UserDAO>
    {
        public async Task DeleteUserByUserID(int userID)
        {
            var context = UserDAO.GetContext();
            var user = await context.Users.FirstOrDefaultAsync(c => c.Id == userID);
            if (user != null)
            {
                context.Users.Remove(user);
                await context.SaveChangesAsync();
            }
        }
        public async Task<List<User>> GetUsersAsync()
        {
            var context = UserDAO.GetContext();
            return await context.Users.ToListAsync();
        }
        public async Task<User> GetUserAsync(string username, string password)
        {
            var context = UserDAO.GetContext();
            return await context.Users.FirstOrDefaultAsync(c => c.UserName.Equals(username) && c.PassWord.Equals(password));
        }
        public async Task InsertUserAsync(User user)
        {
            var context = UserDAO.GetContext();
            await context.Users.AddAsync(user);
            await context.SaveChangesAsync();
        }
        public async Task<bool> CheckUserNameExistsAsync(string username)
        {
            var context = UserDAO.GetContext();
            return await context.Users.AnyAsync(c => c.UserName.Equals(username));
        }
        public async Task<bool> CheckEmailExistsAsync(string email)
        {
            var context = UserDAO.GetContext();
            return await context.Users.AnyAsync(c => c.Email.Equals(email));
        }
        public async Task UpdatePasswordAsync(string email, string password)
        {
            var context = UserDAO.GetContext();
            User user = await context.Users.FirstOrDefaultAsync(c => c.Email.Equals(email));
            if (user != null)
            {
                user.PassWord = password;
                await context.SaveChangesAsync();
            }
        }
        public async Task<User> getUserByUserID(int user_id)
        {
            var context = UserDAO.GetContext();
            return await context.Users.FirstOrDefaultAsync(c => c.Id == user_id);
        }
    }
}
