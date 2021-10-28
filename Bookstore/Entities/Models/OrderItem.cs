using Bookstore.Entities.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Entities.Models
{
    /// <summary>
    /// Элемент закоза
    /// </summary>
    public class OrderItem : ModelBase
    {
        /// <summary>
        /// Кол-во данных книг
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        /// Продажная цена данной книги
        /// (если данная книга в числе книг, на которые действует акция, то цена со скидкой)
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Данная книга
        /// </summary>
        public Book Book { get; set; }
    }
}
