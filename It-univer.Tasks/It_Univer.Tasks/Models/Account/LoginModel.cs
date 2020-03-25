using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace It_Univer.Tasks.Web.Models.Account
{
    public class LoginModel
    {
        public static LoginModel New
        {
            get { return new LoginModel(); }
        }

        /// <summary>
        /// Логин
        /// </summary>
        [Required(ErrorMessage = "Не указан логин")]
        public string Login
        {
            get;
            set;
        }

        /// <summary>
        /// Пароль
        /// </summary>
        [Required(ErrorMessage = "Не указан пароль")]
        [DataType(DataType.Password)]
        public string Password
        {
            get;
            set;
        }
    }
}
