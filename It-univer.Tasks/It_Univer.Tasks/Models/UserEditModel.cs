using ITUniversity.Task.API.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace It_Univer.Tasks.Web.Models
{
    public class UserEditModel
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
        /// Логин
        /// </summary>
        public string Login
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
