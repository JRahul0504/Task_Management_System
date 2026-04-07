using Task_Management_System.Models;

namespace Task_Management_System.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetUser(string username);
        Task AddUser(User user);
    }
}
