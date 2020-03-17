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
        TaskBase FirstOrDefault(TaskBase task);

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
        bool Remove(TaskBase task);

        /// <summary>
        /// Получение полного списка задач
        /// </summary>
        /// <returns></returns>
        List<TaskBase> GetAllTasks();
    }
}
