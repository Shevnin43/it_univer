using ItUniversity.Domain.Entities;
using ItUniversity.Domain.Repositories;
using ItUniversity.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace ItUniversity.Domain.Repositories
{
    /// <summary>
    /// Репозиторий
    /// </summary>
    /// <typeparam name="TEntity">Тип сущность</typeparam>
    /// <typeparam name="TPrimaryKey">Тип первичного ключа</typeparam>
    public interface IRepository<TEntity, TPrimaryKey> : ItUniversity.Repositories.IRepository<TEntity>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        /// <summary>
        /// Сохранить
        /// </summary>
        /// <param name="entity">Сохраняемая сущность</param>
        TEntity Save(TEntity entity);

        /// <summary>
        /// Обновить существующую сущность
        /// </summary>
        /// <param name="entity">Обновляемая сущность</param>
        TEntity Change(TEntity entity);

        /// <summary>
        /// Удалить сущность
        /// </summary>
        /// <param name="id">Идентификатор удаляемой сущность</param>
        bool Remove(TPrimaryKey id);

        /// <summary>
        /// Получить все сущности
        /// </summary>
        IQueryable<TEntity> GetAllTasks();

        /// <summary>
        /// Получить все сущности
        /// </summary>
        IList<TEntity> GetAllList();

        /// <summary>
        /// Получить сущность
        /// </summary>
        /// <param name="id">Идентификатор</param>
        TEntity FirstOrDefault(TPrimaryKey id);

        /*/// <summary>
        /// Получить сущность или null
        /// </summary>
        /// <param name="id">Идентификатор</param>
        TEntity FirstOrDefault(TPrimaryKey id);*/

        /// <summary>
        /// Получить сущность или null
        /// </summary>
        /// <param name="predicate">Условие</param>
        TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate);
    }
}
