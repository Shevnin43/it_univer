using It_Univer.Tasks.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace It_Univer.Tasks.Stores
{
    public interface ITaskStore
    {
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
    }
}
