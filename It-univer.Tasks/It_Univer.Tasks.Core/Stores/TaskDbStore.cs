using System;
using System.Collections.Generic;
using System.Text;
using It_Univer.Tasks.Repositories;
using It_Univer.Tasks.Core.Entities;
using System.Linq;

namespace It_Univer.Tasks.Stores
{
    public class TaskDbStore : ITaskStore
    {
        private readonly ITaskRepository taskRepository;

        public TaskDbStore(ITaskRepository taskRepository)
        {
            this.taskRepository = taskRepository;
        }

        public bool Remove(long id)
        {

            return taskRepository.Remove(id);
        }

        public TaskBase FirstOrDefault(long id)
        {
            return taskRepository.FirstOrDefault(id);
        }

        public List<TaskBase> GetAllTasks()
        {
            return taskRepository.GetAllTasks().ToList();
        }

        public TaskBase Save(TaskBase task)
        {
            return taskRepository.Save(task);
        }

        public TaskBase Change(TaskBase task)
        {
            return taskRepository.Change(task);
        }
    }
}
