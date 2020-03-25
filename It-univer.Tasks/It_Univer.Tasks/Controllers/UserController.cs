using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITUniversity.Task.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace It_Univer.Tasks.Web.Controllers
{
    public class UserController : Controller
    {

        private readonly IUserAppService userAppService;

        public UserController(IUserAppService userAppService)
        {
            this.userAppService = userAppService;
        }
        public IActionResult Index()
        {
            var dtos = userAppService.GetAll();
            return View(dtos);
        }
    }
}