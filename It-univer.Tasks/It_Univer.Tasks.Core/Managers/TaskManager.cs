using It_Univer.Tasks.Core.Entities;
using It_Univer.Tasks.Stores;
using System;
using System.Collections.Generic;
using System.Text;
using It_Univer.Tasks.Repositories;
using System.Linq;

namespace It_Univer.Tasks.Managers
{
    /// <inheritdoc/>
    public class TaskManager : ITaskManager
    {
        private readonly ITaskRepository taskRepo;

        public TaskManager(ITaskRepository taskRepo)
        {
            this.taskRepo = taskRepo;
        }

        /// <inheritdoc/>
        public TaskBase Create(TaskBase task)
        {
            task.CreationDate = DateTime.Now;
            task.Status = Enums.TaskStatus.ToDo;
            return taskRepo.Save(task);
        }
            /// <inheritdoc/>
            public TaskBase Create(string subject)
        {
            var task = new TaskBase { Subject = subject };
            return taskRepo.Save(task);
        }

        public List<TaskBase> GetAllTasks()
        {
            return taskRepo.GetAllTasks().ToList();
        }
        
        public bool Remove(long id)
        {
            return taskRepo.Remove(id);
        }

        public TaskBase FirstOrDefault(long id)
        {
            return taskRepo.FirstOrDefault(id);
        }
        public TaskBase Change(TaskBase task)
        {
            return taskRepo.Change(task);
        }
    }
}
