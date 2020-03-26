using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using It_Univer.Tasks.Web.Models;
using It_Univer.Tasks.Web.Models.Account;
using ITUniversity.Task.API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace It_Univer.Tasks.Web.Controllers
{
    [Authorize/*(Roles ="admin")*/]
    public class UserController : Controller
    {

        private readonly IUserAppService userAppService;
        private readonly IMapper mapper;

        public UserController(IUserAppService userAppService, IMapper mapper)
        {
            this.userAppService = userAppService;
            this.mapper = mapper;
        }
        public IActionResult Index()
        {
            var dtos = userAppService.GetAll();
            return View(dtos);
        }

        public IActionResult Edit(int id)
        {
            var userDto = userAppService.Get(id);
            var model = mapper.Map<UserEditModel>(userDto);
            return View(model); 
        }
    }
}