using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using ItUniversity.Application.Services;
using ITUniversity.Task.API.Services.Dto;

namespace ITUniversity.Task.API.Services
{
    public interface ITaskAppService : IApplicationService
    {
        TaskDto Create(TaskCreateDto task);

        TaskDto Change(TaskUpdateDto task);

        bool Remove(long id);

        TaskDto FirstOrDefault(long id);
    }
}
