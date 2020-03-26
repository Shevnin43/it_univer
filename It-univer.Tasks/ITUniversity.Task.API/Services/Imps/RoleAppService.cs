using AutoMapper;
using It_Univer.Tasks.Repositories;
using ItUniversity.Application.Services;
using ITUniversity.Task.API.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITUniversity.Task.API.Services.Imps
{
    public class RoleAppService : ApplicationService, IRoleAppService
    {

        private readonly IRoleRepository roleRepository;

        private readonly IMapper mapper;
        public RoleAppService(IRoleRepository roleRepository, IMapper mapper)
        {
            this.mapper = mapper;
            this.roleRepository = roleRepository;
        }

        public ICollection<RoleDto> GetAll()
        {
            var entities = roleRepository.GetAllList();
            return mapper.Map<ICollection<RoleDto>>(entities);
        }
    }
}
