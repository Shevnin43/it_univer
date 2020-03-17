using System;
using System.Collections.Generic;
using System.Text;
using ItUniver.Task.Enums;

namespace ItUniver.Task.Entities
{
    public class TaskBase
    {   /// <summary>
        /// АйДи
        /// </summary>
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
        public DateTime CreationDate { get; set; }
        /// <summary>
        /// Статус      
        /// </summary>
        public TaskStatus Status { get; set; }


    }
}
