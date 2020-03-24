using It_Univer.Tasks.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using ItUniversity.Repositories;
using ItUniversity.Domain.Repositories;

namespace It_Univer.Tasks.Repositories
{
    public interface ITaskRepository : IRepository<TaskBase, long>
    {
    }
}
