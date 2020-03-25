using It_Univer.Tasks.Entities;
using It_Univer.Tasks.Repositories;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Text;

namespace It_University.Tasks.NHibernate.Repositories
{
    public class UserRepository : NhRepositoryBase<User, int>, IUserRepository
    {
        /// <summary>
        /// Инициализировать экземпляр <see cref="UserRepository"/>
        /// </summary>
        /// <param name="session">Сессия NHibernate</param>
        public UserRepository(ISession session)
            : base(session)
        {

        }
    }
}
