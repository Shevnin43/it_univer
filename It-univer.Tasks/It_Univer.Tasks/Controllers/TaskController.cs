using System;
using System.Collections.Generic;
using System.Linq;
using It_Univer.Tasks.Controllers;
using It_Univer.Tasks.Core.Entities;
using It_Univer.Tasks.Enums;
using It_Univer.Tasks.Managers;
using It_Univer.Tasks.Stores;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace It_Univer.Tasks.Web.Controllers
{
    public class TaskController : Controller
    {
        private readonly ITaskManager taskManager;

        public TaskController(ITaskManager taskManager)
        {
            this.taskManager = taskManager;
        }

        public IActionResult Index()
        {
            var tasks = taskManager.GetAllTasks();
            return View(tasks);
        }
        public IActionResult Create()
        {
            return View(new TaskBase());
        }

        [HttpPost]
        public IActionResult Create(TaskBase task)
        {
            task.CreationDate = DateTime.Now;
            task.Status = TaskStatus.ToDo;
            this.taskManager.Create(task);
            return RedirectToAction("Index", "Task");
        }
        
        public IActionResult Remove(long id)
        {
            this.taskManager.Remove(id);
            return RedirectToAction("Index","Task");
        }

    }
}