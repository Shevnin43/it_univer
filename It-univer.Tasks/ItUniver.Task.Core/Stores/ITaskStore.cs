using System;
using System.Collections.Generic;
using System.Text;
using ItUniver.Task.Entities;
using ItUniver.Task.Enums;

namespace ItUniver.Task.Stores
{
    public interface ITaskStore
    {
        TaskBase[] ConstTask { get; }

        /// <summary>
        /// Добавление задачи
        /// </summary>
        /// <param name="task"></param>
        /// <returns></returns>
        TaskBase Save(TaskBase task);
        
        /// <summary>
        /// Поиск задачи 
        /// </summary>
        /// <param name="task"></param>
        /// <returns></returns>
        TaskBase FirstOrDefault(long id);

        /// <summary>
        /// Обновление задачи 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TaskBase Change(TaskBase task);

        /// <summary>
        /// Удаление задачи
        /// </summary>
        /// <param name="task"></param>
        /// <returns></returns>
        bool Remove(long id);

        /// <summary>
        /// Получение полного списка задач
        /// </summary>
        /// <returns></returns>
        List<TaskBase> GetAllTasks();

        ICollection<TaskBase> GetAll();
    }
}
