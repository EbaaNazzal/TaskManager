using System;
using System.Collections.Generic;
using System.Linq;
using TasksManagerSys.Data;

namespace TasksManagerSys.Models
{
    public class TaskVM
    {
        public List<Task> liTask { get; set; }
        public List<Project> liProject { get; set; }
        public List<AppUser> liAppUser { get; set; }
    }
}
