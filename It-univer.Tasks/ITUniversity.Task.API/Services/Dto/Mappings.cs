using AutoMapper;
using It_Univer.Tasks.Core.Entities;
using It_Univer.Tasks.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITUniversity.Task.API.Services.Dto
{
    public class Mappings : Profile
    {
        public Mappings()
        {
            CreateMap<TaskBase, TaskDto>();
            CreateMap<TaskCreateDto, TaskBase>();
            CreateMap<TaskUpdateDto, TaskBase>();
            CreateMap<CreateUserDto, User>();
            CreateMap<User, UserDto>();

        }
    }
}
