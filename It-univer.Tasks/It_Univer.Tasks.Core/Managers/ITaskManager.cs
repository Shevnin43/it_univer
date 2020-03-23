using It_Univer.Tasks.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace It_Univer.Tasks.Managers
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

        List<TaskBase> GetAllTasks();
        bool Remove(long id);

        TaskBase GetTask(long id);

        TaskBase Change(TaskBase task);
    }
}
