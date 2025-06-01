using System.Collections.Generic;
using System.Linq;
using NTierTodoApp.Models;

namespace NTierTodoApp.DataAccess
{
    public class TaskRepository
    {
        private readonly List<TaskItem> tasks = new()
        {
            new TaskItem { Id = 1, Title = "أولى مهمة", IsComplete = false },
            new TaskItem { Id = 2, Title = "ثانية مهمة", IsComplete = false }
        };

        public List<TaskItem> GetAll() => tasks;
        
        public void Add(TaskItem task) => tasks.Add(task);
        
        public TaskItem? GetById(int id) => tasks.FirstOrDefault(t => t.Id == id);
        
        public void Delete(int id)
        {
            var task = GetById(id);
            if (task != null)
            {
                tasks.Remove(task);
            }
        }
    }
}