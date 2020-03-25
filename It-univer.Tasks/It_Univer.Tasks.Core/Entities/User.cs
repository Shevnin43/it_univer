﻿using ItUniversity.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace It_Univer.Tasks.Entities
{
    public class User : Entity
    {
        /// <summary>
        /// Имя таблицы
        /// </summary>
        public const string TableName = "Users";

        /// <summary>
        /// Логин
        /// </summary>
        public virtual string Login
        {
            get;
            set;
        }

        /// <summary>
        /// Почта
        /// </summary>
        public virtual string Email
        {
            get;
            set;
        }

        /// <summary>
        /// Пароль
        /// </summary>
        public virtual string Password
        {
            get;
            set;
        }
        public virtual bool IsBlocked
        {
            get;
            set;
        }
    }
}
