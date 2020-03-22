using AutoMapper;
using It_Univer.Tasks.Core.Entities;
using It_Univer.Tasks.Managers;
using ItUniversity.Application.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ITUniversity.Task.API.Services.Imps
{
    public class TaskAppService : ApplicationService, ITaskAppService
    {
        private readonly ITaskManager taskManager;

        private readonly IMapper mapper;

        public TaskAppService(ITaskManager taskManager, IMapper mapper)
        {
            this.taskManager = taskManager;
            this.mapper = mapper;
        }
        
        [HttpPost]
        public ApiCreateModel ApiCreate(ApiCreateModel task)
        {
            var entity = mapper.Map<TaskBase>(task);
            var createdTask= taskManager.Create(entity);
            return mapper.Map<ApiCreateModel>(createdTask);
        }

        [HttpPost]
        public bool ApiRemove(long id)
        {
            return taskManager.Remove(id);
        }

        [HttpPost]
        public ApiCreateModel ApiUpdate(ApiCreateModel task)
        {
            var entity = mapper.Map<TaskBase>(task);
            var createdTask = taskManager.Change(entity);
            return mapper.Map<ApiCreateModel>(createdTask);
        }

        [HttpGet]
        public List<ApiCreateModel> ApiAllTasks()
        {
            var baseTasksList = taskManager.GetAllTasks();
            var apiTasksList = new List<ApiCreateModel>();
            foreach (var task in baseTasksList)
            {
                apiTasksList.Add(mapper.Map<ApiCreateModel>(task));
            }
            return apiTasksList;
        }

        [HttpGet]
        public ApiCreateModel ApiDetails(long id)
        {
            var savedTask = taskManager.GetTask(id);
            return mapper.Map<ApiCreateModel>(savedTask);
        }
    }
}
