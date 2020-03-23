using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace It_Univer.Tasks.Web.Models
{
    public class TaskEditModel
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public long Id {get; set;}

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

    }
}
