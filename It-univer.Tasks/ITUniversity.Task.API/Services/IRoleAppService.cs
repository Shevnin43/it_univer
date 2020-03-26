using ItUniversity.Application.Services;
using ITUniversity.Task.API.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITUniversity.Task.API.Services
{
    public interface IRoleAppService : IApplicationService
    {
        ICollection<RoleDto> GetAll();
    }
}
