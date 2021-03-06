﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace It_Univer.Tasks.Web.Models
{
    /// <summary>
    /// Модель создания задачи
    /// </summary>
    public class TaskCreateModel
    {
        /// <summary>
        /// 
        /// </summary>
        public static TaskCreateModel New
        {
            get { return new TaskCreateModel(); }
        }

        /// <summary>
        /// Тема
        /// </summary>
        [Required(ErrorMessage = "Заполните поле:")]
        [DisplayName("Тема")]
        public string Subject
        { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        [DisplayName("Описание")]
        public string Description
        { get; set; }

        public long Id
        { get; set; }
    }
}
