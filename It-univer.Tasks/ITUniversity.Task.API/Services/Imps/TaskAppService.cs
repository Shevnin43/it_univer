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
            try
            {
                var entity = mapper.Map<TaskBase>(task);
                var createdTask = taskManager.Create(entity);
                return mapper.Map<ApiCreateModel>(createdTask);
            }
            catch (System.Exception)
            {
                return new ApiCreateModel();
            }
        }

        [HttpPost]
        public bool ApiRemove(long id)
        {
            try 
            {
                return taskManager.Remove(id);
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        [HttpPost]
        public ApiCreateModel ApiUpdate(ApiCreateModel task)
        {
            try
            {
                var entity = mapper.Map<TaskBase>(task);
                var changedTask = taskManager.Change(entity);
                return mapper.Map<ApiCreateModel>(changedTask);
            }
            catch (System.Exception)
            {
                return new ApiCreateModel();   
            }
            
        }

        [HttpGet]
        public List<ApiCreateModel> ApiAllTasks()
        {
            try
            {
                var baseTasksList = taskManager.GetAllTasks();
                var apiTasksList = new List<ApiCreateModel>();
                foreach (var task in baseTasksList)
                {
                    apiTasksList.Add(mapper.Map<ApiCreateModel>(task));
                }
                return apiTasksList;
            }
            catch (System.Exception)
            {
                return null;
            }
        }

        [HttpGet]
        public ApiCreateModel ApiDetails(long id)
        {
            try
            {
                var savedTask = taskManager.GetTask(id);
                return mapper.Map<ApiCreateModel>(savedTask);
            }
            catch
            {
                return new ApiCreateModel();
            }
        }
    }
}
