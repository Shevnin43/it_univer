using System;
using System.Collections.Generic;
using System.Text;
using ItUniver.Task.Entities;

namespace ItUniver.Task.Stores
{
    public interface ITaskStore
    {
        TaskBase Save(TaskBase task);
    }
}
