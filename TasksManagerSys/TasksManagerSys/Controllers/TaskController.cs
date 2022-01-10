using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TasksManagerSys.Models;
using TasksManagerSys.Services;

namespace TasksManagerSys.Controllers
{
    public class TaskController : Controller
    {
        ITaskService taskService;
        IProjectService projectService;
        IAppUserService appUserService;
        TaskVM vm;

        public TaskController(ITaskService _taskService, IProjectService _projectService, IAppUserService _appUserService)
        {
            taskService = _taskService;
            projectService = _projectService;
            appUserService = _appUserService;
            vm = new TaskVM();
        }

        public IActionResult Index(int pg=1)
        {
            const int pageSize = 10;
            if (pg < 1)
                pg = 1;
            List<Data.Task> liTask = taskService.GetAllTasks();
            vm.liProject = projectService.GetAllProjects();
            vm.liAppUser = appUserService.GetAllUsers();
            int resCount = liTask.Count();
            var pager = new Pager(resCount, pg, pageSize);
            int reSkip = (pg - 1) * pageSize;
            vm.liTask = liTask.Skip(reSkip).Take(pager.PageSize).ToList();
            this.ViewBag.Pager = pager;
            return View(vm);
        }

        
        public IActionResult SaveAsCompleted(int id)
        {
            taskService.MarkAsCompleted(id);
            return Content("success");
        }

        public IActionResult Search()
        {
            string task = Request.Form["txtTask"];
            vm.liTask = taskService.SearchByName(task);
            vm.liProject = projectService.GetAllProjects();
            vm.liAppUser = appUserService.GetAllUsers();
            return View("Index",vm);
        }
    }
}
