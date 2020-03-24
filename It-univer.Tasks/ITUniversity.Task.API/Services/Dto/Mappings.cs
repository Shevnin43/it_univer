using AutoMapper;
using It_Univer.Tasks.Core.Entities;
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

        }
    }
}
