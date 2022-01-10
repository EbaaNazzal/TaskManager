using System.Collections.Generic;
using TasksManagerSys.Data;

namespace TasksManagerSys.Services
{
    public interface IAppUserService
    {
        List<AppUser> GetAllUsers();
    }
}