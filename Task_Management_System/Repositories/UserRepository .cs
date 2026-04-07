using Microsoft.EntityFrameworkCore;
using Task_Management_System.Data;
using Task_Management_System.Models;

namespace Task_Management_System.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context )
        {
            this._context = context;
        }
        public async Task<User> GetUser(string username)
       => await _context.Users.FirstOrDefaultAsync(x => x.Username == username);

        public async Task AddUser(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }
    }
}
