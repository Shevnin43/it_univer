using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ItUniver.Task.Entities;

namespace ItUniver.Task.Stores
{
    public class TaskMemoryStore : ITaskStore
    {
        private List<TaskBase> tasks;
        private long counterTasks;

        public TaskMemoryStore()
        {
            this.tasks = new List<TaskBase>();
        }

        public TaskBase Save(TaskBase task)
        {
            var saved = tasks.FirstOrDefault(item => item == task);
            if (saved != null)
            {
                return saved;
            }
                task.Id = counterTasks++;
                tasks.Add(task);
                return task;
        }
    }
}
