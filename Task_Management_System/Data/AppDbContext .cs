using Microsoft.EntityFrameworkCore;

namespace Task_Management_System.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Models.User> Users { get; set; }
        public DbSet<Models.TaskItem> Tasks { get; set; }
    }
}
