using System.Collections.Generic;
using TasksManagerSys.Data;

namespace TasksManagerSys.Services
{
    public interface IProjectService
    {
        List<Project> GetAllProjects();
    }
}