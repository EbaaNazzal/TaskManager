using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using TasksManagerSys.Data;
using TasksManagerSys.Dto;

namespace TasksManagerSys.Services
{
    public class TaskService : ITaskService
    {
        TaskManagerContext context;
        public TaskService(TaskManagerContext _context)
        {
            context = _context;
        }

        public List<Task> GetAllTasks() 
        {
            List<Task> liTask = context.task.ToList();
            return liTask;
        }

        public void MarkAsCompleted(int id) 
        {
                Task task = context.task.Find(id);
                task.Completed = "1"; 

                context.SaveChanges();
        }
        public List<Task> SearchByName(string name)
        {
            List<Task> liTask = context.task.Where(x => x.Task_desc == name).ToList();
            return liTask;
        }
    }
}
