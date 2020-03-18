using It_Univer.Tasks.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace It_Univer.Tasks.Helpers
{
    public static class StoreHelper
    {
        public static bool TasksEquals(this TaskBase thisTask, TaskBase otherTask)
        {
            return thisTask.Description == otherTask.Description && thisTask.CreationDate == otherTask.CreationDate && thisTask.Subject == otherTask.Subject && thisTask.Status == thisTask.Status;
        }

        public static TaskBase Copy(this TaskBase task)
        {
            return new TaskBase() { Id = task.Id, CreationDate = task.CreationDate, Description = task.Description, Status = task.Status, Subject = task.Subject };
        }
    }
}
