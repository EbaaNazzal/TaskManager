using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TasksManagerSys.Models;
using TasksManagerSys.Services;

namespace TasksManagerSys.Controllers
{
    public class AccountController : Controller
    {
        IAccountService accountService;
        public AccountController(IAccountService _accountService)
        {
            accountService = _accountService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(LoginModel loginModel)
        {
            var result = accountService.Login(loginModel);
            if (result)
                return RedirectToAction("Index", "Task");
            else
                ViewData["ErrorMg"] = "Invalid username or password";
            return View("Index");
        }
    }
}
