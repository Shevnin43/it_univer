using It_Univer.Tasks.Core.Entities;
using It_Univer.Tasks.Enums;
using It_Univer.Tasks.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace It_Univer.Tasks.Stores
{
    public class TaskMemoryStore : ITaskStore
    {
        private List<TaskBase> tasks;
        private long counterTasks;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        public TaskMemoryStore()
        {
            this.counterTasks = 1;
            this.tasks = new List<TaskBase>();
        }

        /// <summary>
        /// Сохранение задачи
        /// </summary>
        /// <param name="task"></param>
        /// <returns></returns>
        public TaskBase Save(TaskBase task)
        {
            var saved = tasks.FirstOrDefault(item => item.TasksEquals(task));
            if (saved != null)
            {
                task.Id = saved.Id;
                return saved.Copy();
            }
            task.Id = counterTasks++;
            tasks.Add(task.Copy());
            return task;
        }

        /// <summary>
        /// Поиск задачи
        /// </summary>
        /// <param name="task"></param>
        /// <returns></returns>
        public TaskBase FirstOrDefault(long id)
        {
            return (tasks?.FirstOrDefault(item => item.Id == id))?.Copy();
        }

        /// <summary>
        /// Обновление(изменение) задачи
        /// </summary>
        /// <param name="task"></param>
        /// <returns></returns>
        public TaskBase Change(TaskBase task)
        {
            var saved = tasks?.FirstOrDefault(item => item.Id == task.Id);
            if (saved != null)
            {
                saved.Subject = task.Subject;
                saved.Description = task.Description;
                saved.CreationDate = task.CreationDate;
                saved.Status = task.Status;
                return tasks?.FirstOrDefault(item => item.Id == saved.Id);
            }
            return new TaskBase();
        }

        /// <summary>
        /// Удаление задачи
        /// </summary>
        /// <param name="task"></param>
        /// <returns></returns>
        public bool Remove(long id)
        {
            return tasks.Remove(tasks.FirstOrDefault(item => item.Id == id));
        }

        /// <summary>
        /// Получение полного списка задач
        /// </summary>
        /// <returns></returns>
        public List<TaskBase> GetAllTasks() => tasks.Select(x => x.Copy()).ToList();

    }
}
