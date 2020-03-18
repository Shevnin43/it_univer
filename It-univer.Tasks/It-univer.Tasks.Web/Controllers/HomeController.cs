using ItUniver.Task.Entities;
using ItUniver.Task.Enums;
using ItUniver.Task.Stores;
using It_univer.Tasks.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace It_univer.Tasks.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;

        private readonly ITaskStore taskStore;

        /// <summary>
        /// Конструктор контроллера
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="taskStore"></param>
        public HomeController(ILogger<HomeController> logger, ITaskStore taskStore)
        {
            this.logger = logger;
            this.taskStore = taskStore;
        }

        /// <summary>
        /// Добавление таска
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            var result = taskStore.Save(new TaskBase {Id=10, Subject = "Hello", Description = "Hi", CreationDate=DateTime.Now, Status=TaskStatus.Done });
            ViewData["Message"] = $"Добавлена новая задача: {result.ToString()}";
            ViewData["List"] = "Список задач: ";
            foreach (var task in taskStore.GetAllTasks())
            {
                ViewData["List"] += $"{task.ToString()}\n";
            }
            return View();
        }

        /// <summary>
        /// Поиск таска
        /// </summary>
        /// <returns></returns>
        public IActionResult About()
        {
            var result = taskStore.FirstOrDefault(taskStore.ConstTask[0].Id);
            ViewData["Message"] = $"Найденная задача: {result.ToString()}";
            ViewData["List"] = "Список задач: ";
            foreach (var task in taskStore.GetAllTasks())
            {
                ViewData["List"] += $"{task.ToString()}\n";
            }
            return View();
        }

        /// <summary>
        /// Изменение таска
        /// </summary>
        /// <returns></returns>
        public IActionResult Contact()
        {
            var changedTask = taskStore.ConstTask[1];
            changedTask.Description = "Данная задача изменена по требованию Заказчика";
            changedTask.Status = TaskStatus.Done;
            var result = taskStore.Change(changedTask);
            ViewData["Message"] = $"Измененная задача: {result.ToString()}";
            ViewData["List"] = "Список задач: ";
            foreach (var task in taskStore.GetAllTasks())
            {
                ViewData["List"] += $"{task.ToString()}\n";
            }
            return View();
        }

        /// <summary>
        /// Удаление таска
        /// </summary>
        /// <returns></returns>
        public IActionResult Privacy()
        {
            ViewData["Message"] = taskStore.Remove(taskStore.ConstTask[2].Id) 
            ? $"Задача [{taskStore.ConstTask[2].ToString()}] удалена" 
            : $"Что-то пошло не так... (";
            ViewData["List"] = "Список задач: ";
            foreach (var task in taskStore.GetAllTasks())
            {
                ViewData["List"] += $"{task.ToString()}\n";
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
