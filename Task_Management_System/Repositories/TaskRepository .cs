using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Task_Management_System.Data;
using Task_Management_System.Models;

namespace Task_Management_System.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly AppDbContext _context;

        public TaskRepository(AppDbContext context)
        {
            this._context = context;
        }


        public async Task<IEnumerable<TaskItem>> GetAll(int userId)
        => await _context.Tasks.Where(t => t.UserId == userId).ToListAsync();



        public async Task<TaskItem> GetById(int id)
        {
            return await _context.Tasks.FindAsync(id);
        }



        public async Task Add(TaskItem task)
        {
            await _context.Tasks.AddAsync(task);
            await _context.SaveChangesAsync();
        }



        public async Task Update(int id,TaskItem updatedtask)
        {
            var existingTask = await _context.Tasks.FindAsync(id);
            if(existingTask == null)
            {
                throw new Exception("Task not Found....");
            }
            else
            {
                existingTask.Title = updatedtask.Title;
                existingTask.IsCompleted = updatedtask.IsCompleted;
                await _context.SaveChangesAsync();
            }
        }
    }
}
