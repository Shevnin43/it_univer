using ItUniver.Task.Entities;

namespace ItUniver.Task.Manager
{
    /// <inheritdoc/>
    public class TaskManager : ITaskManager
    {
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
    }
}
