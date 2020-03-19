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
        
        [HttpGet]
        public IActionResult Details(long id)
        {
             return View(taskManager.GetTask(id));
        }

        public IActionResult Update(long id)
        {
            var task = mapper.Map<TaskCreateModel>(taskManager.GetTask(id));
            return View(task);
        }

        [HttpPost]
        public IActionResult Update(TaskCreateModel task)
        {
            var saved = taskManager.GetTask(task.Id);
            saved = mapper.Map<TaskBase>(task);
            taskManager.Change(saved);
            return RedirectToAction("Index");
        }

    }
}