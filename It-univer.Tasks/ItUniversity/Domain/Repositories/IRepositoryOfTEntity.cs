using ItUniversity.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItUniversity.Domain.Repositories
{
    public interface IRepository<TEntity> : IRepository<TEntity, int> where TEntity : class, IEntity<int>
    {

    }
}
