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
    /// Издательство книги
    /// </summary>
    public class Publisher : ModelBase
    {
        /// <summary>
        /// Название издательства
        /// </summary>
        [Required(ErrorMessage = "Поле (Title) - должно быть заполнено.", AllowEmptyStrings = false)]
        public string Name { get; set; }
        /// <summary>
        /// Все книги издательства
        /// </summary>
        public List<Book> Books { get; set; } = new();
    }
}
