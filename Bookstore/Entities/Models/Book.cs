
using Bookstore.Entities.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Entities.Models
{
    public class Book : ModelBase
    {
        /// <summary>
        /// Название книги
        /// </summary>
        [Required(ErrorMessage = "Поле (Title) - должно быть заполнено.", AllowEmptyStrings = false)]
        public string Title { get; set; }
        /// <summary>
        /// Авторы книги
        /// </summary>
        public List<Author> Authors { get; set; } = new();
        /// <summary>
        /// Издательство
        /// </summary>
        [Required(ErrorMessage = "Поле (Publisher) - должно быть заполнено.")]
        public Publisher Publisher { get; set; }
        /// <summary>
        /// Жанр
        /// </summary>
        [Required(ErrorMessage = "Поле (Genre) - должно быть заполнено.")]
        public Genre Genre { get; set; }
        /// <summary>
        /// год издания
        /// </summary>
        public int Released { get; set; }
        /// <summary>
        /// Количество страниц в книге
        /// </summary>
        public int Pages { get; set; }
        /// <summary>
        /// Себестоимость книги
        /// </summary>
        public decimal CostPrice { get; set; }
        /// <summary>
        /// Продажная стоимость книги
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Предыдущая часть
        /// </summary>
        /// 
        public Book Previous { get; set; }
        /// <summary>
        /// Количество доступных книг
        /// </summary>
        public int AvailableCount { get; set; }
        /// <summary>
        /// Количество проданных книг
        /// </summary>
        public int SoldCount { get; set; }
    }
}
