using It_Univer.Tasks.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace It_Univer.Tasks.Core.Entities
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

        /// <summary>
        /// Перегрузка метода ToString Формирует строку из Задачи
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"Ай-ди: {Id}; \n Тема: {Subject}; \n Описание: {Description}; \n Дата создания: {CreationDate}; \n Статус: {Status}. \n";

    }
}
