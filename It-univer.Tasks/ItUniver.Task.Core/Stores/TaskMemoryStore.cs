using System;
using System.Collections.Generic;
using System.Linq;
using ItUniver.Task.Entities;
using ItUniver.Task.Enums;


namespace ItUniver.Task.Stores
{
    public class TaskMemoryStore : ITaskStore
    {
        private List<TaskBase> tasks;
        //private long counterTasks;

        /// <summary>
        /// Начальный сисок задач
        /// </summary>
        public TaskBase[] ConstTask { get; } = new TaskBase[]
        { new TaskBase() {Id=0, Subject="Создать задачу", Description="Ну что ж, нужно создать новенькую задачку...", CreationDate = DateTime.Now, Status=TaskStatus.ToDo } ,
          new TaskBase() {Id=1, Subject="Найти задачу", Description="А найдите ка мне вот эту вот самую задачку...", CreationDate = DateTime.Now, Status=TaskStatus.ToDo } ,
          new TaskBase() {Id=2, Subject="Обновить задачу", Description="Давайте ка что-нибудь поменяем...", CreationDate = DateTime.Now, Status=TaskStatus.ToDo } ,
          new TaskBase() {Id=3, Subject="Удалить задачу", Description="Мне эта задача не нравится, удалите её...", CreationDate = DateTime.Now, Status=TaskStatus.ToDo } ,
        };

        /// <summary>
        /// Конструктор класса
        /// </summary>
        public TaskMemoryStore()
        {
            this.tasks = new List<TaskBase>();
            this.tasks.AddRange(ConstTask);
        }

        /// <summary>
        /// Сохранение задачи
        /// </summary>
        /// <param name="task"></param>
        /// <returns></returns>
        public TaskBase Save(TaskBase task)
        {
            var saved = tasks.FirstOrDefault(item => item == task);
            if (saved != null)
            {
                return saved;
            }
                //task.Id = counterTasks++;
                tasks.Add(task);
                return task;
        }

        /// <summary>
        /// Поиск задачи
        /// </summary>
        /// <param name="task"></param>
        /// <returns></returns>
        public TaskBase FirstOrDefault(TaskBase task)
        {
            return tasks?.FirstOrDefault(item => item.Id == task.Id && item.Subject == task.Subject && item.Description == task.Description && item.Status == item.Status && item.CreationDate==task.CreationDate);
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
        public bool Remove(TaskBase task)
        {
            var saved = tasks.FirstOrDefault(item => item.Id == task.Id && item.Subject == task.Subject && item.Description == task.Description && item.Status == item.Status && item.CreationDate == task.CreationDate);
            return (saved == null)?false:tasks.Remove(saved);
        }

        /// <summary>
        /// Получение полного списка задач
        /// </summary>
        /// <returns></returns>
        public List<TaskBase> GetAllTasks() => tasks;
    }
}
