using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TasksManagerSys.Data;
using TasksManagerSys.Models;

namespace TasksManagerSys.Services
{
    public class AccountService: IAccountService
    {
        SignInManager<AppUser> signInManager;
        TaskManagerContext context;

        public AccountService(SignInManager<AppUser> _signInManager, TaskManagerContext _context)
        {
            signInManager = _signInManager;
            context = _context;
        }

        public bool Login(LoginModel loginModel)
        {
            StringBuilder Sb = new StringBuilder();

            AppUser user = context.appUser.Where(x => x.Email == loginModel.Email|| x.UserName==loginModel.Email).FirstOrDefault();
            string storedPass= user.PasswordHash;

            using (SHA256 hash = SHA256Managed.Create())
            {
                Encoding enc = Encoding.UTF8;
                Byte[] result = hash.ComputeHash(enc.GetBytes(loginModel.Password));

                foreach (Byte b in result)
                    Sb.Append(b.ToString("x2"));
            }
            string strPassword = Sb.ToString();
            if (storedPass == strPassword)
                return true;
            else
                return false;
        }
    }
}
