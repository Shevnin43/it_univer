using System;
using System.Collections.Generic;
using System.Text;
using It_Univer.Tasks.Repositories;
using NHibernate;
using It_Univer.Tasks.Core.Entities;
using System.Linq;

namespace It_University.Tasks.NHibernate.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly ISession session;

        public TaskRepository(ISession session)
        {
            this.session = session;
        }

        public bool Remove(long id)
        {
            var entity = GetAll().FirstOrDefault(e => e.Id == id);
            session.Delete(entity);
            session.Flush();
            return true;
        }

        public TaskBase FirstOrDefault(long id)
        {
            return GetAll().FirstOrDefault(e => e.Id == id);
        }

        public List<TaskBase> GetAll()
        {
            return session.Query<TaskBase>().ToList();
        }

        public List<TaskBase> GetAllTasks()
        {
            return GetAll();
        }

        public TaskBase Save(TaskBase entity)
        {
            session.Save(entity);
            session.Flush();

            return entity;
        }

        public TaskBase Change(TaskBase entity)
        {
            session.Update(entity);
            session.Flush();

            return entity;
        }
    }
}
