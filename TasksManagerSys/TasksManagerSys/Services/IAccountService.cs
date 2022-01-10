using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using TasksManagerSys.Models;

namespace TasksManagerSys.Services
{
    public interface IAccountService
    {
        //Task<SignInResult> Login(LoginModel loginModel);
        bool Login(LoginModel loginModel);
    }
}