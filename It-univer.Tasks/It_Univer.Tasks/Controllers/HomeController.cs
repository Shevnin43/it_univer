using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using It_Univer.Tasks.Models;
using It_Univer.Tasks.Stores;
using It_Univer.Tasks.Core.Entities;
using It_Univer.Tasks.Enums;

namespace It_Univer.Tasks.Controllers
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
            
            return View();
        }

        /// <summary>
        /// Удаление таска
        /// </summary>
        /// <returns></returns>
        public IActionResult Privacy()
        {
            
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
