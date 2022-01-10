using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TasksManagerSys.Data;

namespace TasksManagerSys.Services
{
    public class ProjectService: IProjectService
    {
        TaskManagerContext context;
        public ProjectService(TaskManagerContext _context)
        {
            context = _context;
        }
        public List<Project> GetAllProjects() 
        {
            List<Project> liProject = context.project.ToList();
            return liProject;
        }
    }
}
