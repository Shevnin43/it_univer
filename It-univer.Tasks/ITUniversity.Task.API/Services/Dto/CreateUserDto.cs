using System;
using System.Collections.Generic;
using System.Text;

namespace ITUniversity.Task.API.Services.Dto
{
    public class CreateUserDto
    {
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
    }
}
