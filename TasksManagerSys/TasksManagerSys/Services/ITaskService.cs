

using System.Collections.Generic;
using TasksManagerSys.Data;

namespace TasksManagerSys.Services
{
    public interface ITaskService
    {
        List<Task> GetAllTasks();
        void MarkAsCompleted(int id);
        List<Task> SearchByName(string name);
    }
}