using System;
using System.Collections.Generic;
using System.Text;

namespace ItUniversity.Domain.Entities
{
    public interface IEntity<TPrimaryKey>
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        TPrimaryKey Id { get; set; }
    }
}
