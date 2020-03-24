using ItUniversity.Domain.Entities;
using ItUniversity.Domain.Repositories.Impls;
using NHibernate;
using System;
using System.Linq;


namespace It_University.Tasks.NHibernate.Repositories
{
    /// <summary>
    /// Базовый репозиторий NHibernate
    /// </summary>
    /// <typeparam name="TEntity">Тип сущности</typeparam>
    /// <typeparam name="TPrimaryKey">Тип первичного ключа</typeparam>
    public class NhRepositoryBase<TEntity, TPrimaryKey> : RepositoryBase<TEntity, TPrimaryKey>, IDisposable
        where TEntity : class, IEntity<TPrimaryKey>
    {
        public virtual ISession Session { get; }

        //private readonly ITransaction transaction;

        /// <summary>
        /// Инициализировать экземпляр <see cref="NhRepositoryBase{TEntity, TPrimaryKey}"/>
        /// </summary>
        /// <param name="session">Сессия NHibernate</param>
        public NhRepositoryBase(ISession session)
        {
            Session = session;
        }

        /// <inheritdoc/>
        public override IQueryable<TEntity> GetAllTasks()
        {
            return Session.Query<TEntity>();
        }

        /// <inheritdoc/>
        public override TEntity FirstOrDefault(TPrimaryKey id)
        {
            return Session.Get<TEntity>(id);
        }

        /// <inheritdoc/>
        public override TEntity Save(TEntity entity)
        {
            using (Session.BeginTransaction())
            {
                Session.Save(entity);
                Session.Transaction.Commit();
                Session.Close();
                //Session.Flush(); //Не правильно, только для тестов работы приложения
            }
            return entity;
        }

        /// <inheritdoc/>
        public override TEntity Change(TEntity entity)
        {
            Session.Update(entity);
            Session.Flush(); //Не правильно, только для тестов работы приложения
            return entity;
        }

        /// <inheritdoc/>
        public override bool Remove(TPrimaryKey id)
        {
            var entity = Session.Load<TEntity>(id);
            Session.Delete(entity);
            Session.Flush(); //Не правильно, только для тестов работы приложения
            return true;
        }

        public void Dispose()
        {
            //transaction.Commit();
        }
    }
}
