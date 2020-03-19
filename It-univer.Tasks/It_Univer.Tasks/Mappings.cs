using AutoMapper;
using It_Univer.Tasks.Core.Entities;
using It_Univer.Tasks.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace It_Univer.Tasks.Web
{
    public class Mappings : Profile
    {
        public Mappings()
        {
            CreateMap<TaskCreateModel, TaskBase>();
            CreateMap<TaskBase, TaskCreateModel>();
        }
    }
}
