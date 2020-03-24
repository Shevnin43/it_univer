using It_Univer.Tasks.Enums;
using ItUniversity.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace It_Univer.Tasks.Core.Entities
{
    public class TaskBase : Entity<long>
    {
        public const string TableName = "Tasks";
        /// <summary>
        /// Тема
        /// </summary>
        public virtual string Subject { get; set; }
        /// <summary>
        /// Описание
        /// </summary>
        public virtual string Description { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public virtual DateTime CreationDate { get; set; }
        /// <summary>
        /// Статус      
        /// </summary>
        public virtual TaskStatus Status { get; set; }

        /// <summary>
        /// Перегрузка метода ToString Формирует строку из Задачи
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"Ай-ди: {Id}; \n Тема: {Subject}; \n Описание: {Description}; \n Дата создания: {CreationDate}; \n Статус: {Status}. \n";

    }
}
