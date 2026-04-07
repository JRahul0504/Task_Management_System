using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Task_Management_System.DTOs;
using Task_Management_System.Models;
using Task_Management_System.Repositories;

namespace Task_Management_System.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class TaskController : ControllerBase
    {
        private readonly ITaskRepository _repo;

        public TaskController(ITaskRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var userId = int.Parse(User.FindFirst("UserId").Value);
            var tasks = await _repo.GetAll(userId);
            return Ok(tasks);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var task = await _repo.GetById(id);
            if(task == null)
            {
                return NotFound();
            }
            return Ok(task);
        }

        [HttpPost]
        public async Task<IActionResult> Create(TaskDto dto)
        {
            var userId = int.Parse(User.FindFirst("UserId").Value);

            var task = new TaskItem
            {
                Title = dto.Title,
                IsCompleted = dto.IsCompleted,
                UserId = userId
            };

            await _repo.Add(task);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, TaskDto dto)
        {
            var userId = int.Parse(User.FindFirst("UserId").Value);
            var updatedTask = new TaskItem
            {
                Title = dto.Title,
                IsCompleted = dto.IsCompleted,
                UserId = userId
            };
            await _repo.Update(id, updatedTask);
            return Ok();
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id)
        {
            return Ok("Only Admin Can Delete the Task");
        }
    }
}
