using System.Collections.Generic;
using ItUniver.Task.Entities;

namespace ItUniver.Task.Manager
{
    /// <summary>
    /// Менеджер сущности
    /// </summary>
    public interface ITaskManager
    {
        /// <summary>
        /// Создание задачи
        /// </summary>
        /// <param name="task"></param>
        /// <returns></returns>
        TaskBase Create(TaskBase task);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="subject"></param>
        /// <returns></returns>
        TaskBase Create(string subject);

        ICollection<TaskBase> GetAll();
    }
}
