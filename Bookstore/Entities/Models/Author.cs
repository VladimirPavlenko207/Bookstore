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
    /// Автор книги
    /// </summary>
    public class Author : ModelBase
    {
        /// <summary>
        /// Имя и фамилия автора
        /// </summary>
        [Required(ErrorMessage = "Поле (Name) - должно быть заполнено.", AllowEmptyStrings = false)]
        public string Name { get; set; }
        /// <summary>
        /// Все книги автора
        /// </summary>
        public List<Book> Books { get; set; } = new(); 
    }
}
