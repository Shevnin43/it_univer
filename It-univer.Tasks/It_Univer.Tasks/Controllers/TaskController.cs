using System;
using AutoMapper;
using It_Univer.Tasks.Core.Entities;
using It_Univer.Tasks.Enums;
using It_Univer.Tasks.Managers;
using It_Univer.Tasks.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace It_Univer.Tasks.Web.Controllers
{
    public class TaskController : Controller
    {
        private readonly ITaskManager taskManager;

        private readonly IMapper mapper;

        public TaskController(ITaskManager taskManager, IMapper mapper)
        {
            this.taskManager = taskManager;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            var tasks = taskManager.GetAllTasks();
            return View(tasks);
        }
        public IActionResult Create()
        {
            return View(TaskCreateModel.New);
        }

        [HttpPost]
        public IActionResult Create(TaskBase task)
        {
            if (!ModelState.IsValid)
            {
                return View(task);
            }
            var entity = mapper.Map<TaskBase>(task); 
            taskManager.Create(entity);
            return RedirectToAction("Index");
        }
        
        [HttpPost]
        public IActionResult Remove(long id)
        {
            this.taskManager.Remove(id);
            return Json(new { success = true });
        }
        
        public IActionResult Details(long id)
        {
             return View(taskManager.GetTask(id));
        }

        public IActionResult Update(long id)
        {
            var task = mapper.Map<TaskEditModel>(taskManager.GetTask(id));
            return View(task);
        }

        [HttpPost]
        public IActionResult Update(TaskEditModel task)
        {
            var newTask = mapper.Map<TaskBase>(task);
            taskManager.Change(newTask);
            return RedirectToAction("Index");
        }

    }
}