using Bookstore.Entities.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Entities.Models
{
    /// <summary>
    /// Заказ клиента
    /// </summary>
    public class Order : ModelBase
    {
        /// <summary>
        /// Клиент
        /// </summary>
        public User User { get; set; }
        /// <summary>
        /// Дата покупки
        /// </summary>
        public DateTime PurchaseDate { get; set; }
        /// <summary>
        /// Список элементов заказа (книг)
        /// </summary>
        public List<OrderItem> OrderItems { get; set; }
    }
}
