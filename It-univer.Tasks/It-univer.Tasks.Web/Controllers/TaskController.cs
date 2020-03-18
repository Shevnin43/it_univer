using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItUniver.Task.Entities;
using ItUniver.Task.Manager;
using Microsoft.AspNetCore.Mvc;

namespace It_univer.Tasks.Web.Controllers
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
            var tasks = taskManager.GetAll();
            return View(tasks);
        }
        public IActionResult Create()
        {
            return View(new TaskBase());
        }

    }
}