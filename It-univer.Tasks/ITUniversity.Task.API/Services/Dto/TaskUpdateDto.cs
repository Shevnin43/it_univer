using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ITUniversity.Task.API.Services.Dto
{
    public class TaskUpdateDto
    {
        public long Id { get; set; }
        /// <summary>
        /// Тема
        /// </summary>
        public string Subject { get; set; }
        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public virtual DateTime CreationDate { get; set; }
        /// <summary>
        /// Статус      
        /// </summary>
        public virtual TaskStatus Status { get; set; }
    }
}
