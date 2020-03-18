using System.Collections.Generic;
using ItUniver.Task.Entities;
using ItUniver.Task.Stores;

namespace ItUniver.Task.Manager
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
            return task;
        }
        /// <inheritdoc/>
        public TaskBase Create(string subject)
        {
            return new TaskBase();
        }

        public ICollection<TaskBase> GetAll()
        {
            return taskStore.GetAll();
        }
    }
}
