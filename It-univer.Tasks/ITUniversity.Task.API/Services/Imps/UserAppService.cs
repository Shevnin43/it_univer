using AutoMapper;
using It_Univer.Tasks.Entities;
using It_Univer.Tasks.Repositories;
using ITUniversity.Task.API.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITUniversity.Task.API.Services.Imps
{
    public class UserAppService : IUserAppService
    {
        private readonly IUserRepository userRepository;

        private readonly IMapper mapper;

        /// <summary>
        /// Инициализировать экземпляр <see cref="UserAppService"/>
        /// </summary>
        /// <param name="userRepository">Репозиторий пользователей</param>
        /// <param name="mapper">Маппер</param>
        public UserAppService(IUserRepository userRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }

        public bool Block(int id)
        {
            var entity = userRepository.FirstOrDefault(id);
            entity.IsBlocked = true;
            userRepository.Change(entity);
            return true;
        }

        /// <inheritdoc/>
        public UserDto Create(CreateUserDto dto)
        {
            var entity = mapper.Map<User>(dto);
            userRepository.Save(entity);
            return mapper.Map<UserDto>(entity);
        }

        /// <inheritdoc/>
        public UserDto Get(string login)
        {
            var entity = userRepository.FirstOrDefault(e => e.Login == login);
            return mapper.Map<UserDto>(entity);
        }

        /// <inheritdoc/>
        public UserDto Get(string login, string password)
        {
            var entity = userRepository.FirstOrDefault(e => e.Login == login && e.Password == password && !e.IsBlocked);
            return mapper.Map<UserDto>(entity);
        }

        public ICollection<UserDto> GetAll()
        {
           var entities =  userRepository.GetAllTasks().Where(x=>!x.IsBlocked).ToList() ;
            return mapper.Map<ICollection<UserDto>>(entities);
        }

        /// <inheritdoc/>
        public bool IsValidPassword(UserDto dto, string password)
        {
            var entity = userRepository.FirstOrDefault(dto.Id);
            return entity.Password == password;
        }
    }
}
