using It_Univer.Tasks.Core.Entities;
using It_Univer.Tasks.Stores;
using System;
using System.Collections.Generic;
using System.Text;

namespace It_Univer.Tasks.Managers
{
    /// <inheritdoc/>
    public class TaskManager : ITaskManager
    {
        private readonly ITaskStore taskStore;

        public TaskManager(ITaskStore taskStore)
        {
            this.taskStore = taskStore;
        }

        /// <inheritdoc/>
        public TaskBase Create(TaskBase task)
        {
            return taskStore.Save(task);
        }
            /// <inheritdoc/>
            public TaskBase Create(string subject)
        {
            return new TaskBase();
        }

        public List<TaskBase> GetAllTasks()
        {
            return taskStore.GetAllTasks();
        }
        
        public bool Remove(long id)
        {
            return taskStore.Remove(id);
        }

        public TaskBase GetTask(long id)
        {
            return taskStore.FirstOrDefault(id);
        }
        public TaskBase Change(TaskBase task)
        {
            return taskStore.Change(task);
        }
    }
}
