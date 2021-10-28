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
    /// Жанр книги
    /// </summary>
    public class Genre : ModelBase
    {
        /// <summary>
        /// Название жанра 
        /// </summary>
        [Required(ErrorMessage = "Поле (Title) - должно быть заполнено.")]
        public string Title { get; set; }
        /// <summary>
        /// Список книг данного жанра
        /// </summary>
        public List<Book> Books { get; set; } = new();
    }
}
