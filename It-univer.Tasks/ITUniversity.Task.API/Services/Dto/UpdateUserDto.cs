using System;
using System.Collections.Generic;
using System.Text;

namespace ITUniversity.Task.API.Services.Dto
{
    public class UpdateUserDto
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id
        {
            get;
            set;
        }

        /// <summary>
        /// Почта
        /// </summary>
        public string Email
        {
            get;
            set;
        }
        /// <summary>
        /// Роль
        /// </summary>
        public int? Role
        {
            get;
            set;
        }
    }
}
