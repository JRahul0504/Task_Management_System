using Task_Management_System.Models;

namespace Task_Management_System.Repositories
{
    public interface ITaskRepository
    {
        Task<IEnumerable<TaskItem>> GetAll(int userId);
        Task<TaskItem> GetById(int id);
        Task Add(TaskItem task);
        Task Update(int id, TaskItem task);
    }
}
