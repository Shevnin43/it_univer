using System;
using System.Collections.Generic;
using System.Text;
using It_Univer.Tasks.Repositories;
using NHibernate;
using It_Univer.Tasks.Core.Entities;
using System.Linq;

namespace It_University.Tasks.NHibernate.Repositories
{
    /// <summary>
    /// Репозиторий сущности <see cref="TaskBase"/>
    /// </summary>
    public class TaskRepository : NhRepositoryBase<TaskBase, long>, ITaskRepository
    {
        /// <summary>
        /// Инициализировать экземпляр <see cref="TaskRepository"/>
        /// </summary>
        /// <param name="session">Сессия NHibernate</param>
        public TaskRepository(ISession session)
            : base(session)
        {

        }
    }
}
