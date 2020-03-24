using AutoMapper;
using It_Univer.Tasks.Core.Entities;
using It_Univer.Tasks.Managers;
using ItUniversity.Application.Services;
using ITUniversity.Task.API.Services.Dto;
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

        public TaskDto FirstOrDefault(long id)
        {
            var entity = taskManager.FirstOrDefault(id);
            var dto = mapper.Map<TaskDto>(entity);
            return dto;
        }

        public TaskDto Create(TaskCreateDto task)
        {
            var entity = mapper.Map<TaskBase>(task);
            taskManager.Create(entity);
            return mapper.Map<TaskDto>(entity);
        }

        public TaskDto Change(TaskUpdateDto task)
        {
            var entity = mapper.Map<TaskBase>(task);
            taskManager.Change(entity);
            return mapper.Map<TaskDto>(entity);
        }

        public bool Remove(long id)
        {
            return taskManager.Remove(id);
        }
    }
}
