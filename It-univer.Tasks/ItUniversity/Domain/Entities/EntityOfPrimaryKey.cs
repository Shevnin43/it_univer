using System;
using System.Collections.Generic;
using System.Text;

namespace ItUniversity.Domain.Entities
{
    public abstract class Entity<TPrimaryKey> : IEntity<TPrimaryKey>
    {
        /// <inheritdoc/>
        public virtual TPrimaryKey Id { get; set; }
    }
}
