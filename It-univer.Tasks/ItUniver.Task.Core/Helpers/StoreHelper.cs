using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ItUniver.Task.Entities;

namespace ItUniver.Task.Helpers
{
    public static class StoreHelper
    {
        public static TaskBase Eaqwel (List<TaskBase> tasks, TaskBase task)
        {
            return tasks?.FirstOrDefault(x => x.Id == task.Id && x.Description == task.Description && x.Status == task.Status && x.Subject == task.Subject && x.CreationDate == task.CreationDate);
        }

        public static TaskBase Copy(TaskBase task)
        {
            return new TaskBase() { };
        }
    }
}
