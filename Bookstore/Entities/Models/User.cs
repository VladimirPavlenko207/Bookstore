
using Bookstore.Entities.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Entities.Models
{
    /// <summary>
    /// Клиент магазина
    /// </summary>
    public class User : ModelBase
    {
        /// <summary>
        /// Логин клиента
        /// </summary>
        [Required(ErrorMessage = "Поле (Title) - должно быть заполнено.", AllowEmptyStrings = false)]
        public string UserName { get; set; }
        /// <summary>
        /// Пароль клиента
        /// </summary>
        [Required(ErrorMessage = "Поле (Title) - должно быть заполнено.", AllowEmptyStrings = false)]
        public string Password { get; set; }
        /// <summary>
        /// Дата регистрации клиента
        /// </summary>
        public DateTime RegDate { get; private set; } = DateTime.Now;
    }
}
