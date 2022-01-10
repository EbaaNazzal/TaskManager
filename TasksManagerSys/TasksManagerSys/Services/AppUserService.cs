using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TasksManagerSys.Data;

namespace TasksManagerSys.Services
{
    public class AppUserService: IAppUserService
    {
        TaskManagerContext context;

        public AppUserService(TaskManagerContext _context)
        {
            context = _context;
        }
        public List<AppUser> GetAllUsers()
        {
            List<AppUser> liAppUser = context.appUser.ToList();
            return liAppUser;
        }
    }
}
