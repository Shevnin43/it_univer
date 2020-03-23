using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ItUniversity.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {             
        TEntity Save(TEntity entity);
        bool Remove(long id);
        TEntity Change(TEntity entity);
        List<TEntity> GetAllTasks();
        TEntity FirstOrDefault(long id);
    }
}
